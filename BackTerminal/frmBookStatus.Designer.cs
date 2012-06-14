namespace BackTerminal
{
    partial class frmBookStatus
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookLibraryDamagedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new BackTerminal.DataSet();
            this.bookLibraryDamagedTableAdapter = new BackTerminal.DataSetTableAdapters.book_library_damagedTableAdapter();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryTableAdapter = new BackTerminal.DataSetTableAdapters.libraryTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.particular_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.library_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.damagedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDamagedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.particular_id,
            this.Column1,
            this.titleDataGridViewTextBoxColumn,
            this.library_id,
            this.damagedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bookLibraryDamagedBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(660, 369);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookLibraryDamagedBindingSource
            // 
            this.bookLibraryDamagedBindingSource.DataMember = "book_library_damaged";
            this.bookLibraryDamagedBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookLibraryDamagedTableAdapter
            // 
            this.bookLibraryDamagedTableAdapter.ClearBeforeFill = true;
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "library";
            this.libraryBindingSource.DataSource = this.dataSet;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(676, 385);
            this.panel1.TabIndex = 1;
            // 
            // particular_id
            // 
            this.particular_id.DataPropertyName = "particular_id";
            this.particular_id.HeaderText = "实例";
            this.particular_id.Name = "particular_id";
            this.particular_id.ReadOnly = true;
            this.particular_id.Width = 40;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "isbn";
            this.Column1.HeaderText = "ISBN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "书名";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // library_id
            // 
            this.library_id.DataPropertyName = "library_id";
            this.library_id.DataSource = this.libraryBindingSource;
            this.library_id.DisplayMember = "name";
            this.library_id.DisplayStyleForCurrentCellOnly = true;
            this.library_id.HeaderText = "图书馆";
            this.library_id.Name = "library_id";
            this.library_id.ReadOnly = true;
            this.library_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.library_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.library_id.ValueMember = "id";
            this.library_id.Width = 200;
            // 
            // damagedDataGridViewCheckBoxColumn
            // 
            this.damagedDataGridViewCheckBoxColumn.DataPropertyName = "damaged";
            this.damagedDataGridViewCheckBoxColumn.HeaderText = "损否";
            this.damagedDataGridViewCheckBoxColumn.Name = "damagedDataGridViewCheckBoxColumn";
            this.damagedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.damagedDataGridViewCheckBoxColumn.Width = 40;
            // 
            // frmBookStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 385);
            this.Controls.Add(this.panel1);
            this.Name = "frmBookStatus";
            this.Text = "书籍状态";
            this.Load += new System.EventHandler(this.frmBookStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookLibraryDamagedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource bookLibraryDamagedBindingSource;
        private DataSetTableAdapters.book_library_damagedTableAdapter bookLibraryDamagedTableAdapter;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private DataSetTableAdapters.libraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn particular_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn library_id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn damagedDataGridViewCheckBoxColumn;
    }
}