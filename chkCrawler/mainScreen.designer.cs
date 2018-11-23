namespace WindowsFormsApp2
{
    partial class mainScreen
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch (System.Exception ex)
            {
                tsStatusLabel1.Text= ex.Message;
            }
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusMsg = new System.Windows.Forms.StatusStrip();
            this.tsStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCATEGORY_KEYWORD2 = new System.Windows.Forms.TextBox();
            this.txtNM_EMP_REG2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.wb = new DotNetBrowser.WinForms.WinFormsBrowserView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbBeforeChk = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.rbNOScrap = new System.Windows.Forms.RadioButton();
            this.rbOKScrap = new System.Windows.Forms.RadioButton();
            this.btnDeny = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtREQID3 = new System.Windows.Forms.TextBox();
            this.txtDomain2 = new System.Windows.Forms.TextBox();
            this.txtURL2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkResultNO = new System.Windows.Forms.CheckBox();
            this.chkResultOK = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkStepEtc = new System.Windows.Forms.CheckBox();
            this.chkWebBrowser = new System.Windows.Forms.CheckBox();
            this.chkDB = new System.Windows.Forms.CheckBox();
            this.chk202 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkStep2 = new System.Windows.Forms.CheckBox();
            this.chk102 = new System.Windows.Forms.CheckBox();
            this.chk103 = new System.Windows.Forms.CheckBox();
            this.chkHtmlParse = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStep1 = new System.Windows.Forms.CheckBox();
            this.chkNameServer = new System.Windows.Forms.CheckBox();
            this.chkURL = new System.Windows.Forms.CheckBox();
            this.chkROBOTS = new System.Windows.Forms.CheckBox();
            this.txtREQID2 = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cmdWebBrowsing = new System.Windows.Forms.Button();
            this.btnMakeURL = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnCheckScrap = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNO_KEYWORD = new System.Windows.Forms.TextBox();
            this.txtEMBED_KEYWORD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSEARCH_KEYWORD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBEGIN_DT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEND_DT = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtCATEGORY_KEYWORD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtREQID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNM_EMP_REG = new System.Windows.Forms.TextBox();
            this.statusMsg.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusMsg
            // 
            this.statusMsg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel1});
            this.statusMsg.Location = new System.Drawing.Point(0, 840);
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusMsg.Size = new System.Drawing.Size(1520, 22);
            this.statusMsg.TabIndex = 0;
            this.statusMsg.Text = "statusStrip1";
            // 
            // tsStatusLabel1
            // 
            this.tsStatusLabel1.Name = "tsStatusLabel1";
            this.tsStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1520, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenuItem
            // 
            this.tsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHelp});
            this.tsMenuItem.Name = "tsMenuItem";
            this.tsMenuItem.Size = new System.Drawing.Size(66, 24);
            this.tsMenuItem.Text = "도움말";
            // 
            // tsHelp
            // 
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(174, 26);
            this.tsHelp.Text = "프로그램정보";
            this.tsHelp.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1520, 812);
            this.splitContainer1.SplitterDistance = 864;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(864, 812);
            this.splitContainer2.SplitterDistance = 375;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.treeView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 322);
            this.panel3.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(862, 322);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCATEGORY_KEYWORD2);
            this.panel1.Controls.Add(this.txtNM_EMP_REG2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 51);
            this.panel1.TabIndex = 1;
            // 
            // txtCATEGORY_KEYWORD2
            // 
            this.txtCATEGORY_KEYWORD2.Location = new System.Drawing.Point(553, 16);
            this.txtCATEGORY_KEYWORD2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCATEGORY_KEYWORD2.Name = "txtCATEGORY_KEYWORD2";
            this.txtCATEGORY_KEYWORD2.Size = new System.Drawing.Size(199, 25);
            this.txtCATEGORY_KEYWORD2.TabIndex = 66;
            // 
            // txtNM_EMP_REG2
            // 
            this.txtNM_EMP_REG2.Location = new System.Drawing.Point(381, 16);
            this.txtNM_EMP_REG2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNM_EMP_REG2.Name = "txtNM_EMP_REG2";
            this.txtNM_EMP_REG2.Size = new System.Drawing.Size(100, 25);
            this.txtNM_EMP_REG2.TabIndex = 64;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(769, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 29);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(328, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "신청인";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(487, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "분석번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTo
            // 
            this.dateTo.CalendarFont = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(211, 18);
            this.dateTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(111, 25);
            this.dateTo.TabIndex = 56;
            this.dateTo.Value = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(5, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 55;
            this.label15.Text = "신청기간";
            // 
            // dateFrom
            // 
            this.dateFrom.CalendarFont = new System.Drawing.Font("굴림", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(79, 18);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(109, 25);
            this.dateFrom.TabIndex = 1;
            this.dateFrom.Value = new System.DateTime(2018, 11, 1, 0, 0, 0, 0);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.wb);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(651, 812);
            this.splitContainer3.SplitterDistance = 295;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // wb
            // 
            this.wb.AcceptLanguage = null;
            this.wb.AudioMuted = null;
            this.wb.BrowserType = DotNetBrowser.BrowserType.LIGHTWEIGHT;
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.InitialFocusOwner = false;
            this.wb.Location = new System.Drawing.Point(0, 0);
            this.wb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wb.Name = "wb";
            this.wb.Preferences = null;
            this.wb.Size = new System.Drawing.Size(651, 295);
            this.wb.TabIndex = 80;
            this.wb.URL = null;
            this.wb.ZoomLevel = null;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbBeforeChk);
            this.groupBox6.Controls.Add(this.btnConfirm);
            this.groupBox6.Controls.Add(this.rbNOScrap);
            this.groupBox6.Controls.Add(this.rbOKScrap);
            this.groupBox6.Controls.Add(this.btnDeny);
            this.groupBox6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(17, 374);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(605, 65);
            this.groupBox6.TabIndex = 85;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "승인 처리 및 승인불가 입력";
            // 
            // rbBeforeChk
            // 
            this.rbBeforeChk.AutoSize = true;
            this.rbBeforeChk.Checked = true;
            this.rbBeforeChk.Location = new System.Drawing.Point(18, 30);
            this.rbBeforeChk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbBeforeChk.Name = "rbBeforeChk";
            this.rbBeforeChk.Size = new System.Drawing.Size(83, 21);
            this.rbBeforeChk.TabIndex = 50;
            this.rbBeforeChk.TabStop = true;
            this.rbBeforeChk.Text = "검사전";
            this.rbBeforeChk.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Blue;
            this.btnConfirm.Location = new System.Drawing.Point(333, 24);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(127, 29);
            this.btnConfirm.TabIndex = 68;
            this.btnConfirm.Text = "승인 처리";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_2);
            // 
            // rbNOScrap
            // 
            this.rbNOScrap.AutoSize = true;
            this.rbNOScrap.Location = new System.Drawing.Point(226, 29);
            this.rbNOScrap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNOScrap.Name = "rbNOScrap";
            this.rbNOScrap.Size = new System.Drawing.Size(101, 21);
            this.rbNOScrap.TabIndex = 49;
            this.rbNOScrap.Text = "불가능함";
            this.rbNOScrap.UseVisualStyleBackColor = true;
            // 
            // rbOKScrap
            // 
            this.rbOKScrap.AutoSize = true;
            this.rbOKScrap.Location = new System.Drawing.Point(135, 29);
            this.rbOKScrap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbOKScrap.Name = "rbOKScrap";
            this.rbOKScrap.Size = new System.Drawing.Size(83, 21);
            this.rbOKScrap.TabIndex = 48;
            this.rbOKScrap.Text = "가능함";
            this.rbOKScrap.UseVisualStyleBackColor = true;
            // 
            // btnDeny
            // 
            this.btnDeny.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeny.ForeColor = System.Drawing.Color.Blue;
            this.btnDeny.Location = new System.Drawing.Point(466, 23);
            this.btnDeny.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(129, 29);
            this.btnDeny.TabIndex = 71;
            this.btnDeny.Text = "불가 처리";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click_2);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtREQID3);
            this.groupBox5.Controls.Add(this.txtDomain2);
            this.groupBox5.Controls.Add(this.txtURL2);
            this.groupBox5.Location = new System.Drawing.Point(17, 21);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(605, 112);
            this.groupBox5.TabIndex = 84;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "URL 기본정보";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(17, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 15);
            this.label17.TabIndex = 67;
            this.label17.Text = "분석번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 71;
            this.label3.Text = "신청URL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 69;
            this.label13.Text = "도메인명";
            // 
            // txtREQID3
            // 
            this.txtREQID3.Location = new System.Drawing.Point(87, 18);
            this.txtREQID3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtREQID3.Name = "txtREQID3";
            this.txtREQID3.ReadOnly = true;
            this.txtREQID3.Size = new System.Drawing.Size(196, 25);
            this.txtREQID3.TabIndex = 68;
            // 
            // txtDomain2
            // 
            this.txtDomain2.Location = new System.Drawing.Point(87, 80);
            this.txtDomain2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDomain2.Name = "txtDomain2";
            this.txtDomain2.ReadOnly = true;
            this.txtDomain2.Size = new System.Drawing.Size(316, 25);
            this.txtDomain2.TabIndex = 72;
            // 
            // txtURL2
            // 
            this.txtURL2.Location = new System.Drawing.Point(87, 49);
            this.txtURL2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtURL2.Name = "txtURL2";
            this.txtURL2.ReadOnly = true;
            this.txtURL2.Size = new System.Drawing.Size(497, 25);
            this.txtURL2.TabIndex = 70;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkResultNO);
            this.groupBox4.Controls.Add(this.chkResultOK);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(17, 306);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(606, 58);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "스크래핑 확인 결과";
            // 
            // chkResultNO
            // 
            this.chkResultNO.AutoSize = true;
            this.chkResultNO.Location = new System.Drawing.Point(431, 25);
            this.chkResultNO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkResultNO.Name = "chkResultNO";
            this.chkResultNO.Size = new System.Drawing.Size(52, 19);
            this.chkResultNO.TabIndex = 1;
            this.chkResultNO.Text = "NO";
            this.chkResultNO.UseVisualStyleBackColor = true;
            // 
            // chkResultOK
            // 
            this.chkResultOK.AutoSize = true;
            this.chkResultOK.Location = new System.Drawing.Point(226, 25);
            this.chkResultOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkResultOK.Name = "chkResultOK";
            this.chkResultOK.Size = new System.Drawing.Size(59, 19);
            this.chkResultOK.TabIndex = 0;
            this.chkResultOK.Text = "YES";
            this.chkResultOK.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkStepEtc);
            this.groupBox3.Controls.Add(this.chkWebBrowser);
            this.groupBox3.Controls.Add(this.chkDB);
            this.groupBox3.Controls.Add(this.chk202);
            this.groupBox3.Location = new System.Drawing.Point(336, 136);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(287, 165);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "기타 오류";
            // 
            // chkStepEtc
            // 
            this.chkStepEtc.AutoSize = true;
            this.chkStepEtc.Location = new System.Drawing.Point(17, 126);
            this.chkStepEtc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkStepEtc.Name = "chkStepEtc";
            this.chkStepEtc.Size = new System.Drawing.Size(124, 19);
            this.chkStepEtc.TabIndex = 31;
            this.chkStepEtc.Text = "기타오류 없음";
            this.chkStepEtc.UseVisualStyleBackColor = true;
            // 
            // chkWebBrowser
            // 
            this.chkWebBrowser.AutoSize = true;
            this.chkWebBrowser.Location = new System.Drawing.Point(17, 95);
            this.chkWebBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWebBrowser.Name = "chkWebBrowser";
            this.chkWebBrowser.Size = new System.Drawing.Size(139, 19);
            this.chkWebBrowser.TabIndex = 30;
            this.chkWebBrowser.Text = "웹브라우징 오류";
            this.chkWebBrowser.UseVisualStyleBackColor = true;
            // 
            // chkDB
            // 
            this.chkDB.AutoSize = true;
            this.chkDB.Location = new System.Drawing.Point(16, 39);
            this.chkDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDB.Name = "chkDB";
            this.chkDB.Size = new System.Drawing.Size(169, 19);
            this.chkDB.TabIndex = 24;
            this.chkDB.Text = "마리아 DB 접속 오류";
            this.chkDB.UseVisualStyleBackColor = true;
            // 
            // chk202
            // 
            this.chk202.AutoSize = true;
            this.chk202.Location = new System.Drawing.Point(17, 69);
            this.chk202.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk202.Name = "chk202";
            this.chk202.Size = new System.Drawing.Size(119, 19);
            this.chk202.TabIndex = 29;
            this.chk202.Text = "DB 저장 오류";
            this.chk202.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkStep2);
            this.groupBox2.Controls.Add(this.chk102);
            this.groupBox2.Controls.Add(this.chk103);
            this.groupBox2.Controls.Add(this.chkHtmlParse);
            this.groupBox2.Location = new System.Drawing.Point(389, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(182, 165);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "스크래핑 오류";
            this.groupBox2.Visible = false;
            // 
            // chkStep2
            // 
            this.chkStep2.AutoSize = true;
            this.chkStep2.Enabled = false;
            this.chkStep2.Location = new System.Drawing.Point(17, 122);
            this.chkStep2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkStep2.Name = "chkStep2";
            this.chkStep2.Size = new System.Drawing.Size(89, 19);
            this.chkStep2.TabIndex = 27;
            this.chkStep2.Text = "해당없음";
            this.chkStep2.UseVisualStyleBackColor = true;
            // 
            // chk102
            // 
            this.chk102.AutoSize = true;
            this.chk102.Enabled = false;
            this.chk102.Location = new System.Drawing.Point(17, 66);
            this.chk102.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk102.Name = "chk102";
            this.chk102.Size = new System.Drawing.Size(132, 19);
            this.chk102.TabIndex = 18;
            this.chk102.Text = "AJAX 파싱 에러";
            this.chk102.UseVisualStyleBackColor = true;
            // 
            // chk103
            // 
            this.chk103.AutoSize = true;
            this.chk103.Enabled = false;
            this.chk103.Location = new System.Drawing.Point(17, 94);
            this.chk103.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk103.Name = "chk103";
            this.chk103.Size = new System.Drawing.Size(161, 19);
            this.chk103.TabIndex = 21;
            this.chk103.Text = "javascript 파싱 에러";
            this.chk103.UseVisualStyleBackColor = true;
            // 
            // chkHtmlParse
            // 
            this.chkHtmlParse.AutoSize = true;
            this.chkHtmlParse.Enabled = false;
            this.chkHtmlParse.Location = new System.Drawing.Point(17, 39);
            this.chkHtmlParse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkHtmlParse.Name = "chkHtmlParse";
            this.chkHtmlParse.Size = new System.Drawing.Size(125, 19);
            this.chkHtmlParse.TabIndex = 22;
            this.chkHtmlParse.Text = "html 파싱 에러";
            this.chkHtmlParse.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStep1);
            this.groupBox1.Controls.Add(this.chkNameServer);
            this.groupBox1.Controls.Add(this.chkURL);
            this.groupBox1.Controls.Add(this.chkROBOTS);
            this.groupBox1.Location = new System.Drawing.Point(17, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(293, 165);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "시스템 원인";
            // 
            // chkStep1
            // 
            this.chkStep1.AutoSize = true;
            this.chkStep1.Location = new System.Drawing.Point(18, 121);
            this.chkStep1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkStep1.Name = "chkStep1";
            this.chkStep1.Size = new System.Drawing.Size(144, 19);
            this.chkStep1.TabIndex = 26;
            this.chkStep1.Text = "시스템 원인 없음";
            this.chkStep1.UseVisualStyleBackColor = true;
            // 
            // chkNameServer
            // 
            this.chkNameServer.AutoSize = true;
            this.chkNameServer.ForeColor = System.Drawing.Color.Red;
            this.chkNameServer.Location = new System.Drawing.Point(18, 94);
            this.chkNameServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNameServer.Name = "chkNameServer";
            this.chkNameServer.Size = new System.Drawing.Size(144, 19);
            this.chkNameServer.TabIndex = 25;
            this.chkNameServer.Text = "인터넷 접속 오류";
            this.chkNameServer.UseVisualStyleBackColor = true;
            // 
            // chkURL
            // 
            this.chkURL.AutoSize = true;
            this.chkURL.Location = new System.Drawing.Point(18, 39);
            this.chkURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkURL.Name = "chkURL";
            this.chkURL.Size = new System.Drawing.Size(182, 19);
            this.chkURL.TabIndex = 17;
            this.chkURL.Text = "URL 접속 에러  발생함";
            this.chkURL.UseVisualStyleBackColor = true;
            // 
            // chkROBOTS
            // 
            this.chkROBOTS.AutoSize = true;
            this.chkROBOTS.Location = new System.Drawing.Point(18, 66);
            this.chkROBOTS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkROBOTS.Name = "chkROBOTS";
            this.chkROBOTS.Size = new System.Drawing.Size(163, 19);
            this.chkROBOTS.TabIndex = 19;
            this.chkROBOTS.Text = "robots.txt 접근 불가";
            this.chkROBOTS.UseVisualStyleBackColor = true;
            // 
            // txtREQID2
            // 
            this.txtREQID2.Location = new System.Drawing.Point(698, -2);
            this.txtREQID2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtREQID2.Name = "txtREQID2";
            this.txtREQID2.Size = new System.Drawing.Size(199, 25);
            this.txtREQID2.TabIndex = 65;
            this.txtREQID2.Visible = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(862, 430);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(854, 401);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "신청사항";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cmdWebBrowsing);
            this.groupBox9.Controls.Add(this.btnMakeURL);
            this.groupBox9.Controls.Add(this.txtDomain);
            this.groupBox9.Controls.Add(this.btnCheckScrap);
            this.groupBox9.Controls.Add(this.txtURL);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Location = new System.Drawing.Point(6, 4);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox9.Size = new System.Drawing.Size(833, 96);
            this.groupBox9.TabIndex = 57;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "신청 URL";
            // 
            // cmdWebBrowsing
            // 
            this.cmdWebBrowsing.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmdWebBrowsing.ForeColor = System.Drawing.Color.Blue;
            this.cmdWebBrowsing.Location = new System.Drawing.Point(622, 52);
            this.cmdWebBrowsing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdWebBrowsing.Name = "cmdWebBrowsing";
            this.cmdWebBrowsing.Size = new System.Drawing.Size(184, 29);
            this.cmdWebBrowsing.TabIndex = 63;
            this.cmdWebBrowsing.Text = "웹브라우징 확인";
            this.cmdWebBrowsing.UseVisualStyleBackColor = true;
            this.cmdWebBrowsing.Click += new System.EventHandler(this.cmdWebBrowsing_Click_1);
            // 
            // btnMakeURL
            // 
            this.btnMakeURL.Location = new System.Drawing.Point(416, -8);
            this.btnMakeURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeURL.Name = "btnMakeURL";
            this.btnMakeURL.Size = new System.Drawing.Size(142, 22);
            this.btnMakeURL.TabIndex = 62;
            this.btnMakeURL.Text = "1.makeSampleURL";
            this.btnMakeURL.UseVisualStyleBackColor = true;
            this.btnMakeURL.Visible = false;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(97, 54);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.ReadOnly = true;
            this.txtDomain.Size = new System.Drawing.Size(316, 25);
            this.txtDomain.TabIndex = 62;
            // 
            // btnCheckScrap
            // 
            this.btnCheckScrap.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckScrap.ForeColor = System.Drawing.Color.Blue;
            this.btnCheckScrap.Location = new System.Drawing.Point(438, 52);
            this.btnCheckScrap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckScrap.Name = "btnCheckScrap";
            this.btnCheckScrap.Size = new System.Drawing.Size(166, 29);
            this.btnCheckScrap.TabIndex = 61;
            this.btnCheckScrap.Text = "스크래핑 확인";
            this.btnCheckScrap.UseVisualStyleBackColor = true;
            this.btnCheckScrap.Click += new System.EventHandler(this.btnCheckScrap_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(97, 19);
            this.txtURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(710, 25);
            this.txtURL.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(7, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 59;
            this.label11.Text = "신청URL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "도메인명";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.txtNO_KEYWORD);
            this.groupBox8.Controls.Add(this.txtEMBED_KEYWORD);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.txtSEARCH_KEYWORD);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.txtBEGIN_DT);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.txtEND_DT);
            this.groupBox8.Location = new System.Drawing.Point(6, 160);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox8.Size = new System.Drawing.Size(833, 128);
            this.groupBox8.TabIndex = 56;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "선태항목(웹사이트 접속시)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 68;
            this.label12.Text = "배  제  어";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 67;
            this.label9.Text = "포  함  어";
            // 
            // txtNO_KEYWORD
            // 
            this.txtNO_KEYWORD.Location = new System.Drawing.Point(531, 60);
            this.txtNO_KEYWORD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNO_KEYWORD.Name = "txtNO_KEYWORD";
            this.txtNO_KEYWORD.ReadOnly = true;
            this.txtNO_KEYWORD.Size = new System.Drawing.Size(275, 25);
            this.txtNO_KEYWORD.TabIndex = 66;
            // 
            // txtEMBED_KEYWORD
            // 
            this.txtEMBED_KEYWORD.Location = new System.Drawing.Point(97, 61);
            this.txtEMBED_KEYWORD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEMBED_KEYWORD.Name = "txtEMBED_KEYWORD";
            this.txtEMBED_KEYWORD.ReadOnly = true;
            this.txtEMBED_KEYWORD.Size = new System.Drawing.Size(316, 25);
            this.txtEMBED_KEYWORD.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 48;
            this.label16.Text = "수집키워드";
            // 
            // txtSEARCH_KEYWORD
            // 
            this.txtSEARCH_KEYWORD.Location = new System.Drawing.Point(97, 26);
            this.txtSEARCH_KEYWORD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSEARCH_KEYWORD.Name = "txtSEARCH_KEYWORD";
            this.txtSEARCH_KEYWORD.ReadOnly = true;
            this.txtSEARCH_KEYWORD.Size = new System.Drawing.Size(710, 25);
            this.txtSEARCH_KEYWORD.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 15);
            this.label14.TabIndex = 63;
            this.label14.Text = "수집 기간";
            // 
            // txtBEGIN_DT
            // 
            this.txtBEGIN_DT.Location = new System.Drawing.Point(97, 92);
            this.txtBEGIN_DT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBEGIN_DT.Name = "txtBEGIN_DT";
            this.txtBEGIN_DT.ReadOnly = true;
            this.txtBEGIN_DT.Size = new System.Drawing.Size(149, 25);
            this.txtBEGIN_DT.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 59;
            this.label8.Text = "~";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEND_DT
            // 
            this.txtEND_DT.Location = new System.Drawing.Point(277, 91);
            this.txtEND_DT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEND_DT.Name = "txtEND_DT";
            this.txtEND_DT.ReadOnly = true;
            this.txtEND_DT.Size = new System.Drawing.Size(137, 25);
            this.txtEND_DT.TabIndex = 58;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtCATEGORY_KEYWORD);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.txtREQID);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.txtNM_EMP_REG);
            this.groupBox7.Location = new System.Drawing.Point(3, 101);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(833, 50);
            this.groupBox7.TabIndex = 55;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "필수항목";
            // 
            // txtCATEGORY_KEYWORD
            // 
            this.txtCATEGORY_KEYWORD.Location = new System.Drawing.Point(99, 16);
            this.txtCATEGORY_KEYWORD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCATEGORY_KEYWORD.Name = "txtCATEGORY_KEYWORD";
            this.txtCATEGORY_KEYWORD.ReadOnly = true;
            this.txtCATEGORY_KEYWORD.Size = new System.Drawing.Size(196, 25);
            this.txtCATEGORY_KEYWORD.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "분석번호";
            // 
            // txtREQID
            // 
            this.txtREQID.Location = new System.Drawing.Point(613, 18);
            this.txtREQID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtREQID.Name = "txtREQID";
            this.txtREQID.ReadOnly = true;
            this.txtREQID.Size = new System.Drawing.Size(196, 25);
            this.txtREQID.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(342, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "신청인명";
            // 
            // txtNM_EMP_REG
            // 
            this.txtNM_EMP_REG.Location = new System.Drawing.Point(419, 16);
            this.txtNM_EMP_REG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNM_EMP_REG.Name = "txtNM_EMP_REG";
            this.txtNM_EMP_REG.ReadOnly = true;
            this.txtNM_EMP_REG.Size = new System.Drawing.Size(102, 25);
            this.txtNM_EMP_REG.TabIndex = 43;
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1520, 862);
            this.Controls.Add(this.txtREQID2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusMsg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "맞춤형 URL 확인용 프로그램 Ver.1.11.19";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusMsg.ResumeLayout(false);
            this.statusMsg.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtREQID2;
        private System.Windows.Forms.TextBox txtNM_EMP_REG2;
        private System.Windows.Forms.ToolStripMenuItem tsHelp;
        private System.Windows.Forms.TextBox txtCATEGORY_KEYWORD2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView treeView1;
        private DotNetBrowser.WinForms.WinFormsBrowserView wb;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbBeforeChk;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rbNOScrap;
        private System.Windows.Forms.RadioButton rbOKScrap;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtREQID3;
        private System.Windows.Forms.TextBox txtDomain2;
        private System.Windows.Forms.TextBox txtURL2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkResultNO;
        private System.Windows.Forms.CheckBox chkResultOK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkStepEtc;
        private System.Windows.Forms.CheckBox chkWebBrowser;
        private System.Windows.Forms.CheckBox chkDB;
        private System.Windows.Forms.CheckBox chk202;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkStep2;
        private System.Windows.Forms.CheckBox chk102;
        private System.Windows.Forms.CheckBox chk103;
        private System.Windows.Forms.CheckBox chkHtmlParse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkStep1;
        private System.Windows.Forms.CheckBox chkNameServer;
        private System.Windows.Forms.CheckBox chkURL;
        private System.Windows.Forms.CheckBox chkROBOTS;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button cmdWebBrowsing;
        private System.Windows.Forms.Button btnMakeURL;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnCheckScrap;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNO_KEYWORD;
        private System.Windows.Forms.TextBox txtEMBED_KEYWORD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSEARCH_KEYWORD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBEGIN_DT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEND_DT;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtCATEGORY_KEYWORD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtREQID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNM_EMP_REG;
    }
}

