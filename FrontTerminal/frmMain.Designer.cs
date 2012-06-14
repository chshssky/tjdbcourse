namespace FrontTerminal
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpRental = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlRentalInfo = new System.Windows.Forms.Panel();
            this.dgvReaderBorrow = new System.Windows.Forms.DataGridView();
            this.RentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReaderInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textboxBookId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchReader = new System.Windows.Forms.Button();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbReaderId = new System.Windows.Forms.TextBox();
            this.tbpReader = new System.Windows.Forms.TabPage();
            this.pnlReaderWrapper = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlReaderResult = new System.Windows.Forms.Panel();
            this.dbgReaderinfo = new System.Windows.Forms.DataGridView();
            this.readId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credentialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credentialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReaderCond = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbReaderGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbReadName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpRude = new System.Windows.Forms.TabPage();
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particularidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overduereaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frDataSet = new FrontTerminal.FrDataSet();
            this.tbpLost = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.终端TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frontDataSet = new FrontTerminal.FrontDataSet();
            this.frontDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frontDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.overdue_readerTableAdapter = new FrontTerminal.FrDataSetTableAdapters.overdue_readerTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlWrapper.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbpRental.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlRentalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderBorrow)).BeginInit();
            this.pnlReaderInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpReader.SuspendLayout();
            this.pnlReaderWrapper.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlReaderResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgReaderinfo)).BeginInit();
            this.pnlReaderCond.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tbpRude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overduereaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frDataSet)).BeginInit();
            this.tbpLost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frontDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontDataSetBindingSource1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Controls.Add(this.tbcMain);
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.Location = new System.Drawing.Point(0, 25);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Padding = new System.Windows.Forms.Padding(8, 0, 6, 7);
            this.pnlWrapper.Size = new System.Drawing.Size(679, 378);
            this.pnlWrapper.TabIndex = 15;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpRental);
            this.tbcMain.Controls.Add(this.tbpReader);
            this.tbcMain.Controls.Add(this.tbpRude);
            this.tbcMain.Controls.Add(this.tbpLost);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(8, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(665, 371);
            this.tbcMain.TabIndex = 0;
            // 
            // tbpRental
            // 
            this.tbpRental.Controls.Add(this.groupBox2);
            this.tbpRental.Controls.Add(this.pnlReaderInfo);
            this.tbpRental.Location = new System.Drawing.Point(4, 22);
            this.tbpRental.Name = "tbpRental";
            this.tbpRental.Padding = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.tbpRental.Size = new System.Drawing.Size(657, 345);
            this.tbpRental.TabIndex = 0;
            this.tbpRental.Text = "借书还书登记";
            this.tbpRental.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlRentalInfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 235);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者借书信息";
            // 
            // pnlRentalInfo
            // 
            this.pnlRentalInfo.Controls.Add(this.dgvReaderBorrow);
            this.pnlRentalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRentalInfo.Location = new System.Drawing.Point(3, 17);
            this.pnlRentalInfo.Name = "pnlRentalInfo";
            this.pnlRentalInfo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 6);
            this.pnlRentalInfo.Size = new System.Drawing.Size(643, 215);
            this.pnlRentalInfo.TabIndex = 0;
            // 
            // dgvReaderBorrow
            // 
            this.dgvReaderBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaderBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentId,
            this.RentTime,
            this.DueTime,
            this.ReturnTime,
            this.BookId,
            this.ReadId});
            this.dgvReaderBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReaderBorrow.Location = new System.Drawing.Point(5, 0);
            this.dgvReaderBorrow.Name = "dgvReaderBorrow";
            this.dgvReaderBorrow.RowTemplate.Height = 23;
            this.dgvReaderBorrow.Size = new System.Drawing.Size(633, 209);
            this.dgvReaderBorrow.TabIndex = 1;
            this.dgvReaderBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReaderBorrow_CellContentClick);
            // 
            // RentId
            // 
            this.RentId.HeaderText = "借阅编号";
            this.RentId.Name = "RentId";
            // 
            // RentTime
            // 
            this.RentTime.HeaderText = "借阅时间";
            this.RentTime.Name = "RentTime";
            // 
            // DueTime
            // 
            this.DueTime.HeaderText = "应归还时间";
            this.DueTime.Name = "DueTime";
            // 
            // ReturnTime
            // 
            this.ReturnTime.HeaderText = "归还时间";
            this.ReturnTime.Name = "ReturnTime";
            // 
            // BookId
            // 
            this.BookId.HeaderText = "书籍编号";
            this.BookId.Name = "BookId";
            // 
            // ReadId
            // 
            this.ReadId.HeaderText = "读者编号";
            this.ReadId.Name = "ReadId";
            // 
            // pnlReaderInfo
            // 
            this.pnlReaderInfo.Controls.Add(this.groupBox1);
            this.pnlReaderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReaderInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlReaderInfo.Name = "pnlReaderInfo";
            this.pnlReaderInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlReaderInfo.Size = new System.Drawing.Size(649, 104);
            this.pnlReaderInfo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textboxBookId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSearchReader);
            this.groupBox1.Controls.Add(this.txbGender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbReaderId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读者基本信息";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "借书";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "还书";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textboxBookId
            // 
            this.textboxBookId.Location = new System.Drawing.Point(68, 58);
            this.textboxBookId.Name = "textboxBookId";
            this.textboxBookId.Size = new System.Drawing.Size(100, 21);
            this.textboxBookId.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "图书编号";
            // 
            // btnSearchReader
            // 
            this.btnSearchReader.Location = new System.Drawing.Point(225, 58);
            this.btnSearchReader.Name = "btnSearchReader";
            this.btnSearchReader.Size = new System.Drawing.Size(75, 23);
            this.btnSearchReader.TabIndex = 6;
            this.btnSearchReader.Text = "搜索";
            this.btnSearchReader.UseVisualStyleBackColor = true;
            this.btnSearchReader.Click += new System.EventHandler(this.btnSearchReader_Click);
            // 
            // txbGender
            // 
            this.txbGender.Location = new System.Drawing.Point(424, 21);
            this.txbGender.Name = "txbGender";
            this.txbGender.ReadOnly = true;
            this.txbGender.Size = new System.Drawing.Size(100, 21);
            this.txbGender.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "读者性别";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(244, 20);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(100, 21);
            this.txbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "读者姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者编号";
            // 
            // txbReaderId
            // 
            this.txbReaderId.Location = new System.Drawing.Point(65, 20);
            this.txbReaderId.Name = "txbReaderId";
            this.txbReaderId.Size = new System.Drawing.Size(100, 21);
            this.txbReaderId.TabIndex = 1;
            // 
            // tbpReader
            // 
            this.tbpReader.Controls.Add(this.pnlReaderWrapper);
            this.tbpReader.Location = new System.Drawing.Point(4, 22);
            this.tbpReader.Name = "tbpReader";
            this.tbpReader.Padding = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.tbpReader.Size = new System.Drawing.Size(657, 345);
            this.tbpReader.TabIndex = 1;
            this.tbpReader.Text = "读者信息管理";
            this.tbpReader.UseVisualStyleBackColor = true;
            // 
            // pnlReaderWrapper
            // 
            this.pnlReaderWrapper.Controls.Add(this.groupBox4);
            this.pnlReaderWrapper.Controls.Add(this.pnlReaderCond);
            this.pnlReaderWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReaderWrapper.Location = new System.Drawing.Point(3, 3);
            this.pnlReaderWrapper.Name = "pnlReaderWrapper";
            this.pnlReaderWrapper.Size = new System.Drawing.Size(649, 339);
            this.pnlReaderWrapper.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnlReaderResult);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(649, 294);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "读者搜索结果";
            // 
            // pnlReaderResult
            // 
            this.pnlReaderResult.Controls.Add(this.dbgReaderinfo);
            this.pnlReaderResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReaderResult.Location = new System.Drawing.Point(3, 17);
            this.pnlReaderResult.Name = "pnlReaderResult";
            this.pnlReaderResult.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pnlReaderResult.Size = new System.Drawing.Size(643, 274);
            this.pnlReaderResult.TabIndex = 0;
            // 
            // dbgReaderinfo
            // 
            this.dbgReaderinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgReaderinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readId2,
            this.readerName2,
            this.readerGender,
            this.credentialType,
            this.credentialNumber,
            this.telephone,
            this.registerTime,
            this.expireTime,
            this.avaliable,
            this.groupId});
            this.dbgReaderinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgReaderinfo.Location = new System.Drawing.Point(0, 0);
            this.dbgReaderinfo.Name = "dbgReaderinfo";
            this.dbgReaderinfo.RowTemplate.Height = 23;
            this.dbgReaderinfo.Size = new System.Drawing.Size(641, 274);
            this.dbgReaderinfo.TabIndex = 0;
            // 
            // readId2
            // 
            this.readId2.HeaderText = "读者编号";
            this.readId2.Name = "readId2";
            // 
            // readerName2
            // 
            this.readerName2.HeaderText = "读者姓名";
            this.readerName2.Name = "readerName2";
            // 
            // readerGender
            // 
            this.readerGender.HeaderText = "读者性别";
            this.readerGender.Name = "readerGender";
            // 
            // credentialType
            // 
            this.credentialType.HeaderText = "证件类型";
            this.credentialType.Name = "credentialType";
            // 
            // credentialNumber
            // 
            this.credentialNumber.HeaderText = "证件号码";
            this.credentialNumber.Name = "credentialNumber";
            // 
            // telephone
            // 
            this.telephone.HeaderText = "电话号码";
            this.telephone.Name = "telephone";
            // 
            // registerTime
            // 
            this.registerTime.HeaderText = "注册时间";
            this.registerTime.Name = "registerTime";
            // 
            // expireTime
            // 
            this.expireTime.HeaderText = "到期时间";
            this.expireTime.Name = "expireTime";
            // 
            // avaliable
            // 
            this.avaliable.HeaderText = "账户可用否？";
            this.avaliable.Name = "avaliable";
            // 
            // groupId
            // 
            this.groupId.HeaderText = "借书群组";
            this.groupId.Name = "groupId";
            // 
            // pnlReaderCond
            // 
            this.pnlReaderCond.Controls.Add(this.groupBox3);
            this.pnlReaderCond.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReaderCond.Location = new System.Drawing.Point(0, 0);
            this.pnlReaderCond.Name = "pnlReaderCond";
            this.pnlReaderCond.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlReaderCond.Size = new System.Drawing.Size(649, 45);
            this.pnlReaderCond.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cbbReaderGender);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbReadName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(649, 40);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "读者查询条件";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbReaderGender
            // 
            this.cbbReaderGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReaderGender.FormattingEnabled = true;
            this.cbbReaderGender.Items.AddRange(new object[] {
            "不限",
            "男",
            "女"});
            this.cbbReaderGender.Location = new System.Drawing.Point(200, 14);
            this.cbbReaderGender.Name = "cbbReaderGender";
            this.cbbReaderGender.Size = new System.Drawing.Size(121, 20);
            this.cbbReaderGender.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "性别";
            // 
            // txbReadName
            // 
            this.txbReadName.Location = new System.Drawing.Point(59, 14);
            this.txbReadName.Name = "txbReadName";
            this.txbReadName.Size = new System.Drawing.Size(100, 21);
            this.txbReadName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名(&N)";
            // 
            // tbpRude
            // 
            this.tbpRude.Controls.Add(this.dgvOverdue);
            this.tbpRude.Location = new System.Drawing.Point(4, 22);
            this.tbpRude.Name = "tbpRude";
            this.tbpRude.Size = new System.Drawing.Size(657, 345);
            this.tbpRude.TabIndex = 2;
            this.tbpRude.Text = "超期读者管理";
            this.tbpRude.UseVisualStyleBackColor = true;
            // 
            // dgvOverdue
            // 
            this.dgvOverdue.AutoGenerateColumns = false;
            this.dgvOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverdue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.duetimeDataGridViewTextBoxColumn,
            this.particularidDataGridViewTextBoxColumn});
            this.dgvOverdue.DataSource = this.overduereaderBindingSource;
            this.dgvOverdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOverdue.Location = new System.Drawing.Point(0, 0);
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.RowTemplate.Height = 23;
            this.dgvOverdue.Size = new System.Drawing.Size(657, 345);
            this.dgvOverdue.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "读者编号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "读者名字";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "电话号码";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // duetimeDataGridViewTextBoxColumn
            // 
            this.duetimeDataGridViewTextBoxColumn.DataPropertyName = "due_time";
            this.duetimeDataGridViewTextBoxColumn.HeaderText = "到期时间";
            this.duetimeDataGridViewTextBoxColumn.Name = "duetimeDataGridViewTextBoxColumn";
            // 
            // particularidDataGridViewTextBoxColumn
            // 
            this.particularidDataGridViewTextBoxColumn.DataPropertyName = "particular_id";
            this.particularidDataGridViewTextBoxColumn.HeaderText = "书本编号";
            this.particularidDataGridViewTextBoxColumn.Name = "particularidDataGridViewTextBoxColumn";
            // 
            // overduereaderBindingSource
            // 
            this.overduereaderBindingSource.DataMember = "overdue_reader";
            this.overduereaderBindingSource.DataSource = this.frDataSet;
            // 
            // frDataSet
            // 
            this.frDataSet.DataSetName = "FrDataSet";
            this.frDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbpLost
            // 
            this.tbpLost.Controls.Add(this.toolStrip1);
            this.tbpLost.Controls.Add(this.dataGridView4);
            this.tbpLost.Location = new System.Drawing.Point(4, 22);
            this.tbpLost.Name = "tbpLost";
            this.tbpLost.Size = new System.Drawing.Size(657, 345);
            this.tbpLost.TabIndex = 3;
            this.tbpLost.Text = "书籍遗失登记";
            this.tbpLost.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(657, 345);
            this.dataGridView4.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.终端TToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 25);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 终端TToolStripMenuItem
            // 
            this.终端TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出XToolStripMenuItem});
            this.终端TToolStripMenuItem.Name = "终端TToolStripMenuItem";
            this.终端TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.终端TToolStripMenuItem.Text = "终端(&T)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // frontDataSet
            // 
            this.frontDataSet.DataSetName = "FrontDataSet";
            this.frontDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frontDataSetBindingSource
            // 
            this.frontDataSetBindingSource.DataSource = this.frontDataSet;
            this.frontDataSetBindingSource.Position = 0;
            // 
            // frontDataSetBindingSource1
            // 
            this.frontDataSetBindingSource1.DataSource = this.frontDataSet;
            this.frontDataSetBindingSource1.Position = 0;
            // 
            // overdue_readerTableAdapter
            // 
            this.overdue_readerTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "登记遗失";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 403);
            this.Controls.Add(this.pnlWrapper);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "图书馆前台服务终端";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlWrapper.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tbpRental.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnlRentalInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaderBorrow)).EndInit();
            this.pnlReaderInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpReader.ResumeLayout(false);
            this.pnlReaderWrapper.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.pnlReaderResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgReaderinfo)).EndInit();
            this.pnlReaderCond.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tbpRude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overduereaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frDataSet)).EndInit();
            this.tbpLost.ResumeLayout(false);
            this.tbpLost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frontDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontDataSetBindingSource1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWrapper;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpRental;
        private System.Windows.Forms.TabPage tbpReader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 终端TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.TabPage tbpLost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbReaderId;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlRentalInfo;
        private System.Windows.Forms.DataGridView dgvReaderBorrow;
        private System.Windows.Forms.Panel pnlReaderInfo;
        private System.Windows.Forms.Panel pnlReaderWrapper;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pnlReaderCond;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbReadName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbReaderGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlReaderResult;
        private System.Windows.Forms.DataGridView dbgReaderinfo;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tbpRude;
        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.Button btnSearchReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn readId2;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn readerGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn credentialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn credentialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn avaliable;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadId;
        private FrontDataSet frontDataSet;
        private System.Windows.Forms.BindingSource frontDataSetBindingSource;
        private System.Windows.Forms.BindingSource frontDataSetBindingSource1;
        private FrDataSet frDataSet;
        private System.Windows.Forms.BindingSource overduereaderBindingSource;
        private FrDataSetTableAdapters.overdue_readerTableAdapter overdue_readerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn particularidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textboxBookId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}

