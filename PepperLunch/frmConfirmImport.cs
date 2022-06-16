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


        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (!GeneralMethods.isDigit(txtQuantity.Text, false) || !GeneralMethods.isDigit(txtPrice.Text, false))
            {
                XtraMessageBox.Show("Not be Null and must be number");
                return;
            }
           
            IMPORT imp = BLL_IOG.getList().SingleOrDefault(t => t.ID_IOG == ID_IOG);
            string note = imp.NOTE;
            int[] arrRowSelected = gridView_IOGDetail.GetSelectedRows();
            if (arrRowSelected.Length > 0)
            {
                 IOGDETAIL_JOIN datafromRow = (IOGDETAIL_JOIN)gridView_IOGDetail.GetRow(arrRowSelected[0]);
                DETAIL_IMPORT item = bll_iogDetail.getList(ID_IOG).SingleOrDefault(t => t.ID_DETAIL_IOG == datafromRow.ID_DETAIL_IOG);
                try
                {
                    int qty =Int32.Parse(txtQuantity.Text);
                    int price = Int32.Parse(txtPrice.Text);
                    if (qty > 0 && price > 0)
                    {

                        int number = (int)(item.QUANTITY - Int32.Parse(txtQuantity.Text));
                        if (number < 0)
                        {
                            XtraMessageBox.Show("just need enter enough");
                            return;
                        }
                        if(number>0)
                        {
                            note += "{ " + item.ID_INGREDIENT + " Thiếu " + Math.Abs(number).ToString() + " }, ";
                            //if not enough , will be update quantity
                            item.QUANTITY = qty;
                        }
                        item.PRICE = price;
                        bll_iogDetail.update(item);

                        IMPORT import = new IMPORT();
                        import.ID_IOG = ID_IOG;
                        import.NOTE = note;
                        BLL_IOG.updateNote(import);
                    }
                    gridView_IOGDetail.DeleteRow(arrRowSelected[0]);
                    clearText();
                }
                catch
                {
                    XtraMessageBox.Show("It Must be number type Interger");
                    return;
                }
            }
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

        private void gridControl_IOGDetail_Click(object sender, EventArgs e)
        {

        }
    }
}