namespace QLPhong
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxThuong = new System.Windows.Forms.CheckBox();
            this.checkBoxVIP = new System.Windows.Forms.CheckBox();
            this.lbGiaTienPhongThuong = new System.Windows.Forms.Label();
            this.lbGiaTienPhongVIP = new System.Windows.Forms.Label();
            this.lbSoNgayO = new System.Windows.Forms.Label();
            this.txtSoNgayO = new System.Windows.Forms.TextBox();
            this.lbDatPhong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxThuong
            // 
            this.checkBoxThuong.AutoSize = true;
            this.checkBoxThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxThuong.Location = new System.Drawing.Point(16, 26);
            this.checkBoxThuong.Name = "checkBoxThuong";
            this.checkBoxThuong.Size = new System.Drawing.Size(92, 24);
            this.checkBoxThuong.TabIndex = 1;
            this.checkBoxThuong.Text = "Thường";
            this.checkBoxThuong.UseVisualStyleBackColor = true;
            this.checkBoxThuong.CheckedChanged += new System.EventHandler(this.checkBoxThuong_CheckedChanged);
            // 
            // checkBoxVIP
            // 
            this.checkBoxVIP.AutoSize = true;
            this.checkBoxVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVIP.Location = new System.Drawing.Point(16, 56);
            this.checkBoxVIP.Name = "checkBoxVIP";
            this.checkBoxVIP.Size = new System.Drawing.Size(60, 24);
            this.checkBoxVIP.TabIndex = 2;
            this.checkBoxVIP.Text = "VIP";
            this.checkBoxVIP.UseVisualStyleBackColor = true;
            this.checkBoxVIP.CheckedChanged += new System.EventHandler(this.checkBoxVIP_CheckedChanged);
            // 
            // lbGiaTienPhongThuong
            // 
            this.lbGiaTienPhongThuong.AutoSize = true;
            this.lbGiaTienPhongThuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTienPhongThuong.Location = new System.Drawing.Point(128, 27);
            this.lbGiaTienPhongThuong.Name = "lbGiaTienPhongThuong";
            this.lbGiaTienPhongThuong.Size = new System.Drawing.Size(115, 19);
            this.lbGiaTienPhongThuong.TabIndex = 3;
            this.lbGiaTienPhongThuong.Text = ": 200.000 VNĐ";
            // 
            // lbGiaTienPhongVIP
            // 
            this.lbGiaTienPhongVIP.AutoSize = true;
            this.lbGiaTienPhongVIP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTienPhongVIP.Location = new System.Drawing.Point(128, 56);
            this.lbGiaTienPhongVIP.Name = "lbGiaTienPhongVIP";
            this.lbGiaTienPhongVIP.Size = new System.Drawing.Size(115, 19);
            this.lbGiaTienPhongVIP.TabIndex = 4;
            this.lbGiaTienPhongVIP.Text = ": 400.000 VNĐ";
            // 
            // lbSoNgayO
            // 
            this.lbSoNgayO.AutoSize = true;
            this.lbSoNgayO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNgayO.Location = new System.Drawing.Point(10, 102);
            this.lbSoNgayO.Name = "lbSoNgayO";
            this.lbSoNgayO.Size = new System.Drawing.Size(98, 20);
            this.lbSoNgayO.TabIndex = 5;
            this.lbSoNgayO.Text = "Số ngày ở:";
            // 
            // txtSoNgayO
            // 
            this.txtSoNgayO.Location = new System.Drawing.Point(132, 100);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new System.Drawing.Size(157, 22);
            this.txtSoNgayO.TabIndex = 6;
            this.txtSoNgayO.TextChanged += new System.EventHandler(this.txtSoNgayO_TextChanged_1);
            // 
            // lbDatPhong
            // 
            this.lbDatPhong.AutoSize = true;
            this.lbDatPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatPhong.Location = new System.Drawing.Point(386, 23);
            this.lbDatPhong.Name = "lbDatPhong";
            this.lbDatPhong.Size = new System.Drawing.Size(237, 25);
            this.lbDatPhong.TabIndex = 7;
            this.lbDatPhong.Text = "Đặt Phòng Khách Sạn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDatPhong);
            this.groupBox1.Controls.Add(this.txtSoNgayO);
            this.groupBox1.Controls.Add(this.lbSoNgayO);
            this.groupBox1.Controls.Add(this.lbGiaTienPhongVIP);
            this.groupBox1.Controls.Add(this.lbGiaTienPhongThuong);
            this.groupBox1.Controls.Add(this.checkBoxVIP);
            this.groupBox1.Controls.Add(this.checkBoxThuong);
            this.groupBox1.Location = new System.Drawing.Point(81, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 224);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt Phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Location = new System.Drawing.Point(492, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 224);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Location = new System.Drawing.Point(87, 153);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(126, 44);
            this.btnDatPhong.TabIndex = 7;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(155, 153);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(126, 44);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(257, 75);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(157, 34);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tổng số tiền cần thanh toán:";
            // 
            // QLPhong
            // 
            this.ClientSize = new System.Drawing.Size(971, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDatPhong);
            this.Name = "QLPhong";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtSoNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstLoaiPhong;
        private System.Windows.Forms.CheckBox checkBoxThuong;
        private System.Windows.Forms.CheckBox checkBoxVIP;
        private System.Windows.Forms.Label lbGiaTienPhongThuong;
        private System.Windows.Forms.Label lbGiaTienPhongVIP;
        private System.Windows.Forms.Label lbSoNgayO;
        private System.Windows.Forms.TextBox txtSoNgayO;
        private System.Windows.Forms.Label lbDatPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
    }
}

