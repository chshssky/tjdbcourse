﻿namespace BackTerminal
{
    partial class frmBookMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookMan));
            this.readablebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new BackTerminal.DataSet();
            this.readablebookTableAdapter = new BackTerminal.DataSetTableAdapters.readable_bookTableAdapter();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.图书BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBookAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBookBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.分类CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategoryManage = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemNewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.sstMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspMain = new System.Windows.Forms.ToolStrip();
            this.tsbStatus = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBuy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.readablebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.mnsMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.sstMain.SuspendLayout();
            this.tspMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // readablebookBindingSource
            // 
            this.readablebookBindingSource.DataMember = "readable_book";
            this.readablebookBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readablebookTableAdapter
            // 
            this.readablebookTableAdapter.ClearBeforeFill = true;
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具TToolStripMenuItem,
            this.图书BToolStripMenuItem,
            this.分类CToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(617, 25);
            this.mnsMain.TabIndex = 12;
            this.mnsMain.Text = "menuStrip1";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolRefresh,
            this.toolStripMenuItem2,
            this.mnuToolExit});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // mnuToolRefresh
            // 
            this.mnuToolRefresh.Name = "mnuToolRefresh";
            this.mnuToolRefresh.Size = new System.Drawing.Size(116, 22);
            this.mnuToolRefresh.Text = "刷新(&R)";
            this.mnuToolRefresh.Click += new System.EventHandler(this.mnuToolRefresh_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 6);
            // 
            // mnuToolExit
            // 
            this.mnuToolExit.Name = "mnuToolExit";
            this.mnuToolExit.Size = new System.Drawing.Size(116, 22);
            this.mnuToolExit.Text = "退出(&X)";
            this.mnuToolExit.Click += new System.EventHandler(this.mnuToolExit_Click);
            // 
            // 图书BToolStripMenuItem
            // 
            this.图书BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookStatus,
            this.toolStripMenuItem3,
            this.mnuBookAdd,
            this.mnuBookDelete,
            this.toolStripMenuItem1,
            this.mnuBookBuy});
            this.图书BToolStripMenuItem.Name = "图书BToolStripMenuItem";
            this.图书BToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.图书BToolStripMenuItem.Text = "图书(&B)";
            // 
            // mnuBookStatus
            // 
            this.mnuBookStatus.Name = "mnuBookStatus";
            this.mnuBookStatus.Size = new System.Drawing.Size(151, 22);
            this.mnuBookStatus.Text = "状态(&S)...";
            this.mnuBookStatus.Click += new System.EventHandler(this.mnuBookStatus_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 6);
            // 
            // mnuBookAdd
            // 
            this.mnuBookAdd.Name = "mnuBookAdd";
            this.mnuBookAdd.Size = new System.Drawing.Size(151, 22);
            this.mnuBookAdd.Text = "增购(&A)...";
            this.mnuBookAdd.Click += new System.EventHandler(this.mnuBookAdd_Click);
            // 
            // mnuBookDelete
            // 
            this.mnuBookDelete.Name = "mnuBookDelete";
            this.mnuBookDelete.Size = new System.Drawing.Size(151, 22);
            this.mnuBookDelete.Text = "删除(&D)";
            this.mnuBookDelete.Click += new System.EventHandler(this.mnuBookDelete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // mnuBookBuy
            // 
            this.mnuBookBuy.Name = "mnuBookBuy";
            this.mnuBookBuy.Size = new System.Drawing.Size(151, 22);
            this.mnuBookBuy.Text = "购买新书(&N)...";
            this.mnuBookBuy.Click += new System.EventHandler(this.mnuBookBuy_Click);
            // 
            // 分类CToolStripMenuItem
            // 
            this.分类CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCategoryManage});
            this.分类CToolStripMenuItem.Name = "分类CToolStripMenuItem";
            this.分类CToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.分类CToolStripMenuItem.Text = "分类(&C)";
            // 
            // mnuCategoryManage
            // 
            this.mnuCategoryManage.Name = "mnuCategoryManage";
            this.mnuCategoryManage.Size = new System.Drawing.Size(129, 22);
            this.mnuCategoryManage.Text = "管理(&M)...";
            this.mnuCategoryManage.Click += new System.EventHandler(this.mnuCategoryManage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 385);
            this.panel2.TabIndex = 13;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dgvBook.ContextMenuStrip = this.contextMenuStrip;
            this.dgvBook.DataSource = this.readablebookBindingSource;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.Location = new System.Drawing.Point(0, 0);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(617, 385);
            this.dgvBook.TabIndex = 6;
            this.dgvBook.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvBook_CellBeginEdit);
            this.dgvBook.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellEndEdit);
            this.dgvBook.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBook_CellMouseUp);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 50;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "书名";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 64;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "出版社";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "描述";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "分类";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 64;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "数量";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 64;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStatus,
            this.toolStripMenuItemDelete,
            this.toolStripMenuItemAddBook,
            this.toolStripSeparator4,
            this.toolStripMenuItemNewBook});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 98);
            // 
            // toolStripMenuItemStatus
            // 
            this.toolStripMenuItemStatus.Name = "toolStripMenuItemStatus";
            this.toolStripMenuItemStatus.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemStatus.Text = "状态(&S)...";
            this.toolStripMenuItemStatus.Click += new System.EventHandler(this.toolStripMenuItemStatus_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemDelete.Text = "删除(&D)";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // toolStripMenuItemAddBook
            // 
            this.toolStripMenuItemAddBook.Name = "toolStripMenuItemAddBook";
            this.toolStripMenuItemAddBook.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemAddBook.Text = "增购(&A)...";
            this.toolStripMenuItemAddBook.Click += new System.EventHandler(this.toolStripMenuItemAddBook_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItemNewBook
            // 
            this.toolStripMenuItemNewBook.Name = "toolStripMenuItemNewBook";
            this.toolStripMenuItemNewBook.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemNewBook.Text = "购买新书(&N)...";
            this.toolStripMenuItemNewBook.Click += new System.EventHandler(this.toolStripMenuItemNewBook_Click);
            // 
            // sstMain
            // 
            this.sstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.sstMain.Location = new System.Drawing.Point(0, 435);
            this.sstMain.Name = "sstMain";
            this.sstMain.Size = new System.Drawing.Size(617, 22);
            this.sstMain.TabIndex = 14;
            this.sstMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel1.Text = "书籍管理工具。";
            // 
            // tspMain
            // 
            this.tspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStatus,
            this.tsbAdd,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbBuy,
            this.toolStripSeparator2,
            this.tsbCategory,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.txtSearch,
            this.tsbSearch});
            this.tspMain.Location = new System.Drawing.Point(0, 25);
            this.tspMain.Name = "tspMain";
            this.tspMain.Size = new System.Drawing.Size(617, 25);
            this.tspMain.TabIndex = 15;
            // 
            // tsbStatus
            // 
            this.tsbStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStatus.Image = ((System.Drawing.Image)(resources.GetObject("tsbStatus.Image")));
            this.tsbStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStatus.Name = "tsbStatus";
            this.tsbStatus.Size = new System.Drawing.Size(23, 22);
            this.tsbStatus.Text = "状态";
            this.tsbStatus.Click += new System.EventHandler(this.tsbStatus_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "增购";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBuy
            // 
            this.tsbBuy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuy.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuy.Image")));
            this.tsbBuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuy.Name = "tsbBuy";
            this.tsbBuy.Size = new System.Drawing.Size(23, 22);
            this.tsbBuy.Text = "购买新书";
            this.tsbBuy.Click += new System.EventHandler(this.mnuBookBuy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCategory
            // 
            this.tsbCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbCategory.Image")));
            this.tsbCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCategory.Name = "tsbCategory";
            this.tsbCategory.Size = new System.Drawing.Size(23, 22);
            this.tsbCategory.Text = "分类管理";
            this.tsbCategory.Click += new System.EventHandler(this.mnuCategoryManage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "搜索";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbSearch.Text = "搜索";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // frmBookMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tspMain);
            this.Controls.Add(this.mnsMain);
            this.Controls.Add(this.sstMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "frmBookMan";
            this.Text = "书目管理";
            this.Load += new System.EventHandler(this.frmBookMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readablebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.sstMain.ResumeLayout(false);
            this.sstMain.PerformLayout();
            this.tspMain.ResumeLayout(false);
            this.tspMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource readablebookBindingSource;
        private DataSetTableAdapters.readable_bookTableAdapter readablebookTableAdapter;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuToolExit;
        private System.Windows.Forms.ToolStripMenuItem 图书BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBookStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuBookAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuBookDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuBookBuy;
        private System.Windows.Forms.ToolStripMenuItem 分类CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCategoryManage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.StatusStrip sstMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip tspMain;
        private System.Windows.Forms.ToolStripButton tsbStatus;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBuy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuToolRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddBook;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

    }
}

