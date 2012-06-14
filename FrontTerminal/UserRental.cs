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
    class UserRental
    {
        public static void showRental(int readerID, DataGridView dgvRental)
        {
            try
            {
                SqlCommand cmdRental = new SqlCommand("select * from rental where reader_id=" + readerID, Connection.Instance());

                SqlDataReader recRental = cmdRental.ExecuteReader();
                dgvRental.Rows.Clear();
                while (recRental.Read())
                {
                    dgvRental.Rows.Add(new object[] { recRental[0], recRental[1], recRental[2], recRental[3], recRental[4], recRental[5] });
                }
                recRental.Close();
                    
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
