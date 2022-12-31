using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Accounting.PL
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BL.Users.Login login = new BL.Users.Login();

            dt = login.loginTest(txt_user.Text, txt_password.Text);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                frm_Main fm = new PL.frm_Main();
                Program.uname = txt_user.Text;
                Program.username = dt.Rows[0]["U_Fname"].ToString();
                fm.Show();
            }
            else
            {
                MessageBox.Show("كلمة المرور أو اسم المستخدم غير صحيح");
            }


        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
