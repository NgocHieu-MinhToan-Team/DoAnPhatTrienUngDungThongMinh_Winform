using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_PPL;
using BLL_PPL;

namespace PepperLunch
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            STAFF staff = BLL_Staff.checkLogin(username, password);
            if (staff!=null)
            {

                frmContainer frm = new frmContainer();
                frm.static_USERNAME_STAFF = staff.USERNAME_STAFF;
                frm.static_ID_GROUP_USER = staff.ID_GROUP;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter your username & password !");
            }
        }



    }
}