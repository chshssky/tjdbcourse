using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Library
{
    class ConfigUtil
    {
        public static string GetString(string key)
        {
            string sql =
                "select config_value " +
                "from config " +
                "where config_key = @config_key";
            string result = null;

            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@config_key", key);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                object objrslt = reader.GetValue(0);
                if (objrslt is string)
                    result = (string) objrslt;
            }
            reader.Close();
            return result;
        }

        public static bool SetString(string key, string value)
        {
            string sql =
                "update config " +
                "set config_value = @value " +
                "where config_key = @config_key";

            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@config_key", key);
            cmd.Parameters.AddWithValue("@value", value);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
