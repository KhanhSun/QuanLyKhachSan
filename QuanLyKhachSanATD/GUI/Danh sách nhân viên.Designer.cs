namespace QLNV
{
    partial class Danh_sách_nhân_viên
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(200, 505);
            button1.Name = "button1";
            button1.Size = new Size(94, 51);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(310, 505);
            button2.Name = "button2";
            button2.Size = new Size(94, 51);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(423, 505);
            button3.Name = "button3";
            button3.Size = new Size(94, 51);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Blue;
            button5.Location = new Point(523, 505);
            button5.Name = "button5";
            button5.Size = new Size(94, 51);
            button5.TabIndex = 4;
            button5.Text = "Hủy";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PeachPuff;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(263, 93);
            button6.Name = "button6";
            button6.Size = new Size(144, 36);
            button6.TabIndex = 5;
            button6.Text = "Tìm kiếm";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(610, 239);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.ForeColor = Color.BlueViolet;
            groupBox1.Location = new Point(47, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 308);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button6);
            groupBox2.ForeColor = Color.Chocolate;
            groupBox2.Location = new Point(47, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(692, 135);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm nhân viên";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(405, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 34);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(137, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 41);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 7;
            label2.Text = "Tên NV:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 47);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 6;
            label1.Text = "Mã NV:";
            // 
            // Danh_sách_nhân_viên
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(841, 583);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Danh_sách_nhân_viên";
            Text = "Danh_sách_nhân_viên";
            Load += Danh_sách_nhân_viên_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}