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
    public partial class frmIngredients : DevExpress.XtraEditors.XtraForm
    {
        public frmIngredients()
        {
            InitializeComponent();
        }

        private void frmIngredients_Load(object sender, EventArgs e)
        {
            gridControl_Ingredient.DataSource = BLL_Ingredient.getList();
            cbbSupplier.DataSource = BLL_Ingredient.getListSupplier();
            cbbSupplier.DisplayMember = "NAME_SUPPLIER";
            cbbSupplier.ValueMember = "ID_SUPPLIER";
        }

        private void gridView_Ingredient_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] index = gridView_Ingredient.GetSelectedRows();
            if (index != null)
            {
                INGREDIENT item = (INGREDIENT)gridView_Ingredient.GetRow(index[0]);
                txtNameIngredient.Text = item.NAME_INGREDIENT;
                cbbSupplier.SelectedValue = item.ID_SUPPLIER;
            }
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            INGREDIENT ingredient = new INGREDIENT();
            ingredient.ID_INGREDIENT = GeneralMethods.createID("NL");
            int[] index = gridView_Ingredient.GetSelectedRows();
            if (index != null)
            {
                ingredient.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
            }
            ingredient.NAME_INGREDIENT = txtNameIngredient.Text;
            ingredient.INVENTORY = 0;
            if(BLL_Ingredient.checkNameExist(ingredient.NAME_INGREDIENT, ingredient.ID_SUPPLIER))
            {
                if(BLL_Ingredient.add(ingredient))
                    XtraMessageBox.Show("add success");
            }
            else
            {
                XtraMessageBox.Show("Supplier : " + ingredient.ID_SUPPLIER +"existed this ingredient "+ ingredient.NAME_INGREDIENT);
            }
            gridControl_Ingredient.DataSource = BLL_Ingredient.getList();

        }

        private void btnUpdateIngredient_Click(object sender, EventArgs e)
        {
            INGREDIENT ingredient = new INGREDIENT();
            int[] index = gridView_Ingredient.GetSelectedRows();
            if (index != null)
            {
                INGREDIENT item = (INGREDIENT)gridView_Ingredient.GetRow(index[0]);
                ingredient.ID_INGREDIENT = item.ID_INGREDIENT;
                ingredient.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
                ingredient.INVENTORY = item.INVENTORY;
                ingredient.NAME_INGREDIENT = txtNameIngredient.Text;
                if (BLL_Ingredient.checkNameExist(ingredient.NAME_INGREDIENT, ingredient.ID_SUPPLIER))
                {
                    if (BLL_Ingredient.update(ingredient))
                        XtraMessageBox.Show("add success");
                }
                else
                {
                    XtraMessageBox.Show("Supplier : " + ingredient.ID_SUPPLIER + "existed this ingredient " + ingredient.NAME_INGREDIENT);
                }
                gridControl_Ingredient.DataSource = BLL_Ingredient.getList();
            }
           
        }

        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            INGREDIENT ingredient = new INGREDIENT();
            int[] index = gridView_Ingredient.GetSelectedRows();
            if (index != null)
            {
                INGREDIENT item = (INGREDIENT)gridView_Ingredient.GetRow(index[0]);
                ingredient.ID_INGREDIENT = item.ID_INGREDIENT;
                ingredient.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
                ingredient.INVENTORY = item.INVENTORY;
                ingredient.NAME_INGREDIENT = txtNameIngredient.Text;
                BLL_Ingredient.remove(ingredient);
            }
            gridControl_Ingredient.DataSource = BLL_Ingredient.getList();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int[] index = gridView_Ingredient.GetSelectedRows();
            if (index != null)
            {
                INGREDIENT rowData = (INGREDIENT)gridView_Ingredient.GetRow(index[0]);
                DialogResult resultDialog = XtraMessageBox.Show("Are you certain create a IOG from Supplier :" + rowData.ID_SUPPLIER.ToString(), "Confirm Handle", MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question);
                if (resultDialog == DialogResult.Cancel)
                {
                    return;
                }
                // create Import
                IMPORT item = new IMPORT();
                item.ID_IOG = GeneralMethods.createID("NH");
                item.ID_SUPPLIER = rowData.ID_SUPPLIER;
                item.USERNAME_STAFF = Program.frmlogin.staff_global.USERNAME_STAFF;
                item.DATE_IOG = DateTime.Now;
                item.TOTAL_PRICE = 0;
                item.NOTE = "";
                item.STATE_IMPORT = 0;
                BLL_IOG.insert(item);
                // create detail Import
                frmIOGDetail newFrm = new frmIOGDetail();
                newFrm.ID_IOG = item.ID_IOG;
                newFrm.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
                newFrm.FormClosed += (o, evt) =>
                {
                    this.Close();
                    Program.frmcontainer.barBtn_Import.PerformClick();
                };
                newFrm.Show();
            }

            
        }
    }
}