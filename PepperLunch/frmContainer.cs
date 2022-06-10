using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PPL;

namespace PepperLunch
{
    public partial class frmContainer : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string static_USERNAME_STAFF { get; set; }
        public string static_ID_GROUP_USER { get; set; }
        public frmContainer()
        {
            InitializeComponent();
        }


        private bool isOpenForm(Type objForm)
        {
            // if objForm is activated , let's activate it 
            foreach (Form frm in MdiChildren)
            {
                if(frm.GetType() == objForm)
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
           
        }

        private void barBtn_signOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void barBtn_staff_ItemClick(object sender, ItemClickEventArgs e)
        {
            // if form is not opened
            if (!isOpenForm(typeof(frmStaff)))
            {
                frmStaff newForm = new frmStaff();
                newForm.USERNAME_STAFF = static_USERNAME_STAFF;
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void barBtn_Receipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            // if form is not opened
            if (!isOpenForm(typeof(frmReceipt)))
            {
                frmReceipt newForm = new frmReceipt();
                //newForm.USERNAME_STAFF = static_USERNAME_STAFF;
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void barBtn_signOut_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void barBtn_Product_ItemClick(object sender, ItemClickEventArgs e)
        {
            // if form is not opened
            if (!isOpenForm(typeof(frmProduct)))
            {
                frmProduct newForm = new frmProduct();
                //newForm.USERNAME_STAFF = static_USERNAME_STAFF;
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void barBtn_Category_ItemClick(object sender, ItemClickEventArgs e)
        {
            // if form is not opened
            if (!isOpenForm(typeof(frmCategory)))
            {
                frmCategory newForm = new frmCategory();
                //newForm.USERNAME_STAFF = static_USERNAME_STAFF;
                newForm.MdiParent = this;
                newForm.Show();
            }
        }
        private void barBtn_SyncManual_ItemClick(object sender, ItemClickEventArgs e)
        {
            // if form is not opened
            if (!isOpenForm(typeof(frmHandleFirebase)))
            {
                frmHandleFirebase newForm = new frmHandleFirebase();
                //newForm.USERNAME_STAFF = static_USERNAME_STAFF;
                newForm.MdiParent = this;
                newForm.Show();
            }

        }

        private void barBtn_customer_ItemClick(object sender, ItemClickEventArgs e)
        {
            // if form is not opened
           
            frmCustomer newForm = new frmCustomer();
            //newForm.USERNAME_STAFF = static_USERNAME_STAFF;
            newForm.MdiParent = this;
            newForm.Show();
        }

        


        private void barBtn_Promotion_ItemClick(object sender, ItemClickEventArgs e)
        {
            // if form is not opened
            if (!isOpenForm(typeof(frmPromotion)))
            {
                frmPromotion newForm = new frmPromotion();
                newForm.static_USERNAME_STAFF = static_USERNAME_STAFF;
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void frmContainer_Load(object sender, EventArgs e)
        {
            string group_id = Program.frmlogin.staff_global.ID_GROUP;
            // check role user
            if (!BLL_Staff.isAdmin(group_id))
            {
                ribbonPageGroup_Firebase.Visible = false;
            }
        }

        //private void barBtn_Ingredient_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frmRecipe newForm = new frmRecipe();
        //    newForm.MdiParent = this;
        //    newForm.Show();
        //}

        private void barBtn_Import_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmImport newForm = new frmImport();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}