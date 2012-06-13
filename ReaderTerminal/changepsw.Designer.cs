namespace ReaderTerminal
{
    partial class changepsw
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
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.oripsd = new System.Windows.Forms.TextBox();
            this.newpsd = new System.Windows.Forms.TextBox();
            this.newpsdcfm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(47, 154);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(64, 40);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(174, 155);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(68, 40);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "再输入一次：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // oripsd
            // 
            this.oripsd.Location = new System.Drawing.Point(124, 25);
            this.oripsd.Name = "oripsd";
            this.oripsd.Size = new System.Drawing.Size(118, 21);
            this.oripsd.TabIndex = 6;
            // 
            // newpsd
            // 
            this.newpsd.Location = new System.Drawing.Point(124, 65);
            this.newpsd.Name = "newpsd";
            this.newpsd.Size = new System.Drawing.Size(118, 21);
            this.newpsd.TabIndex = 7;
            // 
            // newpsdcfm
            // 
            this.newpsdcfm.Location = new System.Drawing.Point(124, 104);
            this.newpsdcfm.Name = "newpsdcfm";
            this.newpsdcfm.Size = new System.Drawing.Size(118, 21);
            this.newpsdcfm.TabIndex = 8;
            // 
            // changepsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 207);
            this.Controls.Add(this.newpsdcfm);
            this.Controls.Add(this.newpsd);
            this.Controls.Add(this.oripsd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Name = "changepsw";
            this.Text = "changepsw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox oripsd;
        private System.Windows.Forms.TextBox newpsd;
        private System.Windows.Forms.TextBox newpsdcfm;
    }
}