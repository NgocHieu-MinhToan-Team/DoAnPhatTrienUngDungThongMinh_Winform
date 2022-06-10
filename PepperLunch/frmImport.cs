using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_PPL;
using DTO_PPL;
using DevExpress.XtraBars.Navigation;
using System.Windows.Forms;

namespace PepperLunch
{
    public partial class frmImport : DevExpress.XtraEditors.XtraForm
    {
        BLL_IOGDetail bll_iogDetail = new BLL_IOGDetail();
        // get id staff 
        private static string username = Program.frmlogin.staff_global.USERNAME_STAFF;
        private const int TAB_HISTORY = 1;
        private const int TAB_ORDERING = 0;

        public frmImport()
        {
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            loadCbbSupplier();
            loadHistoryImport();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult resultDialog = MessageBox.Show("Are you certain create a IOG from Supplier :" +cbbSupplier.SelectedValue.ToString(),"Confirm Handle", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question);
            if (resultDialog == DialogResult.Cancel)
            {
                return;
            }
            // create Import
            IMPORT item = new IMPORT();
            item.ID_IOG = GeneralMethods.createID("NH");
            item.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
            item.USERNAME_STAFF = username;
            item.DATE_IOG = DateTime.Now;
            item.TOTAL_PRICE = 0;
            item.NOTE =txtNote.Text;
            item.STATE_IMPORT = 0;
            BLL_IOG.insert(item);
            loadDataOnTabs();
            // create detail Import
            frmIOGDetail newFrm = new frmIOGDetail();
            newFrm.ID_IOG = item.ID_IOG;
            newFrm.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
            newFrm.note = item.NOTE;
            newFrm.FormClosed += (o, evt) =>
            {
                // update total price of import
                BLL_IOG.updateTotalPrice(item);
                // update INVENTORY in INGREDIENTS
                if (item.STATE_IMPORT == TAB_ORDERING)
                {
                    foreach (DETAIL_IMPORT detail in bll_iogDetail.getList(item.ID_IOG))
                    {
                        INGREDIENT updateItem = BLL_Ingredient.getList().SingleOrDefault(t => t.ID_INGREDIENT == detail.ID_INGREDIENT);
                        updateItem.INVENTORY += detail.QUANTITY;
                        BLL_Ingredient.update(updateItem);
                    }
                    item.STATE_IMPORT = 1;
                    BLL_IOG.update(item);
                }
                this.Close();
                Program.frmcontainer.barBtn_Import.PerformClick();
            };
            newFrm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_OrderingImport.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_OrderingImport.GetRow(arrRowSelected[0]);
                item.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
                item.USERNAME_STAFF = username;
                item.DATE_IOG = DateTime.Now;
                item.TOTAL_PRICE = item.TOTAL_PRICE;
                item.NOTE ="";
                item.STATE_IMPORT = 0;
                BLL_IOG.update(item);
                loadDataOnTabs();
            }
            else
            {
                MessageBox.Show("Please choose a record Import of goods");
            }
        }


        private void gridView_IOG_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] arrRowSelected = gridView_OrderingImport.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_OrderingImport.GetRow(arrRowSelected[0]);
                cbbSupplier.SelectedValue = item.ID_SUPPLIER;
                dateTimePicker_dateCreate.Value = item.DATE_IOG;
                int countQuantity = (int)bll_iogDetail.getList(item.ID_IOG).Sum(t => t.QUANTITY);
                txtNote.Text = item.NOTE;
            }
        }

        void loadCbbSupplier()
        {
            cbbSupplier.DataSource = BLL_Ingredient.getListSupplier();
            cbbSupplier.DisplayMember = "NAME_SUPPLIER";
            cbbSupplier.ValueMember = "ID_SUPPLIER";
        }
        private void tabPaneImport_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            loadDataOnTabs();
        }

        void loadDataOnTabs()
        {
            if (tabPaneImport.SelectedPageIndex == TAB_HISTORY)
            {
                loadHistoryImport();
            }
            if (tabPaneImport.SelectedPageIndex == TAB_ORDERING)
            {
                loadOrderingImport();
            }
        }

        private void gridControl_historyImport_Click(object sender, EventArgs e)
        {

        }

        void loadHistoryImport()
        {
            gridControl_historyImport.DataSource = BLL_IOG.getImportsByStatus(TAB_HISTORY);
        }
        void loadOrderingImport()
        {
            gridControl_OrderingImport.DataSource = BLL_IOG.getImportsByStatus(TAB_ORDERING);
        }

        private void repositoryItemButtonEdit_detele_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_OrderingImport.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_OrderingImport.GetRow(arrRowSelected[0]);
                BLL_IOG.delete(item);
                loadOrderingImport();
            }
            else
            {
                MessageBox.Show("Please choose a record Import of goods");
            }
        }

        private void cbbSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            // delete import
            gridControl_historyImport.DataSource = BLL_IOG.getImportsByStatus(TAB_ORDERING, cbbSupplier.SelectedValue.ToString());
        }

        private void repositoryItemButtonEdit_detail_Click(object sender, EventArgs e)
        {
            // see detail of import 
            int[] arrRowSelected = gridView_historyImport.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_historyImport.GetRow(arrRowSelected[0]);
                frmConfirmImport frm = new frmConfirmImport();
                frm.FormClosed += (o, evt) =>
                {
                    this.Close();
                    BLL_IOG.updateTotalPrice(item);
                    Program.frmcontainer.barBtn_Import.PerformClick();
                };
               frm.ID_IOG = item.ID_IOG;
                frm.ShowDialog();

            }
           
        }
    }
}