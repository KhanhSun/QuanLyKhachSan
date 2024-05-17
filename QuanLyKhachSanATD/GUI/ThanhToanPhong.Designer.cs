namespace QuanLyKhachSanATD.GUI
{
    partial class ThanhToanPhong
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
            Findla = new Label();
            Findtxt = new TextBox();
            TTdg = new DataGridView();
            nametxt = new TextBox();
            label2 = new Label();
            roomnotxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            paydtp = new DateTimePicker();
            PayBTN = new Button();
            ExitBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)TTdg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 0;
            label1.Text = "Thanh Toán";
            // 
            // Findla
            // 
            Findla.AutoSize = true;
            Findla.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Findla.Location = new Point(375, 53);
            Findla.Name = "Findla";
            Findla.Size = new Size(87, 22);
            Findla.TabIndex = 1;
            Findla.Text = "Tìm Kiếm";
            // 
            // Findtxt
            // 
            Findtxt.Location = new Point(375, 78);
            Findtxt.Name = "Findtxt";
            Findtxt.PlaceholderText = "Enter Fullname";
            Findtxt.Size = new Size(323, 27);
            Findtxt.TabIndex = 2;
            Findtxt.TextChanged += Findtxt_TextChanged;
            // 
            // TTdg
            // 
            TTdg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TTdg.BackgroundColor = Color.White;
            TTdg.BorderStyle = BorderStyle.Fixed3D;
            TTdg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTdg.ColumnHeadersVisible = false;
            TTdg.Location = new Point(23, 111);
            TTdg.Name = "TTdg";
            TTdg.ReadOnly = true;
            TTdg.RowHeadersWidth = 51;
            TTdg.Size = new Size(1289, 514);
            TTdg.TabIndex = 3;
            TTdg.CellContentClick += TTdg_CellContentClick;
            // 
            // nametxt
            // 
            nametxt.Location = new Point(23, 653);
            nametxt.Name = "nametxt";
            nametxt.PlaceholderText = "Enter Name";
            nametxt.ReadOnly = true;
            nametxt.Size = new Size(318, 27);
            nametxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 628);
            label2.Name = "label2";
            label2.Size = new Size(41, 22);
            label2.TabIndex = 4;
            label2.Text = "Tên";
            // 
            // roomnotxt
            // 
            roomnotxt.Location = new Point(359, 653);
            roomnotxt.Name = "roomnotxt";
            roomnotxt.PlaceholderText = "Enter Room No";
            roomnotxt.ReadOnly = true;
            roomnotxt.Size = new Size(153, 27);
            roomnotxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(359, 628);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 6;
            label3.Text = "Số phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(544, 628);
            label4.Name = "label4";
            label4.Size = new Size(157, 22);
            label4.TabIndex = 8;
            label4.Text = "Ngày thanh toán";
            // 
            // paydtp
            // 
            paydtp.CalendarMonthBackground = Color.DarkOrange;
            paydtp.CustomFormat = "MM/dd/yyyy";
            paydtp.Format = DateTimePickerFormat.Custom;
            paydtp.Location = new Point(544, 651);
            paydtp.Name = "paydtp";
            paydtp.Size = new Size(250, 27);
            paydtp.TabIndex = 9;
            // 
            // PayBTN
            // 
            PayBTN.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayBTN.ForeColor = SystemColors.ControlText;
            PayBTN.Location = new Point(1162, 653);
            PayBTN.Name = "PayBTN";
            PayBTN.Size = new Size(150, 59);
            PayBTN.TabIndex = 10;
            PayBTN.Text = "Thanh Toán";
            PayBTN.UseVisualStyleBackColor = true;
            PayBTN.Click += PayBTN_Click;
            // 
            // ExitBTN
            // 
            ExitBTN.FlatAppearance.BorderSize = 0;
            ExitBTN.FlatStyle = FlatStyle.Flat;
            ExitBTN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBTN.Location = new Point(1279, 6);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(50, 48);
            ExitBTN.TabIndex = 11;
            ExitBTN.Text = "X";
            ExitBTN.UseVisualStyleBackColor = true;
            ExitBTN.Click += ExitBTN_Click;
            // 
            // ThanhToanPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1341, 748);
            Controls.Add(ExitBTN);
            Controls.Add(PayBTN);
            Controls.Add(paydtp);
            Controls.Add(label4);
            Controls.Add(roomnotxt);
            Controls.Add(label3);
            Controls.Add(nametxt);
            Controls.Add(label2);
            Controls.Add(TTdg);
            Controls.Add(Findtxt);
            Controls.Add(Findla);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThanhToanPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ThanhToanPhong";
            Load += ThanhToanPhong_Load;
            Leave += ThanhToanPhong_Leave;
            ((System.ComponentModel.ISupportInitialize)TTdg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Findla;
        private TextBox Findtxt;
        private DataGridView TTdg;
        private TextBox nametxt;
        private Label label2;
        private TextBox roomnotxt;
        private Label label3;
        private Label label4;
        private DateTimePicker paydtp;
        private Button PayBTN;
        private Button ExitBTN;
    }
}