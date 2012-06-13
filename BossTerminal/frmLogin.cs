﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace BossTerminal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string trimmedBossName = Library.ConfigUtil.GetString("boss_name").Trim();
            string trimmedPassword = Library.ConfigUtil.GetString("boss_password").Trim();

            string enteredBossName = txtBossName.Text.Trim();
            string encryptedPassword = Library.Util.MD5(txtBossPassword.Text.Trim());

            if ((enteredBossName.Equals(trimmedBossName) &&
                encryptedPassword.Equals(trimmedPassword)) ||
                (trimmedPassword == null || trimmedPassword.Length == 0) &&
                txtBossPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("老板您好。");
                frmMain frmMain = new frmMain();
                this.Hide(); frmMain.ShowDialog(this);
                this.Close(); this.Dispose();
            }
            else
            {
                MessageBox.Show("不好意思，我们老板不在。");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
