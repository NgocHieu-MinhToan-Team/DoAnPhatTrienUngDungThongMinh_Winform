using DevExpress.XtraBars;
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
    public partial class frmContainer : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmContainer()
        {
            InitializeComponent();
            OpenForm(typeof(frmStaff));
        }


        private void OpenForm(Type objForm)
        {
            // if objForm is activated , let's activate it 
            foreach(Form frm in MdiChildren)
            {
                if(frm.GetType() == objForm)
                {
                    frm.Activate();
                    return;
                }
            }
            // otherwise initialize form and set MdiParent 
            Form newForm = (Form)Activator.CreateInstance(objForm);
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void barBtn_signOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void barBtn_staff_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmStaff));
        }

        private void barBtn_Receipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmReceipt));
        }

        private void barBtn_signOut_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void barBtn_Product_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmProduct));
        }
    }
}