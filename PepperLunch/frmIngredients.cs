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
    }
}