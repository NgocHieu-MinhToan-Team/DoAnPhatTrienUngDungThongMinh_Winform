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
        List<IOGDETAIL_JOIN> listClone;

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
            List<IOGDETAIL_JOIN> listDetail;
            listDetail = bll_iogDetail.getListJoinByID(ID_IOG);
            listClone = GeneralMethods.GetClone<IOGDETAIL_JOIN>(listDetail);
            gridControl_IOGDetail.DataSource = listClone;
        }

        private void updateInventory(IOGDETAIL_JOIN DetailIOG)
        {
            INGREDIENT updateItem = BLL_Ingredient.getList().SingleOrDefault(t => t.ID_INGREDIENT == DetailIOG.ID_INGREDIENT);
            updateItem.INVENTORY += DetailIOG.QUANTITY;
            BLL_Ingredient.update(updateItem);
        }
        private void frmConfirmImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultDialog = XtraMessageBox.Show("Do you want to SAVE change?", "Confirm", MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question);
            if (resultDialog == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            // save
            if(resultDialog == DialogResult.Yes)
            {
                //check entire price
                foreach (IOGDETAIL_JOIN item in listClone)
                {
                    if (item.PRICE == 0)
                    {
                        DialogResult resultDialog2 = XtraMessageBox.Show("There are some price of ingredients not set! Do you want to SAVE change? ", "Confirm", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
                        if (resultDialog2 == DialogResult.No)
                        {
                            return;
                        }
                        break;
                    }
                }
                int totalPrice = 0;
                foreach (IOGDETAIL_JOIN item in listClone)
                {
                    if (bll_iogDetail.update(item))
                    {
                        // update inventory
                        updateInventory(item);
                        totalPrice += int.Parse(item.PRICE.ToString()) * int.Parse(item.QUANTITY.ToString());
                    }
                    else
                    {
                        XtraMessageBox.Show("Has error", "Confirm");
                    }
                }
                List<DETAIL_IMPORT> listDetail = bll_iogDetail.getList(ID_IOG);
                // update import
                IMPORT ip = BLL_IOG.getList().SingleOrDefault(t => t.ID_IOG == ID_IOG);
                ip.STATE_IMPORT = 1;
                ip.TOTAL_PRICE = totalPrice;
                BLL_IOG.update(ip);

            }
        }

        private void gridView_IOGDetail_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            // update so luong
            int w ;
            try
            {
                w = Int32.Parse(e.Value.ToString());
                if (w <= 0)
                {
                    XtraMessageBox.Show("Quantity at least 1");
                    // set default value
                    e.Value = 0;
                }
                else
                {
                    XtraMessageBox.Show("Change success!");
                }
            }
            catch
            {
                XtraMessageBox.Show("It must be number!");
                // set old value
                e.Value = 0;
                return;
            }
           
        }

        private void gridView_IOGDetail_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }
    }
}