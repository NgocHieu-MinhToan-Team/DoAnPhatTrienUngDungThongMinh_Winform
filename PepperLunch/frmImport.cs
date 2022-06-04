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
using BLL_PPL;
using DTO_PPL;

namespace PepperLunch
{
    public partial class frmImport : DevExpress.XtraEditors.XtraForm
    {
        // get id staff 
        private static string username = Program.frmlogin.staff_global.USERNAME_STAFF;
        public frmImport()
        {
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            gridControl_IOG.DataSource = BLL_IOG.getList();
            // hide column 
            gridView_IOG.Columns["STAFF"].Visible= gridView_IOG.Columns["FLAG_DEL"].Visible= gridView_IOG.Columns["SUPPLIER"].Visible = false;
            cbbSupplier.DataSource = BLL_Ingredient.getListSupplier();
            cbbSupplier.DisplayMember = "NAME_SUPPLIER";
            cbbSupplier.ValueMember = "ID_SUPPLIER";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // get data from input 
            IMPORT item = new IMPORT();
            item.ID_IOG = GeneralMethods.createID("NH");
            item.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
            item.USERNAME_STAFF = username;
            item.DATE_IOG = DateTime.Now;
            item.TOTAL_PRICE = 0;
            item.NOTE = txtNote.Text;
            BLL_IOG.insert(item);
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_IOG.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_IOG.GetRow(arrRowSelected[0]);
                item.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
                item.USERNAME_STAFF = username;
                item.DATE_IOG = DateTime.Now;
                item.TOTAL_PRICE = item.TOTAL_PRICE;
                item.NOTE = txtNote.Text;
                BLL_IOG.update(item);
                loadData();
            }
            else
            {
                MessageBox.Show("Please choose a record Import of goods");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_IOG.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_IOG.GetRow(arrRowSelected[0]);
                BLL_IOG.delete(item);
                loadData();
            }
            else
            {
                MessageBox.Show("Please choose a record Import of goods");
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_IOG.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_IOG.GetRow(arrRowSelected[0]);
                frmIOGDetail newFrm = new frmIOGDetail();
                newFrm.ID_IOG = item.ID_IOG;
                newFrm.FormClosed += (o, evt) =>
                {
                    // update total price of import
                    BLL_IOG.updateTotalPrice(item);
                    this.Close();
                    Program.frmcontainer.barBtn_Import.PerformClick();
                };
                newFrm.Show();
            }
            else
            {
                MessageBox.Show("Please choose a record Import of goods");
            }
           
        }

        private void gridView_IOG_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] arrRowSelected = gridView_IOG.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_IOG.GetRow(arrRowSelected[0]);
                cbbSupplier.SelectedValue = item.ID_SUPPLIER;
                dateTimePicker_dateCreate.Value = item.DATE_IOG;
                lblTotalPrice.Text = item.TOTAL_PRICE.ToString();
                lblTotalQuantity.Text = "Chua lam";
                txtNote.Text = item.NOTE;
            }
        }
    }
}