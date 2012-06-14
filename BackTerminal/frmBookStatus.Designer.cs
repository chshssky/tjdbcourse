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
            this.dataSet = new BackTerminal.DataSet();
            this.particularbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.particular_bookTableAdapter = new BackTerminal.DataSetTableAdapters.particular_bookTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookisbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particularbookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.libraryidDataGridViewTextBoxColumn,
            this.bookisbnDataGridViewTextBoxColumn,
            this.damagedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.particularbookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(452, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // particularbookBindingSource
            // 
            this.particularbookBindingSource.DataMember = "particular_book";
            this.particularbookBindingSource.DataSource = this.dataSet;
            // 
            // particular_bookTableAdapter
            // 
            this.particular_bookTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libraryidDataGridViewTextBoxColumn
            // 
            this.libraryidDataGridViewTextBoxColumn.DataPropertyName = "library_id";
            this.libraryidDataGridViewTextBoxColumn.HeaderText = "library_id";
            this.libraryidDataGridViewTextBoxColumn.Name = "libraryidDataGridViewTextBoxColumn";
            // 
            // bookisbnDataGridViewTextBoxColumn
            // 
            this.bookisbnDataGridViewTextBoxColumn.DataPropertyName = "book_isbn";
            this.bookisbnDataGridViewTextBoxColumn.HeaderText = "book_isbn";
            this.bookisbnDataGridViewTextBoxColumn.Name = "bookisbnDataGridViewTextBoxColumn";
            // 
            // damagedDataGridViewCheckBoxColumn
            // 
            this.damagedDataGridViewCheckBoxColumn.DataPropertyName = "damaged";
            this.damagedDataGridViewCheckBoxColumn.HeaderText = "damaged";
            this.damagedDataGridViewCheckBoxColumn.Name = "damagedDataGridViewCheckBoxColumn";
            // 
            // frmBookStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 313);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBookStatus";
            this.Text = "frmBookStatus";
            this.Load += new System.EventHandler(this.frmBookStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particularbookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource particularbookBindingSource;
        private DataSetTableAdapters.particular_bookTableAdapter particular_bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookisbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn damagedDataGridViewCheckBoxColumn;
    }
}