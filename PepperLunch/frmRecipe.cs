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
using DevExpress.XtraGrid.Views.Grid;

namespace PepperLunch
{
    public partial class frmRecipe : DevExpress.XtraEditors.XtraForm
    {
        public static string ID_PRODUCT = null, ID_INGREDIENT = null;
        public static bool isUpdate { get; set; }
        public frmRecipe()
        {
            InitializeComponent();
            this.Text += " " + ID_PRODUCT;
        }

        private void frmRecipe_Load(object sender, EventArgs e)
        {
            loadRecipe();
        }

        private void btnOpenIngredient_Click(object sender, EventArgs e)
        {
            frmIngredients frm = new frmIngredients();
            frm.Show();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void loadRecipe()
        {
            List<RECIPE_JOIN> listRecipe = BLL_Recipe.getRecipeJoin(ID_PRODUCT);
            // filter 
            List<INGREDIENT> listIngredient = BLL_Ingredient.getList();
            foreach (RECIPE_JOIN item in BLL_Recipe.getRecipeJoin(ID_PRODUCT))
            {
                INGREDIENT itemDel = listIngredient.SingleOrDefault(t => t.ID_INGREDIENT == item.ID_INGREDIENT);
                listIngredient.Remove(itemDel);
            }
            gridControl_Ingredient.DataSource = listIngredient;
            gridControl_detailProduct.DataSource = listRecipe;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_Ingredient.GetSelectedRows();
            if (arrRowSelected != null)
            {
                if (ID_PRODUCT == null || ID_INGREDIENT == null)
                {
                    MessageBox.Show("Please choose product and ingredient !");
                    return;
                }
                DETAIL_PRODUCT newItem = new DETAIL_PRODUCT();
                newItem.ID_DETAIL = GeneralMethods.createID("RECIPE");
                newItem.ID_PRODUCT = ID_PRODUCT;
                newItem.ID_INGREDIENT = ID_INGREDIENT;
                newItem.WEIGHT_DETAIL = 0;
                BLL_Recipe.add(newItem);
                loadRecipe();
            }
            else
            {
                MessageBox.Show("Please choose 1 ingredient !");
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_detailProduct.GetSelectedRows();
            if (arrRowSelected != null)
            {
                string item = gridView_detailProduct.GetRowCellValue(arrRowSelected[0], "ID_DETAIL").ToString();
                var tmp = BLL_Recipe.getList(ID_PRODUCT);
                DETAIL_PRODUCT itemDel = BLL_Recipe.getList(ID_PRODUCT).SingleOrDefault(t => t.ID_DETAIL == item);
                BLL_Recipe.remove(itemDel);
                loadRecipe();
            }
            else
            {
                MessageBox.Show("Please choose 1 ingredient !");
            }
        }
        private void gridView_detailProduct_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            // update so luong
            int w=0;
            try
            {
                w = Int32.Parse(e.Value.ToString());
            }
            catch
            {
                XtraMessageBox.Show("It must be number!");
                // set old value
                e.Value = getOldQuantity();
            }

            if (w > 0)
            {
                //update quantity
                int[] arrRowSelected = gridView_detailProduct.GetSelectedRows();
                if (arrRowSelected != null)
                {
                    RECIPE_JOIN item = (RECIPE_JOIN)gridView_detailProduct.GetRow(arrRowSelected[0]);
                    DETAIL_PRODUCT itemUpdate = BLL_Recipe.getList(ID_PRODUCT).SingleOrDefault(t => t.ID_DETAIL == item.ID_DETAIL);
                    itemUpdate.WEIGHT_DETAIL = w;
                    BLL_Recipe.update(itemUpdate);
                }
            }
            else
            {
                XtraMessageBox.Show("Quantity must be higher  0");
                // set old value
                e.Value = getOldQuantity();
            }
        }

        int getOldQuantity()
        {
            int w=0;
            XtraMessageBox.Show("Quantity must be higher  0");
            int[] arrRowSelected = gridView_detailProduct.GetSelectedRows();
            if (arrRowSelected != null)
            {
                RECIPE_JOIN item = (RECIPE_JOIN)gridView_detailProduct.GetRow(arrRowSelected[0]);
                w = (int)BLL_Recipe.getList(ID_PRODUCT).SingleOrDefault(t => t.ID_DETAIL == item.ID_DETAIL).WEIGHT_DETAIL;
            }
            return w;
        }


        private void frmRecipe_FormClosing(object sender, FormClosingEventArgs e)
        {

            List<DETAIL_PRODUCT> list = BLL_Recipe.getList(ID_PRODUCT);
            if (list.Count == 0)
            {
                BLL_Product.deleteProduct(ID_PRODUCT);
                return;
            }
            // check weight in list recipe 
            // if entire weight in list recipe > 0 -> ok 
            // else cancel and report to user

            string note = "";
            foreach(DETAIL_PRODUCT item in list)
            {
                if (item.WEIGHT_DETAIL <= 0)
                {
                    note += item.ID_INGREDIENT + " , ";
                }
            }

            if (note != "")
            {
                XtraMessageBox.Show("Not set weight for : " + note);
                e.Cancel = true;
            }
        }

        private void gridView_Ingredient_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] arrRowSelected = gridView_Ingredient.GetSelectedRows();
            if (arrRowSelected != null)
            {
                INGREDIENT item = (INGREDIENT)gridView_Ingredient.GetRow(arrRowSelected[0]);
                ID_INGREDIENT = item.ID_INGREDIENT;
            }
            else
            {
                MessageBox.Show("Please choose 1 ingredient !");
            }
        }
    }
}