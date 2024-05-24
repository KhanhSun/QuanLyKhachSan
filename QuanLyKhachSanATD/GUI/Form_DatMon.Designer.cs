namespace QuanLyKhachSanATD.GUI
{
    partial class Form_DatMon
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
            txtMaKH = new TextBox();
            txtMaPhong = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbTenMon = new ComboBox();
            txtMaMon = new TextBox();
            btn_dat = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            txtThanhTien = new TextBox();
            label8 = new Label();
            txtSoLuong = new TextBox();
            label7 = new Label();
            txtGhiChu = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dgDatMon = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDatMon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 18);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "Đặt Món";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 20);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Khách Hàng:";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(131, 13);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(180, 27);
            txtMaKH.TabIndex = 2;
            txtMaKH.TextChanged += txtMaKH_TextChanged_1;
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(481, 13);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(186, 27);
            txtMaPhong.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 20);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã Phòng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 55);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Tên Món:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 100);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 6;
            label5.Text = "ID Món:";
            // 
            // cmbTenMon
            // 
            cmbTenMon.FormattingEnabled = true;
            cmbTenMon.Location = new Point(131, 52);
            cmbTenMon.Name = "cmbTenMon";
            cmbTenMon.Size = new Size(180, 28);
            cmbTenMon.TabIndex = 7;
            cmbTenMon.SelectedIndexChanged += cmbTenMon_SelectedIndexChanged;
            // 
            // txtMaMon
            // 
            txtMaMon.Location = new Point(481, 93);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(186, 27);
            txtMaMon.TabIndex = 8;
            // 
            // btn_dat
            // 
            btn_dat.Location = new Point(509, 411);
            btn_dat.Name = "btn_dat";
            btn_dat.Size = new Size(89, 27);
            btn_dat.TabIndex = 9;
            btn_dat.Text = "Đặt";
            btn_dat.UseVisualStyleBackColor = true;
            btn_dat.Click += btn_dat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(604, 411);
            button1.Name = "button1";
            button1.Size = new Size(89, 27);
            button1.TabIndex = 10;
            button1.Text = "Làm Mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(699, 411);
            button2.Name = "button2";
            button2.Size = new Size(89, 27);
            button2.TabIndex = 11;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMaMon);
            groupBox1.Controls.Add(cmbTenMon);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaPhong);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 171);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đặt Món";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(481, 132);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(186, 27);
            txtThanhTien.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(398, 139);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 13;
            label8.Text = "Thành Tiền:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(131, 93);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(180, 27);
            txtSoLuong.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 100);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 11;
            label7.Text = "Số Lượng:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(481, 52);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(186, 27);
            txtGhiChu.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(396, 60);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 9;
            label6.Text = "Ghi Chú:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgDatMon);
            groupBox2.Location = new Point(17, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(762, 189);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // dgDatMon
            // 
            dgDatMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatMon.Location = new Point(15, 15);
            dgDatMon.Name = "dgDatMon";
            dgDatMon.RowHeadersWidth = 51;
            dgDatMon.Size = new Size(729, 153);
            dgDatMon.TabIndex = 0;
            // 
            // Form_DatMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_dat);
            Controls.Add(label1);
            Name = "Form_DatMon";
            Text = "Form_DatMon";
            Load += Form_DatMon_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDatMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaKH;
        private TextBox txtMaPhong;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbTenMon;
        private TextBox txtMaMon;
        private Button btn_dat;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private TextBox txtGhiChu;
        private Label label6;
        private TextBox txtThanhTien;
        private Label label8;
        private TextBox txtSoLuong;
        private Label label7;
        private GroupBox groupBox2;
        private DataGridView dgDatMon;
    }
}