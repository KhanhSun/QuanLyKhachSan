namespace QuanLyKhachSanATD.GUI
{
    partial class PhongMenu
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
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(172, 151);
            button1.TabIndex = 0;
            button1.Text = "Thêm Phòng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(190, 12);
            button4.Name = "button4";
            button4.Size = new Size(172, 151);
            button4.TabIndex = 3;
            button4.Text = "Đặt Phòng";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleTurquoise;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(368, 12);
            button5.Name = "button5";
            button5.Size = new Size(172, 151);
            button5.TabIndex = 4;
            button5.Text = "Thanh Toán";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // PhongMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(552, 175);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhongMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhongMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button button5;
    }
}