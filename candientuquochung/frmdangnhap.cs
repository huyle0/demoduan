using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace candientuquochung
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {//đặt câu hỏi thoát phần mềm do sinh viên FPT thực hiện
            DialogResult hoi;
            hoi = MessageBox.Show("bạn có muốn thoát chương trình do sinh vien fpt làm không ?", "Thông báo!", MessageBoxButtons. YesNo,MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
        //khóa nút X trên form
        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }



        private void btndangnhap_Click(object sender, EventArgs e)
        {
            /*
              if (string.IsNullOrEmpty(txtUsr.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản","Tài khoản không thể để trống",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txtUsr.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không thể để trống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPwd.Select();
                return;
            }
             */
            this.Hide();
            frmmain frm = new frmmain();
            frm.Show();
            
        }

        private void lbltaikhoan_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
