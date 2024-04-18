using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhong
{
    public partial class MainForm : Form
    {
        private int roomPrice = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu cho các CheckBox
            checkBoxThuong.Text = "200000 VND/ngày";
            checkBoxVIP.Text = "400000 VND/ngày";
        }

        private void checkBoxThuong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxThuong.Checked)
            {
                // Bỏ chọn RadioButton trong GroupBox 2 (nếu có)
                checkBoxVIP.Checked = false;
                roomPrice = 200000;
            }
        }

        private void checkBoxVIP_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu RadioButton trong GroupBox 2 được chọn
            if (checkBoxVIP.Checked)
            {
                // Bỏ chọn RadioButton trong GroupBox 1 (nếu có)
                checkBoxThuong.Checked = false;
                roomPrice = 400000;
            }
        }

        private void txtSoNgayO_TextChanged_1(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox có rỗng không
            if (string.IsNullOrWhiteSpace(txtSoNgayO.Text))
            {
                return;
            }

            // Kiểm tra xem dữ liệu nhập vào có phải là số không
            if (!Regex.IsMatch(txtSoNgayO.Text, @"^\d+$"))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNgayO.Text = ""; // Xóa dữ liệu không hợp lệ
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có chọn loại phòng và nhập số ngày ở không
            if ((checkBoxThuong.Checked || checkBoxVIP.Checked) && !string.IsNullOrWhiteSpace(txtSoNgayO.Text))
            {
                int numberOfDays;
                if (int.TryParse(txtSoNgayO.Text, out numberOfDays))
                {
                    int totalPrice = roomPrice * numberOfDays;
                    listView1.Items.Clear();
                    listView1.Items.Add(new ListViewItem(new string[] { "Giá phòng", roomPrice.ToString("N0") }));
                    listView1.Items.Add(new ListViewItem(new string[] { "Số ngày ở", numberOfDays.ToString() }));
                    listView1.Items.Add(new ListViewItem(new string[] { "Tổng tiền", totalPrice.ToString("N0") }));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số ngày ở là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng và nhập số ngày ở.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo thanh toán thành công và thoát chương trình
            MessageBox.Show("Bạn đã thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}

