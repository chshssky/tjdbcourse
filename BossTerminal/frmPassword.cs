using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BossTerminal
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string passwordConfirm = txtPasswordConfirm.Text;

            if (newPassword.Length == 0 || passwordConfirm.Length == 0)
            {
                MessageBox.Show("新密码和确认密码不能为空！");
                return;
            }

            if (!newPassword.Equals(passwordConfirm))
            {
                MessageBox.Show("两次密码输入不一致！");
                return;
            }

            string realOldPasswordMd5ed =
                Library.ConfigUtil.GetString("boss_password");
            string oldPasswordMd5ed = Library.Util.MD5(oldPassword);

            if (realOldPasswordMd5ed.Trim().Length != 0 &&
                !oldPasswordMd5ed.Equals(realOldPasswordMd5ed))
            {
                MessageBox.Show("旧密码输入错误！");
                return;
            }

            string newPasswordMd5ed = Library.Util.MD5(newPassword);

            if (Library.ConfigUtil.SetString("boss_password", newPasswordMd5ed))
            {
                MessageBox.Show("密码更新成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("密码更新失败！");
            }
        }
    }
}
