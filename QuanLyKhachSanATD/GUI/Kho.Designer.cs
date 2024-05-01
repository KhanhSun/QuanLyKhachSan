namespace QuanLyKhachSanATD.GUI
{
    partial class Kho
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
            ExitBTN = new Button();
            label1 = new Label();
            Khodg = new DataGridView();
            AddBTN = new Button();
            UpdBTN = new Button();
            label2 = new Label();
            MVL = new TextBox();
            slg = new TextBox();
            label3 = new Label();
            dvt = new TextBox();
            label4 = new Label();
            TVL = new TextBox();
            label5 = new Label();
            ncc = new TextBox();
            label6 = new Label();
            slgtt = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)Khodg).BeginInit();
            SuspendLayout();
            // 
            // ExitBTN
            // 
            ExitBTN.FlatAppearance.BorderSize = 0;
            ExitBTN.FlatStyle = FlatStyle.Flat;
            ExitBTN.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBTN.Location = new Point(941, 1);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(56, 54);
            ExitBTN.TabIndex = 0;
            ExitBTN.Text = "X";
            ExitBTN.UseVisualStyleBackColor = true;
            ExitBTN.Click += ExitBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(73, 37);
            label1.TabIndex = 1;
            label1.Text = "Kho";
            // 
            // Khodg
            // 
            Khodg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Khodg.BackgroundColor = Color.White;
            Khodg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Khodg.Location = new Point(22, 234);
            Khodg.Name = "Khodg";
            Khodg.RowHeadersWidth = 51;
            Khodg.Size = new Size(736, 397);
            Khodg.TabIndex = 2;
            Khodg.CellContentClick += Khodg_CellContentClick;
            Khodg.Leave += Khodg_Leave;
            // 
            // AddBTN
            // 
            AddBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBTN.Location = new Point(829, 234);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(168, 96);
            AddBTN.TabIndex = 3;
            AddBTN.Text = "Thêm";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // UpdBTN
            // 
            UpdBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdBTN.Location = new Point(829, 350);
            UpdBTN.Name = "UpdBTN";
            UpdBTN.Size = new Size(168, 96);
            UpdBTN.TabIndex = 4;
            UpdBTN.Text = "Cập nhật";
            UpdBTN.UseVisualStyleBackColor = true;
            UpdBTN.Click += UpdBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 73);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 5;
            label2.Text = "Mã vật liệu:";
            // 
            // MVL
            // 
            MVL.Location = new Point(141, 69);
            MVL.Name = "MVL";
            MVL.Size = new Size(153, 27);
            MVL.TabIndex = 6;
            // 
            // slg
            // 
            slg.Location = new Point(141, 102);
            slg.Name = "slg";
            slg.Size = new Size(153, 27);
            slg.TabIndex = 8;
            slg.KeyPress += slg_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 106);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 7;
            label3.Text = "Số lượng:";
            // 
            // dvt
            // 
            dvt.Location = new Point(141, 135);
            dvt.Name = "dvt";
            dvt.Size = new Size(153, 27);
            dvt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 139);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 9;
            label4.Text = "Đơn vị tính:";
            // 
            // TVL
            // 
            TVL.Location = new Point(449, 69);
            TVL.Name = "TVL";
            TVL.Size = new Size(309, 27);
            TVL.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(319, 73);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 11;
            label5.Text = "Tên vật liệu:";
            // 
            // ncc
            // 
            ncc.Location = new Point(449, 102);
            ncc.Name = "ncc";
            ncc.Size = new Size(309, 27);
            ncc.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(319, 106);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 13;
            label6.Text = "Nhà cung cấp:";
            // 
            // slgtt
            // 
            slgtt.Location = new Point(198, 171);
            slgtt.Name = "slgtt";
            slgtt.Size = new Size(153, 27);
            slgtt.TabIndex = 16;
            slgtt.TextChanged += slgtt_TextChanged;
            slgtt.KeyPress += slgtt_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 172);
            label7.Name = "label7";
            label7.Size = new Size(161, 23);
            label7.TabIndex = 15;
            label7.Text = "Số lượng tối thiểu:";
            // 
            // Kho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1009, 643);
            Controls.Add(slgtt);
            Controls.Add(label7);
            Controls.Add(ncc);
            Controls.Add(label6);
            Controls.Add(TVL);
            Controls.Add(label5);
            Controls.Add(dvt);
            Controls.Add(label4);
            Controls.Add(slg);
            Controls.Add(label3);
            Controls.Add(MVL);
            Controls.Add(label2);
            Controls.Add(UpdBTN);
            Controls.Add(AddBTN);
            Controls.Add(Khodg);
            Controls.Add(label1);
            Controls.Add(ExitBTN);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kho";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kho";
            Load += Kho_Load;
            ((System.ComponentModel.ISupportInitialize)Khodg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitBTN;
        private Label label1;
        private DataGridView Khodg;
        private Button AddBTN;
        private Button UpdBTN;
        private Label label2;
        private TextBox MVL;
        private TextBox slg;
        private Label label3;
        private TextBox dvt;
        private Label label4;
        private TextBox TVL;
        private Label label5;
        private TextBox ncc;
        private Label label6;
        private TextBox slgtt;
        private Label label7;
    }
}