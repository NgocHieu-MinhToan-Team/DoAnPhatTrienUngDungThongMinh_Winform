using BLL_PPL;
using DTO_PPL;
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

namespace PepperLunch
{
    public partial class frmConfirmImport : DevExpress.XtraEditors.XtraForm
    {
        public string ID_IOG { get; set; }
        List<IOGDETAIL_JOIN> listDetail;
        BLL_IOGDetail bll_iogDetail = new BLL_IOGDetail();

        public frmConfirmImport()
        {
            InitializeComponent();

        }

        private void frmConfirmImport_Load(object sender, EventArgs e)
        {
            loadData();
            this.Text += " " + ID_IOG;
        }

        void loadData()
        {
            listDetail = bll_iogDetail.getListJoinByID(ID_IOG);
            gridControl_IOGDetail.DataSource = listDetail;
        }


        private void gridView_IOGDetail_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void updateInventory(string ID_IOG)
        {
            foreach (DETAIL_IMPORT detail in bll_iogDetail.getList(ID_IOG))
            {
                INGREDIENT updateItem = BLL_Ingredient.getList().SingleOrDefault(t => t.ID_INGREDIENT == detail.ID_INGREDIENT);
                updateItem.INVENTORY += detail.QUANTITY;
                BLL_Ingredient.update(updateItem);
            }
        }


        private void repositoryItemButtonEdit_Confirm_Click(object sender, EventArgs e)
        {
            txtQuantity.Visible = false;
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {

            if(txtQuantity.Visible == false)
            {
                if (!GeneralMethods.isDigit(txtPrice.Text, false))
                {
                    XtraMessageBox.Show("Not be Null and must be number");
                    return;
                }
            }
            else
            {
                if (!GeneralMethods.isDigit(txtQuantity.Text, false) || !GeneralMethods.isDigit(txtPrice.Text, false))
                {
                    XtraMessageBox.Show("Not be Null and must be number");
                    return;
                }
            }
           
            IMPORT imp = BLL_IOG.getList().SingleOrDefault(t => t.ID_IOG == ID_IOG);
            string note = imp.NOTE;
            int[] arrRowSelected = gridView_IOGDetail.GetSelectedRows();
            if (arrRowSelected.Length > 0)
            {
                 IOGDETAIL_JOIN datafromRow = (IOGDETAIL_JOIN)gridView_IOGDetail.GetRow(arrRowSelected[0]);
                DETAIL_IMPORT item = bll_iogDetail.getList(ID_IOG).SingleOrDefault(t => t.ID_DETAIL_IOG == datafromRow.ID_DETAIL_IOG);
                // update only price
                if (txtQuantity.Visible == false)
                {
                    item.PRICE =Int32.Parse(txtPrice.Text);
                    bll_iogDetail.update(item);
                }
                else
                {

                    int number = (int)(item.QUANTITY - Int32.Parse(txtQuantity.Text));

                    if (number > 0)
                    {
                        note += "{ " + item.ID_INGREDIENT + " Thiếu " + Math.Abs(number).ToString() + " }, ";
                    }
                    //redundant / thừa
                    if (number < 0)
                    {
                        note += "{ " + item.ID_INGREDIENT + " Thừa " + Math.Abs(number).ToString() + " }, ";
                    }
                    item.PRICE = Int32.Parse(txtPrice.Text);
                    item.QUANTITY = Int32.Parse(txtQuantity.Text);
                    bll_iogDetail.update(item);

                    IMPORT import = new IMPORT();
                    import.ID_IOG = ID_IOG;
                    import.NOTE = note;
                    BLL_IOG.updateNote(import);
                }
               
                gridView_IOGDetail.DeleteRow(arrRowSelected[0]);
                clearText();

            }
        }

        private void repositoryItemButtonEdit_Incorrect_Click(object sender, EventArgs e)
        {
            txtQuantity.Visible = true;
            clearText();
        }

        private void frmConfirmImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultDialog = XtraMessageBox.Show("Do you want close ?", "Confirm", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
            if (resultDialog == DialogResult.No)
            {
                e.Cancel = true;
            }

            string report = "";
            foreach (IOGDETAIL_JOIN detail in bll_iogDetail.getListJoinByID(ID_IOG))
            {
                if (detail.PRICE <= 0 || detail.QUANTITY <= 0)
                {
                    report += detail.NAME_INGREDIENT + " , ";
                }
            }

            if (report != "")
            {
                XtraMessageBox.Show("Price or Quantity are not set in( " + report + " ).");
                e.Cancel = true;
            }
            else
            {
                // update ingredients
                updateInventory(ID_IOG);
                // update state import
                IMPORT ip = BLL_IOG.getList().SingleOrDefault(t => t.ID_IOG == ID_IOG);
                ip.STATE_IMPORT = 1;
                // update all
                BLL_IOG.update(ip);
                // update only total price
                BLL_IOG.updateTotalPrice(ip);
            }
        }

        void clearText()
        {
            txtQuantity.Text= txtPrice.Text = "";
        }
    }
}