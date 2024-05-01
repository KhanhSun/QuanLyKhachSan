using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanATD.DAL;

namespace QuanLyKhachSanATD.DTO
{
    class Modify
    {
        public Modify() 
        {
        }
        SqlCommand sqlCommand; // dung de truy van insert , update , delete ...
        SqlDataReader dataReader; // dung de doc du lieu trong bang...

        public List<TaiKhoan> TaiKhoans (string query) 
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = ConnectionDB.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3)));
                }

                sqlConnection.Close();
            }
            return taiKhoans;
        }
    }
}
