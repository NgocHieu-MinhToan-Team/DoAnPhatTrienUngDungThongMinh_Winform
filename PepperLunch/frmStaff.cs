using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using BLL_PPL;
using DTO_PPL;
using Modify_Control;
using DevExpress.XtraEditors.Controls;
// lib for firebase "fileSharp"
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

// export, import  excel 
using DevExpress.Export.Xl;
using DevExpress.Spreadsheet;
using System.Diagnostics;

using DevExpress.XtraRichEdit;
using System.Windows.Documents;
using System.Data.Linq.SqlClient;

namespace PepperLunch
{
    public partial class frmStaff : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        BLL_Staff bllStaff = new BLL_Staff();
        IFirebaseConfig fireConfig = new FirebaseConfig()
        {
            AuthSecret = "3ZM87MZG08OAouHFchZo8pHZLkktGoS6j4MIzik8",
            BasePath = "https://api-cua-toan-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient fireClient;
        public frmStaff()
        {
            InitializeComponent();
            // initial cbb gender manual
            cbbGender.Items.Add("Female");
            cbbGender.Items.Add("Male");
            // initial cbb role auto 
            cbbRole.DataSource = bllStaff.readGroupUser();
            cbbRole.DisplayMember = "ROLE_USER";
            cbbRole.ValueMember = "ID_GROUP";
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            gridControl_staff.DataSource = bllStaff.readStaff();
        }


        private async void create(STAFF staff)
        {
            fireClient = new FireSharp.FirebaseClient(fireConfig);
            SetResponse response = await fireClient.SetTaskAsync("staff/" + staff.USERNAME_STAFF, staff);
            STAFF result = response.ResultAs<STAFF>();
            MessageBox.Show("Thanh Cong " + result.NAME_STAFF +staff.SURNAME_STAFF);
        }


        public void exportExcel()
        {
            
        
        }

        public void importExcel()
        {

        }


        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            //STAFF staff = new STAFF();
            //staff.USERNAME_STAFF = txtUsername.Text.Trim();
            //staff.PASSWORD_STAFF = txtPassword.Text.Trim();
            //staff.SURNAME_STAFF = txtSurname.Text.Trim();
            //create(staff);

            STAFF staff = new STAFF();
            staff.USERNAME_STAFF = txtUsername.Text.Trim();
            staff.PASSWORD_STAFF = txtPassword.Text.Trim();
            staff.SURNAME_STAFF = txtSurname.Text.Trim();
            staff.NAME_STAFF = txtName.Text.Trim();
            staff.NUMBER_PHONE = txtPhone.Text.Trim();
            staff.ADDRESS_STAFF = txtAddress.Text.Trim();
            staff.FLAG_DEL = 0;
            // validate 
            if (BLL_Staff.validateCreateStaff(staff))
            {

                if (dateEdit_birth.EditValue != null) { staff.DATE_OF_BIRTH = DateTime.Parse(dateEdit_birth.EditValue.ToString()); }
                else { MessageBox.Show("Date of birth is not selected !"); return; }
                if (cbbGender.SelectedItem != null) { staff.GENDER_STAFF = Int32.Parse(cbbGender.SelectedIndex.ToString().Trim()); }
                else { MessageBox.Show("gender is not selected !"); return; }
                if (cbbRole.SelectedItem != null) { staff.GROUP_USER = (GROUP_USER)cbbRole.SelectedItem; }
                else { MessageBox.Show("gender is not selected !"); return; }
                //create(staff);
            }
            else
            {
                MessageBox.Show("please fill full infomation !");
            }
        }

    
    }
}
