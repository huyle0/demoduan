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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        } private void mnichuongtrinhcan_Click(object sender, EventArgs e)
        {
            
            form2 frm = new form2();
            frm.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaocao frm = new frmBaocao();
            frm.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        public int i = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhottel.Left += i;
            if (lblhottel.Left >= this.Width - lblhottel.Width || lblhottel.Left <= 0)
                i = -i;
        }
    }
}
