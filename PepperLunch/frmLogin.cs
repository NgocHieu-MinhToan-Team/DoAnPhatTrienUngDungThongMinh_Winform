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
            if(txtpassword.Text !=null && txtusername.Text != null)
            {
                //if()
                //frmContainer frm = new frmContainer();


                //frm.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Please enter your username & password !");
            }
        }



    }
}