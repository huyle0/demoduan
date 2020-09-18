using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace candientuquochung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 5)
            {
                timer1.Stop();
                pictureBox1.Hide();
                
                this.Hide();
                frmdangnhap frm = new frmdangnhap();
                frm.Show();

            }
        }
    }
}
