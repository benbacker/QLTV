using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Desktop.BUS;

namespace Desktop.DAO
{
    class ConnectionSQL
    {
        #region checkConnection
        private static SqlConnection m_Connection;
        public static String m_ConnectString = "";

        #region Field
        #endregion
        private static XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
        private static XmlElement xmlEle = xmlDoc.DocumentElement;
        private ConnectionSQL() { }
        public static bool OpenConnection() // Hàm mở connection
        {
            if (m_ConnectString == "")
                ConnectionString();
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectString);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch
            {
                m_Connection.Close();
                return false;
            }
        }

        public static void ConnectionString() // hàm lấy lệnh connection
        {
            try
            {
                if (xmlEle.SelectSingleNode("costatus").InnerText == "true")
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";

                }
                else
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }

                AppSettingBUS.DatabaseName = xmlEle.SelectSingleNode("database").InnerText;
            }
            catch
            {
                //MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static String ConSTR()
        {
            XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
            XmlElement xmlEle = xmlDoc.DocumentElement;
            String connectionST = "";
            try
            {
                if (xmlEle.SelectSingleNode("costatus").InnerText == "true")
                {
                    connectionST = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";

                }
                else
                {
                    connectionST = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }

                AppSettingBUS.DatabaseName = xmlEle.SelectSingleNode("database").InnerText;
            }
            catch
            {
                //MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return connectionST;
        }
        #endregion
        #region ThuVienConection
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static string Lenh = ConSTR();/*Properties.Settings.Default.QuanLyThuVien;*/
        #endregion
        #region ConnecTionSQL
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

        public static bool check(string sql)
        {
            SqlConnection con = new SqlConnection(Lenh);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();

            if (dta.Read() == true)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
