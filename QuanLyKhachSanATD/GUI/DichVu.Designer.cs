namespace QuanLyKhachSanATD.GUI
{
    partial class DichVu
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
            idDV = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DVname = new TextBox();
            label4 = new Label();
            price = new TextBox();
            AddBTN = new Button();
            Exit = new Button();
            DVdata = new DataGridView();
            DelBTN = new Button();
            UpdBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)DVdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 0;
            label1.Text = "Dịch Vụ";
            // 
            // idDV
            // 
            idDV.Location = new Point(120, 77);
            idDV.Name = "idDV";
            idDV.Size = new Size(236, 27);
            idDV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 77);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 2;
            label2.Text = "Mã ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(362, 76);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 4;
            label3.Text = "Tên dịch vụ:";
            // 
            // DVname
            // 
            DVname.Location = new Point(493, 77);
            DVname.Name = "DVname";
            DVname.Size = new Size(313, 27);
            DVname.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 119);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 6;
            label4.Text = "Giá tiền:";
            // 
            // price
            // 
            price.Location = new Point(120, 120);
            price.Name = "price";
            price.Size = new Size(236, 27);
            price.TabIndex = 5;
            // 
            // AddBTN
            // 
            AddBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBTN.Location = new Point(684, 411);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(199, 72);
            AddBTN.TabIndex = 7;
            AddBTN.Text = "Thêm";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // Exit
            // 
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(846, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(50, 54);
            Exit.TabIndex = 8;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // DVdata
            // 
            DVdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DVdata.BackgroundColor = Color.White;
            DVdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVdata.Location = new Point(25, 176);
            DVdata.Name = "DVdata";
            DVdata.RowHeadersWidth = 51;
            DVdata.Size = new Size(646, 504);
            DVdata.TabIndex = 11;
            DVdata.CellContentClick += DVdata_CellContentClick;
            // 
            // DelBTN
            // 
            DelBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DelBTN.Location = new Point(684, 606);
            DelBTN.Name = "DelBTN";
            DelBTN.Size = new Size(199, 72);
            DelBTN.TabIndex = 12;
            DelBTN.Text = "Xóa";
            DelBTN.UseVisualStyleBackColor = true;
            DelBTN.Click += DelBTN_Click;
            // 
            // UpdBTN
            // 
            UpdBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdBTN.Location = new Point(684, 506);
            UpdBTN.Name = "UpdBTN";
            UpdBTN.Size = new Size(199, 72);
            UpdBTN.TabIndex = 13;
            UpdBTN.Text = "Cập nhật";
            UpdBTN.UseVisualStyleBackColor = true;
            UpdBTN.Click += UpdBTN_Click;
            // 
            // DichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(895, 690);
            Controls.Add(UpdBTN);
            Controls.Add(DelBTN);
            Controls.Add(DVdata);
            Controls.Add(Exit);
            Controls.Add(AddBTN);
            Controls.Add(label4);
            Controls.Add(price);
            Controls.Add(label3);
            Controls.Add(DVname);
            Controls.Add(label2);
            Controls.Add(idDV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DichVu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DichVu";
            Load += DichVu_Load;
            Leave += DichVu_Leave;
            ((System.ComponentModel.ISupportInitialize)DVdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idDV;
        private Label label2;
        private Label label3;
        private TextBox DVname;
        private Label label4;
        private TextBox price;
        private Button AddBTN;
        private Button Exit;
        private DataGridView DVdata;
        private Button DelBTN;
        private Button UpdBTN;
    }
}