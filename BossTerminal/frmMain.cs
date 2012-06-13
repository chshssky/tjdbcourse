using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BossTerminal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“libDataSet.book”中。您可以根据需要移动或删除它。
            this.bookTableAdapter.Fill(this.libDataSet.book);
            // TODO: 这行代码将数据加载到表“libDSlibrary.library”中。您可以根据需要移动或删除它。
            this.libraryTableAdapter.Fill(this.libDSlibrary.library);
            // TODO: 这行代码将数据加载到表“libDataSet.manager”中。您可以根据需要移动或删除它。
            this.managerTableAdapter.Fill(this.libDataSet.manager);

        }

        private void mnuToolAddLibrary_Click(object sender, EventArgs e)
        {
            frmAddLib fm = new frmAddLib();
            fm.ShowDialog();
            fm.Close();
        }

        private void mnuToolAddManager_Click(object sender, EventArgs e)
        {

        }

        private void mnuToolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改账号AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBossName fm = new frmBossName();
            fm.ShowDialog();
            fm.Close();
        }

        private void 修改密码PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPassword().ShowDialog();
        }

        private void dgvMangers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
