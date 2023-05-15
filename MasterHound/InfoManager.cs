using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MasterHound
{
    public class InfoManager
    {
        private static InfoManager instance;
        private static int MaxDownload;
        static WebCrawler crawler;
        public List<ArticleInfo> Info;
        public static List<string> IDs;
        static int nextDownloads;
        public static string Search;
        public string[] KeyWords;
        public static int ArticleIndex;
        public static bool FreeFullText;
       
        public int tmpIndex;
        public int tmpMax;
        static Thread thread;
        public bool IsLoadingIndexes;

        public static InfoManager Instance
        {
            get {
                if (instance == null)
                    instance = new InfoManager();

                return InfoManager.instance; 
            }
            set { InfoManager.instance = value; }
        }
        
        public InfoManager()
        {
            crawler          = new WebCrawler(this);
            IDs              = new List<string>();
            Info             = new List<ArticleInfo>();
            MaxDownload      = 100;
            this.tmpIndex    = 0;
            IsLoadingIndexes = false;
        }
        
        public void ProcessIDsRetrieval(string search,int index, int maxDownload, bool freeFullText)
        {            
            Search          = search;
            KeyWords        = Search.Split(new string[] { K.SPACE }, StringSplitOptions.RemoveEmptyEntries);
            FreeFullText    = freeFullText;
            tmpIndex        = index;
            MaxDownload     = maxDownload;
            ArticleIndex    = 0;

            FileManager.SaveQueryLine(search);//saves the query into the text file
            if (KeyWords.Length > 0)
            {
                thread = new Thread(RunIDQuery);
                thread.Start();
            }
        }

        private void RunIDQuery()
        {
            if (!WebCrawler.client.IsBusy)
            {
                LoadAnimation.IsRunning = true;
                IsLoadingIndexes = true;
                crawler.WebQuery(QueryCreator.PubMedIDsQuery(KeyWords, tmpIndex, K.MAX_ID_RETRIEVER, FreeFullText));
                nextDownloads = 0;
            }
        }

        private void ProcessPUBMED_IDS(XDocument doc)
        {
            XElement tmp;
            StringBuilder sb;
            List<XElement> ID_List;
            HashSet<string> uniqueID;
            
            sb      = new StringBuilder();
            tmp     = XMLParser.RetrieveElement(doc.Root, K.COUNT_ID, null);//  retrieved total of IDs for query
            ID_List = doc.Root.Element(K.ID_LIST).Elements(K.ID).ToList();  //  retrieved ID list
            if (int.Parse(tmp.Value) < K.MAX_ID_RETRIEVER)                  //  less than max allowed to retrieve
            {
                if (ID_List.Count > 0)
                {
                    for (int r = 0; r < ID_List.Count; r++)//falta checar aqui mismo la redundancia
                    {
                        IDs.Add(ID_List[r].Value);
                    }

                    uniqueID = new HashSet<string>(IDs);
                    IDs      = new List<string>(uniqueID.ToArray());

                    if (IDs.Count < MaxDownload)
                        MaxDownload = IDs.Count;

                    FileManager.SaveIDs(IDs);
                    crawler.WebQuery(QueryCreator.PubMedArticleInfoQuery(IDs[ArticleIndex]));  //  Start processing IDs
                                                                                               //  lets start one by one
                }
                else
                    LoadAnimation.IsRunning = false;
            }
            else//:::::::::::>>>>>>>>>>> to implement
            {
            }

            IsLoadingIndexes = false;
        }

        public void ContinueDownload(int maxDownload)
        {
            nextDownloads           = 0;
            MaxDownload             = maxDownload;
            LoadAnimation.IsRunning = true;

            thread = new Thread(FindNextArticleToDownload);
            thread.Start();
            //FindNextArticleToDownload();
        }

        private void FindNextArticleToDownload()
        {
            //POPS next missing article      
            while (Info.Exists(x => x.ID == IDs[ArticleIndex]))
            {
                if (ArticleIndex < IDs.Count - 1)
                    ArticleIndex++;
                else
                    break;
            }

            //2.- Generate and execute next query only if id hasn´t been downloaded
            if (ArticleIndex < IDs.Count && nextDownloads < MaxDownload) //
            {
                Thread.Sleep(200);// Manual says no more than 5 queries per second
                crawler.WebQuery(QueryCreator.PubMedArticleInfoQuery(IDs[ArticleIndex]));
            }
            else
            {//quizás agregar mensaje estático para avisar errores
                LoadAnimation.IsRunning = false;
                Info = Info.OrderByDescending(o => o.id).ToList();
            }
        }
                        
        private void ProcessArticleInfo(XDocument doc)
        {
            //1.- Retrieve all about the ArticleInfo
            ArticleInfo tmp;
            
            tmp = XMLParser.RetrieveArticleInfo(IDs[ArticleIndex], doc.Root);

            if (!Info.Exists(x => x.id == tmp.id))//for now it WONT OVER write it if exists
            {
                Info.Add(tmp);
                FileManager.SaveAbstract(tmp);
                nextDownloads++;
            }

            FindNextArticleToDownload();
        }

        public void client_RetrievePubMedIDs(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                XDocument doc = XDocument.Parse(e.Result);
                switch (QueryCreator.queryType)
                {
                    case QUERY_TYPE.PUBMED_IDS:
                        ProcessPUBMED_IDS(doc);
                        break;
                    case QUERY_TYPE.PUBMED_ARTICLE_INFO:
                        ProcessArticleInfo(doc);
                        break;
                }
            }
            catch (Exception)
            {
                LoadAnimation.IsRunning = false;
            }
        }
    }
}
