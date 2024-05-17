namespace QuanLyKhachSanATD.GUI
{
    partial class DatPhong
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
            label1 = new Label();
            label2 = new Label();
            ten = new TextBox();
            sdt = new TextBox();
            label3 = new Label();
            quoctich = new TextBox();
            label4 = new Label();
            label5 = new Label();
            gender = new ComboBox();
            label6 = new Label();
            dob = new DateTimePicker();
            diachi = new TextBox();
            label7 = new Label();
            madinhdanh = new TextBox();
            label8 = new Label();
            checkinday = new DateTimePicker();
            label9 = new Label();
            bed = new ComboBox();
            label10 = new Label();
            roomtype = new ComboBox();
            label11 = new Label();
            Rnum = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            total = new TextBox();
            label14 = new Label();
            Service = new ComboBox();
            button1 = new Button();
            ExitBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 0;
            label1.Text = "Đặt Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 86);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // ten
            // 
            ten.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ten.Location = new Point(34, 126);
            ten.Name = "ten";
            ten.PlaceholderText = "Nhập tên";
            ten.Size = new Size(258, 30);
            ten.TabIndex = 2;
            // 
            // sdt
            // 
            sdt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sdt.Location = new Point(34, 212);
            sdt.Name = "sdt";
            sdt.PlaceholderText = "Nhập số điện thoại";
            sdt.Size = new Size(258, 30);
            sdt.TabIndex = 4;
            sdt.TextChanged += sdt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 172);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại";
            // 
            // quoctich
            // 
            quoctich.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quoctich.Location = new Point(34, 303);
            quoctich.Name = "quoctich";
            quoctich.PlaceholderText = "Nhập quốc tịch";
            quoctich.Size = new Size(258, 30);
            quoctich.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 263);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 5;
            label4.Text = "Quốc tịch";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 352);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 7;
            label5.Text = "Giới tính";
            // 
            // gender
            // 
            gender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            gender.Location = new Point(34, 394);
            gender.Name = "gender";
            gender.Size = new Size(258, 31);
            gender.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 447);
            label6.Name = "label6";
            label6.Size = new Size(100, 28);
            label6.TabIndex = 9;
            label6.Text = "Ngày sinh";
            // 
            // dob
            // 
            dob.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dob.CustomFormat = "MM/dd/yyyy";
            dob.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dob.Format = DateTimePickerFormat.Custom;
            dob.Location = new Point(34, 491);
            dob.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dob.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dob.Name = "dob";
            dob.Size = new Size(258, 30);
            dob.TabIndex = 10;
            dob.Value = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            dob.ValueChanged += dob_ValueChanged;
            // 
            // diachi
            // 
            diachi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diachi.Location = new Point(397, 212);
            diachi.Name = "diachi";
            diachi.PlaceholderText = "Nhập địa chỉ";
            diachi.Size = new Size(258, 30);
            diachi.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(398, 172);
            label7.Name = "label7";
            label7.Size = new Size(73, 28);
            label7.TabIndex = 13;
            label7.Text = "Địa chỉ";
            // 
            // madinhdanh
            // 
            madinhdanh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            madinhdanh.Location = new Point(397, 126);
            madinhdanh.Name = "madinhdanh";
            madinhdanh.PlaceholderText = "Nhập mã định danh";
            madinhdanh.Size = new Size(258, 30);
            madinhdanh.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(398, 86);
            label8.Name = "label8";
            label8.Size = new Size(133, 28);
            label8.TabIndex = 11;
            label8.Text = "Mã định danh";
            // 
            // checkinday
            // 
            checkinday.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkinday.CustomFormat = "MM/dd/yyyy";
            checkinday.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkinday.Format = DateTimePickerFormat.Custom;
            checkinday.Location = new Point(396, 303);
            checkinday.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            checkinday.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            checkinday.Name = "checkinday";
            checkinday.Size = new Size(258, 30);
            checkinday.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(396, 263);
            label9.Name = "label9";
            label9.Size = new Size(135, 28);
            label9.TabIndex = 15;
            label9.Text = "Ngày đăng ký";
            // 
            // bed
            // 
            bed.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bed.FormattingEnabled = true;
            bed.Items.AddRange(new object[] { "Giường đơn", "Giường đôi", "Giường cao cấp" });
            bed.Location = new Point(763, 125);
            bed.Name = "bed";
            bed.Size = new Size(258, 31);
            bed.TabIndex = 18;
            bed.SelectedIndexChanged += bed_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(765, 83);
            label10.Name = "label10";
            label10.Size = new Size(76, 28);
            label10.TabIndex = 17;
            label10.Text = "Giường";
            // 
            // roomtype
            // 
            roomtype.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomtype.FormattingEnabled = true;
            roomtype.Items.AddRange(new object[] { "Phòng đơn", "Phòng đôi", "Phòng VIP" });
            roomtype.Location = new Point(763, 211);
            roomtype.Name = "roomtype";
            roomtype.Size = new Size(258, 31);
            roomtype.TabIndex = 20;
            roomtype.SelectedIndexChanged += roomtype_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(765, 169);
            label11.Name = "label11";
            label11.Size = new Size(109, 28);
            label11.TabIndex = 19;
            label11.Text = "Loại phòng";
            // 
            // Rnum
            // 
            Rnum.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rnum.FormattingEnabled = true;
            Rnum.Location = new Point(763, 302);
            Rnum.Name = "Rnum";
            Rnum.Size = new Size(258, 31);
            Rnum.TabIndex = 22;
            Rnum.SelectedIndexChanged += Rnum_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(765, 260);
            label12.Name = "label12";
            label12.Size = new Size(94, 28);
            label12.TabIndex = 21;
            label12.Text = "Số phòng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(764, 355);
            label13.Name = "label13";
            label13.Size = new Size(77, 28);
            label13.TabIndex = 23;
            label13.Text = "Dịch vụ";
            // 
            // total
            // 
            total.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.Location = new Point(765, 491);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(258, 30);
            total.TabIndex = 26;
            total.TextChanged += total_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(766, 451);
            label14.Name = "label14";
            label14.Size = new Size(80, 28);
            label14.TabIndex = 25;
            label14.Text = "Giá tiền";
            // 
            // Service
            // 
            Service.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Service.FormattingEnabled = true;
            Service.Location = new Point(765, 394);
            Service.Name = "Service";
            Service.Size = new Size(258, 31);
            Service.TabIndex = 27;
            Service.SelectedIndexChanged += Service_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(763, 575);
            button1.Name = "button1";
            button1.Size = new Size(260, 69);
            button1.TabIndex = 28;
            button1.Text = "Thêm khách hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ExitBTN
            // 
            ExitBTN.FlatAppearance.BorderSize = 0;
            ExitBTN.FlatStyle = FlatStyle.Flat;
            ExitBTN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBTN.Location = new Point(1007, 12);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(40, 38);
            ExitBTN.TabIndex = 29;
            ExitBTN.Text = "X";
            ExitBTN.UseVisualStyleBackColor = true;
            ExitBTN.Click += ExitBTN_Click;
            // 
            // DatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1059, 656);
            Controls.Add(ExitBTN);
            Controls.Add(button1);
            Controls.Add(Service);
            Controls.Add(total);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(Rnum);
            Controls.Add(label12);
            Controls.Add(roomtype);
            Controls.Add(label11);
            Controls.Add(bed);
            Controls.Add(label10);
            Controls.Add(checkinday);
            Controls.Add(label9);
            Controls.Add(diachi);
            Controls.Add(label7);
            Controls.Add(madinhdanh);
            Controls.Add(label8);
            Controls.Add(dob);
            Controls.Add(label6);
            Controls.Add(gender);
            Controls.Add(label5);
            Controls.Add(quoctich);
            Controls.Add(label4);
            Controls.Add(sdt);
            Controls.Add(label3);
            Controls.Add(ten);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DatPhong";
            Load += DatPhong_Load;
            Leave += DatPhong_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ten;
        private TextBox sdt;
        private Label label3;
        private TextBox quoctich;
        private Label label4;
        private Label label5;
        private ComboBox gender;
        private Label label6;
        private DateTimePicker dob;
        private TextBox diachi;
        private Label label7;
        private TextBox madinhdanh;
        private Label label8;
        private DateTimePicker checkinday;
        private Label label9;
        private ComboBox bed;
        private Label label10;
        private ComboBox roomtype;
        private Label label11;
        private ComboBox Rnum;
        private Label label12;
        private Label label13;
        private TextBox total;
        private Label label14;
        private ComboBox Service;
        private Button button1;
        private Button ExitBTN;
    }
}