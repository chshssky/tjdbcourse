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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.credentialtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credentialnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registertimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiretimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new FrontTerminal.DataSet();
            this.tbpRude = new System.Windows.Forms.TabPage();
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particularidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overduereaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpLost = new System.Windows.Forms.TabPage();
            this.btnRecord = new System.Windows.Forms.Button();
            this.dgvDamaged = new System.Windows.Forms.DataGridView();
            this.particularidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRental = new System.Windows.Forms.DataGridView();
            this.readernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duetimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particularidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookisbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.终端TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readerTableAdapter = new FrontTerminal.DataSetTableAdapters.readerTableAdapter();
            this.overdue_readerTableAdapter = new FrontTerminal.DataSetTableAdapters.overdue_readerTableAdapter();
            this.damaged_bookTableAdapter = new FrontTerminal.DataSetTableAdapters.damaged_bookTableAdapter();
            this.borrowingTableAdapter = new FrontTerminal.DataSetTableAdapters.borrowingTableAdapter();
            this.tolMain = new System.Windows.Forms.ToolStrip();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.tbpRude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overduereaderBindingSource)).BeginInit();
            this.tbpLost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamaged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damagedbookBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tolMain.SuspendLayout();
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
            this.tbcMain.Controls.Add(this.tbpReader);
            this.tbcMain.Controls.Add(this.tbpRental);
            this.tbcMain.Controls.Add(this.tbpRude);
            this.tbcMain.Controls.Add(this.tbpLost);
            this.tbcMain.Controls.Add(this.tabPage1);
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
            this.tbpRental.Size = new System.Drawing.Size(657, 320);
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
            this.groupBox2.Size = new System.Drawing.Size(649, 210);
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
            this.pnlRentalInfo.Size = new System.Drawing.Size(643, 190);
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
            this.dgvReaderBorrow.Size = new System.Drawing.Size(633, 184);
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
            this.pnlReaderWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReaderWrapper.Location = new System.Drawing.Point(3, 3);
            this.pnlReaderWrapper.Name = "pnlReaderWrapper";
            this.pnlReaderWrapper.Size = new System.Drawing.Size(649, 339);
            this.pnlReaderWrapper.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnlReaderResult);
            this.groupBox4.Controls.Add(this.tolMain);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(649, 339);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "读者搜索结果";
            // 
            // pnlReaderResult
            // 
            this.pnlReaderResult.Controls.Add(this.dbgReaderinfo);
            this.pnlReaderResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReaderResult.Location = new System.Drawing.Point(3, 42);
            this.pnlReaderResult.Name = "pnlReaderResult";
            this.pnlReaderResult.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pnlReaderResult.Size = new System.Drawing.Size(643, 294);
            this.pnlReaderResult.TabIndex = 0;
            // 
            // dbgReaderinfo
            // 
            this.dbgReaderinfo.AutoGenerateColumns = false;
            this.dbgReaderinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgReaderinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.realnameDataGridViewTextBoxColumn,
            this.genderDataGridViewCheckBoxColumn,
            this.credentialtypeDataGridViewTextBoxColumn,
            this.credentialnumberDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.registertimeDataGridViewTextBoxColumn,
            this.expiretimeDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn,
            this.groupidDataGridViewTextBoxColumn});
            this.dbgReaderinfo.DataSource = this.readerBindingSource;
            this.dbgReaderinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgReaderinfo.Location = new System.Drawing.Point(0, 0);
            this.dbgReaderinfo.Name = "dbgReaderinfo";
            this.dbgReaderinfo.RowTemplate.Height = 23;
            this.dbgReaderinfo.Size = new System.Drawing.Size(641, 294);
            this.dbgReaderinfo.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "读者编号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "登录名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "密码";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // realnameDataGridViewTextBoxColumn
            // 
            this.realnameDataGridViewTextBoxColumn.DataPropertyName = "real_name";
            this.realnameDataGridViewTextBoxColumn.HeaderText = "真实姓名";
            this.realnameDataGridViewTextBoxColumn.Name = "realnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewCheckBoxColumn
            // 
            this.genderDataGridViewCheckBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewCheckBoxColumn.HeaderText = "性别";
            this.genderDataGridViewCheckBoxColumn.Name = "genderDataGridViewCheckBoxColumn";
            // 
            // credentialtypeDataGridViewTextBoxColumn
            // 
            this.credentialtypeDataGridViewTextBoxColumn.DataPropertyName = "credential_type";
            this.credentialtypeDataGridViewTextBoxColumn.HeaderText = "证件类型";
            this.credentialtypeDataGridViewTextBoxColumn.Name = "credentialtypeDataGridViewTextBoxColumn";
            // 
            // credentialnumberDataGridViewTextBoxColumn
            // 
            this.credentialnumberDataGridViewTextBoxColumn.DataPropertyName = "credential_number";
            this.credentialnumberDataGridViewTextBoxColumn.HeaderText = "证件号码";
            this.credentialnumberDataGridViewTextBoxColumn.Name = "credentialnumberDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "电话号码";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // registertimeDataGridViewTextBoxColumn
            // 
            this.registertimeDataGridViewTextBoxColumn.DataPropertyName = "register_time";
            this.registertimeDataGridViewTextBoxColumn.HeaderText = "注册时间";
            this.registertimeDataGridViewTextBoxColumn.Name = "registertimeDataGridViewTextBoxColumn";
            // 
            // expiretimeDataGridViewTextBoxColumn
            // 
            this.expiretimeDataGridViewTextBoxColumn.DataPropertyName = "expire_time";
            this.expiretimeDataGridViewTextBoxColumn.HeaderText = "到期时间";
            this.expiretimeDataGridViewTextBoxColumn.Name = "expiretimeDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "是否有效";
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "所属群组";
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "reader";
            this.readerBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dgvOverdue.AllowUserToAddRows = false;
            this.dgvOverdue.AllowUserToDeleteRows = false;
            this.dgvOverdue.AutoGenerateColumns = false;
            this.dgvOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverdue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.telephoneDataGridViewTextBoxColumn1,
            this.duetimeDataGridViewTextBoxColumn,
            this.particularidDataGridViewTextBoxColumn});
            this.dgvOverdue.DataSource = this.overduereaderBindingSource;
            this.dgvOverdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOverdue.Location = new System.Drawing.Point(0, 0);
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.ReadOnly = true;
            this.dgvOverdue.RowTemplate.Height = 23;
            this.dgvOverdue.Size = new System.Drawing.Size(657, 345);
            this.dgvOverdue.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "读者编号";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "登录名";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn1
            // 
            this.telephoneDataGridViewTextBoxColumn1.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn1.HeaderText = "电话号码";
            this.telephoneDataGridViewTextBoxColumn1.Name = "telephoneDataGridViewTextBoxColumn1";
            this.telephoneDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // duetimeDataGridViewTextBoxColumn
            // 
            this.duetimeDataGridViewTextBoxColumn.DataPropertyName = "due_time";
            this.duetimeDataGridViewTextBoxColumn.HeaderText = "到期时间";
            this.duetimeDataGridViewTextBoxColumn.Name = "duetimeDataGridViewTextBoxColumn";
            this.duetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // particularidDataGridViewTextBoxColumn
            // 
            this.particularidDataGridViewTextBoxColumn.DataPropertyName = "particular_id";
            this.particularidDataGridViewTextBoxColumn.HeaderText = "图书编号";
            this.particularidDataGridViewTextBoxColumn.Name = "particularidDataGridViewTextBoxColumn";
            this.particularidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overduereaderBindingSource
            // 
            this.overduereaderBindingSource.DataMember = "overdue_reader";
            this.overduereaderBindingSource.DataSource = this.dataSet;
            // 
            // tbpLost
            // 
            this.tbpLost.Controls.Add(this.btnRecord);
            this.tbpLost.Controls.Add(this.dgvDamaged);
            this.tbpLost.Controls.Add(this.toolStrip1);
            this.tbpLost.Location = new System.Drawing.Point(4, 22);
            this.tbpLost.Name = "tbpLost";
            this.tbpLost.Size = new System.Drawing.Size(657, 345);
            this.tbpLost.TabIndex = 3;
            this.tbpLost.Text = "书籍遗失登记";
            this.tbpLost.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(3, 0);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 4;
            this.btnRecord.Text = "登记";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // dgvDamaged
            // 
            this.dgvDamaged.AllowUserToAddRows = false;
            this.dgvDamaged.AllowUserToDeleteRows = false;
            this.dgvDamaged.AutoGenerateColumns = false;
            this.dgvDamaged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamaged.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.particularidDataGridViewTextBoxColumn1,
            this.isbnDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn});
            this.dgvDamaged.DataSource = this.damagedbookBindingSource;
            this.dgvDamaged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDamaged.Location = new System.Drawing.Point(0, 25);
            this.dgvDamaged.Name = "dgvDamaged";
            this.dgvDamaged.ReadOnly = true;
            this.dgvDamaged.RowTemplate.Height = 23;
            this.dgvDamaged.Size = new System.Drawing.Size(657, 320);
            this.dgvDamaged.TabIndex = 2;
            // 
            // particularidDataGridViewTextBoxColumn1
            // 
            this.particularidDataGridViewTextBoxColumn1.DataPropertyName = "particular_id";
            this.particularidDataGridViewTextBoxColumn1.HeaderText = "图书编号";
            this.particularidDataGridViewTextBoxColumn1.Name = "particularidDataGridViewTextBoxColumn1";
            this.particularidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN号";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "标题";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "出版商";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // damagedbookBindingSource
            // 
            this.damagedbookBindingSource.DataMember = "damaged_book";
            this.damagedbookBindingSource.DataSource = this.dataSet;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRental);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 320);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "借书信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRental
            // 
            this.dgvRental.AllowUserToAddRows = false;
            this.dgvRental.AllowUserToDeleteRows = false;
            this.dgvRental.AutoGenerateColumns = false;
            this.dgvRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readernameDataGridViewTextBoxColumn,
            this.booktitleDataGridViewTextBoxColumn,
            this.bookauthorDataGridViewTextBoxColumn,
            this.bookpublisherDataGridViewTextBoxColumn,
            this.renttimeDataGridViewTextBoxColumn,
            this.duetimeDataGridViewTextBoxColumn1,
            this.readeridDataGridViewTextBoxColumn,
            this.rentalidDataGridViewTextBoxColumn,
            this.particularidDataGridViewTextBoxColumn2,
            this.bookisbnDataGridViewTextBoxColumn});
            this.dgvRental.DataSource = this.borrowingBindingSource;
            this.dgvRental.Location = new System.Drawing.Point(-1, 0);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.ReadOnly = true;
            this.dgvRental.RowTemplate.Height = 23;
            this.dgvRental.Size = new System.Drawing.Size(658, 349);
            this.dgvRental.TabIndex = 0;
            // 
            // readernameDataGridViewTextBoxColumn
            // 
            this.readernameDataGridViewTextBoxColumn.DataPropertyName = "reader_name";
            this.readernameDataGridViewTextBoxColumn.HeaderText = "读者姓名";
            this.readernameDataGridViewTextBoxColumn.Name = "readernameDataGridViewTextBoxColumn";
            this.readernameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // bookpublisherDataGridViewTextBoxColumn
            // 
            this.bookpublisherDataGridViewTextBoxColumn.DataPropertyName = "book_publisher";
            this.bookpublisherDataGridViewTextBoxColumn.HeaderText = "出版商";
            this.bookpublisherDataGridViewTextBoxColumn.Name = "bookpublisherDataGridViewTextBoxColumn";
            this.bookpublisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renttimeDataGridViewTextBoxColumn
            // 
            this.renttimeDataGridViewTextBoxColumn.DataPropertyName = "rent_time";
            this.renttimeDataGridViewTextBoxColumn.HeaderText = "借书时间";
            this.renttimeDataGridViewTextBoxColumn.Name = "renttimeDataGridViewTextBoxColumn";
            this.renttimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duetimeDataGridViewTextBoxColumn1
            // 
            this.duetimeDataGridViewTextBoxColumn1.DataPropertyName = "due_time";
            this.duetimeDataGridViewTextBoxColumn1.HeaderText = "到期时间";
            this.duetimeDataGridViewTextBoxColumn1.Name = "duetimeDataGridViewTextBoxColumn1";
            this.duetimeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // readeridDataGridViewTextBoxColumn
            // 
            this.readeridDataGridViewTextBoxColumn.DataPropertyName = "reader_id";
            this.readeridDataGridViewTextBoxColumn.HeaderText = "读者编号";
            this.readeridDataGridViewTextBoxColumn.Name = "readeridDataGridViewTextBoxColumn";
            this.readeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentalidDataGridViewTextBoxColumn
            // 
            this.rentalidDataGridViewTextBoxColumn.DataPropertyName = "rental_id";
            this.rentalidDataGridViewTextBoxColumn.HeaderText = "借阅记录号";
            this.rentalidDataGridViewTextBoxColumn.Name = "rentalidDataGridViewTextBoxColumn";
            this.rentalidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // particularidDataGridViewTextBoxColumn2
            // 
            this.particularidDataGridViewTextBoxColumn2.DataPropertyName = "particular_id";
            this.particularidDataGridViewTextBoxColumn2.HeaderText = "图书编号";
            this.particularidDataGridViewTextBoxColumn2.Name = "particularidDataGridViewTextBoxColumn2";
            this.particularidDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bookisbnDataGridViewTextBoxColumn
            // 
            this.bookisbnDataGridViewTextBoxColumn.DataPropertyName = "book_isbn";
            this.bookisbnDataGridViewTextBoxColumn.HeaderText = "ISBN号";
            this.bookisbnDataGridViewTextBoxColumn.Name = "bookisbnDataGridViewTextBoxColumn";
            this.bookisbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowingBindingSource
            // 
            this.borrowingBindingSource.DataMember = "borrowing";
            this.borrowingBindingSource.DataSource = this.dataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.终端TToolStripMenuItem,
            this.管理员ToolStripMenuItem});
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
            // 管理员ToolStripMenuItem
            // 
            this.管理员ToolStripMenuItem.Name = "管理员ToolStripMenuItem";
            this.管理员ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.管理员ToolStripMenuItem.Text = "关于(&A)";
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // overdue_readerTableAdapter
            // 
            this.overdue_readerTableAdapter.ClearBeforeFill = true;
            // 
            // damaged_bookTableAdapter
            // 
            this.damaged_bookTableAdapter.ClearBeforeFill = true;
            // 
            // borrowingTableAdapter
            // 
            this.borrowingTableAdapter.ClearBeforeFill = true;
            // 
            // tolMain
            // 
            this.tolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefresh,
            this.tsbSave});
            this.tolMain.Location = new System.Drawing.Point(3, 17);
            this.tolMain.Name = "tolMain";
            this.tolMain.Size = new System.Drawing.Size(643, 25);
            this.tolMain.TabIndex = 19;
            this.tolMain.Text = "toolStrip1";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(52, 22);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
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
            this.groupBox4.PerformLayout();
            this.pnlReaderResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgReaderinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.tbpRude.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overduereaderBindingSource)).EndInit();
            this.tbpLost.ResumeLayout(false);
            this.tbpLost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamaged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damagedbookBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tolMain.ResumeLayout(false);
            this.tolMain.PerformLayout();
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
        private System.Windows.Forms.Panel pnlReaderResult;
        private System.Windows.Forms.DataGridView dbgReaderinfo;
        private System.Windows.Forms.DataGridView dgvDamaged;
        private System.Windows.Forms.TabPage tbpRude;
        private System.Windows.Forms.DataGridView dgvOverdue;
        private System.Windows.Forms.Button btnSearchReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textboxBookId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnRecord;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private DataSetTableAdapters.readerTableAdapter readerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn credentialtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn credentialnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registertimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiretimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource overduereaderBindingSource;
        private DataSetTableAdapters.overdue_readerTableAdapter overdue_readerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn particularidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource damagedbookBindingSource;
        private DataSetTableAdapters.damaged_bookTableAdapter damaged_bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn particularidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvRental;
        private System.Windows.Forms.BindingSource borrowingBindingSource;
        private DataSetTableAdapters.borrowingTableAdapter borrowingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn readernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duetimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn readeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn particularidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookisbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tolMain;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbSave;

    }
}

