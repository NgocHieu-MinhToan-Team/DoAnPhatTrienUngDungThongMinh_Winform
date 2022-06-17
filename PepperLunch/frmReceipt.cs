 using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_PPL;
using DTO_PPL;
using FireBase_PPL;
// lib for export excel
using DevExpress.XtraPrinting;
using System.Diagnostics;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using System.Threading.Tasks;

namespace PepperLunch
{
    public partial class frmReceipt : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private const int CONFIRM = 1;
        private const int DELIVERY = 2;
        private const int COMPLETE = 3;
        private const int CANCEL = 4;


        public frmReceipt()
        {
            InitializeComponent();

        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            loadData();
        }

        async void loadData()
        {
            // check customer not sync
            List<Customer> listOfLocal = await BLL_Synchronized.getCustomersNotSync();
            if (listOfLocal.Count>0)
            {
                XtraMessageBox.Show("Có Khách Hàng Mới Vui Lòng Đồng bộ Khách hàng mới trước khi đồng bộ hóa đơn !");
            }

            accordionControl1.Enabled = false;
            gridView_receiptFB.ShowLoadingPanel();
            gridView_receiptSql.ShowLoadingPanel();

            List<RECEIPT> list = await FB_Receipt.getEntireNotSync();
            gridControl_receiptFB.DataSource = list;
            gridControl_receiptSql.DataSource = BLL_Receipt.getList();

            gridView_receiptFB.HideLoadingPanel();
            gridView_receiptSql.HideLoadingPanel();
            accordionControl1.Enabled = true;

        }

        private void accordionCtrlE_exportWord_Click(object sender, EventArgs e)
        {
            // export from from sql
            int[] arrRowSelected = gridView_receiptSql.GetSelectedRows();
            if (arrRowSelected != null)
            {
                RECEIPT item = (RECEIPT)gridView_receiptSql.GetRow(arrRowSelected[0]);
                BLL_Receipt.export_ReceiptToWord(item.ID_RECEIPT);
            }
            // retrieve to receipt to export 
        }

        private void accordionCtrlE_exportExcel_Click(object sender, EventArgs e)
        {
            string path = "Templates\\Export.xlsx";
            //Customize export options
           gridView_receiptSql.OptionsPrint.PrintHeader = true;
            XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
            advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
            advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
            advOptions.SheetName = "Exported from Data Grid";

            gridControl_receiptSql.ExportToXlsx(path, advOptions);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }


        private async void accordionCtrlE_SyncFromFirebase_Click(object sender, EventArgs e)
        {
            if (!await checkCustomerNotSyncAsync())
            {
                return;
            }

            SplashScreenManager.ShowForm(typeof(waitFrmLoading));
            accordionControl1.Enabled = false;
            List<RECEIPT> listNotSync = await FB_Receipt.getEntireNotSync();
            if (listNotSync.Count == 0)
            {
                XtraMessageBox.Show("Chưa có đơn hàng mới !");
                accordionControl1.Enabled = true;
                SplashScreenManager.CloseForm();
                return;
            }
           
            if (await FB_Receipt.updateEntireReceiptFromFirebase(CONFIRM))
            {
                XtraMessageBox.Show("Tất Cả Đơn Hàng Đã Được thêm Vào SQL");
                loadData();
            }
            else
            {
                XtraMessageBox.Show("Nguyên Liệu Không Đủ");
            }
            //await FB_Receipt.updateDetailReceiptFromFirebase();
            accordionControl1.Enabled = true;
            SplashScreenManager.CloseForm();
        }

        private async void repositoryItemButtonEdit_confirm_Click(object sender, EventArgs e)
        {
            if (!await checkCustomerNotSyncAsync())
            {
                return;
            }

            int[] index = gridView_receiptFB.GetSelectedRows();
            if (index != null)
            {
                RECEIPT item = (RECEIPT)gridView_receiptFB.GetRow(index[0]);
                SplashScreenManager.ShowForm(typeof(waitFrmLoading));
                accordionControl1.Enabled = false;

                if (await FB_Receipt.updateReceiptFromFirebase(item,CONFIRM))
                {
                    XtraMessageBox.Show("Đơn Hàng"+item.CUSTOMER+" Đã Được thêm Vào SQL");
                    loadData();
                }
                else
                {
                    // update status Cancel Order 
                    DialogResult rs =  XtraMessageBox.Show("Đơn Hàng "+item.ID_RECEIPT+" của Khách hàng có ID :"+item.ID_CUSTOMER+"Đang Không Đủ Nguyên Liệu" +" ,Chọn Yes : Hủy Đơn Hàng -- No : Quay Lại ","Confifm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        await FB_Receipt.updateStatusReceipt(item, CANCEL);
                        XtraMessageBox.Show("Đơn Hàng Bị Hủy , Đang Phản Hồi Đến Khách Hàng");
                    }
                }
                //await FB_Receipt.updateDetailReceiptFromFirebase();
                accordionControl1.Enabled = true;
                SplashScreenManager.CloseForm();
              

            }

        }
        async Task<bool> checkCustomerNotSyncAsync()
        {
            // check customer not sync
            List<Customer> listOfLocal = await BLL_Synchronized.getCustomersNotSync();
            if (listOfLocal.Count > 0)
            {
                XtraMessageBox.Show("Có Khách Hàng Mới Vui Lòng Đồng bộ Khách hàng mới trước khi đồng bộ hóa đơn !");
                return false;
            }
            return true;
        }

        private async void repositoryItemButtonEdit_response_Click(object sender, EventArgs e)
        {
            int[] index = gridView_receiptSql.GetSelectedRows();
            if (index != null)
            {
                RECEIPT item = (RECEIPT)gridView_receiptSql.GetRow(index[0]);
                if(item.STATE_RECEIPT == CONFIRM)
                {
                    await FB_Receipt.updateStatusReceipt(item, DELIVERY);
                
                    XtraMessageBox.Show("Đơn Hàng Đã Xong , Chuyển Sang Trạng Thái Vận Chuyển");
                    loadData();
                    return;
                }
                repositoryItemButtonEdit_response.ReadOnly = true;
                return;
            }
        }

        private void repositoryItemButtonEdit_seemore_Click(object sender, EventArgs e)
        {
            int[] index = gridView_receiptSql.GetSelectedRows();
            if (index != null)
            {
                RECEIPT item = (RECEIPT)gridView_receiptSql.GetRow(index[0]);
                frmDetailReceipt frm = new frmDetailReceipt();
                frm.ID = item.ID_RECEIPT;
                frm.ShowDialog();
            }
        }

        private async void repositoryItemButtonEdit_CompleteOrder_Click(object sender, EventArgs e)
        {
            int[] index = gridView_receiptSql.GetSelectedRows();
            if (index != null)
            {
                RECEIPT item = (RECEIPT)gridView_receiptSql.GetRow(index[0]);
                if (item.STATE_RECEIPT == DELIVERY)
                {
                    await FB_Receipt.updateStatusReceipt(item, COMPLETE);
                    XtraMessageBox.Show("Hoàn Tất Giao Hàng");
                    loadData();
                    return;
                }
                repositoryItemButtonEdit_CompleteOrder.ReadOnly = true;
                return;
            }
        }

        private void accordionCtrlE_Reload_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
