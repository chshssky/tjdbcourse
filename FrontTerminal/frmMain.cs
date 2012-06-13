using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library;

namespace FrontTerminal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'frontDataSet.reader' table. You can move, or remove it, as needed.
            this.readerTableAdapter.Fill(this.frontDataSet.reader);

        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            if (txbReaderId.Text == "")
            {
                MessageBox.Show("请输入读者编号");
            }
            else
            {
                int readerID = Convert.ToInt32(txbReaderId.Text);
                Console.Out.WriteLine(readerID);
                SqlConnection con = Connection.Instance();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                try
                {
                    cmd.CommandText = "select * from  Reader where id = " + readerID;
                    SqlDataReader record = cmd.ExecuteReader();
                    if (!record.HasRows)
                        MessageBox.Show("没有该用户！");
                    else
                    {
                        while (record.Read())
                        {
                            txbName.Text = record[1].ToString();
                            if (Convert.ToInt32(record[3]) == 0)
                                txbGender.Text = "女";
                            else
                                txbGender.Text = "男";
                        }
                        record.Close();
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                con.Close();
            }
           
        }
    }
}
