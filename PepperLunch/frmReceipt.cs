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
// lib for export excel
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace PepperLunch
{
    public partial class frmReceipt : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
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
            gridView_receiptFB.Columns.Clear();
            List<RECEIPT> list = await BLL_Receipt.getDataFromFirebaseAsync();
            gridControl_receiptFB.DataSource = list;
            listData = BLL_Receipt.read_Receipt();
            gridControl_receiptSql.DataSource = listData;
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

        private void accordionCtrlE_removeReceipt_Click(object sender, EventArgs e)
        {
            int[] index = gridView_receiptFB.GetSelectedRows();
            if (index.Length > 0)
            {
                RECEIPT_FULL itemDel = (RECEIPT_FULL)gridView_receiptFB.GetRow(index[0]);
                BLL_Receipt.deleteReceipt(itemDel);
            }
        }

        private async void accordionCtrlE_SyncFromFirebase_Click(object sender, EventArgs e)
        {
            await BLL_Receipt.updateReceiptFromFirebase();
            loadData();

        }
    }
}
