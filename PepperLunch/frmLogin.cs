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
        public STAFF staff_global { get; set; }
        public frmContainer formContainer;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            handleLogin();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                handleLogin();
            }
        }

        void handleLogin()
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            STAFF staff = BLL_Staff.checkLogin(username, password);
            if (staff != null)
            {
                Program.frmcontainer = new frmContainer();
                staff_global = staff;
                Program.frmcontainer.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please enter your username & password !");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtusername;
            txtusername.Focus();
        }
    }
}