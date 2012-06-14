using System;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string trimmedBossName = Library.ConfigUtil.GetString("boss_name").Trim();
            string trimmedPassword = Library.ConfigUtil.GetString("boss_password").Trim();

            string enteredBossName = txtBossName.Text.Trim();
            string encryptedPassword = Library.Util.MD5(txtBossPassword.Text);

            bool correctBossName = enteredBossName.Equals(trimmedBossName);
            bool correctPassword = encryptedPassword.Equals(trimmedPassword);
            bool noPasswordWasSet = trimmedPassword == null || trimmedPassword.Length == 0;
            bool noPasswordEntered = txtBossPassword.Text.Length == 0;

            if ((correctBossName && correctPassword) ||
                (noPasswordWasSet && noPasswordEntered))
            {
                this.Hide();
                new frmMain().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("您的输入有误。");
            }
        }
    }
}
