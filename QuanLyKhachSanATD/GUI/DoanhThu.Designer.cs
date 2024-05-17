namespace QuanLyKhachSanATD.GUI
{
    partial class DoanhThu
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
            dtgdt = new DataGridView();
            ExportBTN = new Button();
            label2 = new Label();
            label3 = new Label();
            dtpfrom = new DateTimePicker();
            dtpto = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgdt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(652, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 40);
            label1.TabIndex = 0;
            label1.Text = "Revenue";
            // 
            // dtgdt
            // 
            dtgdt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgdt.BackgroundColor = SystemColors.Control;
            dtgdt.BorderStyle = BorderStyle.Fixed3D;
            dtgdt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgdt.Location = new Point(282, 81);
            dtgdt.Name = "dtgdt";
            dtgdt.RowHeadersWidth = 51;
            dtgdt.Size = new Size(1180, 641);
            dtgdt.TabIndex = 1;
            // 
            // ExportBTN
            // 
            ExportBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExportBTN.Location = new Point(1312, 741);
            ExportBTN.Name = "ExportBTN";
            ExportBTN.Size = new Size(150, 53);
            ExportBTN.TabIndex = 2;
            ExportBTN.Text = "IMPORT EXCEL";
            ExportBTN.UseVisualStyleBackColor = true;
            ExportBTN.Click += ExportBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 3;
            label2.Text = "FROM :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(49, 28);
            label3.TabIndex = 4;
            label3.Text = "TO :";
            // 
            // dtpfrom
            // 
            dtpfrom.CustomFormat = "MM/dd/yyyy";
            dtpfrom.Format = DateTimePickerFormat.Custom;
            dtpfrom.Location = new Point(12, 118);
            dtpfrom.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpfrom.Name = "dtpfrom";
            dtpfrom.Size = new Size(250, 27);
            dtpfrom.TabIndex = 5;
            // 
            // dtpto
            // 
            dtpto.CustomFormat = "MM/dd/yyyy";
            dtpto.Format = DateTimePickerFormat.Custom;
            dtpto.Location = new Point(12, 179);
            dtpto.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpto.Name = "dtpto";
            dtpto.Size = new Size(250, 27);
            dtpto.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(140, 212);
            button1.Name = "button1";
            button1.Size = new Size(122, 33);
            button1.TabIndex = 7;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1419, 12);
            button2.Name = "button2";
            button2.Size = new Size(57, 49);
            button2.TabIndex = 8;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1488, 806);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpto);
            Controls.Add(dtpfrom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ExportBTN);
            Controls.Add(dtgdt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoanhThu";
            Text = "DoanhThu";
            Load += DoanhThu_Load;
            ((System.ComponentModel.ISupportInitialize)dtgdt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgdt;
        private Button ExportBTN;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpfrom;
        private DateTimePicker dtpto;
        private Button button1;
        private Button button2;
    }
}