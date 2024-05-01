using QuanLyKhachSanATD.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanATD.GUI
{
    public partial class ThanhToanPhong : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";
        public ThanhToanPhong()
        {
            InitializeComponent();
        }

        private void ThanhToanPhong_Load(object sender, EventArgs? e)
        {
            query = "select DatPhong.cid, DatPhong.cname, DatPhong.mobile, DatPhong.quoctich, DatPhong.gioitinh, DatPhong.ngaysinh, DatPhong.maDN, DatPhong.diachi, DatPhong.checkin,DatPhong.rservice, LoaiPhong.MaPhong,  LoaiPhong.TenLoaiPhong,DatPhong.allcost from DatPhong inner join LoaiPhong on DatPhong.roomid = LoaiPhong.roomid where checkout = 'No'; ";
            DataSet ds = sun.getData(query);
            TTdg.DataSource = ds.Tables[0];
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Findtxt_TextChanged(object sender, EventArgs e)
        {
            query = "select DatPhong.cid, DatPhong.cname, DatPhong.mobile, DatPhong.quoctich, DatPhong.gioitinh, DatPhong.ngaysinh, DatPhong.maDN, DatPhong.diachi, DatPhong.checkin,DatPhong.rservice, LoaiPhong.MaPhong,  LoaiPhong.TenLoaiPhong,DatPhong.allcost from DatPhong inner join LoaiPhong on DatPhong.roomid = LoaiPhong.roomid where cname like '" + Findtxt.Text + "%' and checkout = 'No'";
            DataSet ds = sun.getData(query);
            TTdg.DataSource = ds.Tables[0];
        }
        int id;
        private void TTdg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TTdg.Rows[e.RowIndex].Cells[e.RowIndex] != null)
            {
                id = int.Parse(TTdg.Rows[e.RowIndex].Cells[0].Value.ToString());
                nametxt.Text = TTdg.Rows[e.RowIndex].Cells[1].Value.ToString();
                roomnotxt.Text = TTdg.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void PayBTN_Click(object sender, EventArgs e)
        {
            if (nametxt.Text != "")
            {
                if (MessageBox.Show("Chắc chắn chưa ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = paydtp.Text;
                    query = @"update DatPhong set checkout = 'Yes', chekout = '" + cdate + "' where cid = " + id + " update LoaiPhong set TinhTrangPhong = 'No' where MaPhong = '" + roomnotxt.Text + "'";
                    sun.setData(query, "Thanh toán thành công!");
                    ThanhToanPhong_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Không có khách hàng để lựa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            Findtxt.Clear();
            nametxt.Clear();
            roomnotxt.Clear();
            paydtp.ResetText();
        }

        private void ThanhToanPhong_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
