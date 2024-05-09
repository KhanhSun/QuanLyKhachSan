using QuanLyKhachSanATD.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSanATD.GUI
{
    public partial class DatPhong : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";
        int error = 0;
        public DatPhong()
        {
            InitializeComponent();
        }

        public void setcombobox(String query, ComboBox combo)
        {
            SqlDataReader sdr = sun.getforCmb(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomtype.SelectedIndex = -1;
            Rnum.Items.Clear();
            total.Clear();
        }

        private void roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rnum.Items.Clear();
            query = "select MaPhong from LoaiPhong where LoaiGiuong = N'" + bed.Text + "' and TenLoaiPhong = N'" + roomtype.Text + "' and TinhTrangPhong = 'No'";
            setcombobox(query, Rnum);

        }
        int rid;
        private void Rnum_SelectedIndexChanged(object sender, EventArgs e)
        { 
            query = "select TenDichVu from DichVu";
            setcombobox(query, Service);
        }
        private void Service_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (error != 0)
            {
                return;
            }
            else
            {
                query = "select GiaPhong, roomid from LoaiPhong where MaPhong = '" + Rnum.Text + "'";
                DataSet dn = sun.getData(query);
                String query2 = "select TienDichVu, TenDichVu from DichVu where TenDichVu = N'" + Service.Text+ "'";
                DataSet sv = sun.getData(query2);
                
                // hỏi thầy
                int sum1 = int.Parse(s: dn.Tables[0].Rows[0][0].ToString());

                int sum2 = int.Parse(sv.Tables[0].Rows[0][0].ToString());
                int sum = sum1 + sum2;
                total.Text = sum.ToString();
                rid = int.Parse(dn.Tables[0].Rows[0][1].ToString());
                error++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ten.Text != "" && sdt.Text != "" && quoctich.Text != "" && gender.Text != "" && dob.Text != "" && madinhdanh.Text != "" && diachi.Text != "" && checkinday.Text != "" && total.Text != "")
            {
                String name = ten.Text;
                Int64 mobile = Int64.Parse(sdt.Text);
                String nation = quoctich.Text;
                String gioitinh = gender.Text;
                String ngaysinh = dob.Text;
                String idf = madinhdanh.Text;
                String dc = diachi.Text;
                String checkin = checkinday.Text;
                String rservice = Service.Text;
                String Alltotal = total.Text;
                if (rservice == "")
                {
                    query = "INSERT INTO DatPhong (cname, mobile, quoctich, gioitinh, ngaysinh, maDN, diachi, checkin,rservice, roomid,allcost) values (N'" + name + "'," + mobile + ",'" + nation + "','" + gioitinh + "','" + ngaysinh + "','" + idf + "',N'" + dc + "','" + checkin + "', NULL ," + rid + "," + Alltotal + ") update LoaiPhong set TinhTrangPhong = 'YES' where roomid = '" + rid + "'";
                    sun.setData(query, "Số phòng " + Rnum.Text + " đặt phòng thành công.");
                    clearAll();
                }
                else
                {
                    query = "INSERT INTO DatPhong (cname, mobile, quoctich, gioitinh, ngaysinh, maDN, diachi, checkin,rservice, roomid,allcost) values (N'" + name + "'," + mobile + ",'" + nation + "','" + gioitinh + "','" + ngaysinh + "','" + idf + "',N'" + dc + "','" + checkin + "',N'" + rservice + "'," + rid + "," + Alltotal + ") update LoaiPhong set TinhTrangPhong = 'YES' where roomid = '" + rid + "'";
                    sun.setData(query, "Số phòng " + Rnum.Text + " đặt phòng thành công.");
                    clearAll();
                }

            }
            else
            {
                MessageBox.Show("xin vui lòng điền đủ thông tin.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            ten.Clear();
            sdt.Clear();
            quoctich.Clear();
            gender.SelectedIndex = -1;
            dob.ResetText();
            madinhdanh.Clear();
            diachi.Clear();
            checkinday.ResetText();
            bed.SelectedIndex = -1;
            roomtype.SelectedIndex = -1;
            Service.SelectedIndex = -1;
            Rnum.Items.Clear();
            total.Clear();
            error--;
        }

        private void sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatPhong_Load(object sender, EventArgs e)
        {

        }

        private void DatPhong_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
