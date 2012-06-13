using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BossTerminal
{
    public partial class frmBossName : Form
    {
        public frmBossName()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string trimmedNewName = txtNewName.Text.Trim();
            string trimmedNameConfirm = txtNameConfirm.Text.Trim();

            if (!trimmedNameConfirm.Equals(trimmedNewName))
            {
                MessageBox.Show("两次输入不匹配，请重新输入。");
                return;
            }

            if (Library.ConfigUtil.SetString("boss_name", trimmedNewName))
            {
                MessageBox.Show("名称修改成功。");
                this.Close();
            }
            else
            {
                MessageBox.Show("名称修改失败。");
            }
        }
    }
}
