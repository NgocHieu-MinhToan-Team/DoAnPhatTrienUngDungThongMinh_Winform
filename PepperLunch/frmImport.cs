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
using DevExpress.XtraGrid.Columns;

namespace PepperLunch
{
    public partial class frmImport : DevExpress.XtraEditors.XtraForm
    {
        BLL_IOGDetail bll_iogDetail = new BLL_IOGDetail();
        // get id staff 
        public static string username { get; set; }
        private const int TAB_HISTORY = 1;
        private const int TAB_ORDERING = 0;

        public frmImport()
        {
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            loadCbbSupplier();
            loadOrderingImport();
            loadHistoryImport();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult resultDialog = XtraMessageBox.Show("Are you certain create a IOG from Supplier :" +cbbSupplier.SelectedValue.ToString(),"Confirm Handle", MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question);
            if (resultDialog == DialogResult.Cancel)
            {
                return;
            }
            // create Import
            IMPORT item = new IMPORT();
            item.ID_IOG = GeneralMethods.createID("NH");
            item.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
            item.USERNAME_STAFF = username;
            item.DATE_IOG = dateTimePicker_dateCreate.Value;
            item.TOTAL_PRICE = 0;
            item.NOTE ="";
            item.STATE_IMPORT = 0;
            BLL_IOG.insert(item);
            loadOrderingImport();
            // create detail Import
            frmIOGDetail newFrm = new frmIOGDetail();
            newFrm.ID_IOG = item.ID_IOG;
            newFrm.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
            newFrm.FormClosed += (o, evt) =>
            {
                this.Close();
                Program.frmcontainer.barBtn_Import.PerformClick();
            };
            newFrm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_history.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_history.GetRow(arrRowSelected[0]);
                item.ID_SUPPLIER = cbbSupplier.SelectedValue.ToString();
                item.USERNAME_STAFF = username;
                item.DATE_IOG = DateTime.Now;
                item.TOTAL_PRICE = item.TOTAL_PRICE;
                item.NOTE ="";
                item.STATE_IMPORT = 0;
                BLL_IOG.update(item);
                loadOrderingImport();
            }
            else
            {
                MessageBox.Show("Please choose a record Import of goods");
            }
        }


        private void gridView_IOG_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] arrRowSelected = gridView_history.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_history.GetRow(arrRowSelected[0]);
                cbbSupplier.SelectedValue = item.ID_SUPPLIER;
                dateTimePicker_dateCreate.Value = item.DATE_IOG;
                int countQuantity = (int)bll_iogDetail.getList(item.ID_IOG).Sum(t => t.QUANTITY);
               
            }
        }

        void loadCbbSupplier()
        {
            cbbSupplier.DataSource = BLL_Ingredient.getListSupplier();
            cbbSupplier.DisplayMember = "NAME_SUPPLIER";
            cbbSupplier.ValueMember = "ID_SUPPLIER";
        }
       

        void loadHistoryImport()
        {
            gridControl_history.DataSource = BLL_IOG.getImportsByStatus(TAB_HISTORY);
        }
        void loadOrderingImport()
        {
            gridControl_orders.DataSource = BLL_IOG.getImportsByStatus(TAB_ORDERING);
        }
        private void cbbSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            // delete import
            gridControl_orders.DataSource = BLL_IOG.getImportsByStatus(TAB_ORDERING, cbbSupplier.SelectedValue.ToString());
        }
        private void repositoryItemButtonEdit_UpdateIOG_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_orders.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_orders.GetRow(arrRowSelected[0]);
                frmIOGDetail frm = new frmIOGDetail();
                frm.FormClosed += (o, evt) =>
                {
                    this.Close();
                    Program.frmcontainer.barBtn_Import.PerformClick();
                };
                frm.ID_IOG = item.ID_IOG;
                frm.ID_SUPPLIER = item.ID_SUPPLIER;
                frm.ShowDialog();
            }
        }

        private void repositoryItemButtonEdit_confirm_Click(object sender, EventArgs e)
        {
            //confirm of import
            int[] arrRowSelected = gridView_orders.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_orders.GetRow(arrRowSelected[0]);
                frmConfirmImport frm = new frmConfirmImport();
                frm.FormClosed += (o, evt) =>
                {
                    this.Close();
                    // bỏ dòng bên dưới
                   //BLL_IOG.updateTotalPrice(item);
                    Program.frmcontainer.barBtn_Import.PerformClick();
                };
                frm.ID_IOG = item.ID_IOG;
                frm.ShowDialog();
            }
        }

        private void btnLoadHistoryReceipt_Click(object sender, EventArgs e)
        {
            loadHistoryImport();
        }

        private void repositoryItemButtonEdit_change_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_history.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMPORT item = (IMPORT)gridView_history.GetRow(arrRowSelected[0]);
                frmConfirmImport frm = new frmConfirmImport();
                frm.FormClosed += (o, evt) =>
                {
                    this.Close();
                    Program.frmcontainer.barBtn_Import.PerformClick();
                };
                frm.ID_IOG = item.ID_IOG;
                frm.ShowDialog();
            }
        }
    }
}