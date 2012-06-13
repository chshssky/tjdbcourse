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
            this.mstMain = new System.Windows.Forms.MenuStrip();
            this.mnuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBoss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBossChangeName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBossChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMangers = new System.Windows.Forms.DataGridView();
            this.libraryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpgLibrary = new System.Windows.Forms.TabPage();
            this.dgvLibrary = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new BossTerminal.DataSet();
            this.tpgManager = new System.Windows.Forms.TabPage();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbvMain = new System.Windows.Forms.TabControl();
            this.managerTableAdapter = new BossTerminal.DataSetTableAdapters.managerTableAdapter();
            this.libraryTableAdapter = new BossTerminal.DataSetTableAdapters.libraryTableAdapter();
            this.mstMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangers)).BeginInit();
            this.tpgLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.tpgManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            this.tbvMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMain
            // 
            this.mstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTool,
            this.mnuBoss,
            this.mnuHelp});
            this.mstMain.Location = new System.Drawing.Point(0, 0);
            this.mstMain.Name = "mstMain";
            this.mstMain.Size = new System.Drawing.Size(680, 25);
            this.mstMain.TabIndex = 1;
            this.mstMain.Text = "menuStrip1";
            // 
            // mnuTool
            // 
            this.mnuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolSave,
            this.mnuToolRefresh,
            this.toolStripMenuItem1,
            this.mnuToolExit});
            this.mnuTool.Name = "mnuTool";
            this.mnuTool.Size = new System.Drawing.Size(59, 21);
            this.mnuTool.Text = "工具(&T)";
            // 
            // mnuToolSave
            // 
            this.mnuToolSave.Name = "mnuToolSave";
            this.mnuToolSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuToolSave.Size = new System.Drawing.Size(163, 22);
            this.mnuToolSave.Text = "保存(&S)";
            this.mnuToolSave.Click += new System.EventHandler(this.mnuToolSave_Click);
            // 
            // mnuToolRefresh
            // 
            this.mnuToolRefresh.Name = "mnuToolRefresh";
            this.mnuToolRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuToolRefresh.Size = new System.Drawing.Size(163, 22);
            this.mnuToolRefresh.Text = "刷新(&R)";
            this.mnuToolRefresh.Click += new System.EventHandler(this.mnuToolRefresh_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // mnuToolExit
            // 
            this.mnuToolExit.Name = "mnuToolExit";
            this.mnuToolExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuToolExit.Size = new System.Drawing.Size(163, 22);
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
            // dgvMangers
            // 
            this.dgvMangers.AutoGenerateColumns = false;
            this.dgvMangers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMangers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMangers.Location = new System.Drawing.Point(0, 0);
            this.dgvMangers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMangers.Name = "dgvMangers";
            this.dgvMangers.RowTemplate.Height = 23;
            this.dgvMangers.Size = new System.Drawing.Size(584, 469);
            this.dgvMangers.TabIndex = 1;
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
            // tpgLibrary
            // 
            this.tpgLibrary.Controls.Add(this.dgvLibrary);
            this.tpgLibrary.Location = new System.Drawing.Point(4, 22);
            this.tpgLibrary.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tpgLibrary.Name = "tpgLibrary";
            this.tpgLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLibrary.Size = new System.Drawing.Size(672, 381);
            this.tpgLibrary.TabIndex = 7;
            this.tpgLibrary.Text = "图书馆管理";
            this.tpgLibrary.UseVisualStyleBackColor = true;
            // 
            // dgvLibrary
            // 
            this.dgvLibrary.AllowUserToResizeRows = false;
            this.dgvLibrary.AutoGenerateColumns = false;
            this.dgvLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.addressDataGridViewTextBoxColumn});
            this.dgvLibrary.DataSource = this.libraryBindingSource;
            this.dgvLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibrary.Location = new System.Drawing.Point(3, 3);
            this.dgvLibrary.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLibrary.Name = "dgvLibrary";
            this.dgvLibrary.RowTemplate.Height = 30;
            this.dgvLibrary.Size = new System.Drawing.Size(666, 375);
            this.dgvLibrary.TabIndex = 3;
            this.dgvLibrary.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_CellBeginEdit);
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
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "library";
            this.libraryBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dgvManager.AllowUserToResizeRows = false;
            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.permissionDataGridViewTextBoxColumn1,
            this.libraryidDataGridViewTextBoxColumn1});
            this.dgvManager.DataSource = this.managerBindingSource;
            this.dgvManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManager.Location = new System.Drawing.Point(3, 3);
            this.dgvManager.Margin = new System.Windows.Forms.Padding(2);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.RowTemplate.Height = 30;
            this.dgvManager.Size = new System.Drawing.Size(666, 375);
            this.dgvManager.TabIndex = 2;
            this.dgvManager.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_CellBeginEdit);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "编号";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "名称";
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
            this.libraryidDataGridViewTextBoxColumn1.HeaderText = "图书馆编号";
            this.libraryidDataGridViewTextBoxColumn1.Name = "libraryidDataGridViewTextBoxColumn1";
            this.libraryidDataGridViewTextBoxColumn1.Width = 200;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "manager";
            this.managerBindingSource.DataSource = this.dataSet;
            // 
            // tbvMain
            // 
            this.tbvMain.Controls.Add(this.tpgManager);
            this.tbvMain.Controls.Add(this.tpgLibrary);
            this.tbvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbvMain.Location = new System.Drawing.Point(0, 25);
            this.tbvMain.Name = "tbvMain";
            this.tbvMain.SelectedIndex = 0;
            this.tbvMain.Size = new System.Drawing.Size(680, 407);
            this.tbvMain.TabIndex = 0;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 432);
            this.Controls.Add(this.tbvMain);
            this.Controls.Add(this.mstMain);
            this.MainMenuStrip = this.mstMain;
            this.Name = "frmMain";
            this.Text = "人事管理工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mstMain.ResumeLayout(false);
            this.mstMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangers)).EndInit();
            this.tpgLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.tpgManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            this.tbvMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMain;
        private System.Windows.Forms.ToolStripMenuItem mnuTool;
        private System.Windows.Forms.ToolStripMenuItem mnuToolExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuBoss;
        private System.Windows.Forms.ToolStripMenuItem mnuBossChangeName;
        private System.Windows.Forms.ToolStripMenuItem mnuBossChangePassword;
        private System.Windows.Forms.DataGridView dgvMangers;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tpgLibrary;
        private System.Windows.Forms.DataGridView dgvLibrary;
        private System.Windows.Forms.TabPage tpgManager;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.TabControl tbvMain;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuToolRefresh;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private DataSetTableAdapters.managerTableAdapter managerTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem mnuToolSave;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private DataSetTableAdapters.libraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}