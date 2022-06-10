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
        public string note { get; set; }
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
            gridControl_IOGDetail.DataSource = bll_iogDetail.getList(ID_IOG);
            gridControl_Ingredient.DataSource = BLL_Ingredient.getListByID_SUPPLIER(ID_SUPPLIER);
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
                newDetail.QUANTITY = 0;
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
        private void gridView_IOGDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int[] arrRowSelected = gridView_IOGDetail.GetSelectedRows();
            if (arrRowSelected.Length > 0)
            {
                DETAIL_IMPORT item = (DETAIL_IMPORT)gridView_IOGDetail.GetRow(arrRowSelected[0]);
                if (!bll_iogDetail.validateIsNumber(item.PRICE.ToString()) || bll_iogDetail.validateIsNumber(item.QUANTITY.ToString()))
                {
                    MessageBox.Show("Must be number [0-9] at record "+item.ID_INGREDIENT);
                    return;
                }
                bll_iogDetail.update(item);
                loadData();
            }
        }
    }
}