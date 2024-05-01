namespace QuanLyKhachSanATD.GUI
{
    partial class LoaiPhong
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
            PhongLa = new Label();
            dataGridView1 = new DataGridView();
            RoomNum = new Label();
            RNum = new TextBox();
            RoomType = new Label();
            label2 = new Label();
            Price = new Label();
            comboBox1 = new ComboBox();
            Bedtype = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ExitBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PhongLa
            // 
            PhongLa.AutoSize = true;
            PhongLa.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhongLa.Location = new Point(24, 22);
            PhongLa.Name = "PhongLa";
            PhongLa.Size = new Size(107, 35);
            PhongLa.TabIndex = 0;
            PhongLa.Text = "Phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(769, 563);
            dataGridView1.TabIndex = 1;
            // 
            // RoomNum
            // 
            RoomNum.AutoSize = true;
            RoomNum.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomNum.Location = new Point(833, 77);
            RoomNum.Name = "RoomNum";
            RoomNum.Size = new Size(136, 38);
            RoomNum.TabIndex = 2;
            RoomNum.Text = "Số Phòng";
            // 
            // RNum
            // 
            RNum.Location = new Point(833, 133);
            RNum.Name = "RNum";
            RNum.Size = new Size(266, 27);
            RNum.TabIndex = 3;
            // 
            // RoomType
            // 
            RoomType.AutoSize = true;
            RoomType.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomType.Location = new Point(833, 187);
            RoomType.Name = "RoomType";
            RoomType.Size = new Size(155, 38);
            RoomType.TabIndex = 4;
            RoomType.Text = "Loại Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(833, 303);
            label2.Name = "label2";
            label2.Size = new Size(166, 38);
            label2.TabIndex = 5;
            label2.Text = "Loại Giường";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.Location = new Point(833, 422);
            Price.Name = "Price";
            Price.Size = new Size(112, 38);
            Price.TabIndex = 6;
            Price.Text = "Giá tiền";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phòng đơn", "Phòng đôi", "Phòng VIP" });
            comboBox1.Location = new Point(833, 245);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Bedtype
            // 
            Bedtype.FormattingEnabled = true;
            Bedtype.Items.AddRange(new object[] { "Giường đơn", "Giường đôi", "Giường cao cấp" });
            Bedtype.Location = new Point(833, 369);
            Bedtype.Name = "Bedtype";
            Bedtype.Size = new Size(266, 28);
            Bedtype.TabIndex = 8;
            Bedtype.SelectedIndexChanged += Bedtype_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(833, 474);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 27);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(912, 575);
            button1.Name = "button1";
            button1.Size = new Size(187, 44);
            button1.TabIndex = 10;
            button1.Text = "Thêm Phòng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ExitBTN
            // 
            ExitBTN.FlatAppearance.BorderSize = 0;
            ExitBTN.FlatStyle = FlatStyle.Flat;
            ExitBTN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBTN.Location = new Point(1190, 12);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(42, 45);
            ExitBTN.TabIndex = 11;
            ExitBTN.Text = "X";
            ExitBTN.UseVisualStyleBackColor = true;
            ExitBTN.Click += ExitBTN_Click;
            // 
            // LoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 656);
            Controls.Add(ExitBTN);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Bedtype);
            Controls.Add(comboBox1);
            Controls.Add(Price);
            Controls.Add(label2);
            Controls.Add(RoomType);
            Controls.Add(RNum);
            Controls.Add(RoomNum);
            Controls.Add(dataGridView1);
            Controls.Add(PhongLa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoaiPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoaiPhong";
            Load += LoaiPhong_Load_1;
            Enter += LoaiPhong_Enter;
            Leave += LoaiPhong_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PhongLa;
        private DataGridView dataGridView1;
        private Label RoomNum;
        private TextBox RNum;
        private Label RoomType;
        private Label label2;
        private Label Price;
        private ComboBox comboBox1;
        private ComboBox Bedtype;
        private TextBox textBox1;
        private Button button1;
        private Button ExitBTN;
    }
}