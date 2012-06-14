namespace FrontTerminal
{
    partial class formRecordLost
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbReaderLId = new System.Windows.Forms.TextBox();
            this.txbBookLId = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者编号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "遗失书籍编号";
            // 
            // txbReaderLId
            // 
            this.txbReaderLId.Location = new System.Drawing.Point(106, 22);
            this.txbReaderLId.Name = "txbReaderLId";
            this.txbReaderLId.Size = new System.Drawing.Size(100, 21);
            this.txbReaderLId.TabIndex = 2;
            // 
            // txbBookLId
            // 
            this.txbBookLId.Location = new System.Drawing.Point(106, 82);
            this.txbBookLId.Name = "txbBookLId";
            this.txbBookLId.Size = new System.Drawing.Size(100, 21);
            this.txbBookLId.TabIndex = 3;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(54, 146);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "确认";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(155, 146);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 23);
            this.btnNO.TabIndex = 5;
            this.btnNO.Text = "重置";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // formRecordLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txbBookLId);
            this.Controls.Add(this.txbReaderLId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formRecordLost";
            this.Text = "formRecordLost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbReaderLId;
        private System.Windows.Forms.TextBox txbBookLId;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNO;
    }
}