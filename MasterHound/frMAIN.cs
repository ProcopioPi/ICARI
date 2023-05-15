using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace MasterHound
{
    public partial class frMAIN : Form
    {
        

        public static int ViewPage;
        public static int row;
        static frPaperHound PaperViewer;
        static string folder;
        //static string tmpProjectName;
        static int maxIndex, index;
        static DirectoryInfo di;
        static StringBuilder sb = new StringBuilder();

        static bool UserScores, IDxes, AIScore, Titles, Checked;

        public frMAIN()
        {
            InitializeComponent();
            Init();
            SimpleLog("MASTER_HOUND_INIT_********" + K.SPACE + DateTime.Now + K.RETURN);
        }

        #region INIT
        public void Init()
        {
            InstancesInit();
            GridInit();
            UserUX();
            CMB_BOX.Select();
        }

        private void InstancesInit()
        {
            PaperViewer = new frPaperHound();
            OFD.Filter  = K.ICA_FILES;
            maxIndex    = 1000;
            index       = 0;
            ViewPage    = 0;

            UserScores = IDxes = AIScore = Titles = Checked = false;
        }

        public void GridInit()
        {
            DATA_GRID_VIEW.Rows.Clear();
            DATA_GRID_VIEW.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            // set it to false if not needed
            DATA_GRID_VIEW.RowHeadersVisible = false;

            this.DATA_GRID_VIEW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            int i = 0;
            while (i++ < 100)
            {
                rows.Add(InsertEmptyRow(i));
            }
        
            DATA_GRID_VIEW.Rows.AddRange(rows.ToArray());
            DATA_GRID_VIEW.Refresh();    
        }

        public void UserUX()
        {
            LBL_EVENTS.ForeColor            = K.k2;
            CHK_FREE_FULLTEXT.ForeColor     = K.k8;
            TXT_PROJECT_NAME.ForeColor      = K.k8;
            fileToolStripMenuItem.ForeColor = K.k8;
            
            TXT_INDEX.ForeColor = TXT_MAX_DOWNLOAD.ForeColor = TXT_MAX_INDEX.ForeColor = K.k8; 
            TXT_INDEX.BackColor = TXT_MAX_DOWNLOAD.BackColor = TXT_MAX_INDEX.BackColor = K.k2;     
            
            BTN_LEFT.BackColor = BTN_RIGHT.BackColor = MAIN_PNL.BackColor = PNL_INDEXES_BUTTONS.BackColor = PNL_INDEXES.BackColor = K.k1;
            PNL_PAGE_TURNER.BackColor = PNL_HEAD.BackColor = K.k1;
            TXT_PROJECT_NAME.BackColor = K.k1;
            BTN_CLEAR_SEARCH.BackColor = BTN_DOWNLOAD_PAPERS.BackColor = K.k1;

            MENU_STRIP.BackColor = Color.FromArgb(200, 200, 200);
            DATA_GRID_VIEW.BackgroundColor  = K.k1;

            int value = 220;

            TXT_INDEX.BackColor = Color.FromArgb(value, value, value);
            TXT_MAX_DOWNLOAD.BackColor = Color.FromArgb(value, value, value);
            TXT_MAX_INDEX.BackColor = Color.FromArgb(value, value, value);
            TXT_PROJECT_NAME.BackColor = Color.FromArgb(value, value, value);
            BTN_DOWNLOAD_PAPERS.BackColor = Color.FromArgb(value, value, value);

            CMB_BOX.BackColor = Color.FromArgb(value, value, value);
            
            BTN_DOWNLOAD_PAPERS.ForeColor= K.k8;

            toolStripMenuItem1.BackColor = Color.FromArgb(value, value, value);
            openToolStripMenuItem.BackColor = Color.FromArgb(value, value, value);
            quitToolStripMenuItem1.BackColor = Color.FromArgb(value, value, value);

            value = 100;
            toolStripMenuItem1.ForeColor = Color.FromArgb(value, value, value);
            openToolStripMenuItem.ForeColor = Color.FromArgb(value, value, value);
            quitToolStripMenuItem1.ForeColor = Color.FromArgb(value, value, value);
            //PCT_CANVAS.BackColor = Color.FromArgb(value, value, value);
        }

        #endregion

        #region EVENTS
        
        private void TXT_MAX_INDEX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MaxIndexTextChange();
                SimpleLog("TXT_MAX_INDEX_TextChanged" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "TXT_MAX_INDEX_TextChanged" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void TXT_INDEX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IndexTextChange();
                SimpleLog("TXT_INDEX_TextChanged" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "TXT_INDEX_TextChanged" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void TXT_MAX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MaxDownload();
                SimpleLog("TXT_MAX_TextChanged" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "TXT_MAX_TextChanged" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }
        
        private void BTN_CLEAR_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                ClearSearchBox();
                SimpleLog("BTN_CLEAR_SEARCH_Click" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "BTN_CLEAR_SEARCH_Click" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void CMB_BOX_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                CmbBoxClick();
                SimpleLog("CMB_BOX_MouseClick" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "CMB_BOX_MouseClick" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }
         
        private void CMB_BOX_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                CmbBoxKeyDown(e.KeyValue);
                //SimpleLog("CMB_BOX_KeyDown" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "CMB_BOX_KeyDown" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void TIMER_Tick(object sender, EventArgs e)
        {
            try
            {
                TimerTick();
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "TimerTick" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void BTN_PAGE_TURNER_Click(object sender, EventArgs e)
        {
            try
            {
                TurnPage((Button)sender);
                SimpleLog("BTN_PAGE_TURNER_Click" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "BTN_PAGE_TURNER_Click" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void BTN_RIGHT_Click(object sender, EventArgs e)
        {
            try
            {
                TurnPageRight();
                SimpleLog("BTN_RIGHT_Click" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "BTN_RIGHT_Click" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }  

        private void BTN_LEFT_Click(object sender, EventArgs e)
        {
            try
            {
                TurnPageLeft();
                SimpleLog("BTN_LEFT_Click" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "BTN_LEFT_Click" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }
 
        private void DATA_GRID_VIEW_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridDoubleClick((DataGridView)sender, e.RowIndex);
                SimpleLog("DATA_GRID_VIEW_CellDoubleClick" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "DATA_GRID_VIEW_CellDoubleClick" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }
        
        private void DATA_GRID_VIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridCheckClick(e.RowIndex, e.ColumnIndex);
                SimpleLog("DATA_GRID_VIEW_CellContentClick" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "DATA_GRID_VIEW_CellContentClick" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void DATA_GRID_VIEW_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SortInfoinDataGrid((CELL)e.ColumnIndex);
                SimpleLog("DATA_GRID_VIEW_ColumnHeaderMouseClick" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) {
                SimpleLog(K.EXCEPTION + "DATA_GRID_VIEW_ColumnHeaderMouseClick" + K.SPACE + DateTime.Now +K.SPACE+ ex.Message + K.RETURN);
            } 
        }

        private void frMAIN_FormClosing(object sender, FormClosedEventArgs e)
        {
            try
            {                
                BeforeFormClosing();
                SimpleLog("frMAIN_FormClosing-----" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "frMAIN_FormClosing" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenProject();
                SimpleLog("OpenToolStripMenuItem_Click" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "OpenToolStripMenuItem_Click" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleLog("QuitToolStripMenuItem_Click" + K.SPACE + DateTime.Now + K.RETURN);
                Application.Exit();
               
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "QuitToolStripMenuItem_Click" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void NewtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewProject();
                SimpleLog("NewtoolStripMenuItem_Click" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "NewtoolStripMenuItem_Click" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void TXT_PROJECT_NAME_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                TXT_PROJECT_NAME.SelectAll();
                //tmpProjectName = TXT_PROJECT_NAME.Text;
                SimpleLog("TXT_PROJECT_NAME_MouseClick" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "TXT_PROJECT_NAME_MouseClick" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        private void TXT_PROJECT_NAME_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ChangeProjectName(e.KeyValue);
                SimpleLog("TXT_PROJECT_NAME_KeyDown" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "TXT_PROJECT_NAME_KeyDown" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }

        #endregion

        #region RESPONSE METHODS

        private void ChangeProjectName(int KeyValue)
        {
            if (KeyValue == 13)// IF ENTER
            {
                if (TXT_PROJECT_NAME.Text != K.EMPTY)
                {
                    FileManager.ChangeProjectFolderName(TXT_PROJECT_NAME.Text);
                }
            }
        }

        private void DownLoadPapers()
        {
            InfoManager.Instance.ContinueDownload(int.Parse(TXT_MAX_DOWNLOAD.Text));
            this.Enabled = false;
            TIMER.Start();
        }

        private void MaxIndexTextChange()
        {
            int mI;
            mI = maxIndex;
            try
            {
                mI = int.Parse(TXT_MAX_INDEX.Text);
                maxIndex = mI;
            }
            catch (Exception)
            {
                mI = maxIndex;
            }
            TXT_MAX_INDEX.Text = mI.ToString();
        }

        private void IndexTextChange()
        {
            int i;
            i = index;
            try
            {
                i = int.Parse(TXT_INDEX.Text);
                index = i;
            }
            catch (Exception)
            {
                i = index;
            }
            TXT_INDEX.Text = i.ToString();
        }

        private void MaxDownload()
        {
            int val;

            val = InfoManager.Instance.tmpMax;
            try
            {
                val = int.Parse(TXT_MAX_DOWNLOAD.Text);
                InfoManager.Instance.tmpMax = val;
            }
            catch (Exception)
            {
                MessageBox.Show(TXT_MAX_DOWNLOAD.Text + K.NOT_VALID_NUMBER);
                TXT_MAX_DOWNLOAD.Text = InfoManager.Instance.tmpMax.ToString();
            }
        }
        
        private void OpenProject()
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            DirectoryInfo sub = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            DirectoryInfo[] dirInfo = sub.GetDirectories();

            if (sub.GetDirectories().Length > 0)
                sub = sub.GetDirectories()[0];

            diag.SelectedPath = sub.FullName;

            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folder  = diag.SelectedPath;
                di      = new DirectoryInfo(folder);

                InfoManager.Instance.Info   = new List<ArticleInfo>();
                string[] fileEntries        = Directory.GetFiles(folder);
                string[] ids;

                TXT_PROJECT_NAME.Text       = di.Name;
                FileManager.projectFolder   = di.FullName;

                ids = new string[0];
                for (int i = 0; i < fileEntries.Length; i++)
                {
                    string fileName = Path.GetFileName(fileEntries[i]);
                    if (fileName != K.IDS_FILE && fileName != K.QUERIES_FILE)
                    {
                        InfoManager.Instance.Info.Add(FileManager.OpenFile(fileEntries[i]));
                    }
                    if (fileName == K.IDS_FILE)
                    {
                        ids = File.ReadAllLines(fileEntries[i]);
                    }
                }

                FileManager.UniqueIDs = new List<string>(ids);
                InfoManager.IDs = new List<string>(FileManager.UniqueIDs);

                UpdateInfo();//update visual info
            }
        }
        
        private void ClearSearchBox()
        {
            CMB_BOX.Text = K.EMPTY;
            LBL_EVENTS.Text = K.CLEAR_SEARCH_BAR;
            
        }

        private void CmbBoxClick()
        {
            string[] options = FileManager.ReadQueryLines();
            CMB_BOX.Text = K.EMPTY;

            if (options.Length > 0)
            {
                CMB_BOX.Items.Clear();
                CMB_BOX.Items.AddRange(options);
                CMB_BOX.DroppedDown = true;
            }

            LBL_EVENTS.Text = K.MOUSE_CLICK;
        }

        private void CmbBoxKeyDown(int KeyValue)
        {
            if (KeyValue == 13)// IF ENTER-------------------------------------------------------------------------------
            {
                if (CMB_BOX.Text != K.EMPTY)
                {
                    PrepareSearchData(CMB_BOX.Text, int.Parse(TXT_INDEX.Text), int.Parse(TXT_MAX_INDEX.Text), CHK_FREE_FULLTEXT.Checked);
                }
                LBL_EVENTS.Text = K.ENTER;
                SimpleLog("CMB_BOX_KeyDown" + K.SPACE + DateTime.Now + K.RETURN);
            }
        }

        private void TimerTick()
        {
            if (LoadAnimation.IsRunning)
            {
                MyHandlers.SetCTREnableValue(this, false);

                if (InfoManager.Instance.IsLoadingIndexes)
                    MyHandlers.SetPCTValue(PCT_CANVAS, LoadAnimation.Instance.AnimateLoadingIndexes());
                else
                    MyHandlers.SetPCTValue(PCT_CANVAS, LoadAnimation.Instance.AnimateLoadingNextFrame(InfoManager.ArticleIndex));
            }
            else
            {
                MyHandlers.SetCTREnableValue(this, true);

                MyHandlers.SetPCTValue(PCT_CANVAS, LoadAnimation.Instance.FinishAnimation());
                TIMER.Stop();
                UpdateInfo();
                SimpleLog("TimerTick_End" + K.SPACE + DateTime.Now + K.RETURN);
            }
        }

        private void TurnPage(Button btn)
        {
            ViewPage = int.Parse(btn.Text);

            UpdateViewPage(ViewPage);
        }

        private void TurnPageRight()
        {
            ViewPage++;
            UpdateViewPage(ViewPage);
        }

        private void TurnPageLeft()
        {
            ViewPage--;
            if (ViewPage > -1)
                UpdateViewPage(ViewPage);
        }

        private void DataGridDoubleClick(DataGridView dataGridView, int row)
        {
            if (dataGridView == null)
                return;

            if (dataGridView.CurrentRow.Selected)
            {
                if (row > -1 && dataGridView.Rows[row].Cells[(int)CELL.ID].Value != null)
                    if (dataGridView.Rows[row].Cells[1].Value.ToString() != K.EMPTY)
                    {
                        int id = (int)dataGridView.Rows[row].Cells[(int)CELL.ID].Value;
                        int idx = (int)dataGridView.Rows[row].Cells[(int)CELL.INDEX].Value;//the actual index in the info array

                        ArticleInfo tmp = InfoManager.Instance.Info[idx];

                        if (tmp.ArticleStatus != ARTICLE_STATUS.NOT_LOADED)
                        {
                            PaperViewer.LoadArticleInfo(this, idx, TXT_PROJECT_NAME.Text);// WE HAVE TO SEND VIEW_PAGE_INDEX
                        }
                    }
            }
        }

        private void DataGridCheckClick(int row, int column)
        {
            LBL_EVENTS.Text = K.COLUMN + column + K.ROW + row;
            if (column == (int)CELL.CHECKED && row > -1 && row < 100)
            {
                var value = Convert.ToBoolean(DATA_GRID_VIEW[column, row].Value);
                DATA_GRID_VIEW[column, row].Value = !value;

                int idx = (int)DATA_GRID_VIEW.Rows[row].Cells[(int)CELL.INDEX].Value;

                InfoManager.Instance.Info[idx].Checked = Convert.ToBoolean(DATA_GRID_VIEW[column, row].Value);
                FileManager.SaveAbstract(InfoManager.Instance.Info[idx]);
            }
        }

        private void SortInfoinDataGrid(CELL cell)
        {
            switch (cell)
            {
                case CELL.AI_SCORE:
                    if (AIScore)
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderBy(o => o.AI_score).ToList();
                    else
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderByDescending(o => o.AI_score).ToList();
                    AIScore = !AIScore;
                    break;
                case CELL.CHECKED:
                    if (Checked)
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderBy(o => o.Checked).ToList();
                    else
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderByDescending(o => o.Checked).ToList();
                    Checked = !Checked;
                    break;
                case CELL.ID:
                    if (IDxes)
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderBy(o => o.id).ToList();
                    else
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderByDescending(o => o.id).ToList();
                    IDxes = !IDxes;
                    break;
                case CELL.INDEX:
                    break;
                case CELL.TITLE:
                    if (Titles)
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderBy(o => o.Title).ToList();
                    else
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderByDescending(o => o.Title).ToList();
                    Titles = !Titles;
                    break;
                case CELL.USER_SCORE:
                    if (UserScores)
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderBy(o => o.User_Score).ToList();
                    else
                        InfoManager.Instance.Info = InfoManager.Instance.Info.OrderByDescending(o => o.User_Score).ToList();
                    UserScores = !UserScores;
                    break;
            }
            UpdateViewPage(ViewPage);
        }

        private void NewProject()
        {
            GridInit();
            FileManager.projectFolder = null;
            FileManager.UniqueIDs = new List<string>();
            FileManager.IsProjectStarted = false;
            InfoManager.Instance = new InfoManager();
            TXT_PROJECT_NAME.Text = "PROJECT NAME";
            ClearSearchBox();
            CMB_BOX.Select();
        }

        private void BeforeFormClosing()
        {
            TIMER.Stop();
            SimpleLog(K.MASTER_HOUND_EXIT+ K.SPACE + DateTime.Now + K.RETURN);
            Application.Exit();
        }

        private void BTN_DOWNLOAD_PAPERS_Click(object sender, EventArgs e)
        {
            try
            {
                DownLoadPapers();
                SimpleLog("BTN_DOWNLOAD_PAPERS_Click" + K.SPACE + DateTime.Now + K.RETURN);
            }
            catch (Exception ex) { SimpleLog(K.EXCEPTION + "BTN_DOWNLOAD_PAPERS_Click" + K.SPACE + DateTime.Now + K.SPACE + ex.Message + K.RETURN); }
        }
        #endregion

        #region COMMON METHODS
        public void UpdateInfo()
        {
            if (FileManager.UniqueIDs != null)
            {
                LBL_STATUS.Text = K.TOTAL_IDS_PROJECT + FileManager.UniqueIDs.Count + K.SPACE;
            }

            UpdateDataGrid();
        }

        private void PrepareSearchData(string query, int index, int max, bool freeFullText)//***********************************
        {            
            this.Enabled = false;
            ExecuteQuerySearch(query, max, index, freeFullText); 
        }
        
        private void ExecuteQuerySearch(string line, int max, int index, bool freeFullText)
        {
            if(!FileManager.IsProjectStarted)
                TXT_PROJECT_NAME.Text = FileManager.StartProject();

            InfoManager.Instance.ProcessIDsRetrieval(line, index, int.Parse(TXT_MAX_DOWNLOAD.Text), freeFullText);
            TIMER.Start();
        }

        private void CreateButtonsBrowsers()
        {            
            Button btn;
            List<Button> buttons = new List<Button>();

            int totalButtons             = InfoManager.Instance.Info.Count / K.HUNDRED;

            if (InfoManager.Instance.Info.Count % K.HUNDRED != 0)
                totalButtons++;

            PNL_INDEXES_BUTTONS.Width    = (totalButtons * 55) + 6;
            PNL_INDEXES_BUTTONS.Height   = 38;
            PNL_INDEXES_BUTTONS.Location = new Point(0, 7);
            PNL_INDEXES_BUTTONS.Controls.Clear();

            EventHandler vth = new EventHandler(BTN_PAGE_TURNER_Click);

            for (int t = 0; t < totalButtons; t++)
            {
                btn             = new Button();
                btn.BackColor   = TXT_MAX_DOWNLOAD.BackColor;
                btn.ForeColor   = TXT_MAX_DOWNLOAD.ForeColor;
                btn.Text        = t.ToString();
                btn.Width       = 50;
                btn.Height      = 32;
                btn.Location    = new Point(4+(btn.Width+5) * t, 2);
                btn.FlatStyle   = FlatStyle.Flat;
                btn.Click      += vth;
                buttons.Add(btn);
            }       

            PNL_INDEXES_BUTTONS.Controls.AddRange(buttons.ToArray());
        }

        private DataGridViewRow InsertEmptyRow(int index)
        {
            DataGridViewRow row = (DataGridViewRow)DATA_GRID_VIEW.Rows[0].Clone();

            //Color C = Color.FromArgb(32, 32, 32);

            row.Cells[(int)CELL.INDEX].Value        = string.Empty;
            row.Cells[(int)CELL.ID].Value           = string.Empty;
            row.Cells[(int)CELL.TITLE].Value        = string.Empty;
            row.Cells[(int)CELL.USER_SCORE].Value   = string.Empty;
            row.Cells[(int)CELL.AI_SCORE].Value     = string.Empty;
            row.Cells[(int)CELL.CHECKED].Value      = false;

            row.Cells[(int)CELL.INDEX].Style.BackColor          = K.C1;
            row.Cells[(int)CELL.ID].Style.BackColor             = K.C1;
            row.Cells[(int)CELL.TITLE].Style.BackColor          = K.C1;
            row.Cells[(int)CELL.USER_SCORE].Style.BackColor     = K.C1;
            row.Cells[(int)CELL.AI_SCORE].Style.BackColor       = K.C1;
            row.Cells[(int)CELL.CHECKED].Style.BackColor        = K.C1;

            row.MinimumHeight = 35;
            return row;
        }

        public void ClearRowValues(int index)
        {
            DATA_GRID_VIEW[(int)CELL.INDEX, index % K.HUNDRED].Value        = string.Empty;
            DATA_GRID_VIEW[(int)CELL.ID, index % K.HUNDRED].Value           = string.Empty;
            DATA_GRID_VIEW[(int)CELL.TITLE, index % K.HUNDRED].Value        = string.Empty;
            DATA_GRID_VIEW[(int)CELL.USER_SCORE, index % K.HUNDRED].Value  = string.Empty;
            DATA_GRID_VIEW[(int)CELL.AI_SCORE, index % K.HUNDRED].Value     = string.Empty;
            DATA_GRID_VIEW[(int)CELL.CHECKED, index % K.HUNDRED].Value      = false;

            DATA_GRID_VIEW[(int)CELL.INDEX, index % K.HUNDRED].Style.BackColor          = K.C1;
            DATA_GRID_VIEW[(int)CELL.ID, index % K.HUNDRED].Style.BackColor             = K.C1;
            DATA_GRID_VIEW[(int)CELL.TITLE, index % K.HUNDRED].Style.BackColor          = K.C1;
            DATA_GRID_VIEW[(int)CELL.USER_SCORE, index % K.HUNDRED].Style.BackColor     = K.C1;
            DATA_GRID_VIEW[(int)CELL.AI_SCORE, index % K.HUNDRED].Style.BackColor       = K.C1;
            DATA_GRID_VIEW[(int)CELL.CHECKED, index % K.HUNDRED].Style.BackColor        = K.C1;
        }

        public void UpdateDataGrid()
        {
            int pages = InfoManager.Instance.Info.Count / K.HUNDRED;
            ViewPage = 0;

            CreateButtonsBrowsers();
            UpdateViewPage(ViewPage);
        }

        public void UpdateViewPage(int page)
        {
            int total = page * K.HUNDRED;

            ((ISupportInitialize)DATA_GRID_VIEW).BeginInit();
            for (int i = total; i < (K.HUNDRED + total); i++)
            {
                if (i < InfoManager.Instance.Info.Count)
                {
                    UpdateRowValues(i, InfoManager.Instance.Info[i]);//
                }
                else//clean remaining rows
                {
                    ClearRowValues(i);
                }
            }

            BTN_LEFT.Enabled = !(page == 0);
            BTN_RIGHT.Enabled = (total + K.HUNDRED) < InfoManager.Instance.Info.Count;

            DATA_GRID_VIEW.AutoResizeColumns();
            ((ISupportInitialize)DATA_GRID_VIEW).EndInit();

            DATA_GRID_VIEW.Refresh();
            DATA_GRID_VIEW.Select();

            LBL_EVENTS.Text = K.PAGE + page.ToString();
        }
        
        public void UpdateRowValues(int idx)
        {
            int row = idx % K.HUNDRED;
            int tempPage = idx / 100;
            if (tempPage == ViewPage)
            {
                ArticleInfo info = InfoManager.Instance.Info[idx];//IDX is the index in the Info list
                UpdateRowValues((ViewPage * 100) + row, info);
            }
        }

        private void UpdateRowValues(int idx, ArticleInfo info)
        {
            DATA_GRID_VIEW[(int)CELL.INDEX, idx % K.HUNDRED].Value        = idx;
            DATA_GRID_VIEW[(int)CELL.ID, idx % K.HUNDRED].Value           = info.id;
            DATA_GRID_VIEW[(int)CELL.TITLE, idx % K.HUNDRED].Value        = info.Title;
            DATA_GRID_VIEW[(int)CELL.USER_SCORE, idx % K.HUNDRED].Value   = info.User_Score;
            DATA_GRID_VIEW[(int)CELL.AI_SCORE, idx % K.HUNDRED].Value     = info.AI_score;
            DATA_GRID_VIEW[(int)CELL.CHECKED, idx % K.HUNDRED].Value      = info.Checked;
            
            switch (info.ArticleStatus)
            {
                case ARTICLE_STATUS.NOT_LOADED:
                    SetRowBackgroundColor(idx, K.C1);
                    break;
                case ARTICLE_STATUS.LOADED:
                    SetRowBackgroundColor(idx, K.C2);
                    break;
                case ARTICLE_STATUS.EVALUATED:
                    SetRowBackgroundColor(idx, K.C3);
                    break;
            }            
        }
  
        private void SetRowBackgroundColor(int row, Color c)
        {
            DATA_GRID_VIEW[(int)CELL.INDEX, row % K.HUNDRED].Style.BackColor        = c;
            DATA_GRID_VIEW[(int)CELL.ID, row % K.HUNDRED].Style.BackColor           = c;
            DATA_GRID_VIEW[(int)CELL.TITLE, row % K.HUNDRED].Style.BackColor        = c;
            DATA_GRID_VIEW[(int)CELL.USER_SCORE, row % K.HUNDRED].Style.BackColor   = c;
            DATA_GRID_VIEW[(int)CELL.AI_SCORE, row % K.HUNDRED].Style.BackColor     = c;
            DATA_GRID_VIEW[(int)CELL.CHECKED, row % K.HUNDRED].Style.BackColor      = c;
        }
        #endregion

        private void SimpleLog(string message)
        {
            message = message.Replace(K.SPACE, K.TAB + K.TAB + K.TAB + K.TAB);
            sb.Append(message);
            File.AppendAllText(K.LOG_FILE, sb.ToString());
            sb.Clear();
        }         
    }
}
