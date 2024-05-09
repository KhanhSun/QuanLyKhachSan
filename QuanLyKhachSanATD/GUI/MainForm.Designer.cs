namespace QuanLyKhachSanATD.MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            Logo = new Label();
            PhongBTN = new Button();
            DichVuBTN = new Button();
            BepBTN = new Button();
            KTBTN = new Button();
            KHBTN = new Button();
            DTBTN = new Button();
            KhoBTN = new Button();
            NVBTN = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            UserLa = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1353, 0);
            button1.Name = "button1";
            button1.Size = new Size(153, 56);
            button1.TabIndex = 0;
            button1.Text = "Log Out";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(PhongBTN);
            flowLayoutPanel1.Controls.Add(DichVuBTN);
            flowLayoutPanel1.Controls.Add(BepBTN);
            flowLayoutPanel1.Controls.Add(KTBTN);
            flowLayoutPanel1.Controls.Add(KHBTN);
            flowLayoutPanel1.Controls.Add(DTBTN);
            flowLayoutPanel1.Controls.Add(KhoBTN);
            flowLayoutPanel1.Controls.Add(NVBTN);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 853);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(Logo);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 183);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // Logo
            // 
            Logo.AutoSize = true;
            Logo.Font = new Font("Monotype Corsiva", 64.2000046F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Logo.ForeColor = SystemColors.ActiveCaptionText;
            Logo.Location = new Point(-3, 20);
            Logo.Name = "Logo";
            Logo.Size = new Size(257, 133);
            Logo.TabIndex = 0;
            Logo.Text = "ATD";
            // 
            // PhongBTN
            // 
            PhongBTN.FlatAppearance.BorderSize = 0;
            PhongBTN.FlatStyle = FlatStyle.Flat;
            PhongBTN.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhongBTN.ForeColor = SystemColors.ButtonFace;
            PhongBTN.Image = (Image)resources.GetObject("PhongBTN.Image");
            PhongBTN.ImageAlign = ContentAlignment.MiddleLeft;
            PhongBTN.Location = new Point(3, 192);
            PhongBTN.Name = "PhongBTN";
            PhongBTN.Size = new Size(247, 78);
            PhongBTN.TabIndex = 1;
            PhongBTN.Text = "Phòng";
            PhongBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            PhongBTN.UseVisualStyleBackColor = true;
            PhongBTN.Click += PhongBTN_Click;
            // 
            // DichVuBTN
            // 
            DichVuBTN.FlatAppearance.BorderSize = 0;
            DichVuBTN.FlatStyle = FlatStyle.Flat;
            DichVuBTN.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DichVuBTN.ForeColor = SystemColors.ButtonFace;
            DichVuBTN.Image = (Image)resources.GetObject("DichVuBTN.Image");
            DichVuBTN.ImageAlign = ContentAlignment.MiddleLeft;
            DichVuBTN.Location = new Point(3, 276);
            DichVuBTN.Name = "DichVuBTN";
            DichVuBTN.Size = new Size(247, 78);
            DichVuBTN.TabIndex = 2;
            DichVuBTN.Text = "Dịch vụ";
            DichVuBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            DichVuBTN.UseVisualStyleBackColor = true;
            DichVuBTN.Click += DichVuBTN_Click;
            // 
            // BepBTN
            // 
            BepBTN.FlatAppearance.BorderSize = 0;
            BepBTN.FlatStyle = FlatStyle.Flat;
            BepBTN.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BepBTN.ForeColor = SystemColors.ButtonFace;
            BepBTN.Image = (Image)resources.GetObject("BepBTN.Image");
            BepBTN.ImageAlign = ContentAlignment.MiddleLeft;
            BepBTN.Location = new Point(3, 360);
            BepBTN.Name = "BepBTN";
            BepBTN.Size = new Size(247, 78);
            BepBTN.TabIndex = 3;
            BepBTN.Text = "Bếp";
            BepBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            BepBTN.UseVisualStyleBackColor = true;
            BepBTN.Click += BepBTN_Click;
            // 
            // KTBTN
            // 
            KTBTN.FlatAppearance.BorderSize = 0;
            KTBTN.FlatStyle = FlatStyle.Flat;
            KTBTN.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KTBTN.ForeColor = SystemColors.ButtonFace;
            KTBTN.Image = (Image)resources.GetObject("KTBTN.Image");
            KTBTN.ImageAlign = ContentAlignment.MiddleLeft;
            KTBTN.Location = new Point(3, 444);
            KTBTN.Name = "KTBTN";
            KTBTN.Size = new Size(247, 78);
            KTBTN.TabIndex = 4;
            KTBTN.Text = "Kỹ thuật";
            KTBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            KTBTN.UseVisualStyleBackColor = true;
            KTBTN.Click += KTBTN_Click;
            // 
            // KHBTN
            // 
            KHBTN.FlatAppearance.BorderSize = 0;
            KHBTN.FlatStyle = FlatStyle.Flat;
            KHBTN.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KHBTN.ForeColor = SystemColors.ButtonFace;
            KHBTN.Image = (Image)resources.GetObject("KHBTN.Image");
            KHBTN.ImageAlign = ContentAlignment.MiddleLeft;
            KHBTN.Location = new Point(3, 528);
            KHBTN.Name = "KHBTN";
            KHBTN.Size = new Size(247, 78);
            KHBTN.TabIndex = 5;
            KHBTN.Text = "Khách hàng";
            KHBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            KHBTN.UseVisualStyleBackColor = true;
            KHBTN.Click += KHBTN_Click;
            // 
            // DTBTN
            // 
            DTBTN.FlatAppearance.BorderSize = 0;
            DTBTN.FlatStyle = FlatStyle.Flat;
            DTBTN.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTBTN.ForeColor = SystemColors.ButtonFace;
            DTBTN.Image = (Image)resources.GetObject("DTBTN.Image");
            DTBTN.ImageAlign = ContentAlignment.MiddleLeft;
            DTBTN.Location = new Point(3, 612);
            DTBTN.Name = "DTBTN";
            DTBTN.Size = new Size(247, 78);
            DTBTN.TabIndex = 6;
            DTBTN.Text = "Doanh thu";
            DTBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            DTBTN.UseVisualStyleBackColor = true;
            DTBTN.Click += DTBTN_Click;
            // 
            // KhoBTN
            // 
            KhoBTN.FlatAppearance.BorderSize = 0;
            KhoBTN.FlatStyle = FlatStyle.Flat;
            KhoBTN.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KhoBTN.ForeColor = SystemColors.ButtonFace;
            KhoBTN.Image = (Image)resources.GetObject("KhoBTN.Image");
            KhoBTN.ImageAlign = ContentAlignment.MiddleLeft;
            KhoBTN.Location = new Point(3, 696);
            KhoBTN.Name = "KhoBTN";
            KhoBTN.Size = new Size(247, 78);
            KhoBTN.TabIndex = 7;
            KhoBTN.Text = "Kho";
            KhoBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            KhoBTN.UseVisualStyleBackColor = true;
            KhoBTN.Click += KhoBTN_Click;
            // 
            // NVBTN
            // 
            NVBTN.FlatAppearance.BorderSize = 0;
            NVBTN.FlatStyle = FlatStyle.Flat;
            NVBTN.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NVBTN.ForeColor = SystemColors.ButtonFace;
            NVBTN.Image = (Image)resources.GetObject("NVBTN.Image");
            NVBTN.ImageAlign = ContentAlignment.MiddleLeft;
            NVBTN.Location = new Point(3, 780);
            NVBTN.Name = "NVBTN";
            NVBTN.Size = new Size(247, 78);
            NVBTN.TabIndex = 8;
            NVBTN.Text = "Nhân viên";
            NVBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            NVBTN.UseVisualStyleBackColor = true;
            NVBTN.Click += NVBTN_Click;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(pictureBox1);
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(256, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(1250, 666);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(382, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(755, 630);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UserLa
            // 
            UserLa.AutoSize = true;
            UserLa.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserLa.ImageAlign = ContentAlignment.MiddleLeft;
            UserLa.Location = new Point(1084, 23);
            UserLa.Name = "UserLa";
            UserLa.Size = new Size(0, 24);
            UserLa.TabIndex = 3;
            UserLa.TextAlign = ContentAlignment.MiddleCenter;
            UserLa.Click += UserLa_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Turquoise;
            ClientSize = new Size(1506, 853);
            Controls.Add(UserLa);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label Logo;
        private Button PhongBTN;
        private Button DichVuBTN;
        private Button BepBTN;
        private Button KTBTN;
        private Button KHBTN;
        private Button DTBTN;
        private Button KhoBTN;
        private Button NVBTN;
        private PictureBox pictureBox1;
        private Label UserLa;
    }
}