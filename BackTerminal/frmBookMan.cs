using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BackTerminal
{
    public partial class frmBookMan : Form
    {
        public frmBookMan()
        {
            InitializeComponent();
        }

        private void frmBookMan_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet.readable_book”中。您可以根据需要移动或删除它。
            this.readablebookTableAdapter.Fill(this.dataSet.readable_book);

        }
    }
}
