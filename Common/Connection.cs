using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Library
{
    class Connection
    {
        private static SqlConnection connection = null;
        public static SqlConnection Instance()
        {
            if (connection == null)
            {
                string connstr =
                    "Data Source=GREENMOON55-PC\\SQLEXPRESS; " +
                    "Persist Security Info=True; " +
                    "Initial Catalog=lib; " +
                    "User Id=lib; " +
                    "Password=lib; ";

                connection = new SqlConnection(connstr);
                connection.Open();
            }
            return connection;
        }
    }
}
