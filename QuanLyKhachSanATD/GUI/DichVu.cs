using QuanLyKhachSanATD.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanATD.GUI
{
    public partial class DichVu : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";
        public DichVu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clearAll()
        {
            idDV.Clear();
            DVname.Clear();
            price.Clear();
        }
        private void DichVu_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void DichVu_Load(object sender, EventArgs? e)
        {
            query = "Select * from DichVu";
            DataSet ds = sun.getData(query);
            DVdata.DataSource = ds.Tables[0];
        }

        private void DVdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DelBTN_Click(object sender, EventArgs e)
        {
            if (idDV.Text != "")
            {
                String id = idDV.Text;

                query = "DELETE FROM DichVu WHERE IdDichVu = '" + id + "'";
                sun.setData(query, "Đã xóa dịch vụ");

                DichVu_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdBTN_Click(object sender, EventArgs e)
        {
            if (idDV.Text != "" && DVname.Text != "" && price.Text != "")
            {
                String id = idDV.Text;
                String DVn = DVname.Text;
                String DVp = price.Text;

                query = "update DichVu set TenDichVu = '" + DVn + "' , TienDichVu = '" + DVp + "' where IdDichVu = '" + id + "' ";
                sun.setData(query, "Đã cập nhật");

                DichVu_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập id", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (DVname.Text != "" && price.Text != "")
            {
                String DVn = DVname.Text;
                String DVp = price.Text;

                query = "INSERT INTO DichVu (TenDichVu, TienDichVu) VALUES (N'" + DVn + "','" + DVp + "')";
                sun.setData(query, "Đã thêm dịch vụ");

                DichVu_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetDV_Click(object sender, EventArgs e)
        {
        }
        private void cm1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
