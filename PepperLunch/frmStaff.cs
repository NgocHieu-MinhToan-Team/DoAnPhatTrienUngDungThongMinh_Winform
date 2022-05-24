using System;
using System.Windows.Forms;
using BLL_PPL;
using DTO_PPL;
using System.Linq;
using System.Collections.Generic;

namespace PepperLunch
{
    public partial class frmStaff : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public string USERNAME_STAFF { get; set; }
        public frmStaff()
        {
            InitializeComponent();
            
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //gridControl_staff.DataSource = CallAPI.GetWatchList();
            LoadData();
        }

        private void LoadData()
        {
            List<STAFF> list = BLL_Staff.getStaffs();
            gridControl_staff.DataSource = list;
            LoadCbbRole();
            LoadCbbGender(list);
        }
        private void LoadCbbRole()
        {
            // load cbb role auto 
            cbbRole.DataSource = BLL_Staff.readGroupUser();
            cbbRole.DisplayMember = "ROLE_USER";
            cbbRole.ValueMember = "ID_GROUP";
        }

        private void LoadCbbGender(List<STAFF> list)
        {
            // initial cbb gender manual
            var listGroupBy = list.GroupBy(n => new { n.GENDER_STAFF }).Select(g => new { g.Key.GENDER_STAFF }).ToList();
            foreach (var itemGroupBy in listGroupBy)
            {
                if (itemGroupBy.GENDER_STAFF == 1)
                {
                    cbbGender.Items.Add("Male");
                }
                else 
                    cbbGender.Items.Add("Female");
            }
        }


        private void accordionCtrlEle_newStaff_Click(object sender, EventArgs e)
        {
            STAFF staff = new STAFF();
            staff.USERNAME_STAFF = txtUsername.Text.Trim();
            staff.PASSWORD_STAFF = txtPassword.Text.Trim();
            staff.SURNAME_STAFF = txtSurname.Text.Trim();
            staff.NAME_STAFF = txtName.Text.Trim();
            staff.NUMBER_PHONE = txtPhone.Text.Trim();
            staff.ADDRESS_STAFF = txtAddress.Text.Trim();
            staff.GENDER_STAFF = cbbGender.SelectedIndex;
            staff.ID_GROUP = (string)cbbRole.SelectedValue;
            staff.DATE_OF_BIRTH = dateEdit_birth.DateTime;
            staff.FLAG_DEL = 0;
            // validate 
            if (BLL_Staff.validateCreateStaff(staff))
            {
                if (BLL_Staff.checkPrimaryKey(staff.USERNAME_STAFF)) { 
                    BLL_Staff.insertStaff(staff);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("This username has existed , pleased try again !");
                    txtUsername.Text = "";
                }
            }
        }

        private void accordionCtrlEle_updateStaff_Click(object sender, EventArgs e)
        {
            int[] index = gridView_Staff.GetSelectedRows();
            if (index.Length > 0)
            {
                STAFF data = (STAFF)gridView_Staff.GetRow(index[0]);
                data.USERNAME_STAFF = txtUsername.Text.Trim();
                data.PASSWORD_STAFF = txtPassword.Text.Trim();
                data.SURNAME_STAFF = txtSurname.Text.Trim();
                data.NAME_STAFF = txtName.Text.Trim();
                data.NUMBER_PHONE = txtPhone.Text.Trim();
                data.ADDRESS_STAFF = txtAddress.Text.Trim();
                data.GENDER_STAFF = cbbGender.SelectedIndex;
                data.ID_GROUP = (string)cbbRole.SelectedValue;
                data.DATE_OF_BIRTH = dateEdit_birth.DateTime;
                if (BLL_Staff.validateCreateStaff(data))
                {
                    BLL_Staff.updateStaff(data);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("This username has existed , pleased try again !");
                    txtUsername.Text = "";
                }
            }
        }
        private void accordionCtrlEle_removeStaff_Click(object sender, EventArgs e)
        {
            int[] index = gridView_Staff.GetSelectedRows();
            if (index.Length >0)
            {
                STAFF data = (STAFF)gridView_Staff.GetRow(index[0]);
                BLL_Staff.deleteStaff(data);
                LoadData();
            }
        }

        private void gridView_Staff_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] index = gridView_Staff.GetSelectedRows();
            if (index.Length > 0)
            {
                STAFF data = (STAFF)gridView_Staff.GetRow(index[0]);
                txtUsername.Text = data.USERNAME_STAFF;
                txtPassword.Text = data.PASSWORD_STAFF;
                txtSurname.Text = data.SURNAME_STAFF;
                txtName.Text = data.NAME_STAFF;
                txtPhone.Text = data.NUMBER_PHONE;
                txtAddress.Text = data.ADDRESS_STAFF;
                cbbGender.SelectedIndex = (int)data.GENDER_STAFF;
                cbbRole.SelectedValue = data.ID_GROUP;
                dateEdit_birth.DateTime = (DateTime)data.DATE_OF_BIRTH;
            }
        }
    }
}
