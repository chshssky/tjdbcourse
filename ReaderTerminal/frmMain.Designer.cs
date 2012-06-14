namespace ReaderTerminal
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlWrapperMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgBookSearch = new System.Windows.Forms.TabPage();
            this.lstBookResult = new System.Windows.Forms.ListView();
            this.pnlSearchWrapper = new System.Windows.Forms.Panel();
            this.grpBookSearch = new System.Windows.Forms.GroupBox();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.tblSearchBar = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchContent = new System.Windows.Forms.TextBox();
            this.tpgReaderInfo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.txtReaderRealName = new System.Windows.Forms.TextBox();
            this.txtReaderCredNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtRegTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExpTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.cmbReaderGender = new System.Windows.Forms.ComboBox();
            this.cmbReaderCredType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReaderSubmit = new System.Windows.Forms.Button();
            this.btnReaderCancel = new System.Windows.Forms.Button();
            this.tpgBookRental = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvBorrowed = new System.Windows.Forms.DataGridView();
            this.bookisbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new ReaderTerminal.DataSet();
            this.tpgBookReserve = new System.Windows.Forms.TabPage();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.终端TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.读者RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReaderChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbChangePassword = new System.Windows.Forms.ToolStripButton();
            this.borrowingTableAdapter = new ReaderTerminal.DataSetTableAdapters.borrowingTableAdapter();
            this.pnlWrapperMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tpgBookSearch.SuspendLayout();
            this.pnlSearchWrapper.SuspendLayout();
            this.grpBookSearch.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            this.tblSearchBar.SuspendLayout();
            this.tpgReaderInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpgBookRental.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWrapperMain
            // 
            this.pnlWrapperMain.Controls.Add(this.tabMain);
            this.pnlWrapperMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapperMain.Location = new System.Drawing.Point(0, 50);
            this.pnlWrapperMain.Name = "pnlWrapperMain";
            this.pnlWrapperMain.Padding = new System.Windows.Forms.Padding(7, 0, 5, 6);
            this.pnlWrapperMain.Size = new System.Drawing.Size(624, 360);
            this.pnlWrapperMain.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgBookSearch);
            this.tabMain.Controls.Add(this.tpgReaderInfo);
            this.tabMain.Controls.Add(this.tpgBookRental);
            this.tabMain.Controls.Add(this.tpgBookReserve);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(7, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(612, 354);
            this.tabMain.TabIndex = 1;
            // 
            // tpgBookSearch
            // 
            this.tpgBookSearch.Controls.Add(this.lstBookResult);
            this.tpgBookSearch.Controls.Add(this.pnlSearchWrapper);
            this.tpgBookSearch.Location = new System.Drawing.Point(4, 22);
            this.tpgBookSearch.Name = "tpgBookSearch";
            this.tpgBookSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBookSearch.Size = new System.Drawing.Size(604, 328);
            this.tpgBookSearch.TabIndex = 0;
            this.tpgBookSearch.Text = "书籍检索";
            this.tpgBookSearch.UseVisualStyleBackColor = true;
            // 
            // lstBookResult
            // 
            this.lstBookResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBookResult.Location = new System.Drawing.Point(3, 66);
            this.lstBookResult.Name = "lstBookResult";
            this.lstBookResult.Size = new System.Drawing.Size(598, 259);
            this.lstBookResult.TabIndex = 7;
            this.lstBookResult.UseCompatibleStateImageBehavior = false;
            this.lstBookResult.SelectedIndexChanged += new System.EventHandler(this.lstBookResult_SelectedIndexChanged);
            this.lstBookResult.DoubleClick += new System.EventHandler(this.lstBookResult_DoubleClick);
            // 
            // pnlSearchWrapper
            // 
            this.pnlSearchWrapper.Controls.Add(this.grpBookSearch);
            this.pnlSearchWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchWrapper.Location = new System.Drawing.Point(3, 3);
            this.pnlSearchWrapper.Name = "pnlSearchWrapper";
            this.pnlSearchWrapper.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSearchWrapper.Size = new System.Drawing.Size(598, 63);
            this.pnlSearchWrapper.TabIndex = 6;
            // 
            // grpBookSearch
            // 
            this.grpBookSearch.Controls.Add(this.pnlSearchBar);
            this.grpBookSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBookSearch.Location = new System.Drawing.Point(8, 8);
            this.grpBookSearch.Name = "grpBookSearch";
            this.grpBookSearch.Size = new System.Drawing.Size(582, 47);
            this.grpBookSearch.TabIndex = 3;
            this.grpBookSearch.TabStop = false;
            this.grpBookSearch.Text = "检索方式及关键字";
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.Controls.Add(this.tblSearchBar);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBar.Location = new System.Drawing.Point(3, 17);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(576, 27);
            this.pnlSearchBar.TabIndex = 0;
            // 
            // tblSearchBar
            // 
            this.tblSearchBar.ColumnCount = 3;
            this.tblSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearchBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblSearchBar.Controls.Add(this.cmbSearchType, 0, 0);
            this.tblSearchBar.Controls.Add(this.btnSearch, 2, 0);
            this.tblSearchBar.Controls.Add(this.txtSearchContent, 1, 0);
            this.tblSearchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearchBar.Location = new System.Drawing.Point(0, 0);
            this.tblSearchBar.Name = "tblSearchBar";
            this.tblSearchBar.RowCount = 1;
            this.tblSearchBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearchBar.Size = new System.Drawing.Size(576, 27);
            this.tblSearchBar.TabIndex = 4;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "题名",
            "责任者",
            "ISBN",
            "分类",
            "出版社"});
            this.cmbSearchType.Location = new System.Drawing.Point(3, 3);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(74, 20);
            this.cmbSearchType.TabIndex = 0;
            this.cmbSearchType.SelectedIndexChanged += new System.EventHandler(this.cmbSearchType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(499, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 21);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchContent
            // 
            this.txtSearchContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchContent.Location = new System.Drawing.Point(83, 3);
            this.txtSearchContent.Name = "txtSearchContent";
            this.txtSearchContent.Size = new System.Drawing.Size(410, 21);
            this.txtSearchContent.TabIndex = 1;
            this.txtSearchContent.TextChanged += new System.EventHandler(this.txtSearchContent_TextChanged);
            // 
            // tpgReaderInfo
            // 
            this.tpgReaderInfo.Controls.Add(this.panel1);
            this.tpgReaderInfo.Controls.Add(this.panel2);
            this.tpgReaderInfo.Location = new System.Drawing.Point(4, 22);
            this.tpgReaderInfo.Name = "tpgReaderInfo";
            this.tpgReaderInfo.Size = new System.Drawing.Size(604, 328);
            this.tpgReaderInfo.TabIndex = 1;
            this.tpgReaderInfo.Text = "读者信息";
            this.tpgReaderInfo.UseVisualStyleBackColor = true;
            this.tpgReaderInfo.Enter += new System.EventHandler(this.btnReaderCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 12, 6, 6);
            this.panel1.Size = new System.Drawing.Size(604, 288);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtReaderName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtReaderRealName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtReaderCredNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPhone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtRegTime, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtExpTime, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtGroupName, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtAvailable, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbReaderGender, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbReaderCredType, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 270);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名(&L)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "真实姓名(&R)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别(&G)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "电话(&P)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "注册时间(&E)";
            // 
            // txtReaderName
            // 
            this.txtReaderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReaderName.Location = new System.Drawing.Point(103, 3);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.ReadOnly = true;
            this.txtReaderName.Size = new System.Drawing.Size(492, 21);
            this.txtReaderName.TabIndex = 7;
            // 
            // txtReaderRealName
            // 
            this.txtReaderRealName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReaderRealName.Location = new System.Drawing.Point(103, 28);
            this.txtReaderRealName.Name = "txtReaderRealName";
            this.txtReaderRealName.Size = new System.Drawing.Size(492, 21);
            this.txtReaderRealName.TabIndex = 8;
            // 
            // txtReaderCredNumber
            // 
            this.txtReaderCredNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReaderCredNumber.Location = new System.Drawing.Point(103, 78);
            this.txtReaderCredNumber.Name = "txtReaderCredNumber";
            this.txtReaderCredNumber.Size = new System.Drawing.Size(492, 21);
            this.txtReaderCredNumber.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Location = new System.Drawing.Point(103, 103);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(492, 21);
            this.txtPhone.TabIndex = 11;
            // 
            // txtRegTime
            // 
            this.txtRegTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegTime.Location = new System.Drawing.Point(103, 128);
            this.txtRegTime.Name = "txtRegTime";
            this.txtRegTime.ReadOnly = true;
            this.txtRegTime.Size = new System.Drawing.Size(492, 21);
            this.txtRegTime.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "到期时间(&X)";
            // 
            // txtExpTime
            // 
            this.txtExpTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpTime.Location = new System.Drawing.Point(103, 153);
            this.txtExpTime.Name = "txtExpTime";
            this.txtExpTime.ReadOnly = true;
            this.txtExpTime.Size = new System.Drawing.Size(492, 21);
            this.txtExpTime.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "组名称(&U)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "可用(&V)";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGroupName.Location = new System.Drawing.Point(103, 178);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.ReadOnly = true;
            this.txtGroupName.Size = new System.Drawing.Size(492, 21);
            this.txtGroupName.TabIndex = 16;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAvailable.Location = new System.Drawing.Point(103, 203);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(492, 21);
            this.txtAvailable.TabIndex = 17;
            // 
            // cmbReaderGender
            // 
            this.cmbReaderGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbReaderGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReaderGender.FormattingEnabled = true;
            this.cmbReaderGender.Items.AddRange(new object[] {
            "男",
            "女",
            "保密"});
            this.cmbReaderGender.Location = new System.Drawing.Point(103, 53);
            this.cmbReaderGender.Name = "cmbReaderGender";
            this.cmbReaderGender.Size = new System.Drawing.Size(492, 20);
            this.cmbReaderGender.TabIndex = 18;
            // 
            // cmbReaderCredType
            // 
            this.cmbReaderCredType.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbReaderCredType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReaderCredType.FormattingEnabled = true;
            this.cmbReaderCredType.Items.AddRange(new object[] {
            "身份证",
            "学生证",
            "军官证",
            "驾驶执照"});
            this.cmbReaderCredType.Location = new System.Drawing.Point(16, 78);
            this.cmbReaderCredType.Name = "cmbReaderCredType";
            this.cmbReaderCredType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbReaderCredType.Size = new System.Drawing.Size(81, 20);
            this.cmbReaderCredType.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 40);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReaderSubmit);
            this.panel3.Controls.Add(this.btnReaderCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(420, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 40);
            this.panel3.TabIndex = 1;
            // 
            // btnReaderSubmit
            // 
            this.btnReaderSubmit.Location = new System.Drawing.Point(25, 6);
            this.btnReaderSubmit.Name = "btnReaderSubmit";
            this.btnReaderSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnReaderSubmit.TabIndex = 1;
            this.btnReaderSubmit.Text = "确定(&O)";
            this.btnReaderSubmit.UseVisualStyleBackColor = true;
            this.btnReaderSubmit.Click += new System.EventHandler(this.btnReaderSubmit_Click);
            // 
            // btnReaderCancel
            // 
            this.btnReaderCancel.Location = new System.Drawing.Point(106, 6);
            this.btnReaderCancel.Name = "btnReaderCancel";
            this.btnReaderCancel.Size = new System.Drawing.Size(75, 26);
            this.btnReaderCancel.TabIndex = 0;
            this.btnReaderCancel.Text = "取消(&C)";
            this.btnReaderCancel.UseVisualStyleBackColor = true;
            this.btnReaderCancel.Click += new System.EventHandler(this.btnReaderCancel_Click);
            // 
            // tpgBookRental
            // 
            this.tpgBookRental.Controls.Add(this.panel4);
            this.tpgBookRental.Location = new System.Drawing.Point(4, 22);
            this.tpgBookRental.Name = "tpgBookRental";
            this.tpgBookRental.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBookRental.Size = new System.Drawing.Size(604, 328);
            this.tpgBookRental.TabIndex = 2;
            this.tpgBookRental.Text = "在借书刊";
            this.tpgBookRental.UseVisualStyleBackColor = true;
            this.tpgBookRental.Enter += new System.EventHandler(this.tpgBookRental_Enter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvBorrowed);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(598, 322);
            this.panel4.TabIndex = 1;
            // 
            // dgvBorrowed
            // 
            this.dgvBorrowed.AllowUserToAddRows = false;
            this.dgvBorrowed.AllowUserToDeleteRows = false;
            this.dgvBorrowed.AutoGenerateColumns = false;
            this.dgvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookisbnDataGridViewTextBoxColumn,
            this.booktitleDataGridViewTextBoxColumn,
            this.bookauthorDataGridViewTextBoxColumn,
            this.bookpublisherDataGridViewTextBoxColumn,
            this.renttimeDataGridViewTextBoxColumn,
            this.duetimeDataGridViewTextBoxColumn});
            this.dgvBorrowed.DataSource = this.borrowingBindingSource;
            this.dgvBorrowed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrowed.Location = new System.Drawing.Point(3, 3);
            this.dgvBorrowed.Name = "dgvBorrowed";
            this.dgvBorrowed.ReadOnly = true;
            this.dgvBorrowed.RowTemplate.Height = 23;
            this.dgvBorrowed.Size = new System.Drawing.Size(592, 316);
            this.dgvBorrowed.TabIndex = 0;
            this.dgvBorrowed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowed_CellContentClick);
            // 
            // bookisbnDataGridViewTextBoxColumn
            // 
            this.bookisbnDataGridViewTextBoxColumn.DataPropertyName = "book_isbn";
            this.bookisbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.bookisbnDataGridViewTextBoxColumn.Name = "bookisbnDataGridViewTextBoxColumn";
            this.bookisbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookisbnDataGridViewTextBoxColumn.Width = 64;
            // 
            // booktitleDataGridViewTextBoxColumn
            // 
            this.booktitleDataGridViewTextBoxColumn.DataPropertyName = "book_title";
            this.booktitleDataGridViewTextBoxColumn.HeaderText = "书名";
            this.booktitleDataGridViewTextBoxColumn.Name = "booktitleDataGridViewTextBoxColumn";
            this.booktitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookauthorDataGridViewTextBoxColumn
            // 
            this.bookauthorDataGridViewTextBoxColumn.DataPropertyName = "book_author";
            this.bookauthorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.bookauthorDataGridViewTextBoxColumn.Name = "bookauthorDataGridViewTextBoxColumn";
            this.bookauthorDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookauthorDataGridViewTextBoxColumn.Width = 64;
            // 
            // bookpublisherDataGridViewTextBoxColumn
            // 
            this.bookpublisherDataGridViewTextBoxColumn.DataPropertyName = "book_publisher";
            this.bookpublisherDataGridViewTextBoxColumn.HeaderText = "出版社";
            this.bookpublisherDataGridViewTextBoxColumn.Name = "bookpublisherDataGridViewTextBoxColumn";
            this.bookpublisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renttimeDataGridViewTextBoxColumn
            // 
            this.renttimeDataGridViewTextBoxColumn.DataPropertyName = "rent_time";
            this.renttimeDataGridViewTextBoxColumn.HeaderText = "借阅时间";
            this.renttimeDataGridViewTextBoxColumn.Name = "renttimeDataGridViewTextBoxColumn";
            this.renttimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duetimeDataGridViewTextBoxColumn
            // 
            this.duetimeDataGridViewTextBoxColumn.DataPropertyName = "due_time";
            this.duetimeDataGridViewTextBoxColumn.HeaderText = "应还时间";
            this.duetimeDataGridViewTextBoxColumn.Name = "duetimeDataGridViewTextBoxColumn";
            this.duetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowingBindingSource
            // 
            this.borrowingBindingSource.DataMember = "borrowing";
            this.borrowingBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpgBookReserve
            // 
            this.tpgBookReserve.Location = new System.Drawing.Point(4, 22);
            this.tpgBookReserve.Name = "tpgBookReserve";
            this.tpgBookReserve.Size = new System.Drawing.Size(604, 328);
            this.tpgBookReserve.TabIndex = 3;
            this.tpgBookReserve.Text = "预约查询";
            this.tpgBookReserve.UseVisualStyleBackColor = true;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.终端TToolStripMenuItem,
            this.读者RToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(624, 25);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // 终端TToolStripMenuItem
            // 
            this.终端TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolExit});
            this.终端TToolStripMenuItem.Name = "终端TToolStripMenuItem";
            this.终端TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.终端TToolStripMenuItem.Text = "终端(&T)";
            // 
            // mnuToolExit
            // 
            this.mnuToolExit.Name = "mnuToolExit";
            this.mnuToolExit.Size = new System.Drawing.Size(116, 22);
            this.mnuToolExit.Text = "退出(&X)";
            this.mnuToolExit.Click += new System.EventHandler(this.mnuTerminalExit_Click);
            // 
            // 读者RToolStripMenuItem
            // 
            this.读者RToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReaderChangePassword});
            this.读者RToolStripMenuItem.Name = "读者RToolStripMenuItem";
            this.读者RToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.读者RToolStripMenuItem.Text = "读者(&R)";
            // 
            // mnuReaderChangePassword
            // 
            this.mnuReaderChangePassword.Name = "mnuReaderChangePassword";
            this.mnuReaderChangePassword.Size = new System.Drawing.Size(140, 22);
            this.mnuReaderChangePassword.Text = "修改密码(&C)";
            this.mnuReaderChangePassword.Click += new System.EventHandler(this.mnuReaderChangePassword_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "图书馆读者终端。";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChangePassword});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbChangePassword
            // 
            this.tsbChangePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangePassword.Image")));
            this.tsbChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangePassword.Name = "tsbChangePassword";
            this.tsbChangePassword.Size = new System.Drawing.Size(23, 22);
            this.tsbChangePassword.Text = "toolStripButton1";
            this.tsbChangePassword.Click += new System.EventHandler(this.mnuReaderChangePassword_Click);
            // 
            // borrowingTableAdapter
            // 
            this.borrowingTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 432);
            this.Controls.Add(this.pnlWrapperMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(640, 470);
            this.Name = "frmMain";
            this.Text = "图书馆读者终端";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlWrapperMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tpgBookSearch.ResumeLayout(false);
            this.pnlSearchWrapper.ResumeLayout(false);
            this.grpBookSearch.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.tblSearchBar.ResumeLayout(false);
            this.tblSearchBar.PerformLayout();
            this.tpgReaderInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tpgBookRental.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWrapperMain;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgBookSearch;
        private System.Windows.Forms.Panel pnlSearchWrapper;
        private System.Windows.Forms.GroupBox grpBookSearch;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.TableLayoutPanel tblSearchBar;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchContent;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem 读者RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 终端TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuToolExit;
        private System.Windows.Forms.TabPage tpgBookRental;
        private System.Windows.Forms.TabPage tpgBookReserve;
        private System.Windows.Forms.ListView lstBookResult;
        private System.Windows.Forms.TabPage tpgReaderInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mnuReaderChangePassword;
        private System.Windows.Forms.ToolStripButton tsbChangePassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.TextBox txtReaderRealName;
        private System.Windows.Forms.TextBox txtReaderCredNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtRegTime;
        private System.Windows.Forms.TextBox txtExpTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbReaderGender;
        private System.Windows.Forms.ComboBox cmbReaderCredType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReaderSubmit;
        private System.Windows.Forms.Button btnReaderCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvBorrowed;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource borrowingBindingSource;
        private DataSetTableAdapters.borrowingTableAdapter borrowingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookisbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duetimeDataGridViewTextBoxColumn;


    }
}