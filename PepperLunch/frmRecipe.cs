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
    public partial class frmRecipe : DevExpress.XtraEditors.XtraForm
    {
        private static string ID_PRODUCT = null, ID_INGREDIENT = null;
        public static bool isUpdate { get; set; }
        public frmRecipe()
        {
            InitializeComponent();
        }

        private void frmRecipe_Load(object sender, EventArgs e)
        {
            gridControl_Ingredient.DataSource = BLL_Ingredient.getList();
            cbbCategory.DataSource = BLL_Category.getCategories();
            cbbCategory.DisplayMember = "NAME_CATEGORY";
            cbbCategory.ValueMember = "ID_CATEGORY";
        }

        private void btnOpenIngredient_Click(object sender, EventArgs e)
        {
            frmIngredients frm = new frmIngredients();
            frm.FormClosed += (o, evt) =>
            {
                this.Close();
                Program.frmcontainer.barBtn_Ingredient.PerformClick();
            };
            frm.Show();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridControl_product.DataSource = BLL_Product.getProducts().Where(t => t.ID_CATEGORY == cbbCategory.SelectedValue.ToString()).ToList<PRODUCT>();
            for (int i = 0; i < gridView_product.Columns.Count; i++)
            {
                gridView_product.Columns[i].Visible = false;
            }
            gridView_product.Columns["NAME_PRODUCT_EN"].Visible = true;
        }

        private void gridView_product_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] arrRowSelected = gridView_product.GetSelectedRows();
            if (arrRowSelected != null)
            {
                PRODUCT pro = (PRODUCT)gridView_product.GetRow(arrRowSelected[0]);
                ID_PRODUCT = pro.ID_PRODUCT;
                loadRecipe(ID_PRODUCT);

            }
        }

        void loadRecipe(string ID)
        {
            gridControl_detailProduct.DataSource = BLL_Recipe.getRecipeJoin().Where(t => t.ID_PRODUCT == ID).ToList<RECIPE_JOIN>();
            gridView_detailProduct.Columns["ID_PRODUCT"].Visible = false;
            gridView_detailProduct.Columns["ID_INGREDIENT"].Visible = false;
            gridView_detailProduct.Columns["FLAG_DEL"].Visible = false;
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
                if (BLL_Recipe.validate(txtWeight.Text))
                {
                    DETAIL_PRODUCT newItem = new DETAIL_PRODUCT();
                    newItem.ID_DETAIL = GeneralMethods.createID("RECIPE");
                    newItem.ID_PRODUCT = ID_PRODUCT;
                    newItem.ID_INGREDIENT = ID_INGREDIENT;
                    newItem.WEIGHT_DETAIL = Convert.ToInt32(txtWeight.Text);
                    BLL_Recipe.add(newItem);
                    loadRecipe(ID_PRODUCT);
                }
                else
                {
                    MessageBox.Show("Please enter weight for recipe !");
                }
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
                var tmp = BLL_Recipe.getList();
                DETAIL_PRODUCT itemDel = BLL_Recipe.getList().SingleOrDefault(t => t.ID_DETAIL == item);
                BLL_Recipe.remove(itemDel);
                loadRecipe(ID_PRODUCT);
            }
            else
            {
                MessageBox.Show("Please choose 1 ingredient !");
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