﻿using System;
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
            // TODO: This line of code loads data into the 'dataSet.borrowing' table. You can move, or remove it, as needed.
            this.borrowingTableAdapter.Fill(this.dataSet.borrowing);
            // TODO: This line of code loads data into the 'dataSet.damaged_book' table. You can move, or remove it, as needed.
            this.damaged_bookTableAdapter.Fill(this.dataSet.damaged_book);
            // TODO: This line of code loads data into the 'dataSet.overdue_reader' table. You can move, or remove it, as needed.
            this.overdue_readerTableAdapter.Fill(this.dataSet.overdue_reader);
            // TODO: This line of code loads data into the 'dataSet.reader' table. You can move, or remove it, as needed.
            this.readerTableAdapter.Fill(this.dataSet.reader);
        }
        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            if (txbReaderId.Text.Trim() == "")
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
                            Console.Out.WriteLine(recReaderInfo[4]);
                            if (recReaderInfo[4] == null)
                            {
                                txbGender.Text = "不便透露";
                            }
                            else if (Convert.ToInt32(recReaderInfo[4]) == 0)
                            {
                                txbGender.Text = "女";
                            }
                            else
                            {
                                txbGender.Text = "男";
                            }
                        }
                    }
                    recReaderInfo.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                UserRental.showRental(readerID, dgvReaderBorrow);
            }
        }

        private void dgvReaderBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void selectionChange(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e) //这是借书的
        {
            if ((Convert.ToString(txbReaderId.Text.Trim())) == "")
            {
                MessageBox.Show("请输入读者编号！");
                return;
            }
            if ((Convert.ToString(txbReaderId.Text.Trim())) == "")
            {
                MessageBox.Show("请输入图书编号");
                return;
            }
            int readerId = Convert.ToInt32(txbReaderId.Text);
            int bookId = Convert.ToInt32(textboxBookId.Text);

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
                int authory = Convert.ToInt32(recReader[11]);
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
                SqlCommand cmdGroup = new SqlCommand("select * from [group] where id = @authory", Connection.Instance());
                cmdGroup.Parameters.Add("@authory", authory);
                SqlDataReader recGroup = cmdGroup.ExecuteReader();
                recGroup.Read();
                int maxBorrowTime = Convert.ToInt32(recGroup[2]);
                recGroup.Close();
                DateTime nowTime = System.DateTime.Now;
                DateTime oughtToReturn = System.DateTime.Now.AddDays(maxBorrowTime);
                SqlCommand cmdRental = new SqlCommand("insert into rental(rent_time,due_time,particular_book_id,reader_id) values(@nowTime,@oughtToReturn,@bookId,@readerId)", Connection.Instance());

                cmdRental.CommandText = "insert into rental(rent_time,due_time,particular_book_id,reader_id) values(@nowTime,@oughtToReturn,@bookId,@readerId)";
                cmdRental.Parameters.Add("@nowTime", nowTime);

                cmdRental.Parameters.Add("@oughtToReturn", SqlDbType.DateTime, 8, "due_time");
                cmdRental.Parameters["@oughtToReturn"].Value = oughtToReturn;

                cmdRental.Parameters.Add("@bookId", SqlDbType.Int, 4, "particular_book_id");
                cmdRental.Parameters["@bookId"].Value = bookId;

                cmdRental.Parameters.Add("@readerId", SqlDbType.Int, 4, "reader_id");
                cmdRental.Parameters["@readerId"].Value = readerId;

                cmdRental.ExecuteNonQuery();
                UserRental.showRental(readerId, dgvReaderBorrow);
                MessageBox.Show("借书成功！");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) //这是还书的
        {
            if (textboxBookId.Text.ToString() == "")
            {
                MessageBox.Show("请输入还书编号");
                return;
            }//如果还书编号为空，弹出提示
            else
            {
                int bookId = Convert.ToInt32(textboxBookId.Text); //因为还书只需要书籍编号，所以我只获取了图书编号
                //先把rental表中该书的return time填上。
                // SqlCommand cmdReturn = new SqlCommand("select * from rental where particular_book_id=" + bookId, Connection.Instance());

                //
                DateTime returnTime = System.DateTime.Now;
                String update = "update rental set return_time='" + returnTime + "' where particular_book_id='" + bookId + "' and return_time is null";
                SqlCommand cmdReturn = new SqlCommand(update, Connection.Instance());
                SqlDataReader drReturn = cmdReturn.ExecuteReader();
                drReturn.Close();
                
                // 走到这一步，把rental表中的return_time填上了
                //，接下来就要看看有谁预约了这本书,因为预约中的书是用isbn表示，
                //而还书的书籍编号是用ID，所以要多一步，在book表中换成ID对应的isbn

                String getBookisbn = "select * from  particular_book where id = " + bookId;
                SqlCommand cmdFindIsbn = new SqlCommand(getBookisbn, Connection.Instance());
                SqlDataReader drFindIsbn = cmdFindIsbn.ExecuteReader();
                drFindIsbn.Read();
                String theIsbn = drFindIsbn[2].ToString(); //找出该id的isbn
                drFindIsbn.Close();
                
                String ifOrder = "";
                String findReserve = "select * from  reserve where book_isbn='" + theIsbn+"'";
                SqlCommand cmdFindReserve = new SqlCommand(findReserve, Connection.Instance());
                SqlDataReader drFindReserve = cmdFindReserve.ExecuteReader();
                if (!drFindReserve.HasRows)
                {
                    drFindReserve.Close();
                    ifOrder = "没有人预约了这本书";
                }
                else
                {
                    do
                    {
                        if (drFindReserve.Read())
                            continue;
                        else
                        {
                            ifOrder = "no valid one has reserved";
                            break; //当当前已经到了最后一列，说明所有预约者的借书卡都无效了（不过可能性有点小也）
                        }
                    }
                    while (Convert.ToUInt32(drFindReserve[4]) == 0);//此读者的借书卡无效，接着找下一个人
                    if (ifOrder != "no valid one has reserved")
                        ifOrder = "studentId:" + drFindReserve[1].ToString() + "has reserved it";
                    
                    MessageBox.Show(ifOrder);

                }
                drFindReserve.Close();
                 //在预约读者中找出有没有人预约此书
                if (txbReaderId.Text != "")
                    UserRental.showRental(Convert.ToInt32(txbReaderId.Text), dgvReaderBorrow);
                MessageBox.Show("还书成功！");
            }
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            formRecordLost inputLostInfo = new formRecordLost();
            inputLostInfo.Show();
            this.damaged_bookTableAdapter.Fill(this.dataSet.damaged_book);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            this.readerTableAdapter.Fill(this.dataSet.reader);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(this.readerTableAdapter.Adapter);
            this.readerTableAdapter.Update(this.dataSet);
        }
        private string lastPassword = "";
        private void dbgReaderinfo_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.Rows[e.RowIndex];
            DataGridViewColumn column = view.Columns[e.ColumnIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];
            if (column.DataPropertyName.Equals("password"))
            {
                if (cell.Value is string)
                    lastPassword = (string)cell.Value;
                cell.Value = "";
            }
            else
                Library.Util.TrimGridCell((DataGridView)sender, e.RowIndex, e.ColumnIndex);
        }

        private void dbgReaderinfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow row = view.Rows[e.RowIndex];
            DataGridViewColumn column = view.Columns[e.ColumnIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];
            if (column.DataPropertyName.Equals("password"))
            {
                if (((string)cell.Value).Length == 0)
                    cell.Value = lastPassword;
                else
                    cell.Value = Library.Util.MD5((string)cell.Value);
            }
        }

    }
}
