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
    public partial class changepsw : Form
    {
        public changepsw()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string oldpsw = oripsd.Text;
            string newpsw = newpsd.Text;
            string newpswcfm = newpsdcfm.Text;
            string sql1 = 
                "select password " +
                "from reader "+
                "where id = @id and password = @psd";
            if (newpsw.Equals(newpswcfm))
            {
                SqlCommand cmd = new SqlCommand(sql1, Library.Connection.Instance());
                cmd.Parameters.AddWithValue("@id", frmLogin.readerId);
                cmd.Parameters.AddWithValue("@psd", oldpsw);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string sql2 = "update reader set password = @password where id = @id";
                    SqlCommand cmd2 = new SqlCommand(sql2, Library.Connection.Instance());
                    cmd2.Parameters.AddWithValue("@id", frmLogin.readerId);
                    cmd2.Parameters.AddWithValue("@password", newpsw);
                    reader.Close();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("修改成功!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("你密码输错啦");
                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("两次密码不一致，请重新输入");
            }
        }
    }
}
