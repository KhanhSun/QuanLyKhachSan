namespace QLPhong_QLKyThuat
{
    partial class frmMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTrangChu = new System.Windows.Forms.TabPage();
            this.tabQLPhong = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTimKiemPhong = new System.Windows.Forms.TabPage();
            this.dataGridView_TKP = new System.Windows.Forms.DataGridView();
            this.lbLoaiPhong_TKP = new System.Windows.Forms.Label();
            this.lbTinhTrangPhong_TKP = new System.Windows.Forms.Label();
            this.lbSoPhong_TKP = new System.Windows.Forms.Label();
            this.lbTimKiemPhong = new System.Windows.Forms.Label();
            this.grBox_TKP = new System.Windows.Forms.GroupBox();
            this.btnCapNhat_TKP = new System.Windows.Forms.Button();
            this.btnTimKQLP_TKP = new System.Windows.Forms.Button();
            this.txtGiaTien_TKP = new System.Windows.Forms.TextBox();
            this.lbGiaTien_TKP = new System.Windows.Forms.Label();
            this.txtGiuong_TKP = new System.Windows.Forms.TextBox();
            this.lbGiuong_TKP = new System.Windows.Forms.Label();
            this.txtLoaiPhong_TKP = new System.Windows.Forms.TextBox();
            this.txtTinhTrangPhong_TKP = new System.Windows.Forms.TextBox();
            this.txtSoPhong_TKP = new System.Windows.Forms.TextBox();
            this.tabQuanLyPhong = new System.Windows.Forms.TabPage();
            this.dataGridView_QLP = new System.Windows.Forms.DataGridView();
            this.btnSua_QLP = new System.Windows.Forms.Button();
            this.btnXoa_QLP = new System.Windows.Forms.Button();
            this.btnThem_QLP = new System.Windows.Forms.Button();
            this.txtGiaTien_QLP = new System.Windows.Forms.TextBox();
            this.txtGiuong_QLP = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong_QLP = new System.Windows.Forms.TextBox();
            this.txtTinhTrangPhong_QLP = new System.Windows.Forms.TextBox();
            this.txtSoPhong_QLP = new System.Windows.Forms.TextBox();
            this.lbGiaTien_QLP = new System.Windows.Forms.Label();
            this.lbLoaiPhong_QLP = new System.Windows.Forms.Label();
            this.lbGiuong_QLP = new System.Windows.Forms.Label();
            this.lbTinhTrangPhong_QLP = new System.Windows.Forms.Label();
            this.lbSoPhong_QLP = new System.Windows.Forms.Label();
            this.lbQuanLyPhong = new System.Windows.Forms.Label();
            this.grBox_QLP = new System.Windows.Forms.GroupBox();
            this.tabQLKyThuat = new System.Windows.Forms.TabPage();
            this.dataGridView_QLKT = new System.Windows.Forms.DataGridView();
            this.lbQuanLyKyThuat = new System.Windows.Forms.Label();
            this.grBox_QLKT = new System.Windows.Forms.GroupBox();
            this.btnCapNhat_QLKT = new System.Windows.Forms.Button();
            this.txtTinhTrangPhong_QLKT = new System.Windows.Forms.TextBox();
            this.btnTimKiem_QLKT = new System.Windows.Forms.Button();
            this.lbTinhTrangPhong_QLKT = new System.Windows.Forms.Label();
            this.txtGiaTien_QLKT = new System.Windows.Forms.TextBox();
            this.btnThem_QLKT = new System.Windows.Forms.Button();
            this.lbTienPhuCap_QLKT = new System.Windows.Forms.Label();
            this.txtMoTa_QLKT = new System.Windows.Forms.TextBox();
            this.lbSoPhong_QLKT = new System.Windows.Forms.Label();
            this.txtSoPhong_QLKT = new System.Windows.Forms.TextBox();
            this.lbMoTa_QLKT = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThoat_QLKT = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabQLPhong.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTimKiemPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TKP)).BeginInit();
            this.grBox_TKP.SuspendLayout();
            this.tabQuanLyPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLP)).BeginInit();
            this.tabQLKyThuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLKT)).BeginInit();
            this.grBox_QLKT.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTrangChu);
            this.tabControl.Controls.Add(this.tabQLPhong);
            this.tabControl.Controls.Add(this.tabQLKyThuat);
            this.tabControl.Location = new System.Drawing.Point(5, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1239, 528);
            this.tabControl.TabIndex = 0;
            // 
            // tabTrangChu
            // 
            this.tabTrangChu.Location = new System.Drawing.Point(4, 25);
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrangChu.Size = new System.Drawing.Size(1231, 499);
            this.tabTrangChu.TabIndex = 0;
            this.tabTrangChu.Text = "Trang Chủ";
            this.tabTrangChu.UseVisualStyleBackColor = true;
            // 
            // tabQLPhong
            // 
            this.tabQLPhong.Controls.Add(this.tabControl1);
            this.tabQLPhong.Location = new System.Drawing.Point(4, 25);
            this.tabQLPhong.Name = "tabQLPhong";
            this.tabQLPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLPhong.Size = new System.Drawing.Size(1231, 499);
            this.tabQLPhong.TabIndex = 1;
            this.tabQLPhong.Text = "Phòng";
            this.tabQLPhong.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTimKiemPhong);
            this.tabControl1.Controls.Add(this.tabQuanLyPhong);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1229, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTimKiemPhong
            // 
            this.tabTimKiemPhong.Controls.Add(this.dataGridView_TKP);
            this.tabTimKiemPhong.Controls.Add(this.lbLoaiPhong_TKP);
            this.tabTimKiemPhong.Controls.Add(this.lbTinhTrangPhong_TKP);
            this.tabTimKiemPhong.Controls.Add(this.lbSoPhong_TKP);
            this.tabTimKiemPhong.Controls.Add(this.lbTimKiemPhong);
            this.tabTimKiemPhong.Controls.Add(this.grBox_TKP);
            this.tabTimKiemPhong.Location = new System.Drawing.Point(4, 25);
            this.tabTimKiemPhong.Name = "tabTimKiemPhong";
            this.tabTimKiemPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimKiemPhong.Size = new System.Drawing.Size(1221, 458);
            this.tabTimKiemPhong.TabIndex = 0;
            this.tabTimKiemPhong.Text = "Tìm Kiếm Phòng";
            this.tabTimKiemPhong.UseVisualStyleBackColor = true;
            // 
            // dataGridView_TKP
            // 
            this.dataGridView_TKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TKP.Location = new System.Drawing.Point(4, 260);
            this.dataGridView_TKP.Name = "dataGridView_TKP";
            this.dataGridView_TKP.RowHeadersWidth = 51;
            this.dataGridView_TKP.RowTemplate.Height = 24;
            this.dataGridView_TKP.Size = new System.Drawing.Size(1221, 198);
            this.dataGridView_TKP.TabIndex = 7;
            this.dataGridView_TKP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TKP_CellClick);
            // 
            // lbLoaiPhong_TKP
            // 
            this.lbLoaiPhong_TKP.AutoSize = true;
            this.lbLoaiPhong_TKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhong_TKP.Location = new System.Drawing.Point(47, 159);
            this.lbLoaiPhong_TKP.Name = "lbLoaiPhong_TKP";
            this.lbLoaiPhong_TKP.Size = new System.Drawing.Size(117, 22);
            this.lbLoaiPhong_TKP.TabIndex = 3;
            this.lbLoaiPhong_TKP.Text = "Loại Phòng:";
            // 
            // lbTinhTrangPhong_TKP
            // 
            this.lbTinhTrangPhong_TKP.AutoSize = true;
            this.lbTinhTrangPhong_TKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrangPhong_TKP.Location = new System.Drawing.Point(47, 113);
            this.lbTinhTrangPhong_TKP.Name = "lbTinhTrangPhong_TKP";
            this.lbTinhTrangPhong_TKP.Size = new System.Drawing.Size(178, 22);
            this.lbTinhTrangPhong_TKP.TabIndex = 2;
            this.lbTinhTrangPhong_TKP.Text = "Tình Trạng Phòng:";
            // 
            // lbSoPhong_TKP
            // 
            this.lbSoPhong_TKP.AutoSize = true;
            this.lbSoPhong_TKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhong_TKP.Location = new System.Drawing.Point(47, 61);
            this.lbSoPhong_TKP.Name = "lbSoPhong_TKP";
            this.lbSoPhong_TKP.Size = new System.Drawing.Size(103, 22);
            this.lbSoPhong_TKP.TabIndex = 1;
            this.lbSoPhong_TKP.Text = "Số Phòng:";
            // 
            // lbTimKiemPhong
            // 
            this.lbTimKiemPhong.AutoSize = true;
            this.lbTimKiemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiemPhong.Location = new System.Drawing.Point(479, 0);
            this.lbTimKiemPhong.Name = "lbTimKiemPhong";
            this.lbTimKiemPhong.Size = new System.Drawing.Size(271, 38);
            this.lbTimKiemPhong.TabIndex = 0;
            this.lbTimKiemPhong.Text = "Tìm Kiếm Phòng";
            // 
            // grBox_TKP
            // 
            this.grBox_TKP.Controls.Add(this.btnCapNhat_TKP);
            this.grBox_TKP.Controls.Add(this.btnTimKQLP_TKP);
            this.grBox_TKP.Controls.Add(this.txtGiaTien_TKP);
            this.grBox_TKP.Controls.Add(this.lbGiaTien_TKP);
            this.grBox_TKP.Controls.Add(this.txtGiuong_TKP);
            this.grBox_TKP.Controls.Add(this.lbGiuong_TKP);
            this.grBox_TKP.Controls.Add(this.txtLoaiPhong_TKP);
            this.grBox_TKP.Controls.Add(this.txtTinhTrangPhong_TKP);
            this.grBox_TKP.Controls.Add(this.txtSoPhong_TKP);
            this.grBox_TKP.Location = new System.Drawing.Point(36, 44);
            this.grBox_TKP.Name = "grBox_TKP";
            this.grBox_TKP.Size = new System.Drawing.Size(1114, 207);
            this.grBox_TKP.TabIndex = 6;
            this.grBox_TKP.TabStop = false;
            // 
            // btnCapNhat_TKP
            // 
            this.btnCapNhat_TKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat_TKP.Location = new System.Drawing.Point(834, 146);
            this.btnCapNhat_TKP.Name = "btnCapNhat_TKP";
            this.btnCapNhat_TKP.Size = new System.Drawing.Size(102, 40);
            this.btnCapNhat_TKP.TabIndex = 8;
            this.btnCapNhat_TKP.Text = "Cập Nhật";
            this.btnCapNhat_TKP.UseVisualStyleBackColor = true;
            this.btnCapNhat_TKP.Click += new System.EventHandler(this.btnCapNhat_TKP_Click);
            // 
            // btnTimKQLP_TKP
            // 
            this.btnTimKQLP_TKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKQLP_TKP.Location = new System.Drawing.Point(677, 146);
            this.btnTimKQLP_TKP.Name = "btnTimKQLP_TKP";
            this.btnTimKQLP_TKP.Size = new System.Drawing.Size(102, 40);
            this.btnTimKQLP_TKP.TabIndex = 7;
            this.btnTimKQLP_TKP.Text = "Tìm Kiếm";
            this.btnTimKQLP_TKP.UseVisualStyleBackColor = true;
            // 
            // txtGiaTien_TKP
            // 
            this.txtGiaTien_TKP.Location = new System.Drawing.Point(774, 71);
            this.txtGiaTien_TKP.Name = "txtGiaTien_TKP";
            this.txtGiaTien_TKP.Size = new System.Drawing.Size(304, 22);
            this.txtGiaTien_TKP.TabIndex = 6;
            // 
            // lbGiaTien_TKP
            // 
            this.lbGiaTien_TKP.AutoSize = true;
            this.lbGiaTien_TKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTien_TKP.Location = new System.Drawing.Point(673, 67);
            this.lbGiaTien_TKP.Name = "lbGiaTien_TKP";
            this.lbGiaTien_TKP.Size = new System.Drawing.Size(93, 22);
            this.lbGiaTien_TKP.TabIndex = 5;
            this.lbGiaTien_TKP.Text = "Giá Tiền:";
            // 
            // txtGiuong_TKP
            // 
            this.txtGiuong_TKP.Location = new System.Drawing.Point(774, 17);
            this.txtGiuong_TKP.Name = "txtGiuong_TKP";
            this.txtGiuong_TKP.Size = new System.Drawing.Size(304, 22);
            this.txtGiuong_TKP.TabIndex = 3;
            // 
            // lbGiuong_TKP
            // 
            this.lbGiuong_TKP.AutoSize = true;
            this.lbGiuong_TKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiuong_TKP.Location = new System.Drawing.Point(673, 21);
            this.lbGiuong_TKP.Name = "lbGiuong_TKP";
            this.lbGiuong_TKP.Size = new System.Drawing.Size(86, 22);
            this.lbGiuong_TKP.TabIndex = 4;
            this.lbGiuong_TKP.Text = "Giường: ";
            // 
            // txtLoaiPhong_TKP
            // 
            this.txtLoaiPhong_TKP.Location = new System.Drawing.Point(201, 115);
            this.txtLoaiPhong_TKP.Name = "txtLoaiPhong_TKP";
            this.txtLoaiPhong_TKP.Size = new System.Drawing.Size(274, 22);
            this.txtLoaiPhong_TKP.TabIndex = 2;
            // 
            // txtTinhTrangPhong_TKP
            // 
            this.txtTinhTrangPhong_TKP.Location = new System.Drawing.Point(201, 69);
            this.txtTinhTrangPhong_TKP.Name = "txtTinhTrangPhong_TKP";
            this.txtTinhTrangPhong_TKP.Size = new System.Drawing.Size(274, 22);
            this.txtTinhTrangPhong_TKP.TabIndex = 1;
            // 
            // txtSoPhong_TKP
            // 
            this.txtSoPhong_TKP.Location = new System.Drawing.Point(201, 21);
            this.txtSoPhong_TKP.Name = "txtSoPhong_TKP";
            this.txtSoPhong_TKP.Size = new System.Drawing.Size(274, 22);
            this.txtSoPhong_TKP.TabIndex = 0;
            // 
            // tabQuanLyPhong
            // 
            this.tabQuanLyPhong.Controls.Add(this.dataGridView_QLP);
            this.tabQuanLyPhong.Controls.Add(this.btnSua_QLP);
            this.tabQuanLyPhong.Controls.Add(this.btnXoa_QLP);
            this.tabQuanLyPhong.Controls.Add(this.btnThem_QLP);
            this.tabQuanLyPhong.Controls.Add(this.txtGiaTien_QLP);
            this.tabQuanLyPhong.Controls.Add(this.txtGiuong_QLP);
            this.tabQuanLyPhong.Controls.Add(this.txtLoaiPhong_QLP);
            this.tabQuanLyPhong.Controls.Add(this.txtTinhTrangPhong_QLP);
            this.tabQuanLyPhong.Controls.Add(this.txtSoPhong_QLP);
            this.tabQuanLyPhong.Controls.Add(this.lbGiaTien_QLP);
            this.tabQuanLyPhong.Controls.Add(this.lbLoaiPhong_QLP);
            this.tabQuanLyPhong.Controls.Add(this.lbGiuong_QLP);
            this.tabQuanLyPhong.Controls.Add(this.lbTinhTrangPhong_QLP);
            this.tabQuanLyPhong.Controls.Add(this.lbSoPhong_QLP);
            this.tabQuanLyPhong.Controls.Add(this.lbQuanLyPhong);
            this.tabQuanLyPhong.Controls.Add(this.grBox_QLP);
            this.tabQuanLyPhong.Location = new System.Drawing.Point(4, 25);
            this.tabQuanLyPhong.Name = "tabQuanLyPhong";
            this.tabQuanLyPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyPhong.Size = new System.Drawing.Size(1221, 458);
            this.tabQuanLyPhong.TabIndex = 2;
            this.tabQuanLyPhong.Text = "Quản Lý Phòng";
            this.tabQuanLyPhong.UseVisualStyleBackColor = true;
            // 
            // dataGridView_QLP
            // 
            this.dataGridView_QLP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QLP.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView_QLP.Location = new System.Drawing.Point(0, 254);
            this.dataGridView_QLP.Name = "dataGridView_QLP";
            this.dataGridView_QLP.RowHeadersWidth = 51;
            this.dataGridView_QLP.RowTemplate.Height = 24;
            this.dataGridView_QLP.Size = new System.Drawing.Size(1221, 208);
            this.dataGridView_QLP.TabIndex = 16;
            this.dataGridView_QLP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_QLP_CellClick);
            // 
            // btnSua_QLP
            // 
            this.btnSua_QLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_QLP.Location = new System.Drawing.Point(1039, 207);
            this.btnSua_QLP.Name = "btnSua_QLP";
            this.btnSua_QLP.Size = new System.Drawing.Size(76, 35);
            this.btnSua_QLP.TabIndex = 14;
            this.btnSua_QLP.Text = "Sửa";
            this.btnSua_QLP.UseVisualStyleBackColor = true;
            this.btnSua_QLP.Click += new System.EventHandler(this.btnSua_QLP_Click);
            // 
            // btnXoa_QLP
            // 
            this.btnXoa_QLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_QLP.Location = new System.Drawing.Point(901, 207);
            this.btnXoa_QLP.Name = "btnXoa_QLP";
            this.btnXoa_QLP.Size = new System.Drawing.Size(76, 35);
            this.btnXoa_QLP.TabIndex = 13;
            this.btnXoa_QLP.Text = "Xóa";
            this.btnXoa_QLP.UseVisualStyleBackColor = true;
            this.btnXoa_QLP.Click += new System.EventHandler(this.btnXoa_QLP_Click);
            // 
            // btnThem_QLP
            // 
            this.btnThem_QLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_QLP.Location = new System.Drawing.Point(773, 207);
            this.btnThem_QLP.Name = "btnThem_QLP";
            this.btnThem_QLP.Size = new System.Drawing.Size(76, 35);
            this.btnThem_QLP.TabIndex = 12;
            this.btnThem_QLP.Text = "Thêm";
            this.btnThem_QLP.UseVisualStyleBackColor = true;
            this.btnThem_QLP.Click += new System.EventHandler(this.btnThem_QLP_Click);
            // 
            // txtGiaTien_QLP
            // 
            this.txtGiaTien_QLP.Location = new System.Drawing.Point(870, 117);
            this.txtGiaTien_QLP.Name = "txtGiaTien_QLP";
            this.txtGiaTien_QLP.Size = new System.Drawing.Size(216, 22);
            this.txtGiaTien_QLP.TabIndex = 11;
            // 
            // txtGiuong_QLP
            // 
            this.txtGiuong_QLP.Location = new System.Drawing.Point(870, 73);
            this.txtGiuong_QLP.Name = "txtGiuong_QLP";
            this.txtGiuong_QLP.Size = new System.Drawing.Size(216, 22);
            this.txtGiuong_QLP.TabIndex = 10;
            // 
            // txtLoaiPhong_QLP
            // 
            this.txtLoaiPhong_QLP.Location = new System.Drawing.Point(233, 159);
            this.txtLoaiPhong_QLP.Name = "txtLoaiPhong_QLP";
            this.txtLoaiPhong_QLP.Size = new System.Drawing.Size(216, 22);
            this.txtLoaiPhong_QLP.TabIndex = 9;
            // 
            // txtTinhTrangPhong_QLP
            // 
            this.txtTinhTrangPhong_QLP.Location = new System.Drawing.Point(233, 117);
            this.txtTinhTrangPhong_QLP.Name = "txtTinhTrangPhong_QLP";
            this.txtTinhTrangPhong_QLP.Size = new System.Drawing.Size(216, 22);
            this.txtTinhTrangPhong_QLP.TabIndex = 8;
            // 
            // txtSoPhong_QLP
            // 
            this.txtSoPhong_QLP.Location = new System.Drawing.Point(233, 73);
            this.txtSoPhong_QLP.Name = "txtSoPhong_QLP";
            this.txtSoPhong_QLP.Size = new System.Drawing.Size(216, 22);
            this.txtSoPhong_QLP.TabIndex = 7;
            // 
            // lbGiaTien_QLP
            // 
            this.lbGiaTien_QLP.AutoSize = true;
            this.lbGiaTien_QLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaTien_QLP.Location = new System.Drawing.Point(769, 115);
            this.lbGiaTien_QLP.Name = "lbGiaTien_QLP";
            this.lbGiaTien_QLP.Size = new System.Drawing.Size(93, 22);
            this.lbGiaTien_QLP.TabIndex = 6;
            this.lbGiaTien_QLP.Text = "Giá Tiền:";
            // 
            // lbLoaiPhong_QLP
            // 
            this.lbLoaiPhong_QLP.AutoSize = true;
            this.lbLoaiPhong_QLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhong_QLP.Location = new System.Drawing.Point(43, 159);
            this.lbLoaiPhong_QLP.Name = "lbLoaiPhong_QLP";
            this.lbLoaiPhong_QLP.Size = new System.Drawing.Size(117, 22);
            this.lbLoaiPhong_QLP.TabIndex = 5;
            this.lbLoaiPhong_QLP.Text = "Loại Phòng:";
            // 
            // lbGiuong_QLP
            // 
            this.lbGiuong_QLP.AutoSize = true;
            this.lbGiuong_QLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiuong_QLP.Location = new System.Drawing.Point(769, 74);
            this.lbGiuong_QLP.Name = "lbGiuong_QLP";
            this.lbGiuong_QLP.Size = new System.Drawing.Size(80, 22);
            this.lbGiuong_QLP.TabIndex = 3;
            this.lbGiuong_QLP.Text = "Giường:";
            // 
            // lbTinhTrangPhong_QLP
            // 
            this.lbTinhTrangPhong_QLP.AutoSize = true;
            this.lbTinhTrangPhong_QLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrangPhong_QLP.Location = new System.Drawing.Point(43, 115);
            this.lbTinhTrangPhong_QLP.Name = "lbTinhTrangPhong_QLP";
            this.lbTinhTrangPhong_QLP.Size = new System.Drawing.Size(178, 22);
            this.lbTinhTrangPhong_QLP.TabIndex = 2;
            this.lbTinhTrangPhong_QLP.Text = "Tình Trạng Phòng:";
            // 
            // lbSoPhong_QLP
            // 
            this.lbSoPhong_QLP.AutoSize = true;
            this.lbSoPhong_QLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhong_QLP.Location = new System.Drawing.Point(43, 74);
            this.lbSoPhong_QLP.Name = "lbSoPhong_QLP";
            this.lbSoPhong_QLP.Size = new System.Drawing.Size(103, 22);
            this.lbSoPhong_QLP.TabIndex = 1;
            this.lbSoPhong_QLP.Text = "Số Phòng:";
            // 
            // lbQuanLyPhong
            // 
            this.lbQuanLyPhong.AutoSize = true;
            this.lbQuanLyPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyPhong.Location = new System.Drawing.Point(486, 3);
            this.lbQuanLyPhong.Name = "lbQuanLyPhong";
            this.lbQuanLyPhong.Size = new System.Drawing.Size(257, 38);
            this.lbQuanLyPhong.TabIndex = 0;
            this.lbQuanLyPhong.Text = "Quản Lý Phòng";
            // 
            // grBox_QLP
            // 
            this.grBox_QLP.Location = new System.Drawing.Point(28, 56);
            this.grBox_QLP.Name = "grBox_QLP";
            this.grBox_QLP.Size = new System.Drawing.Size(1122, 197);
            this.grBox_QLP.TabIndex = 15;
            this.grBox_QLP.TabStop = false;
            // 
            // tabQLKyThuat
            // 
            this.tabQLKyThuat.Controls.Add(this.dataGridView_QLKT);
            this.tabQLKyThuat.Controls.Add(this.lbQuanLyKyThuat);
            this.tabQLKyThuat.Controls.Add(this.grBox_QLKT);
            this.tabQLKyThuat.Location = new System.Drawing.Point(4, 25);
            this.tabQLKyThuat.Name = "tabQLKyThuat";
            this.tabQLKyThuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLKyThuat.Size = new System.Drawing.Size(1231, 499);
            this.tabQLKyThuat.TabIndex = 2;
            this.tabQLKyThuat.Text = "Kỹ Thuật";
            this.tabQLKyThuat.UseVisualStyleBackColor = true;
            // 
            // dataGridView_QLKT
            // 
            this.dataGridView_QLKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QLKT.Location = new System.Drawing.Point(4, 267);
            this.dataGridView_QLKT.Name = "dataGridView_QLKT";
            this.dataGridView_QLKT.RowHeadersWidth = 51;
            this.dataGridView_QLKT.RowTemplate.Height = 24;
            this.dataGridView_QLKT.Size = new System.Drawing.Size(1227, 236);
            this.dataGridView_QLKT.TabIndex = 10;
            this.dataGridView_QLKT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_QLKT_CellClick);
            // 
            // lbQuanLyKyThuat
            // 
            this.lbQuanLyKyThuat.AutoSize = true;
            this.lbQuanLyKyThuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyKyThuat.Location = new System.Drawing.Point(474, 3);
            this.lbQuanLyKyThuat.Name = "lbQuanLyKyThuat";
            this.lbQuanLyKyThuat.Size = new System.Drawing.Size(297, 38);
            this.lbQuanLyKyThuat.TabIndex = 0;
            this.lbQuanLyKyThuat.Text = "Quản Lý Kỹ Thuật";
            // 
            // grBox_QLKT
            // 
            this.grBox_QLKT.Controls.Add(this.btnCapNhat_QLKT);
            this.grBox_QLKT.Controls.Add(this.txtTinhTrangPhong_QLKT);
            this.grBox_QLKT.Controls.Add(this.btnTimKiem_QLKT);
            this.grBox_QLKT.Controls.Add(this.lbTinhTrangPhong_QLKT);
            this.grBox_QLKT.Controls.Add(this.txtGiaTien_QLKT);
            this.grBox_QLKT.Controls.Add(this.btnThem_QLKT);
            this.grBox_QLKT.Controls.Add(this.lbTienPhuCap_QLKT);
            this.grBox_QLKT.Controls.Add(this.txtMoTa_QLKT);
            this.grBox_QLKT.Controls.Add(this.lbSoPhong_QLKT);
            this.grBox_QLKT.Controls.Add(this.txtSoPhong_QLKT);
            this.grBox_QLKT.Controls.Add(this.lbMoTa_QLKT);
            this.grBox_QLKT.Location = new System.Drawing.Point(34, 45);
            this.grBox_QLKT.Name = "grBox_QLKT";
            this.grBox_QLKT.Size = new System.Drawing.Size(1155, 195);
            this.grBox_QLKT.TabIndex = 9;
            this.grBox_QLKT.TabStop = false;
            // 
            // btnCapNhat_QLKT
            // 
            this.btnCapNhat_QLKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat_QLKT.Location = new System.Drawing.Point(964, 153);
            this.btnCapNhat_QLKT.Name = "btnCapNhat_QLKT";
            this.btnCapNhat_QLKT.Size = new System.Drawing.Size(96, 36);
            this.btnCapNhat_QLKT.TabIndex = 11;
            this.btnCapNhat_QLKT.Text = "Cập Nhật";
            this.btnCapNhat_QLKT.UseVisualStyleBackColor = true;
            this.btnCapNhat_QLKT.Click += new System.EventHandler(this.btnCapNhat_QLKT_Click);
            // 
            // txtTinhTrangPhong_QLKT
            // 
            this.txtTinhTrangPhong_QLKT.Location = new System.Drawing.Point(857, 21);
            this.txtTinhTrangPhong_QLKT.Name = "txtTinhTrangPhong_QLKT";
            this.txtTinhTrangPhong_QLKT.Size = new System.Drawing.Size(263, 22);
            this.txtTinhTrangPhong_QLKT.TabIndex = 8;
            // 
            // btnTimKiem_QLKT
            // 
            this.btnTimKiem_QLKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_QLKT.Location = new System.Drawing.Point(793, 153);
            this.btnTimKiem_QLKT.Name = "btnTimKiem_QLKT";
            this.btnTimKiem_QLKT.Size = new System.Drawing.Size(96, 36);
            this.btnTimKiem_QLKT.TabIndex = 10;
            this.btnTimKiem_QLKT.Text = "Tìm Kiếm";
            this.btnTimKiem_QLKT.UseVisualStyleBackColor = true;
            // 
            // lbTinhTrangPhong_QLKT
            // 
            this.lbTinhTrangPhong_QLKT.AutoSize = true;
            this.lbTinhTrangPhong_QLKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrangPhong_QLKT.Location = new System.Drawing.Point(712, 18);
            this.lbTinhTrangPhong_QLKT.Name = "lbTinhTrangPhong_QLKT";
            this.lbTinhTrangPhong_QLKT.Size = new System.Drawing.Size(115, 22);
            this.lbTinhTrangPhong_QLKT.TabIndex = 3;
            this.lbTinhTrangPhong_QLKT.Text = "Tình Trạng:";
            // 
            // txtGiaTien_QLKT
            // 
            this.txtGiaTien_QLKT.Location = new System.Drawing.Point(857, 91);
            this.txtGiaTien_QLKT.Name = "txtGiaTien_QLKT";
            this.txtGiaTien_QLKT.Size = new System.Drawing.Size(263, 22);
            this.txtGiaTien_QLKT.TabIndex = 7;
            // 
            // btnThem_QLKT
            // 
            this.btnThem_QLKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_QLKT.Location = new System.Drawing.Point(634, 153);
            this.btnThem_QLKT.Name = "btnThem_QLKT";
            this.btnThem_QLKT.Size = new System.Drawing.Size(96, 36);
            this.btnThem_QLKT.TabIndex = 0;
            this.btnThem_QLKT.Text = "Thêm";
            this.btnThem_QLKT.UseVisualStyleBackColor = true;
            this.btnThem_QLKT.Click += new System.EventHandler(this.btnThem_QLKT_Click);
            // 
            // lbTienPhuCap_QLKT
            // 
            this.lbTienPhuCap_QLKT.AutoSize = true;
            this.lbTienPhuCap_QLKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienPhuCap_QLKT.Location = new System.Drawing.Point(712, 91);
            this.lbTienPhuCap_QLKT.Name = "lbTienPhuCap_QLKT";
            this.lbTienPhuCap_QLKT.Size = new System.Drawing.Size(139, 22);
            this.lbTienPhuCap_QLKT.TabIndex = 4;
            this.lbTienPhuCap_QLKT.Text = "Tiền Phụ Cấp:";
            // 
            // txtMoTa_QLKT
            // 
            this.txtMoTa_QLKT.Location = new System.Drawing.Point(166, 89);
            this.txtMoTa_QLKT.Name = "txtMoTa_QLKT";
            this.txtMoTa_QLKT.Size = new System.Drawing.Size(263, 22);
            this.txtMoTa_QLKT.TabIndex = 6;
            // 
            // lbSoPhong_QLKT
            // 
            this.lbSoPhong_QLKT.AutoSize = true;
            this.lbSoPhong_QLKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhong_QLKT.Location = new System.Drawing.Point(32, 18);
            this.lbSoPhong_QLKT.Name = "lbSoPhong_QLKT";
            this.lbSoPhong_QLKT.Size = new System.Drawing.Size(103, 22);
            this.lbSoPhong_QLKT.TabIndex = 1;
            this.lbSoPhong_QLKT.Text = "Số Phòng:";
            // 
            // txtSoPhong_QLKT
            // 
            this.txtSoPhong_QLKT.Location = new System.Drawing.Point(166, 18);
            this.txtSoPhong_QLKT.Name = "txtSoPhong_QLKT";
            this.txtSoPhong_QLKT.Size = new System.Drawing.Size(263, 22);
            this.txtSoPhong_QLKT.TabIndex = 5;
            // 
            // lbMoTa_QLKT
            // 
            this.lbMoTa_QLKT.AutoSize = true;
            this.lbMoTa_QLKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoTa_QLKT.Location = new System.Drawing.Point(32, 89);
            this.lbMoTa_QLKT.Name = "lbMoTa_QLKT";
            this.lbMoTa_QLKT.Size = new System.Drawing.Size(72, 22);
            this.lbMoTa_QLKT.TabIndex = 2;
            this.lbMoTa_QLKT.Text = "Mô Tả:";
            // 
            // btnThoat_QLKT
            // 
            this.btnThoat_QLKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_QLKT.Location = new System.Drawing.Point(587, 546);
            this.btnThoat_QLKT.Name = "btnThoat_QLKT";
            this.btnThoat_QLKT.Size = new System.Drawing.Size(90, 35);
            this.btnThoat_QLKT.TabIndex = 1;
            this.btnThoat_QLKT.Text = "Thoát";
            this.btnThoat_QLKT.UseVisualStyleBackColor = true;
            this.btnThoat_QLKT.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 586);
            this.Controls.Add(this.btnThoat_QLKT);
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabQLPhong.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTimKiemPhong.ResumeLayout(false);
            this.tabTimKiemPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TKP)).EndInit();
            this.grBox_TKP.ResumeLayout(false);
            this.grBox_TKP.PerformLayout();
            this.tabQuanLyPhong.ResumeLayout(false);
            this.tabQuanLyPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLP)).EndInit();
            this.tabQLKyThuat.ResumeLayout(false);
            this.tabQLKyThuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QLKT)).EndInit();
            this.grBox_QLKT.ResumeLayout(false);
            this.grBox_QLKT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTrangChu;
        private System.Windows.Forms.TabPage tabQLPhong;
        private System.Windows.Forms.TabPage tabQLKyThuat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTimKiemPhong;
        private System.Windows.Forms.Label lbGiaTien_TKP;
        private System.Windows.Forms.Label lbGiuong_TKP;
        private System.Windows.Forms.Label lbLoaiPhong_TKP;
        private System.Windows.Forms.Label lbTinhTrangPhong_TKP;
        private System.Windows.Forms.Label lbSoPhong_TKP;
        private System.Windows.Forms.Label lbTimKiemPhong;
        private System.Windows.Forms.TabPage tabQuanLyPhong;
        private System.Windows.Forms.DataGridView dataGridView_QLP;
        private System.Windows.Forms.Button btnSua_QLP;
        private System.Windows.Forms.Button btnXoa_QLP;
        private System.Windows.Forms.Button btnThem_QLP;
        private System.Windows.Forms.TextBox txtGiaTien_QLP;
        private System.Windows.Forms.TextBox txtGiuong_QLP;
        private System.Windows.Forms.TextBox txtLoaiPhong_QLP;
        private System.Windows.Forms.TextBox txtTinhTrangPhong_QLP;
        private System.Windows.Forms.TextBox txtSoPhong_QLP;
        private System.Windows.Forms.Label lbGiaTien_QLP;
        private System.Windows.Forms.Label lbLoaiPhong_QLP;
        private System.Windows.Forms.Label lbGiuong_QLP;
        private System.Windows.Forms.Label lbTinhTrangPhong_QLP;
        private System.Windows.Forms.Label lbSoPhong_QLP;
        private System.Windows.Forms.Label lbQuanLyPhong;
        private System.Windows.Forms.GroupBox grBox_QLP;
        private System.Windows.Forms.DataGridView dataGridView_TKP;
        private System.Windows.Forms.GroupBox grBox_TKP;
        private System.Windows.Forms.Button btnCapNhat_TKP;
        private System.Windows.Forms.Button btnTimKQLP_TKP;
        private System.Windows.Forms.TextBox txtGiaTien_TKP;
        private System.Windows.Forms.TextBox txtGiuong_TKP;
        private System.Windows.Forms.TextBox txtLoaiPhong_TKP;
        private System.Windows.Forms.TextBox txtTinhTrangPhong_TKP;
        private System.Windows.Forms.TextBox txtSoPhong_TKP;
        private System.Windows.Forms.Label lbSoPhong_QLKT;
        private System.Windows.Forms.Label lbQuanLyKyThuat;
        private System.Windows.Forms.TextBox txtTinhTrangPhong_QLKT;
        private System.Windows.Forms.TextBox txtGiaTien_QLKT;
        private System.Windows.Forms.TextBox txtMoTa_QLKT;
        private System.Windows.Forms.TextBox txtSoPhong_QLKT;
        private System.Windows.Forms.Label lbTienPhuCap_QLKT;
        private System.Windows.Forms.Label lbTinhTrangPhong_QLKT;
        private System.Windows.Forms.Label lbMoTa_QLKT;
        private System.Windows.Forms.GroupBox grBox_QLKT;
        private System.Windows.Forms.Button btnThem_QLKT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView_QLKT;
        private System.Windows.Forms.Button btnCapNhat_QLKT;
        private System.Windows.Forms.Button btnTimKiem_QLKT;
        private System.Windows.Forms.Button btnThoat_QLKT;
    }
}

