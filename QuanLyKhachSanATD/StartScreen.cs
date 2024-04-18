using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSanATD;
using QuanLyKhachSan.Form_DK_DN;



namespace QuanLyKhachSanATD
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if(panel2.Width >= 800)
            {
                timer1.Stop();
                Form_DN lgf = new Form_DN(); ;
                this.Hide();
                lgf.Show();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
