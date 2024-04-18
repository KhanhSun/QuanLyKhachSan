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
            this.Dangnhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTK = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btDN = new System.Windows.Forms.Button();
            this.linkQMK = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkDK = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Dangnhap
            // 
            this.Dangnhap.AutoSize = true;
            this.Dangnhap.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dangnhap.Location = new System.Drawing.Point(234, 27);
            this.Dangnhap.Name = "Dangnhap";
            this.Dangnhap.Size = new System.Drawing.Size(296, 62);
            this.Dangnhap.TabIndex = 0;
            this.Dangnhap.Text = "Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu:";
            // 
            // textBoxTK
            // 
            this.textBoxTK.Location = new System.Drawing.Point(282, 134);
            this.textBoxTK.Name = "textBoxTK";
            this.textBoxTK.Size = new System.Drawing.Size(248, 22);
            this.textBoxTK.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btDN
            // 
            this.btDN.Location = new System.Drawing.Point(337, 288);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(123, 37);
            this.btDN.TabIndex = 5;
            this.btDN.Text = "Đăng Nhập";
            this.btDN.UseVisualStyleBackColor = true;
            // 
            // linkQMK
            // 
            this.linkQMK.AutoSize = true;
            this.linkQMK.Location = new System.Drawing.Point(466, 260);
            this.linkQMK.Name = "linkQMK";
            this.linkQMK.Size = new System.Drawing.Size(104, 16);
            this.linkQMK.TabIndex = 6;
            this.linkQMK.TabStop = true;
            this.linkQMK.Text = "Quên Mật Khẩu?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nếu chưa có tài khoản?";
            // 
            // linkDK
            // 
            this.linkDK.AutoSize = true;
            this.linkDK.Location = new System.Drawing.Point(394, 350);
            this.linkDK.Name = "linkDK";
            this.linkDK.Size = new System.Drawing.Size(89, 16);
            this.linkDK.TabIndex = 8;
            this.linkDK.TabStop = true;
            this.linkDK.Text = "Tạo tài khoản";
            // 
            // Form_DN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkQMK);
            this.Controls.Add(this.btDN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dangnhap);
            this.Name = "Form_DN";
            this.Text = "  Đăng Nhập";
            this.Load += new System.EventHandler(this.Form_DN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.LinkLabel linkQMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkDK;
    }
}