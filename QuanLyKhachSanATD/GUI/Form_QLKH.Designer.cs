namespace QuanLyKhachSan.QLKH
{
    partial class Form_QLKH
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
            label8 = new Label();
            label10 = new Label();
            txtTimKiem = new TextBox();
            button1 = new Button();
            dtgKH = new DataGridView();
            btnThoat = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            cmbSex = new ComboBox();
            txtEmail = new TextBox();
            txtQuocTich = new TextBox();
            txtSDT = new TextBox();
            txtCCCD = new TextBox();
            btnXacNhan = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgKH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 157);
            label1.Name = "label1";
            label1.Size = new Size(158, 16);
            label1.TabIndex = 0;
            label1.Text = "Thông tin khách hàng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 11);
            label8.Name = "label8";
            label8.Size = new Size(74, 16);
            label8.TabIndex = 7;
            label8.Text = "Tìm kiếm:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(130, 11);
            label10.Name = "label10";
            label10.Size = new Size(114, 20);
            label10.TabIndex = 10;
            label10.Text = "Hộ Chiếu/CCCD";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(260, 8);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(239, 27);
            txtTimKiem.TabIndex = 11;
            txtTimKiem.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(525, 8);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 12;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtgKH
            // 
            dtgKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgKH.Location = new Point(37, 194);
            dtgKH.Name = "dtgKH";
            dtgKH.RowHeadersWidth = 51;
            dtgKH.Size = new Size(721, 266);
            dtgKH.TabIndex = 13;
            dtgKH.CellContentClick += dtgKH_CellContentClick;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ActiveCaption;
            btnThoat.Location = new Point(694, 466);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ActiveCaption;
            btnThem.Location = new Point(585, 466);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ActiveCaption;
            btnXoa.Location = new Point(476, 466);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 50);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 17;
            label2.Text = "Mã";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 89);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 18;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 127);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 19;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 50);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 20;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 89);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 21;
            label6.Text = "Quốc tịch";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(290, 127);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 22;
            label7.Text = "Số điện thoại ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(543, 93);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 23;
            label9.Text = "CCCD";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(103, 47);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(125, 27);
            txtMa.TabIndex = 24;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(103, 86);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 25;
            // 
            // cmbSex
            // 
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbSex.Location = new Point(103, 119);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(151, 28);
            cmbSex.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(391, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 27);
            txtEmail.TabIndex = 27;
            // 
            // txtQuocTich
            // 
            txtQuocTich.Location = new Point(391, 86);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.Size = new Size(125, 27);
            txtQuocTich.TabIndex = 28;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(391, 119);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 29;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(607, 86);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(181, 27);
            txtCCCD.TabIndex = 30;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = SystemColors.Highlight;
            btnXacNhan.Location = new Point(627, 125);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 31;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // Form_QLKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btnXacNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtSDT);
            Controls.Add(txtQuocTich);
            Controls.Add(txtEmail);
            Controls.Add(cmbSex);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(dtgKH);
            Controls.Add(button1);
            Controls.Add(txtTimKiem);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_QLKH";
            Text = "Form_QLKH";
            Load += Form_QLKH_Load;
            ((System.ComponentModel.ISupportInitialize)dtgKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button button1;
        private DataGridView dtgKH;
        private Button btnThoat;
        private Button btnThem;
        private Button btnXoa;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private TextBox txtMa;
        private TextBox txtTen;
        private ComboBox cmbSex;
        private TextBox txtEmail;
        private TextBox txtQuocTich;
        private TextBox txtSDT;
        private TextBox txtCCCD;
        private Button btnXacNhan;
    }
}