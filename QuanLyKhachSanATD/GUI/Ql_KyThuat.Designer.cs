namespace QL_KyThuat
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
            this.txtMaThietBi = new System.Windows.Forms.TextBox();
            this.txtMoTaCongViec = new System.Windows.Forms.TextBox();
            this.txtMaBaoTri = new System.Windows.Forms.TextBox();
            this.txtMoTaSuaChua = new System.Windows.Forms.TextBox();
            this.txtChiPhiSuaChua = new System.Windows.Forms.TextBox();
            this.dtpNgayBaoTri = new System.Windows.Forms.DateTimePicker();
            this.cboTrangThaiBaoTri = new System.Windows.Forms.ComboBox();
            this.btnLichBaoTri = new System.Windows.Forms.Button();
            this.btnXacNhanSua = new System.Windows.Forms.Button();
            this.btnLuuChiPhi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThietBi.Location = new System.Drawing.Point(130, 59);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Size = new System.Drawing.Size(173, 27);
            this.txtMaThietBi.TabIndex = 0;
            // 
            // txtMoTaCongViec
            // 
            this.txtMoTaCongViec.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTaCongViec.Location = new System.Drawing.Point(130, 116);
            this.txtMoTaCongViec.Name = "txtMoTaCongViec";
            this.txtMoTaCongViec.Size = new System.Drawing.Size(173, 27);
            this.txtMoTaCongViec.TabIndex = 1;
            // 
            // txtMaBaoTri
            // 
            this.txtMaBaoTri.Location = new System.Drawing.Point(139, 59);
            this.txtMaBaoTri.Name = "txtMaBaoTri";
            this.txtMaBaoTri.Size = new System.Drawing.Size(159, 30);
            this.txtMaBaoTri.TabIndex = 2;
            // 
            // txtMoTaSuaChua
            // 
            this.txtMoTaSuaChua.Location = new System.Drawing.Point(199, 116);
            this.txtMoTaSuaChua.Name = "txtMoTaSuaChua";
            this.txtMoTaSuaChua.Size = new System.Drawing.Size(191, 30);
            this.txtMoTaSuaChua.TabIndex = 3;
            // 
            // txtChiPhiSuaChua
            // 
            this.txtChiPhiSuaChua.Location = new System.Drawing.Point(199, 60);
            this.txtChiPhiSuaChua.Name = "txtChiPhiSuaChua";
            this.txtChiPhiSuaChua.Size = new System.Drawing.Size(191, 30);
            this.txtChiPhiSuaChua.TabIndex = 4;
            // 
            // dtpNgayBaoTri
            // 
            this.dtpNgayBaoTri.Location = new System.Drawing.Point(34, 198);
            this.dtpNgayBaoTri.Name = "dtpNgayBaoTri";
            this.dtpNgayBaoTri.Size = new System.Drawing.Size(269, 30);
            this.dtpNgayBaoTri.TabIndex = 5;
            // 
            // cboTrangThaiBaoTri
            // 
            this.cboTrangThaiBaoTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThaiBaoTri.FormattingEnabled = true;
            this.cboTrangThaiBaoTri.Items.AddRange(new object[] {
            "Hoàn thành",
            "Đang xử lý"});
            this.cboTrangThaiBaoTri.Location = new System.Drawing.Point(139, 116);
            this.cboTrangThaiBaoTri.Name = "cboTrangThaiBaoTri";
            this.cboTrangThaiBaoTri.Size = new System.Drawing.Size(147, 31);
            this.cboTrangThaiBaoTri.TabIndex = 6;
            this.cboTrangThaiBaoTri.DropDown += new System.EventHandler(this.cboTrangThaiBaoTri_SelectedIndexChanged);
            this.cboTrangThaiBaoTri.SelectedIndexChanged += new System.EventHandler(this.cboTrangThaiBaoTri_SelectedIndexChanged);
            this.cboTrangThaiBaoTri.Click += new System.EventHandler(this.cboTrangThaiBaoTri_SelectedIndexChanged);
            this.cboTrangThaiBaoTri.MouseCaptureChanged += new System.EventHandler(this.cboTrangThaiBaoTri_SelectedIndexChanged);
            // 
            // btnLichBaoTri
            // 
            this.btnLichBaoTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichBaoTri.Location = new System.Drawing.Point(83, 275);
            this.btnLichBaoTri.Name = "btnLichBaoTri";
            this.btnLichBaoTri.Size = new System.Drawing.Size(164, 37);
            this.btnLichBaoTri.TabIndex = 7;
            this.btnLichBaoTri.Text = "Lên lịch bảo trì";
            this.btnLichBaoTri.UseVisualStyleBackColor = true;
            this.btnLichBaoTri.Click += new System.EventHandler(this.btnLichBaoTri_Click);
            // 
            // btnXacNhanSua
            // 
            this.btnXacNhanSua.Location = new System.Drawing.Point(111, 275);
            this.btnXacNhanSua.Name = "btnXacNhanSua";
            this.btnXacNhanSua.Size = new System.Drawing.Size(100, 38);
            this.btnXacNhanSua.TabIndex = 8;
            this.btnXacNhanSua.Text = "Xác nhận";
            this.btnXacNhanSua.UseVisualStyleBackColor = true;
            this.btnXacNhanSua.Click += new System.EventHandler(this.btnXacNhanSua_Click);
            // 
            // btnLuuChiPhi
            // 
            this.btnLuuChiPhi.Location = new System.Drawing.Point(177, 274);
            this.btnLuuChiPhi.Name = "btnLuuChiPhi";
            this.btnLuuChiPhi.Size = new System.Drawing.Size(86, 38);
            this.btnLuuChiPhi.TabIndex = 9;
            this.btnLuuChiPhi.Text = "Lưu";
            this.btnLuuChiPhi.UseVisualStyleBackColor = true;
            this.btnLuuChiPhi.Click += new System.EventHandler(this.btnLuuChiPhi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLichBaoTri);
            this.groupBox1.Controls.Add(this.txtMaThietBi);
            this.groupBox1.Controls.Add(this.txtMoTaCongViec);
            this.groupBox1.Controls.Add(this.dtpNgayBaoTri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 336);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch bảo trì";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Thiết Bị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mô Tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chi Phí Sửa Chữa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mô Tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Trạng Thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã Bảo Trì:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.cboTrangThaiBaoTri);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMaBaoTri);
            this.groupBox2.Controls.Add(this.btnXacNhanSua);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 336);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập Nhật";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.txtChiPhiSuaChua);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnLuuChiPhi);
            this.groupBox3.Controls.Add(this.txtMoTaSuaChua);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(746, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 336);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Phí";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 413);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaThietBi;
        private System.Windows.Forms.TextBox txtMoTaCongViec;
        private System.Windows.Forms.TextBox txtMaBaoTri;
        private System.Windows.Forms.TextBox txtMoTaSuaChua;
        private System.Windows.Forms.TextBox txtChiPhiSuaChua;
        private System.Windows.Forms.DateTimePicker dtpNgayBaoTri;
        private System.Windows.Forms.ComboBox cboTrangThaiBaoTri;
        private System.Windows.Forms.Button btnLichBaoTri;
        private System.Windows.Forms.Button btnXacNhanSua;
        private System.Windows.Forms.Button btnLuuChiPhi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

