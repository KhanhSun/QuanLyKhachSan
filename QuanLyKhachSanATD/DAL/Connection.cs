using DevExpress.XtraRichEdit.Layout;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanATD.DAL
{
    class ConnectionDB
    {
        private static string strConn = @"Data Source=SUNCE\SUNCE;Database=QLKS;Trusted_Connection=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConn);
        }

        public DataSet getData(String query)
        {
            SqlConnection conn = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, string message)
        {
            SqlConnection conn = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(message, "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public SqlDataReader getforCmb(String query)
        {
            SqlConnection conn = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query,conn);
            SqlDataReader sdr  = cmd.ExecuteReader();
            return sdr;
        }
    }
}

