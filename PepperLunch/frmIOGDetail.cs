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
    public partial class frmIOGDetail : DevExpress.XtraEditors.XtraForm
    {
        BLL_IOGDetail bll_iogDetail = new BLL_IOGDetail();
        public string ID_IOG { get; set; }
        public string ID_SUPPLIER { get; set; }
        public frmIOGDetail()
        {
            InitializeComponent();
        }

        private void frmIOGDetail_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            List<IOGDETAIL_JOIN> listIOGDETAIL = bll_iogDetail.getListJoinByID(ID_IOG);
            // filter 
            List<INGREDIENT> listIngredient = BLL_Ingredient.getListByID_SUPPLIER(ID_SUPPLIER);
            foreach (IOGDETAIL_JOIN item in listIOGDETAIL)
            {
                INGREDIENT itemDel = listIngredient.SingleOrDefault(t => t.ID_INGREDIENT == item.ID_INGREDIENT);
                listIngredient.Remove(itemDel);
            }
            gridControl_Ingredient.DataSource = listIngredient;
            gridControl_IOGDetail.DataSource = listIOGDETAIL;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_Ingredient.GetSelectedRows();
            if (arrRowSelected.Length > 0)
            {
                INGREDIENT item = (INGREDIENT)gridView_Ingredient.GetRow(arrRowSelected[0]);
                DETAIL_IMPORT newDetail = new DETAIL_IMPORT();
                newDetail.ID_DETAIL_IOG = GeneralMethods.createID("DETAILIOG");
                newDetail.ID_IOG = ID_IOG;
                newDetail.ID_INGREDIENT = item.ID_INGREDIENT;
                newDetail.PRICE = 0;
                newDetail.QUANTITY = 1;
                bll_iogDetail.insert(newDetail);
                loadData();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_IOGDetail.GetSelectedRows();
            if (arrRowSelected.Length >0 )
            {
                DETAIL_IMPORT item = (DETAIL_IMPORT)gridView_IOGDetail.GetRow(arrRowSelected[0]);
                bll_iogDetail.delete(item);
                loadData();
            }
        }

        private void gridView_IOGDetail_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            // update so luong
            int w = 0;
            try
            {
                w = Int32.Parse(e.Value.ToString());
            }
            catch
            {
                XtraMessageBox.Show("It must be number!");
                // set old value
                e.Value = 0;
                return;
            }
            if (w <= 0)
            {
                XtraMessageBox.Show("Quantity at least 1");
                // set default value
                e.Value = 1;
            }
            else
            {
                int[] arrRowSelected = gridView_IOGDetail.GetSelectedRows();
                if (arrRowSelected.Length > 0)
                {
                    IOGDETAIL_JOIN item = (IOGDETAIL_JOIN)gridView_IOGDetail.GetRow(arrRowSelected[0]);
                    DETAIL_IMPORT itemUpdate = bll_iogDetail.getList(ID_IOG).SingleOrDefault(t => t.ID_DETAIL_IOG == item.ID_DETAIL_IOG);
                    itemUpdate.QUANTITY = w;
                    bll_iogDetail.update(itemUpdate);
                    loadData();
                }
            }
        }
    }
}