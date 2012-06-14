using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb; 
namespace Library
{
    class Connection
    {
        private static SqlConnection connection = null;
        private static OleDbConnection a = null;

        public static SqlConnection Instance()
        {
            if (connection == null)
            {
                string connstr =
                    "Data Source=10.60.1.59\\SQLEXPRESS,1433; " +
                    "Persist Security Info=True; " +
                    "Initial Catalog=lib; " +
                    "User Id=lib; " +
                    "Password=liuyue; ";

                connection = new SqlConnection(connstr);
                connection.Open();
            }
            return connection;
        }
    }
}
