using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // TODO: 这行代码将数据加载到表“dataSet.library”中。您可以根据需要移动或删除它。
            this.libraryTableAdapter.Fill(this.dataSet.library);
            // TODO: 这行代码将数据加载到表“dataSet.manager”中。您可以根据需要移动或删除它。
            this.managerTableAdapter.Fill(this.dataSet.manager);
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

        private void mnuToolRefresh_Click(object sender, EventArgs e)
        {
            this.managerTableAdapter.Fill(this.dataSet.manager);
            this.libraryTableAdapter.Fill(this.dataSet.library);
        }

        private void mnuToolSave_Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(this.managerTableAdapter.Adapter);
            this.managerTableAdapter.Update(this.dataSet);
            new SqlCommandBuilder(this.libraryTableAdapter.Adapter);
            this.libraryTableAdapter.Update(this.dataSet);
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Library.Util.TrimGridCell((DataGridView)sender, e.RowIndex, e.ColumnIndex);
        }
    }
}
