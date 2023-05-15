namespace MasterHound
{
    partial class frMAIN
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMAIN));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DATA_GRID_VIEW = new System.Windows.Forms.DataGridView();
            this.ColumnINDEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MAIN_PNL = new System.Windows.Forms.Panel();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PNL_PAGE_TURNER = new System.Windows.Forms.Panel();
            this.PNL_INDEXES = new System.Windows.Forms.Panel();
            this.PNL_INDEXES_BUTTONS = new System.Windows.Forms.Panel();
            this.BTN_RIGHT = new System.Windows.Forms.Button();
            this.BTN_LEFT = new System.Windows.Forms.Button();
            this.TXT_PROJECT_NAME = new System.Windows.Forms.TextBox();
            this.LBL_EVENTS = new System.Windows.Forms.Label();
            this.MENU_STRIP = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PNL_HEAD = new System.Windows.Forms.Panel();
            this.PNL_RIGHT = new System.Windows.Forms.Panel();
            this.LBL_RET_MAX = new System.Windows.Forms.Label();
            this.TXT_MAX_DOWNLOAD = new System.Windows.Forms.TextBox();
            this.LBL_ARTINFO = new System.Windows.Forms.Label();
            this.BTN_DOWNLOAD_PAPERS = new System.Windows.Forms.Button();
            this.LBL_RET_INDEX = new System.Windows.Forms.Label();
            this.TXT_MAX_INDEX = new System.Windows.Forms.TextBox();
            this.TXT_INDEX = new System.Windows.Forms.TextBox();
            this.CMB_BOX = new System.Windows.Forms.ComboBox();
            this.CHK_FREE_FULLTEXT = new System.Windows.Forms.CheckBox();
            this.BTN_CLEAR_SEARCH = new System.Windows.Forms.Button();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_GRID_VIEW)).BeginInit();
            this.MAIN_PNL.SuspendLayout();
            this.PNL_PAGE_TURNER.SuspendLayout();
            this.PNL_INDEXES.SuspendLayout();
            this.MENU_STRIP.SuspendLayout();
            this.PNL_HEAD.SuspendLayout();
            this.PNL_RIGHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA_GRID_VIEW
            // 
            this.DATA_GRID_VIEW.AllowUserToOrderColumns = true;
            this.DATA_GRID_VIEW.AllowUserToResizeRows = false;
            this.DATA_GRID_VIEW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DATA_GRID_VIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA_GRID_VIEW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DATA_GRID_VIEW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DATA_GRID_VIEW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DATA_GRID_VIEW.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.DATA_GRID_VIEW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DATA_GRID_VIEW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DATA_GRID_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_GRID_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnINDEX,
            this.ColumnID,
            this.ColumnTITLE,
            this.ColumnUSER,
            this.ColumnAI,
            this.ColumnChecked});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DATA_GRID_VIEW.DefaultCellStyle = dataGridViewCellStyle8;
            this.DATA_GRID_VIEW.EnableHeadersVisualStyles = false;
            this.DATA_GRID_VIEW.GridColor = System.Drawing.Color.LightGray;
            this.DATA_GRID_VIEW.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DATA_GRID_VIEW.Location = new System.Drawing.Point(3, 119);
            this.DATA_GRID_VIEW.MultiSelect = false;
            this.DATA_GRID_VIEW.Name = "DATA_GRID_VIEW";
            this.DATA_GRID_VIEW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DATA_GRID_VIEW.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DATA_GRID_VIEW.RowHeadersWidth = 20;
            this.DATA_GRID_VIEW.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DATA_GRID_VIEW.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DATA_GRID_VIEW.RowTemplate.DividerHeight = 2;
            this.DATA_GRID_VIEW.RowTemplate.Height = 100;
            this.DATA_GRID_VIEW.RowTemplate.ReadOnly = true;
            this.DATA_GRID_VIEW.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DATA_GRID_VIEW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DATA_GRID_VIEW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATA_GRID_VIEW.ShowRowErrors = false;
            this.DATA_GRID_VIEW.Size = new System.Drawing.Size(1096, 297);
            this.DATA_GRID_VIEW.TabIndex = 0;
            this.DATA_GRID_VIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_GRID_VIEW_CellContentClick);
            this.DATA_GRID_VIEW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_GRID_VIEW_CellDoubleClick);
            this.DATA_GRID_VIEW.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DATA_GRID_VIEW_ColumnHeaderMouseClick);
            // 
            // ColumnINDEX
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnINDEX.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnINDEX.DividerWidth = 1;
            this.ColumnINDEX.HeaderText = "INDEX";
            this.ColumnINDEX.Name = "ColumnINDEX";
            this.ColumnINDEX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnID
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnID.DividerWidth = 1;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MaxInputLength = 300;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnTITLE
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColumnTITLE.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnTITLE.DividerWidth = 1;
            this.ColumnTITLE.HeaderText = "TITLE";
            this.ColumnTITLE.Name = "ColumnTITLE";
            this.ColumnTITLE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnUSER
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnUSER.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnUSER.DividerWidth = 1;
            this.ColumnUSER.HeaderText = "USER SCORE";
            this.ColumnUSER.Name = "ColumnUSER";
            this.ColumnUSER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnAI
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAI.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnAI.DividerWidth = 1;
            this.ColumnAI.HeaderText = "AI SCORE";
            this.ColumnAI.Name = "ColumnAI";
            this.ColumnAI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnChecked
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = false;
            this.ColumnChecked.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnChecked.DividerWidth = 1;
            this.ColumnChecked.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColumnChecked.HeaderText = "CHECKED";
            this.ColumnChecked.Name = "ColumnChecked";
            // 
            // MAIN_PNL
            // 
            this.MAIN_PNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.MAIN_PNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MAIN_PNL.Controls.Add(this.LBL_STATUS);
            this.MAIN_PNL.Controls.Add(this.PNL_PAGE_TURNER);
            this.MAIN_PNL.Controls.Add(this.TXT_PROJECT_NAME);
            this.MAIN_PNL.Controls.Add(this.LBL_EVENTS);
            this.MAIN_PNL.Controls.Add(this.DATA_GRID_VIEW);
            this.MAIN_PNL.Controls.Add(this.MENU_STRIP);
            this.MAIN_PNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MAIN_PNL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAIN_PNL.ForeColor = System.Drawing.Color.Black;
            this.MAIN_PNL.Location = new System.Drawing.Point(0, 0);
            this.MAIN_PNL.Name = "MAIN_PNL";
            this.MAIN_PNL.Size = new System.Drawing.Size(1104, 511);
            this.MAIN_PNL.TabIndex = 1;
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_STATUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_STATUS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBL_STATUS.Location = new System.Drawing.Point(844, 486);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(256, 23);
            this.LBL_STATUS.TabIndex = 19;
            this.LBL_STATUS.Text = "      WELCOME   ";
            this.LBL_STATUS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PNL_PAGE_TURNER
            // 
            this.PNL_PAGE_TURNER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_PAGE_TURNER.BackColor = System.Drawing.Color.White;
            this.PNL_PAGE_TURNER.Controls.Add(this.PNL_INDEXES);
            this.PNL_PAGE_TURNER.Controls.Add(this.BTN_RIGHT);
            this.PNL_PAGE_TURNER.Controls.Add(this.BTN_LEFT);
            this.PNL_PAGE_TURNER.Location = new System.Drawing.Point(3, 419);
            this.PNL_PAGE_TURNER.Name = "PNL_PAGE_TURNER";
            this.PNL_PAGE_TURNER.Size = new System.Drawing.Size(1096, 65);
            this.PNL_PAGE_TURNER.TabIndex = 3;
            // 
            // PNL_INDEXES
            // 
            this.PNL_INDEXES.AutoScroll = true;
            this.PNL_INDEXES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.PNL_INDEXES.Controls.Add(this.PNL_INDEXES_BUTTONS);
            this.PNL_INDEXES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_INDEXES.ForeColor = System.Drawing.Color.Transparent;
            this.PNL_INDEXES.Location = new System.Drawing.Point(40, 0);
            this.PNL_INDEXES.Name = "PNL_INDEXES";
            this.PNL_INDEXES.Size = new System.Drawing.Size(1020, 65);
            this.PNL_INDEXES.TabIndex = 26;
            // 
            // PNL_INDEXES_BUTTONS
            // 
            this.PNL_INDEXES_BUTTONS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PNL_INDEXES_BUTTONS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_INDEXES_BUTTONS.Location = new System.Drawing.Point(0, 0);
            this.PNL_INDEXES_BUTTONS.Name = "PNL_INDEXES_BUTTONS";
            this.PNL_INDEXES_BUTTONS.Size = new System.Drawing.Size(1, 1);
            this.PNL_INDEXES_BUTTONS.TabIndex = 0;
            // 
            // BTN_RIGHT
            // 
            this.BTN_RIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.BTN_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_RIGHT.Enabled = false;
            this.BTN_RIGHT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_RIGHT.FlatAppearance.BorderSize = 0;
            this.BTN_RIGHT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_RIGHT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BTN_RIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RIGHT.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RIGHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_RIGHT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_RIGHT.Image")));
            this.BTN_RIGHT.Location = new System.Drawing.Point(1060, 0);
            this.BTN_RIGHT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_RIGHT.Name = "BTN_RIGHT";
            this.BTN_RIGHT.Size = new System.Drawing.Size(36, 65);
            this.BTN_RIGHT.TabIndex = 24;
            this.BTN_RIGHT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_RIGHT.UseVisualStyleBackColor = false;
            this.BTN_RIGHT.Click += new System.EventHandler(this.BTN_RIGHT_Click);
            // 
            // BTN_LEFT
            // 
            this.BTN_LEFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTN_LEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_LEFT.Enabled = false;
            this.BTN_LEFT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_LEFT.FlatAppearance.BorderSize = 0;
            this.BTN_LEFT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_LEFT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BTN_LEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LEFT.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LEFT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_LEFT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LEFT.Image")));
            this.BTN_LEFT.Location = new System.Drawing.Point(0, 0);
            this.BTN_LEFT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_LEFT.Name = "BTN_LEFT";
            this.BTN_LEFT.Size = new System.Drawing.Size(40, 65);
            this.BTN_LEFT.TabIndex = 23;
            this.BTN_LEFT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_LEFT.UseVisualStyleBackColor = false;
            this.BTN_LEFT.Click += new System.EventHandler(this.BTN_LEFT_Click);
            // 
            // TXT_PROJECT_NAME
            // 
            this.TXT_PROJECT_NAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXT_PROJECT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_PROJECT_NAME.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PROJECT_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_PROJECT_NAME.Location = new System.Drawing.Point(53, 3);
            this.TXT_PROJECT_NAME.Name = "TXT_PROJECT_NAME";
            this.TXT_PROJECT_NAME.Size = new System.Drawing.Size(1010, 20);
            this.TXT_PROJECT_NAME.TabIndex = 18;
            this.TXT_PROJECT_NAME.Text = "PROJECT NAME";
            this.TXT_PROJECT_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PROJECT_NAME.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TXT_PROJECT_NAME_MouseClick);
            this.TXT_PROJECT_NAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_PROJECT_NAME_KeyDown);
            // 
            // LBL_EVENTS
            // 
            this.LBL_EVENTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_EVENTS.AutoSize = true;
            this.LBL_EVENTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_EVENTS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EVENTS.ForeColor = System.Drawing.Color.LightGray;
            this.LBL_EVENTS.Location = new System.Drawing.Point(11, 487);
            this.LBL_EVENTS.Name = "LBL_EVENTS";
            this.LBL_EVENTS.Size = new System.Drawing.Size(71, 18);
            this.LBL_EVENTS.TabIndex = 1;
            this.LBL_EVENTS.Text = "WELCOME";
            // 
            // MENU_STRIP
            // 
            this.MENU_STRIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MENU_STRIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU_STRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MENU_STRIP.Location = new System.Drawing.Point(0, 0);
            this.MENU_STRIP.Name = "MENU_STRIP";
            this.MENU_STRIP.Size = new System.Drawing.Size(1102, 27);
            this.MENU_STRIP.TabIndex = 4;
            this.MENU_STRIP.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.toolStripMenuItem1.Text = "New";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.NewtoolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitToolStripMenuItem1.ForeColor = System.Drawing.Color.Silver;
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(164, 24);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // PNL_HEAD
            // 
            this.PNL_HEAD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_HEAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PNL_HEAD.Controls.Add(this.PNL_RIGHT);
            this.PNL_HEAD.Controls.Add(this.CMB_BOX);
            this.PNL_HEAD.Controls.Add(this.CHK_FREE_FULLTEXT);
            this.PNL_HEAD.Controls.Add(this.BTN_CLEAR_SEARCH);
            this.PNL_HEAD.Controls.Add(this.PCT_CANVAS);
            this.PNL_HEAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNL_HEAD.ForeColor = System.Drawing.Color.Black;
            this.PNL_HEAD.Location = new System.Drawing.Point(0, 27);
            this.PNL_HEAD.Name = "PNL_HEAD";
            this.PNL_HEAD.Size = new System.Drawing.Size(1104, 95);
            this.PNL_HEAD.TabIndex = 2;
            // 
            // PNL_RIGHT
            // 
            this.PNL_RIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_RIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.PNL_RIGHT.Controls.Add(this.LBL_RET_MAX);
            this.PNL_RIGHT.Controls.Add(this.TXT_MAX_DOWNLOAD);
            this.PNL_RIGHT.Controls.Add(this.LBL_ARTINFO);
            this.PNL_RIGHT.Controls.Add(this.BTN_DOWNLOAD_PAPERS);
            this.PNL_RIGHT.Controls.Add(this.LBL_RET_INDEX);
            this.PNL_RIGHT.Controls.Add(this.TXT_MAX_INDEX);
            this.PNL_RIGHT.Controls.Add(this.TXT_INDEX);
            this.PNL_RIGHT.Location = new System.Drawing.Point(882, 0);
            this.PNL_RIGHT.Name = "PNL_RIGHT";
            this.PNL_RIGHT.Size = new System.Drawing.Size(218, 97);
            this.PNL_RIGHT.TabIndex = 29;
            // 
            // LBL_RET_MAX
            // 
            this.LBL_RET_MAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_RET_MAX.AutoSize = true;
            this.LBL_RET_MAX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RET_MAX.Location = new System.Drawing.Point(46, 24);
            this.LBL_RET_MAX.Name = "LBL_RET_MAX";
            this.LBL_RET_MAX.Size = new System.Drawing.Size(77, 19);
            this.LBL_RET_MAX.TabIndex = 24;
            this.LBL_RET_MAX.Text = "Max Index";
            // 
            // TXT_MAX_DOWNLOAD
            // 
            this.TXT_MAX_DOWNLOAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_MAX_DOWNLOAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TXT_MAX_DOWNLOAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_MAX_DOWNLOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MAX_DOWNLOAD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TXT_MAX_DOWNLOAD.Location = new System.Drawing.Point(126, 47);
            this.TXT_MAX_DOWNLOAD.Name = "TXT_MAX_DOWNLOAD";
            this.TXT_MAX_DOWNLOAD.Size = new System.Drawing.Size(70, 15);
            this.TXT_MAX_DOWNLOAD.TabIndex = 20;
            this.TXT_MAX_DOWNLOAD.Text = "10";
            this.TXT_MAX_DOWNLOAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_MAX_DOWNLOAD.TextChanged += new System.EventHandler(this.TXT_MAX_TextChanged);
            // 
            // LBL_ARTINFO
            // 
            this.LBL_ARTINFO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_ARTINFO.AutoSize = true;
            this.LBL_ARTINFO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ARTINFO.Location = new System.Drawing.Point(31, 45);
            this.LBL_ARTINFO.Name = "LBL_ARTINFO";
            this.LBL_ARTINFO.Size = new System.Drawing.Size(91, 19);
            this.LBL_ARTINFO.TabIndex = 28;
            this.LBL_ARTINFO.Text = "Next Articles";
            // 
            // BTN_DOWNLOAD_PAPERS
            // 
            this.BTN_DOWNLOAD_PAPERS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_DOWNLOAD_PAPERS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BTN_DOWNLOAD_PAPERS.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_DOWNLOAD_PAPERS.FlatAppearance.BorderSize = 0;
            this.BTN_DOWNLOAD_PAPERS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTN_DOWNLOAD_PAPERS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BTN_DOWNLOAD_PAPERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DOWNLOAD_PAPERS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DOWNLOAD_PAPERS.ForeColor = System.Drawing.Color.Silver;
            this.BTN_DOWNLOAD_PAPERS.Location = new System.Drawing.Point(31, 67);
            this.BTN_DOWNLOAD_PAPERS.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DOWNLOAD_PAPERS.Name = "BTN_DOWNLOAD_PAPERS";
            this.BTN_DOWNLOAD_PAPERS.Size = new System.Drawing.Size(168, 24);
            this.BTN_DOWNLOAD_PAPERS.TabIndex = 22;
            this.BTN_DOWNLOAD_PAPERS.Text = "DOWNLOAD NEXT";
            this.BTN_DOWNLOAD_PAPERS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_DOWNLOAD_PAPERS.UseVisualStyleBackColor = false;
            this.BTN_DOWNLOAD_PAPERS.Click += new System.EventHandler(this.BTN_DOWNLOAD_PAPERS_Click);
            // 
            // LBL_RET_INDEX
            // 
            this.LBL_RET_INDEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_RET_INDEX.AutoSize = true;
            this.LBL_RET_INDEX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RET_INDEX.Location = new System.Drawing.Point(45, 4);
            this.LBL_RET_INDEX.Name = "LBL_RET_INDEX";
            this.LBL_RET_INDEX.Size = new System.Drawing.Size(78, 19);
            this.LBL_RET_INDEX.TabIndex = 26;
            this.LBL_RET_INDEX.Text = "Start Index";
            // 
            // TXT_MAX_INDEX
            // 
            this.TXT_MAX_INDEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_MAX_INDEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TXT_MAX_INDEX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_MAX_INDEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_MAX_INDEX.ForeColor = System.Drawing.Color.Silver;
            this.TXT_MAX_INDEX.Location = new System.Drawing.Point(126, 25);
            this.TXT_MAX_INDEX.Name = "TXT_MAX_INDEX";
            this.TXT_MAX_INDEX.Size = new System.Drawing.Size(70, 15);
            this.TXT_MAX_INDEX.TabIndex = 23;
            this.TXT_MAX_INDEX.Text = "1000";
            this.TXT_MAX_INDEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_MAX_INDEX.TextChanged += new System.EventHandler(this.TXT_MAX_INDEX_TextChanged);
            // 
            // TXT_INDEX
            // 
            this.TXT_INDEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_INDEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TXT_INDEX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_INDEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_INDEX.ForeColor = System.Drawing.Color.Silver;
            this.TXT_INDEX.Location = new System.Drawing.Point(126, 3);
            this.TXT_INDEX.Name = "TXT_INDEX";
            this.TXT_INDEX.Size = new System.Drawing.Size(70, 15);
            this.TXT_INDEX.TabIndex = 25;
            this.TXT_INDEX.Text = "0";
            this.TXT_INDEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_INDEX.TextChanged += new System.EventHandler(this.TXT_INDEX_TextChanged);
            // 
            // CMB_BOX
            // 
            this.CMB_BOX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_BOX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_BOX.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_BOX.FormattingEnabled = true;
            this.CMB_BOX.Location = new System.Drawing.Point(42, 23);
            this.CMB_BOX.Margin = new System.Windows.Forms.Padding(2);
            this.CMB_BOX.Name = "CMB_BOX";
            this.CMB_BOX.Size = new System.Drawing.Size(695, 31);
            this.CMB_BOX.TabIndex = 27;
            this.CMB_BOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CMB_BOX_KeyDown);
            this.CMB_BOX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CMB_BOX_MouseClick);
            // 
            // CHK_FREE_FULLTEXT
            // 
            this.CHK_FREE_FULLTEXT.Checked = true;
            this.CHK_FREE_FULLTEXT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_FREE_FULLTEXT.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.CHK_FREE_FULLTEXT.FlatAppearance.BorderSize = 0;
            this.CHK_FREE_FULLTEXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CHK_FREE_FULLTEXT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_FREE_FULLTEXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CHK_FREE_FULLTEXT.Location = new System.Drawing.Point(54, 59);
            this.CHK_FREE_FULLTEXT.Name = "CHK_FREE_FULLTEXT";
            this.CHK_FREE_FULLTEXT.Size = new System.Drawing.Size(134, 23);
            this.CHK_FREE_FULLTEXT.TabIndex = 19;
            this.CHK_FREE_FULLTEXT.Text = " Free Fulltext";
            this.CHK_FREE_FULLTEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CHK_FREE_FULLTEXT.UseVisualStyleBackColor = true;
            // 
            // BTN_CLEAR_SEARCH
            // 
            this.BTN_CLEAR_SEARCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CLEAR_SEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BTN_CLEAR_SEARCH.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BTN_CLEAR_SEARCH.FlatAppearance.BorderSize = 0;
            this.BTN_CLEAR_SEARCH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTN_CLEAR_SEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BTN_CLEAR_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLEAR_SEARCH.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLEAR_SEARCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_CLEAR_SEARCH.Location = new System.Drawing.Point(744, 25);
            this.BTN_CLEAR_SEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CLEAR_SEARCH.Name = "BTN_CLEAR_SEARCH";
            this.BTN_CLEAR_SEARCH.Size = new System.Drawing.Size(26, 26);
            this.BTN_CLEAR_SEARCH.TabIndex = 17;
            this.BTN_CLEAR_SEARCH.Text = "X";
            this.BTN_CLEAR_SEARCH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_CLEAR_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_CLEAR_SEARCH.Click += new System.EventHandler(this.BTN_CLEAR_SEARCH_Click);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCT_CANVAS.Location = new System.Drawing.Point(797, 14);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(79, 73);
            this.PCT_CANVAS.TabIndex = 16;
            this.PCT_CANVAS.TabStop = false;
            // 
            // OFD
            // 
            this.OFD.RestoreDirectory = true;
            // 
            // TIMER
            // 
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImageColumn1.DividerWidth = 1;
            this.dataGridViewImageColumn1.HeaderText = "PROCESS";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // frMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 511);
            this.Controls.Add(this.PNL_HEAD);
            this.Controls.Add(this.MAIN_PNL);
            this.Name = "frMAIN";
            this.Text = "AUTO SEARCH V0.5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frMAIN_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DATA_GRID_VIEW)).EndInit();
            this.MAIN_PNL.ResumeLayout(false);
            this.MAIN_PNL.PerformLayout();
            this.PNL_PAGE_TURNER.ResumeLayout(false);
            this.PNL_INDEXES.ResumeLayout(false);
            this.MENU_STRIP.ResumeLayout(false);
            this.MENU_STRIP.PerformLayout();
            this.PNL_HEAD.ResumeLayout(false);
            this.PNL_RIGHT.ResumeLayout(false);
            this.PNL_RIGHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DATA_GRID_VIEW;
        private System.Windows.Forms.Panel MAIN_PNL;
        private System.Windows.Forms.Panel PNL_HEAD;
        private System.Windows.Forms.Button BTN_CLEAR_SEARCH;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.TextBox TXT_PROJECT_NAME;
        private System.Windows.Forms.Label LBL_EVENTS;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.CheckBox CHK_FREE_FULLTEXT;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.TextBox TXT_MAX_DOWNLOAD;
        private System.Windows.Forms.Button BTN_DOWNLOAD_PAPERS;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel PNL_PAGE_TURNER;
        private System.Windows.Forms.Button BTN_RIGHT;
        private System.Windows.Forms.Button BTN_LEFT;
        private System.Windows.Forms.Panel PNL_INDEXES;
        private System.Windows.Forms.Label LBL_RET_INDEX;
        private System.Windows.Forms.TextBox TXT_INDEX;
        private System.Windows.Forms.Label LBL_RET_MAX;
        private System.Windows.Forms.TextBox TXT_MAX_INDEX;
        private System.Windows.Forms.MenuStrip MENU_STRIP;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.Panel PNL_INDEXES_BUTTONS;
        private System.Windows.Forms.ComboBox CMB_BOX;
        private System.Windows.Forms.Label LBL_ARTINFO;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnINDEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnChecked;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel PNL_RIGHT;
    }
}

