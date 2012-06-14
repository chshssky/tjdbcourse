namespace BackTerminal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.readablebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new BackTerminal.DataSet();
            this.readablebookTableAdapter = new BackTerminal.DataSetTableAdapters.readable_bookTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.readablebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "图书搜索";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 32);
            this.panel1.TabIndex = 11;
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具TToolStripMenuItem,
            this.图书BToolStripMenuItem,
            this.分类CToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(617, 25);
            this.mnsMain.TabIndex = 12;
            this.mnsMain.Text = "menuStrip1";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolExit});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 图书BToolStripMenuItem
            // 
            this.图书BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookStatus,
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
            this.mnuBookStatus.Size = new System.Drawing.Size(152, 22);
            this.mnuBookStatus.Text = "状态(&S)...";
            // 
            // mnuBookDelete
            // 
            this.mnuBookDelete.Name = "mnuBookDelete";
            this.mnuBookDelete.Size = new System.Drawing.Size(152, 22);
            this.mnuBookDelete.Text = "删除(&D)";
            // 
            // mnuBookAdd
            // 
            this.mnuBookAdd.Name = "mnuBookAdd";
            this.mnuBookAdd.Size = new System.Drawing.Size(152, 22);
            this.mnuBookAdd.Text = "增购(&A)...";
            // 
            // mnuBookBuy
            // 
            this.mnuBookBuy.Name = "mnuBookBuy";
            this.mnuBookBuy.Size = new System.Drawing.Size(152, 22);
            this.mnuBookBuy.Text = "购买新书(&N)...";
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
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpAbout.Text = "关于(&A)";
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
            this.mnuCategoryManage.Size = new System.Drawing.Size(152, 22);
            this.mnuCategoryManage.Text = "管理(&M)...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 400);
            this.panel2.TabIndex = 13;
            // 
            // dgvBook
            // 
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
            this.dgvBook.DataSource = this.readablebookBindingSource;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.Location = new System.Drawing.Point(0, 0);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.Size = new System.Drawing.Size(617, 400);
            this.dgvBook.TabIndex = 6;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "书名";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
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
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "数量";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // frmBookMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "frmBookMan";
            this.Text = "书籍管理";
            this.Load += new System.EventHandler(this.frmBookMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readablebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource readablebookBindingSource;
        private DataSetTableAdapters.readable_bookTableAdapter readablebookTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuToolExit;
        private System.Windows.Forms.ToolStripMenuItem 图书BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBookStatus;
        private System.Windows.Forms.ToolStripMenuItem mnuBookAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuBookDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuBookBuy;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem 分类CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCategoryManage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;

    }
}

