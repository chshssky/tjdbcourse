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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuTerminalExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuReaderLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from readable_book where ";

            switch (cmbSearchType.SelectedIndex)
            {
                case 0: sql += "title"; break;
                case 1: sql += "author"; break;
                case 2: sql += "isbn"; break;
                case 3: sql += "category"; return;
                case 4: sql += "publisher"; break;
            }

            sql += " like @value";

            this.readableBookTableAdapter.Adapter.SelectCommand.CommandText = sql;
            this.readableBookTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            this.readableBookTableAdapter.Adapter.SelectCommand.Parameters
                .AddWithValue("@value", "%" + txtSearchContent.Text + "%");
            this.readableBookTableAdapter.Fill(this.dataSet.readable_book);
        }

        private void lstBookResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet.readable_book”中。您可以根据需要移动或删除它。
            this.readableBookTableAdapter.Fill(this.dataSet.readable_book);
            // TODO: 这行代码将数据加载到表“dataSet.category”中。您可以根据需要移动或删除它。
            this.categoryTableAdapter.Fill(this.dataSet.category);
            // TODO: 这行代码将数据加载到表“dataSet.active_reserve”中。您可以根据需要移动或删除它。
            this.activeReserveTableAdapter.Fill(this.dataSet.active_reserve);
            // TODO: 这行代码将数据加载到表“dataSet.active_reserve”中。您可以根据需要移动或删除它。
            this.activeReserveTableAdapter.Fill(this.dataSet.active_reserve);
            // TODO: 这行代码将数据加载到表“dataSet.returned”中。您可以根据需要移动或删除它。
            this.returnedTableAdapter.Fill(this.dataSet.returned);
            // TODO: 这行代码将数据加载到表“dataSet.borrowing”中。您可以根据需要移动或删除它。
            this.borrowingTableAdapter.Fill(this.dataSet.borrowing);
            // TODO: 这行代码将数据加载到表“dataSet.returned”中。您可以根据需要移动或删除它。
            this.returnedTableAdapter.Fill(this.dataSet.returned);
            // TODO: 这行代码将数据加载到表“dataSet.borrowing”中。您可以根据需要移动或删除它。
            this.borrowingTableAdapter.Fill(this.dataSet.borrowing);
            cmbSearchType.SelectedIndex = 0;
            this.Size = new System.Drawing.Size(640, 480);
        }

        private void tpgReaderInfo_Click(object sender, EventArgs e)
        {
            btnReaderCancel_Click(sender, e);
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPassword frm = new frmPassword();
            frm.ShowDialog();
            this.Show();
        }

        private void mnuReaderChangePassword_Click(object sender, EventArgs e)
        {
            new frmPassword().ShowDialog();
        }

        private void btnReaderCancel_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            int readerId = frmLogin.readerId;
            string sql =
                "select * " +
                "from readable_reader " +
                "where id = @readerid";
            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@readerid", readerId);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtReaderName.Text = reader["name"].ToString().Trim();
                txtReaderRealName.Text = reader["real_name"].ToString().Trim();

                Boolean? gender = null;
                if (!(reader["gender"] is DBNull))
                    gender = (Boolean)reader["gender"];
                if (gender == null)
                    cmbReaderGender.SelectedIndex = 2;
                else if (gender == false)
                    cmbReaderGender.SelectedIndex = 1;
                else
                    cmbReaderGender.SelectedIndex = 0;

                int credType = (int)reader["credential_type"];
                cmbReaderCredType.SelectedIndex = credType - 1;
                txtReaderCredNumber.Text = ((string)reader["credential_number"]).Trim();

                txtPhone.Text = reader["telephone"].ToString().Trim();
                txtRegTime.Text = reader["register_time"].ToString().Trim();
                txtExpTime.Text = reader["expire_time"].ToString().Trim();
                bool available = (bool)reader["available"];
                if (available)
                    txtAvailable.Text = "是";
                else
                    txtAvailable.Text = "否";

                txtGroupName.Text = reader["group"].ToString().Trim();

                reader.Close();
            }
        }

        private void btnReaderSubmit_Click(object sender, EventArgs e)
        {
            string sql = "update reader set " +
                "   real_name = @real_name, " +
                "   gender = @gender, " +
                "   credential_type = @credential_type, " +
                "   credential_number = @credential_number, " +
                "   telephone = @telephone " +
                "where id = @id";

            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());

            cmd.Parameters.AddWithValue("@id", frmLogin.readerId);

            cmd.Parameters.AddWithValue("@real_name", txtReaderRealName.Text);

            Boolean? gender = null;
            if (cmbReaderGender.SelectedIndex == 1)
                gender = false;
            else if (cmbReaderGender.SelectedIndex == 0)
                gender = true;

            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@credential_type", cmbReaderCredType.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@credential_number", txtReaderCredNumber.Text);
            cmd.Parameters.AddWithValue("@telephone", txtPhone.Text);

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("成功更改读者信息。", "更改成功",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("无法更改读者信息。", "无法更改",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tpgBookRental_Enter(object sender, EventArgs e)
        {
            this.dataSet.borrowing.Clear();

            string sql = "select * from borrowing where reader_id = @reader_id";

            this.borrowingTableAdapter.Adapter.SelectCommand.CommandText = sql;

            this.borrowingTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            this.borrowingTableAdapter.Adapter.SelectCommand.Parameters
                .AddWithValue("@reader_id", frmLogin.readerId);

            this.borrowingTableAdapter.Fill(dataSet.borrowing);
        }

        private void tpgHistory_Enter(object sender, EventArgs e)
        {
            this.dataSet.returned.Clear();

            string sql = "select * from returned where reader_id = @reader_id";

            this.returnedTableAdapter.Adapter.SelectCommand.CommandText = sql;

            this.returnedTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            this.returnedTableAdapter.Adapter.SelectCommand.Parameters
                .AddWithValue("@reader_id", frmLogin.readerId);

            this.returnedTableAdapter.Fill(dataSet.returned);
        }

        private void tpgBookReserve_Enter(object sender, EventArgs e)
        {
            this.dataSet.active_reserve.Clear();

            string sql = "select * from active_reserve where reader_id = @reader_id";

            this.activeReserveTableAdapter.Adapter.SelectCommand.CommandText = sql;

            this.activeReserveTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            this.activeReserveTableAdapter.Adapter.SelectCommand.Parameters
                .AddWithValue("@reader_id", frmLogin.readerId);

            this.activeReserveTableAdapter.Fill(dataSet.active_reserve);
        }

        private void dgvSearch_DoubleClick(object sender, EventArgs e)
        {
            string isbn = dgvSearch.SelectedRows[0].Cells[0].Value.ToString();
            new frmBook(isbn).ShowDialog();
        }
    }
}
