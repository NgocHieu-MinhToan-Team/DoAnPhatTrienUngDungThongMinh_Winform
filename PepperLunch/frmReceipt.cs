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

        private  void frmReceipt_Load(object sender, EventArgs e)
        {
            listData = BLL_Receipt.read_Receipt();
            gridControl_receipt.DataSource = listData;
        }


        private void accordionCtrlE_exportWord_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView1.GetSelectedRows();
            if (arrRowSelected != null)
            {
                RECEIPT item = (RECEIPT)gridView1.GetRow(arrRowSelected[0]);
                BLL_Receipt.export_ReceiptToWord(item.ID_RECEIPT);
            }
            // retrieve to receipt to export 
        }

        private void accordionCtrlE_exportExcel_Click(object sender, EventArgs e)
        {
            string path = "Templates\\Export.xlsx";
            //Customize export options
           gridView1.OptionsPrint.PrintHeader = true;
            XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
            advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
            advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
            advOptions.SheetName = "Exported from Data Grid";

            gridControl_receipt.ExportToXlsx(path, advOptions);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private void accordionCtrlE_removeReceipt_Click(object sender, EventArgs e)
        {
            int[] index = gridView1.GetSelectedRows();
            if (index.Length > 0)
            {
                RECEIPT_FULL itemDel = (RECEIPT_FULL)gridView1.GetRow(index[0]);
                BLL_Receipt.deleteReceipt(itemDel);
            }
        }

        private void accordionCtrlE_SyncFromFirebase_Click(object sender, EventArgs e)
        {
            gridView1.Columns.Clear();
            gridControl_receipt.DataSource = BLL_Receipt.getDataFromFirebaseAsync();
        }
    }
}
