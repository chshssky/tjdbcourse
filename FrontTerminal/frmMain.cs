using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            int readerID = Convert.ToInt32(txbReaderId.Text);
            Console.Out.WriteLine(readerID);
            SqlConnection con = Connection.Instance();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                cmd.CommandText = "select * from  Reader where id = "+readerID;
                SqlDataReader record = cmd.ExecuteReader();
                if (record.IsDBNull(0))
                    MessageBox.Show("没有该用户！");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
    }
}
