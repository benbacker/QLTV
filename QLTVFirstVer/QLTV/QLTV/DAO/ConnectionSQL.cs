using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.DAO
{
    class ConnectionSQL
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static string Lenh = Properties.Settings.Default.QuanLyThuVien;
        public static DataTable TaoBang(string sql)
        {
            conn = new SqlConnection(Lenh);
            conn.Open();
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int ExecuteNonQuery(string sql)
        {
            int re = 0;
            try
            {
                conn = new SqlConnection(Lenh);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                re = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
            return re;
        }

        public static int Identity(int ID)
        {
            string query = "select IDDocGia from TheDocGia";
            conn = new SqlConnection(Lenh);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = int.Parse(reader[0].ToString()) + 1;
            }
            return ID;
        }

        public static int Identitytable(int ID,string a , string b)
        {
            string query = "select "+ a + " from " + b + " ";
            conn = new SqlConnection(Lenh);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = int.Parse(reader[0].ToString()) + 1;
            }
            return ID;
        }

        public static AutoCompleteStringCollection AutoTextbox(string querytable,string column)
        {
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            string query = querytable;
            conn = new SqlConnection(Lenh);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                col.Add(reader[column].ToString());
            }
            return col;
        }

        public static int ConvertNameToID(string TenTG)
        {
            int ID = 0;
            string query = "Select IDTacGia from TacGia where TenTacGia = N'"+ TenTG + "'";
            conn = new SqlConnection(Lenh);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ID = int.Parse(reader[0].ToString());
            }
            return ID;
        }

        public static string GetStringTable(string GetString, string Query)
        {
            string GetTable;
            conn = new SqlConnection(Lenh);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd = new SqlCommand(Query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            GetTable = reader[""+GetString+""].ToString();
            return GetTable;
        }
    }
}
