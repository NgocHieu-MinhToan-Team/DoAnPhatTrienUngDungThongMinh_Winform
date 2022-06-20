using System;
using System.Windows.Forms;
using BLL_PPL;
using DTO_PPL;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;

namespace PepperLunch
{
    public partial class frmStaff : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private string ID_GROUP_USER = null;
        private int GENDER =-1;
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
            //clear when reload 
            repositoryItemComboBox_role.Items.Clear();
            repositoryItemComboBox_gender.Items.Clear();


            List<STAFF> list = BLL_Staff.getStaffs();
            List<GROUP_USER> listGrp = BLL_Staff.readGroupUser();
            List<string> arrRole = new List<string>(); 
            listGrp.ForEach((GROUP_USER) =>
            {
                arrRole.Add(GROUP_USER.ID_GROUP);
            });
            // cbb role
            repositoryItemComboBox_role.Items.AddRange(arrRole.ToArray());
            gridControl_staff.RepositoryItems.Add(repositoryItemComboBox_role);
            // cbb gender
            repositoryItemComboBox_gender.Items.AddRange(new string[] { "MALE", "FEMALE" });
            gridControl_staff.RepositoryItems.Add(repositoryItemComboBox_gender);


            gridView_Staff.Columns["GENDER"].ColumnEdit = repositoryItemComboBox_gender;
            gridView_Staff.Columns["ROLE"].ColumnEdit = repositoryItemComboBox_role;

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
            cbbGender.Items.Clear();
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
                if (ID_GROUP_USER != null)
                {
                    data.ID_GROUP = ID_GROUP_USER;
                }

                if (GENDER >= 0 )
                {
                    data.GENDER_STAFF = GENDER;
                }


                if (BLL_Staff.updateStaff(data))
                {
                    XtraMessageBox.Show("Update infomation "+data.USERNAME_STAFF);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Has Error!");
                }
                //reset choose cbb
                ID_GROUP_USER = null;
                GENDER = -1;
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
            //reset choose cbb
            ID_GROUP_USER = null;
            GENDER = -1;
        }

        private void repositoryItemComboBox_role_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbb = sender as ComboBoxEdit;
            ID_GROUP_USER = cbb.SelectedItem.ToString();
        }

        private void repositoryItemComboBox_gender_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cbb = sender as ComboBoxEdit;
            if (cbb.SelectedItem.ToString() == "MALE")
            {
                GENDER = 1;
            }
            else
            {
                GENDER = 0;
            }
        }
    }
}
