namespace QuanLyKhachSan.Form_DK_DN
{
    partial class Form_DN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DN));
            Dangnhap = new Label();
            label1 = new Label();
            label2 = new Label();
            UserText = new TextBox();
            PassText = new TextBox();
            btDN = new Button();
            ExitBTN = new Button();
            SuspendLayout();
            // 
            // Dangnhap
            // 
            Dangnhap.AutoSize = true;
            Dangnhap.Font = new Font("Harrington", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dangnhap.Location = new Point(152, 36);
            Dangnhap.Name = "Dangnhap";
            Dangnhap.Size = new Size(265, 55);
            Dangnhap.TabIndex = 0;
            Dangnhap.Text = "Đăng Nhập";
            Dangnhap.Click += Dangnhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 121);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 169);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu:";
            // 
            // UserText
            // 
            UserText.Location = new Point(231, 121);
            UserText.Margin = new Padding(3, 4, 3, 4);
            UserText.Name = "UserText";
            UserText.Size = new Size(248, 27);
            UserText.TabIndex = 3;
            UserText.TextChanged += UserText_TextChanged;
            // 
            // PassText
            // 
            PassText.Location = new Point(231, 169);
            PassText.Margin = new Padding(3, 4, 3, 4);
            PassText.Name = "PassText";
            PassText.PasswordChar = '■';
            PassText.Size = new Size(248, 27);
            PassText.TabIndex = 4;
            PassText.TextChanged += PassText_TextChanged;
            // 
            // btDN
            // 
            btDN.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDN.Location = new Point(104, 238);
            btDN.Margin = new Padding(3, 4, 3, 4);
            btDN.Name = "btDN";
            btDN.Size = new Size(375, 46);
            btDN.TabIndex = 5;
            btDN.Text = "Đăng Nhập";
            btDN.UseVisualStyleBackColor = true;
            btDN.Click += btDN_Click;
            // 
            // ExitBTN
            // 
            ExitBTN.FlatAppearance.BorderSize = 0;
            ExitBTN.FlatStyle = FlatStyle.Flat;
            ExitBTN.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitBTN.Location = new Point(551, 1);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(40, 41);
            ExitBTN.TabIndex = 6;
            ExitBTN.Text = "X";
            ExitBTN.UseVisualStyleBackColor = true;
            ExitBTN.Click += ExitBTN_Click;
            // 
            // Form_DN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(593, 346);
            Controls.Add(ExitBTN);
            Controls.Add(btDN);
            Controls.Add(PassText);
            Controls.Add(UserText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Dangnhap);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_DN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Form_DN_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Dangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Button btDN;
        private Button ExitBTN;
    }
}