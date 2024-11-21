using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLSV_winform
{
    internal class database()
    {
        private static string connectionString = "Data Source=ICEBEAR\\SQLEXPRESS;Initial Catalog=qlsv;Integrated Security=True";
        private static SqlConnection conn;
        public static SqlConnection OpenConnection()
        {
            conn = new SqlConnection(connectionString); 
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi mở kết nối: " + ex.Message);
                conn = null;
            }
            return conn;
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
                conn.Dispose();
            }
        }
    }
}
