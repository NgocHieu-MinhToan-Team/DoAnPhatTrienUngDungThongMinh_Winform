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

namespace PepperLunch
{
    public partial class frmReceipt : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private const int CONFIRM = 1;
        private const int COMPLETE = 2;
        private const int CANCEL = 3;


        List<RECEIPT_FULL> listData;
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
            int[] arrRowSelected = gridView_receiptFB.GetSelectedRows();
            if (arrRowSelected != null)
            {
                RECEIPT item = (RECEIPT)gridView_receiptFB.GetRow(arrRowSelected[0]);
                BLL_Receipt.export_ReceiptToWord(item.ID_RECEIPT);
            }
            // retrieve to receipt to export 
        }

        private void accordionCtrlE_exportExcel_Click(object sender, EventArgs e)
        {
            string path = "Templates\\Export.xlsx";
            //Customize export options
           gridView_receiptFB.OptionsPrint.PrintHeader = true;
            XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
            advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
            advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
            advOptions.SheetName = "Exported from Data Grid";

            gridControl_receiptFB.ExportToXlsx(path, advOptions);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }


        private async void accordionCtrlE_SyncFromFirebase_Click(object sender, EventArgs e)
        {
            
            SplashScreenManager.ShowForm(typeof(waitFrmLoading));
            accordionControl1.Enabled = false;
           
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
            int[] index = gridView_receiptFB.GetSelectedRows();
            if (index != null)
            {
                RECEIPT item = (RECEIPT)gridView_receiptFB.GetRow(index[0]);
                SplashScreenManager.ShowForm(typeof(waitFrmLoading));
                accordionControl1.Enabled = false;

                if (await FB_Receipt.updateReceiptFromFirebase(item,CONFIRM))
                {
                    XtraMessageBox.Show("Tất Cả Đơn Hàng Đã Được thêm Vào SQL");
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

        private async void repositoryItemButtonEdit_response_Click(object sender, EventArgs e)
        {
            int[] index = gridView_receiptSql.GetSelectedRows();
            if (index != null)
            {
                RECEIPT item = (RECEIPT)gridView_receiptSql.GetRow(index[0]);
                await FB_Receipt.updateStatusReceipt(item,COMPLETE);
                XtraMessageBox.Show("Đơn Hàng Đã Xong , Chuyển Sang Trạng Thái Vận Chuyển");
                loadData();
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

    }
}
