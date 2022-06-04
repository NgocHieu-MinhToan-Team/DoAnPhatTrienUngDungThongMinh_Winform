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
        public string ID_IOG { get; set; }
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
            gridControl_IOGDetail.DataSource = BLL_IOGDetail.getList(ID_IOG);
            gridView_IOGDetail.Columns["IMPORT"].Visible = gridView_IOGDetail.Columns["INGREDIENT"].Visible = false;
            gridControl_Ingredient.DataSource = BLL_Ingredient.getList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_Ingredient.GetSelectedRows();
            if (arrRowSelected != null)
            {
                INGREDIENT item = (INGREDIENT)gridView_Ingredient.GetRow(arrRowSelected[0]);
                DETAIL_IMPORT newDetail = new DETAIL_IMPORT();
                newDetail.ID_DETAIL_IOG = GeneralMethods.createID("DETAILIOG");
                newDetail.ID_IOG = ID_IOG;
                newDetail.ID_INGREDIENT = item.ID_INGREDIENT;
                if(!BLL_IOGDetail.validateIsNumber(txtPrice.Text, txtCount.Text))
                {
                    MessageBox.Show("Please Enter Count and Price for " + item.NAME_INGREDIENT);
                    return;
                }
                newDetail.PRICE = Int32.Parse(txtPrice.Text);
                newDetail.QUANTITY = Int32.Parse(txtCount.Text);
                BLL_IOGDetail.insert(newDetail);
                loadData();
                clearTextBox();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_IOGDetail.GetSelectedRows();
            if (arrRowSelected != null)
            {
                DETAIL_IMPORT item = (DETAIL_IMPORT)gridView_IOGDetail.GetRow(arrRowSelected[0]);
                BLL_IOGDetail.delete(item);
                loadData();
                clearTextBox();
            }
        }

        void clearTextBox()
        {
            txtCount.Text = "";
            txtPrice.Text = "";
        }
    }
}