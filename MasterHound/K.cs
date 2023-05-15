using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MasterHound
{
    // For connection response handling
    public enum QUERY_TYPE
    {
        PUBMED_IDS,
        PUBMED_ARTICLE_INFO,
        SCOPUS_IDS,
        SCOPUS_ARTICLE_INFO
    }

    public enum CELL: int
    {
        INDEX       = 0,
        ID          = 1,
        TITLE       = 2,
        USER_SCORE  = 3,
        AI_SCORE    = 4,
        CHECKED     = 5,
    }



    // Different text widgets sharing event handler
    public enum TXT
    {
        TXT_PROJECT_NAME,
        TXT_SEARCHBAR,
        TXT_AUTOSAVE,
        TXT_INDEX,
        TXT_MAX,
        CHK_FREE_FULLTEXT,
        TXT_MAX_DOWNLOAD
    }


    public enum ARTICLE_STATUS : int
    {
        NOT_LOADED,         // RED
        LOADED,             // YELLOW
        EVALUATED,          // GREEN
        MACHINE_EVALUATED,  // BLUE
        NOT_EVALUATED,
    }

    public enum FILE_LINES : int
    {
        ID          = 0,
        TITLE       = 1,
        DATE        = 2,
        JOURNAL     = 3,
        ABSTRACT    = 4,
        STATUS      = 5,
        AI_SCORE    = 6,
        HUMAN_SCORE = 7,
        DOI         = 8,
        CHECKED     = 9
    }

    class K
    {
        public static string EXTENSION = ".txt";
        public static Color C1 = Color.FromArgb(240, 240, 240);//init
        public static Color C2 = Color.FromArgb(230, 230, 210);
        public static Color C3 = Color.FromArgb(190, 230, 210);
        public static Color C4 = Color.FromArgb(210, 210, 210);

        /*
        public static Color C1 = Color.FromArgb(90, 95, 95);//init
        public static Color C2 = Color.FromArgb(180, 150, 80);//110,90,70
        public static Color C3 = Color.FromArgb(100, 120, 80);
         public static Color C4 = Color.FromArgb(80, 120, 100);
        //*/


        public static Color k0 = Color.White;
        public static Color k1 = Color.WhiteSmoke;
        public static Color k2 = Color.Gainsboro;
        public static Color k3 = Color.LightGray;
        public static Color k4 = Color.Silver;
        public static Color k5 = Color.DarkGray;
        public static Color k6 = Color.Gray;
        public static Color k7 = Color.DimGray;
        public static Color k8 = Color.Black;

        public static Color EVAL_COLOR = Color.Azure;
        public static Color NOT_EVAL_COLOR = Color.OrangeRed;


        public const string ALIGN_LEFT = "\r\n\r\n\r\n";
        public const string ALIGN_RIGHT = "\r\n\r\n\r\n\r\n\r\n";
             
        public const int HUNDRED = 100;
        public const int MAX_ID_RETRIEVER = 1000000;
        public const string SEARCH = "     Search";
        public const string TOTAL_IDS_PROJECT = "Total IDs in project: ";
        public const string SPACE = " ";
        public const string TAB = "\t";
        public const string COLUMN = " Column ";
        public const string ROW = " Row ";
        public const string NOT_VALID_NUMBER = " is not a valid number ";
        public const string EMPTY = "";
        public const string COLON = ":";
        public const string ENTER = " ENTER ";
        public const string MOUSE_CLICK = " Mouse Click ";
        public const string CLEAR_SEARCH_BAR = "Clear SEARCHBAR";
        public const string MASTER_HOUND_EXIT = "MASTER_HOUND_EXIT";

        public const string IDS_FILE = "_IDS.txt";
        public const string QUERIES_FILE = "_QYS.txt";
        public const string LOG_FILE = "log.txt";
        public const string ICA_FILES = "ICA files (*.ica)|*.txt|All files (*.*)|*.*";
        public const string PAGE = "PAGE: ";

        //public const string PUB_MED_BASE = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/esearch.fcgi?db=pmc&term=";
        //public const string PUB_MED_BASE = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/esearch.fcgi?dbfrom=pubmed&db=pmc&term=";
        public const string PUB_MED_BASE = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/esearch.fcgi?db=pubmed&term=";//egquery
        public const string PUB_MED_BASE_QUERY = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/egquery.fcgi?term=";//egquery

        
        public const string FREE_FULLTEXT = "+AND+free+full+text[filter]";
        public const string RET_START = "&retstart=";
        public const string RET_MAX = "&retmax=";

        public const string ID = "Id";
        public const string AND = "+AND+";
        public const string SPLITTER = "|%|";
        public const string SPLITTER_X = ":|%|";
        public const string ID_LIST = "IdList";
        public const string RETURN = "\r\n";
        public const string EXCEPTION = "EXCEPTION :: ";

        public const string COUNT_ID = "Count";


        public const string ARTICLE_TITLE = "ArticleTitle";
        public const string YEAR = "Year";
        public const string DOI = "ELocationID";//
        public const string MEDLINE_DATE = "MedlineDate";
        public const string ABSTRACT = "Abstract";
        public const string ABSTRACT_TEXT = "AbstractText";
        public const string JOURNAL = "Title";

        //public const string API_KEY = "&api_key=0e7a93d2536095c536909cdb22540ee93908";
        public const string API_KEY = "apiKey=c92d047ccf62bcc3d7c9d92606f9d392";
        public const string XML_APP = "httpAccept=application/xml";
        public const string SCOPUS_BASE = "https://api.elsevier.com/content/search/scopus?query=";
        public const string START = "start=";
        public const string COUNT = "count=";
    }
}
