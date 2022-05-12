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
        BLL_Receipt bllReceipt = new BLL_Receipt();
        List<RECEIPT> listData;
        GridView gridView;
        public frmReceipt()
        {
            InitializeComponent();

        }

        private  async void frmReceipt_Load(object sender, EventArgs e)
        {
            RECEIPT item = await bllReceipt.getReceiptFromFirebase();
            List<RECEIPT> list = new List<RECEIPT>();
            if (item == null)
                MessageBox.Show("Item return null");
            else
            {
               list.Add(item);
            }
            gridControl_receipt.DataSource = list;

            //listData = bllReceipt.read_Receipt();
            //gridControl_receipt.DataSource = listData;
            //gridView = new GridView();
            //gridControl_receipt.MainView = gridView;
            //gridView.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
          
            
        }

        private void accordionCtrlE_exportWord_Click(object sender, EventArgs e)
        {
            //get id of receipt 
            int index = gridView.FocusedRowHandle;
            RECEIPT receipt = listData[index];
            // retrieve to receipt to export 
            bllReceipt.export_ReceiptToWord(receipt.ID_RECEIPT);
        }

        private void accordionCtrlE_exportExcel_Click(object sender, EventArgs e)
        {
            string path = "Templates\\Export.xlsx";
            //Customize export options
           gridView.OptionsPrint.PrintHeader = true;
            XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
            advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
            advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
            advOptions.SheetName = "Exported from Data Grid";

            gridControl_receipt.ExportToXlsx(path, advOptions);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private async void accordionCtrlE_getDataFromFB_Click(object sender, EventArgs e)
        {
           
        }
    }
}
