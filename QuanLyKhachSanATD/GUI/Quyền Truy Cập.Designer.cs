﻿namespace QLNV
{
    partial class Quyền_Truy_Cập
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
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            button6 = new Button();
            groupBox3 = new GroupBox();
            listBox2 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Aqua;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DodgerBlue;
            groupBox1.Location = new Point(40, 29);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(901, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại Nhân Viên:";
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(588, 95);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(260, 59);
            button4.TabIndex = 5;
            button4.Text = "Đóng";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(588, 32);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(260, 59);
            button3.TabIndex = 4;
            button3.Text = "Thêm mới";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(319, 91);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(260, 59);
            button2.TabIndex = 3;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(319, 32);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(260, 59);
            button1.TabIndex = 1;
            button1.Text = "Sửa tên";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 95);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 39);
            comboBox1.TabIndex = 2;
            comboBox1.DropDown += comboBox1_DropDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 1;
            label1.Text = "Tên loại nhân viên:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Aquamarine;
            groupBox2.Controls.Add(listBox1);
            groupBox2.ForeColor = Color.DodgerBlue;
            groupBox2.Location = new Point(40, 216);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(351, 367);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quyền hiện tại";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Turquoise;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Items.AddRange(new object[] { "Đặt Phòng", "Nhận Phòng", "Sử dụng dịch vụ và Thanh toán", "Thống kê và doanh thu", "Quản lí phòng", "Quản lí nhân viên", "Quản lí khách hàng", "Quản lí hóa đơn", "Quản lí dịch vụ", "Quy định" });
            listBox1.Location = new Point(29, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(274, 284);
            listBox1.TabIndex = 0;
            listBox1.Tag = "";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.BackColor = Color.SpringGreen;
            button6.ForeColor = Color.DodgerBlue;
            button6.Location = new Point(408, 388);
            button6.Name = "button6";
            button6.Size = new Size(114, 54);
            button6.TabIndex = 3;
            button6.Text = ">>";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkSeaGreen;
            groupBox3.Controls.Add(listBox2);
            groupBox3.ForeColor = Color.DodgerBlue;
            groupBox3.Location = new Point(528, 216);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(360, 367);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Phân công nhiệm vụ";
            // 
            // listBox2
            // 
            listBox2.AccessibleRole = AccessibleRole.None;
            listBox2.BackColor = Color.YellowGreen;
            listBox2.ForeColor = Color.YellowGreen;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 28;
            listBox2.Location = new Point(22, 53);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(252, 284);
            listBox2.TabIndex = 0;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // Quyền_Truy_Cập
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1100, 630);
            Controls.Add(groupBox3);
            Controls.Add(button6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(4);
            Name = "Quyền_Truy_Cập";
            Text = "Quyền_Truy_Cập";
            Load += Quyền_Truy_Cập_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button button6;
        private GroupBox groupBox3;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}