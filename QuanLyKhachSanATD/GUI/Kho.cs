
using QuanLyKhachSanATD.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanATD.GUI
{
    public partial class Kho : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";
        public Kho()
        {
            InitializeComponent();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Khodg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void clearAll()
        {
            MVL.Clear();
            TVL.Clear();
            ncc.Clear();
            dvt.Clear();
            slg.Clear();
            slgtt.Clear();
        }

        private void Khodg_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (MVL.Text != "" && TVL.Text != "" && ncc.Text != "" && dvt.Text != "" && slg.Text != "" && slgtt.Text != "")
            {
                String mvl = MVL.Text;
                String tvl = TVL.Text;
                String Ncc = ncc.Text;
                String Dvt = dvt.Text;
                String Slg = slg.Text;
                String Slgtt = slgtt.Text;

                query = "INSERT INTO QLKho(MaVL,TenVL,NCC,DonViTinh,SoLuong,SoLuongToiDa) VALUES  ('" + mvl + "', N'" + tvl + "', N'" + Ncc + "', N'" + Dvt + "','" + Slg + "','" + Slgtt + "')";
                sun.setData(query, "Đã thêm vào kho");

                Kho_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdBTN_Click(object sender, EventArgs e)
        {
            if (MVL.Text != "" && TVL.Text != "" && slg.Text != "")
            {
                String mvl = MVL.Text;
                String tvl = TVL.Text;
                String Slg = slg.Text;
                int check1 = Int32.Parse(Slg);
                String Slgtt = slgtt.Text;
                int check2 = Int32.Parse(Slgtt);
                if(check1 <= check2)
                {
                    query = "update QLKho set SoLuong = '" + Slg + "' where MaVL = '" + mvl + "' ";
                    sun.setData(query, "Đã cập nhật");

                    Kho_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập id", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Kho_Load(object sender, EventArgs? e)
        {
            query = "Select * from QLKHO";
            DataSet ds = sun.getData(query);
            Khodg.DataSource = ds.Tables[0];
        }

        private void slg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void slgtt_TextChanged(object sender, EventArgs e)
        {

        }

        private void slgtt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
