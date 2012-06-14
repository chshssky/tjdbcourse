using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReaderTerminal
{
    public partial class frmRegister : Form
    {
        public static string[] GENDER_DESC = {"男", "女", "保密"};
        public static string[] CRED_TYPE_DESC = { "身份证", "学生证", "军官证", "驾驶执照" };

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            if (!password.Equals(txtPwConfirm.Text))
            {
                MessageBox.Show("两次输入密码不一致，请重新输入。", "密码不一致",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string realName = txtRealName.Text;
            Boolean? gender = null;
            if (cmbGender.SelectedIndex == 0)
                gender = true; // Male.
            else if (cmbGender.SelectedIndex == 1)
                gender = false; // Female.
            int credType = cmbCredType.SelectedIndex + 1;
            string credNumber = txtCredNumber.Text;
            string phone = txtPhoneNumber.Text;

            string sql =
                "insert into reader ([name], password, gender, real_name, " +
                "   credential_type, credential_number, telephone, " +
                "   register_time, expire_time, available) " +
                "values (@name, @password, @gender, @real_name, " +
                "   @credential_type, @credential_number, @telephone, " +
                "   @register_time, @expire_time, @available)";

            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@real_name", realName);
            cmd.Parameters.AddWithValue("@credential_type", credType);
            cmd.Parameters.AddWithValue("@credential_number", credNumber);
            cmd.Parameters.AddWithValue("@telephone", phone);
            cmd.Parameters.AddWithValue("@register_time", System.DateTime.Now);
            cmd.Parameters.AddWithValue("@expire_time", System.DateTime.Now.AddYears(1));
            cmd.Parameters.AddWithValue("@available", true);

            if (cmd.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("您填写的信息有误，请重新输入。", "无法注册",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("注册成功！", "注册成功",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmbCredType.SelectedIndex = 0;
            cmbGender.SelectedIndex = 1;
        }
    }
}
