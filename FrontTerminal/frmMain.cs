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
            // TODO: 这行代码将数据加载到表“frDataSet.overdue_reader”中。您可以根据需要移动或删除它。
            this.overdue_readerTableAdapter.Fill(this.frDataSet.overdue_reader);
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
                try
                {
                    SqlCommand cmdReaderInfo = new SqlCommand("select * from  Reader where id = " + readerID, Connection.Instance());
                    SqlDataReader recReaderInfo = cmdReaderInfo.ExecuteReader();

                    if (!recReaderInfo.HasRows)
                        MessageBox.Show("没有该用户！");
                    else
                    {
                        while (recReaderInfo.Read())
                        {
                            txbName.Text = recReaderInfo[1].ToString();
                            if (Convert.ToInt32(recReaderInfo[3]) == 0)
                                txbGender.Text = "女";
                            else
                                txbGender.Text = "男";
                        }
                        recReaderInfo.Close();
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                try
                {

                    SqlCommand cmdRental = new SqlCommand("select * from rental where reader_id=" + readerID, Connection.Instance());

                    SqlDataReader recRental = cmdRental.ExecuteReader();
                    while (recRental.Read())
                    {
                        dgvReaderBorrow.Rows.Add(new object[] { recRental[0], recRental[1], recRental[2], recRental[3], recRental[4], recRental[5] });
                    }
                    recRental.Close();
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
           
        }

        private void dgvReaderBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void selectionChange(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            String readerName = Convert.ToString(txbReadName.Text);
            String readerGender = Convert.ToString(cbbReaderGender.Text);
            int readerGenderI;
            if (readerGender == "女")
            {
                readerGenderI = 0;
            }
            else if (readerGender == "男")
            {
                readerGenderI = 1;
            }
            else
            {
                readerGenderI = 2;
            }
            Console.Out.WriteLine(readerName);
            SqlConnection con = Connection.Instance();
            SqlCommand cmdReader = new SqlCommand();
            try
            {
                cmdReader.Connection = con;
                if (readerGenderI == 2)
                {
                    cmdReader.CommandText = "select * from  Reader where name like '*" + readerName + "%'";
                }
                else
                    cmdReader.CommandText = "select * from  Reader where name like '*" + readerName + "%' and gender=" + readerGenderI;
                SqlDataReader recordShow = cmdReader.ExecuteReader();

                if (!recordShow.HasRows)
                    MessageBox.Show("没有该用户！");
                else
                {
                    while (recordShow.Read())
                    {
                        dbgReaderinfo.Rows.Add(new object[] { recordShow[0], recordShow[1], recordShow[3], recordShow[4], recordShow[5], recordShow[6], recordShow[7], recordShow[8], recordShow[9], recordShow[10] });
                    }
                    recordShow.Close();

                }
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        private void button3_Click(object sender, EventArgs e) //这是借书的
        {
            
            if ((Convert.ToString(txbReaderId.Text.Trim())) == "")
                MessageBox.Show("请输入读者编号！");
            else
            {
                int readerId = Convert.ToInt32(txbReaderId.Text);
                int bookId = Convert.ToInt32(textboxBookId.Text);
                String borrowTime = System.DateTime.Now.ToString();
                String dueTime = System.DateTime.Now.AddDays(30).ToString();
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from  Reader where id = " + readerId, Connection.Instance());
                   
                    SqlDataReader recReader = cmd.ExecuteReader();

                    if (!recReader.HasRows)
                    {
                        recReader.Close();
                        MessageBox.Show("没有该用户！");
                        return;
                    }

                    recReader.Read();
                    int authory = Convert.ToInt32(recReader[10]);
                    recReader.Close();

                    SqlCommand cmdBookBorrowed = new SqlCommand("select * from borrowable_particular where particular_id = " + bookId, Connection.Instance());
                    SqlDataReader recBook = cmdBookBorrowed.ExecuteReader();

                    if (!recBook.HasRows)
                    {
                        recBook.Close();
                        MessageBox.Show("书籍已经被借");
                        return;
                    }
                    recBook.Close();
                    new SqlCommand("select * from  group where id = " + authory, Connection.Instance());
                    SqlDataReader recGroup = cmd.ExecuteReader();
                    recGroup.Read();
                    int maxBorrowTime = Convert.ToInt32(recGroup[2]);
                    recGroup.Close();
                    DateTime nowTime = System.DateTime.Now;
                    DateTime oughtToReturn = System.DateTime.Now.AddDays(maxBorrowTime);
                    SqlCommand cmdRental = new SqlCommand("insert into rental(rent_time,due_time,particular_book_id,reader_id) values(@nowTime,@oughtToReturn,@bookId,@readerId)", Connection.Instance());

                    cmdRental.CommandText = "insert into rental(rent_time,due_time,particular_book_id,reader_id) values(@nowTime,@oughtToReturn,@bookId,@readerId)";
                    cmdRental.Parameters.Add("@nowTime", SqlDbType.DateTime, 8, "rent_time");
                    cmdRental.Parameters["@nowTime"].Value = nowTime;

                    cmdRental.Parameters.Add("@oughtToReturn", SqlDbType.DateTime, 8, "due_time");
                    cmdRental.Parameters["@oughtToReturn"].Value = oughtToReturn;

                    cmdRental.Parameters.Add("@bookId", SqlDbType.Int, 4, "particular_book_id");
                    cmdRental.Parameters["@bookId"].Value = bookId;

                    cmdRental.Parameters.Add("@readerId", SqlDbType.Int, 4, "reader_id");
                    cmdRental.Parameters["@readerId"].Value = readerId;

                    cmdRental.ExecuteNonQuery();
                    MessageBox.Show("借书成功！");
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e) //这是还书的
        {
            int bookId = Convert.ToInt32(textboxBookId.Text); //因为还书只需要书籍编号，所以我只获取了图书编号

        }

    }
}
