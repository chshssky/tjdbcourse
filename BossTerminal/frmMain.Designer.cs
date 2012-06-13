namespace BossTerminal
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
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDSlibrary = new BossTerminal.libDSlibrary();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSet = new BossTerminal.libDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolAddLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolAddManager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBoss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBossChangeName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBossChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.managerTableAdapter = new BossTerminal.libDataSetTableAdapters.managerTableAdapter();
            this.libraryTableAdapter = new BossTerminal.libDSlibraryTableAdapters.libraryTableAdapter();
            this.dgvMangers = new System.Windows.Forms.DataGridView();
            this.libraryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new BossTerminal.libDataSetTableAdapters.bookTableAdapter();
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tpgLibrary = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tpgManager = new System.Windows.Forms.TabPage();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.前台服务人员 = new System.Windows.Forms.TabControl();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDSlibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            this.tpgLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tpgManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            this.前台服务人员.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "library";
            this.libraryBindingSource.DataSource = this.libDSlibrary;
            // 
            // libDSlibrary
            // 
            this.libDSlibrary.DataSetName = "libDSlibrary";
            this.libDSlibrary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "manager";
            this.managerBindingSource.DataSource = this.libDataSet;
            // 
            // libDataSet
            // 
            this.libDataSet.DataSetName = "libDataSet";
            this.libDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTool,
            this.mnuBoss,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuTool
            // 
            this.mnuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolAddLibrary,
            this.mnuToolAddManager,
            this.toolStripMenuItem1,
            this.mnuToolExit});
            this.mnuTool.Name = "mnuTool";
            this.mnuTool.Size = new System.Drawing.Size(59, 21);
            this.mnuTool.Text = "工具(&T)";
            // 
            // mnuToolAddLibrary
            // 
            this.mnuToolAddLibrary.Name = "mnuToolAddLibrary";
            this.mnuToolAddLibrary.Size = new System.Drawing.Size(152, 22);
            this.mnuToolAddLibrary.Text = "添加图书馆";
            this.mnuToolAddLibrary.Click += new System.EventHandler(this.mnuToolAddLibrary_Click);
            // 
            // mnuToolAddManager
            // 
            this.mnuToolAddManager.Name = "mnuToolAddManager";
            this.mnuToolAddManager.Size = new System.Drawing.Size(152, 22);
            this.mnuToolAddManager.Text = "添加管理员";
            this.mnuToolAddManager.Click += new System.EventHandler(this.mnuToolAddManager_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuToolExit
            // 
            this.mnuToolExit.Name = "mnuToolExit";
            this.mnuToolExit.Size = new System.Drawing.Size(152, 22);
            this.mnuToolExit.Text = "退出(&X)";
            this.mnuToolExit.Click += new System.EventHandler(this.mnuToolExit_Click);
            // 
            // mnuBoss
            // 
            this.mnuBoss.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBossChangeName,
            this.mnuBossChangePassword});
            this.mnuBoss.Name = "mnuBoss";
            this.mnuBoss.Size = new System.Drawing.Size(60, 21);
            this.mnuBoss.Text = "老板(&B)";
            // 
            // mnuBossChangeName
            // 
            this.mnuBossChangeName.Name = "mnuBossChangeName";
            this.mnuBossChangeName.Size = new System.Drawing.Size(142, 22);
            this.mnuBossChangeName.Text = "修改名称(&N)";
            this.mnuBossChangeName.Click += new System.EventHandler(this.修改账号AToolStripMenuItem_Click);
            // 
            // mnuBossChangePassword
            // 
            this.mnuBossChangePassword.Name = "mnuBossChangePassword";
            this.mnuBossChangePassword.Size = new System.Drawing.Size(142, 22);
            this.mnuBossChangePassword.Text = "修改密码(&P)";
            this.mnuBossChangePassword.Click += new System.EventHandler(this.修改密码PToolStripMenuItem_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(61, 21);
            this.mnuHelp.Text = "帮助(&H)";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuHelpAbout.Text = "关于(&A)";
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMangers
            // 
            this.dgvMangers.AutoGenerateColumns = false;
            this.dgvMangers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMangers.DataSource = this.managerBindingSource;
            this.dgvMangers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMangers.Location = new System.Drawing.Point(0, 0);
            this.dgvMangers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMangers.Name = "dgvMangers";
            this.dgvMangers.RowTemplate.Height = 23;
            this.dgvMangers.Size = new System.Drawing.Size(584, 469);
            this.dgvMangers.TabIndex = 1;
            this.dgvMangers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMangers_CellContentClick);
            // 
            // libraryidDataGridViewTextBoxColumn
            // 
            this.libraryidDataGridViewTextBoxColumn.DataPropertyName = "library_id";
            this.libraryidDataGridViewTextBoxColumn.HeaderText = "library_id";
            this.libraryidDataGridViewTextBoxColumn.Name = "libraryidDataGridViewTextBoxColumn";
            // 
            // permissionDataGridViewTextBoxColumn
            // 
            this.permissionDataGridViewTextBoxColumn.DataPropertyName = "permission";
            this.permissionDataGridViewTextBoxColumn.HeaderText = "permission";
            this.permissionDataGridViewTextBoxColumn.Name = "permissionDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "book";
            this.bindingSource1.DataSource = this.libDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "manager";
            this.managerBindingSource1.DataSource = this.libDataSet;
            // 
            // tpgLibrary
            // 
            this.tpgLibrary.Controls.Add(this.dataGridView4);
            this.tpgLibrary.Location = new System.Drawing.Point(4, 22);
            this.tpgLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.tpgLibrary.Name = "tpgLibrary";
            this.tpgLibrary.Padding = new System.Windows.Forms.Padding(2);
            this.tpgLibrary.Size = new System.Drawing.Size(672, 381);
            this.tpgLibrary.TabIndex = 7;
            this.tpgLibrary.Text = "图书馆管理";
            this.tpgLibrary.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.libraryBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(2, 2);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 30;
            this.dataGridView4.Size = new System.Drawing.Size(668, 377);
            this.dataGridView4.TabIndex = 3;
            // 
            // tpgManager
            // 
            this.tpgManager.Controls.Add(this.dgvManager);
            this.tpgManager.Location = new System.Drawing.Point(4, 22);
            this.tpgManager.Name = "tpgManager";
            this.tpgManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpgManager.Size = new System.Drawing.Size(672, 381);
            this.tpgManager.TabIndex = 4;
            this.tpgManager.Text = "管理员管理";
            this.tpgManager.UseVisualStyleBackColor = true;
            // 
            // dgvManager
            // 
            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.permissionDataGridViewTextBoxColumn1,
            this.libraryidDataGridViewTextBoxColumn1});
            this.dgvManager.DataSource = this.managerBindingSource1;
            this.dgvManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManager.Location = new System.Drawing.Point(3, 3);
            this.dgvManager.Margin = new System.Windows.Forms.Padding(2);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.RowTemplate.Height = 30;
            this.dgvManager.Size = new System.Drawing.Size(666, 375);
            this.dgvManager.TabIndex = 2;
            this.dgvManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 前台服务人员
            // 
            this.前台服务人员.Controls.Add(this.tpgManager);
            this.前台服务人员.Controls.Add(this.tpgLibrary);
            this.前台服务人员.Dock = System.Windows.Forms.DockStyle.Fill;
            this.前台服务人员.Location = new System.Drawing.Point(0, 25);
            this.前台服务人员.Name = "前台服务人员";
            this.前台服务人员.SelectedIndex = 0;
            this.前台服务人员.Size = new System.Drawing.Size(680, 407);
            this.前台服务人员.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "编号";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 300;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "编号";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "密码";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            // 
            // permissionDataGridViewTextBoxColumn1
            // 
            this.permissionDataGridViewTextBoxColumn1.DataPropertyName = "permission";
            this.permissionDataGridViewTextBoxColumn1.HeaderText = "权限";
            this.permissionDataGridViewTextBoxColumn1.Name = "permissionDataGridViewTextBoxColumn1";
            // 
            // libraryidDataGridViewTextBoxColumn1
            // 
            this.libraryidDataGridViewTextBoxColumn1.DataPropertyName = "library_id";
            this.libraryidDataGridViewTextBoxColumn1.HeaderText = "所在图书馆";
            this.libraryidDataGridViewTextBoxColumn1.Name = "libraryidDataGridViewTextBoxColumn1";
            this.libraryidDataGridViewTextBoxColumn1.Width = 150;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 432);
            this.Controls.Add(this.前台服务人员);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "人事管理工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDSlibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            this.tpgLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tpgManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            this.前台服务人员.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTool;
        private System.Windows.Forms.ToolStripMenuItem mnuToolExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuBoss;
        private System.Windows.Forms.ToolStripMenuItem mnuBossChangeName;
        private System.Windows.Forms.ToolStripMenuItem mnuBossChangePassword;
        private libDataSet libDataSet;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private libDataSetTableAdapters.managerTableAdapter managerTableAdapter;
        private libDSlibrary libDSlibrary;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private libDSlibraryTableAdapters.libraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem mnuToolAddLibrary;
        private System.Windows.Forms.ToolStripMenuItem mnuToolAddManager;
        private System.Windows.Forms.DataGridView dgvMangers;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private libDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource managerBindingSource1;
        private System.Windows.Forms.TabPage tpgLibrary;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tpgManager;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.TabControl 前台服务人员;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryidDataGridViewTextBoxColumn1;
    }
}