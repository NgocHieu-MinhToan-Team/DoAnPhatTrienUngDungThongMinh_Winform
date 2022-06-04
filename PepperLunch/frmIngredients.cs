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
            BLL_Ingredient.add(ingredient);
           
            
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
                BLL_Ingredient.update(ingredient);
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
        }

    }
}