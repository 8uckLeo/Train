using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace train
{
    public class DBHelper
    {
        private static string ConnStr = "server=120.107.95.99;port=10028;user id=train_user;password=1234;database=trains;charset=utf8;";

        public static int ExecuteNonQuery(string sql, params MySqlParameter[] paras)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddRange(paras);
                int result = command.ExecuteNonQuery();
                return result;
            }
        }

        public static object ExecuteScalar(string sql, params MySqlParameter[] paras)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddRange(paras);
                object obj = command.ExecuteScalar();
                return obj;
            }
        }

        public static MySqlDataReader ExecuteReader(string sql, params MySqlParameter[] paras)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddRange(paras);
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public static DataRow GetDataRow(string sql, params MySqlParameter[] paras)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddRange(paras);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }

            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            else
                return null;
        }

        public static DataTable GetDataTable(string sql, params MySqlParameter[] paras)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddRange(paras);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public static DataSet GetDataSet(string sql, params MySqlParameter[] paras)
        {
            DataSet ds = new DataSet();
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddRange(paras);
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(ds);
                }
            }
            return ds;
        }
    }
}