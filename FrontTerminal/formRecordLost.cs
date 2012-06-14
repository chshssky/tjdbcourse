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
    public partial class formRecordLost : Form
    {
        public formRecordLost()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)// 确认登记遗失书籍
        {
            int readerId = Convert.ToInt32(txbReaderLId.Text);  
            int bookId = Convert.ToInt32(txbBookLId.Text);
            //要进行的操作有：把particular_book的damage设置为true。把书当做还了，修改rental表
            String update = "update particular_book set damaged='1' where id="+ bookId;
            SqlCommand cmdChangeDamage = new SqlCommand(update, Connection.Instance());
            SqlDataReader drChangeDamage = cmdChangeDamage.ExecuteReader();
            drChangeDamage.Close();
            DateTime returnTime = System.DateTime.Now;
            String updateRental = "update rental set return_time='" + returnTime + "' where particular_book_id='" + bookId + "' and return_time is null";
            SqlCommand cmdReturn = new SqlCommand(updateRental, Connection.Instance());
            SqlDataReader drReturn = cmdReturn.ExecuteReader();
            drReturn.Close();
        }

        private void btnNO_Click(object sender, EventArgs e) 
        {
            txbBookLId.Text = "";
            txbReaderLId.Text = "";
        }
    }
}
