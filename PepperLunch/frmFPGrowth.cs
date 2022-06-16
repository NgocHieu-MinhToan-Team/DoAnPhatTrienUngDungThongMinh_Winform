using BLL_PPL;
using DevExpress.XtraEditors;
using DTO_PPL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FireBase_PPL;

namespace PepperLunch
{
    public partial class frmFPGrowth : DevExpress.XtraEditors.XtraForm
    {
       
        public frmFPGrowth()
        {
            InitializeComponent();
        }

        private void frmSyncCustomer_Load(object sender, EventArgs e)
        {
            List<FPGrowth_Item> list = BLL_Receipt.getListForFPGrowth();
            gridView_sync.Columns.Clear();
            gridControl_top.DataSource = list;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            try
            {
                double minsup = double.Parse(txtMinsup.Text);
                double confidence = double.Parse(txtConfidence.Text);
                if (minsup > 0 && minsup < 1 && confidence > 0 && confidence < 1)
                {
                    List<FPGrowth_Item> list = BLL_Receipt.getListForFPGrowth();
                    string[] data = new string[list.Count];
                    for (int i = 0; i < list.Count; i++)
                    {
                        data[i] = (i + 1).ToString() + "\t" + list[i].detail;
                    }
                    File.WriteAllLines("input.txt", data);
                    gridControl_bottom.DataSource = BLL_FPGrowth.getResult(minsup,confidence);
                    XtraMessageBox.Show("Training Success!");
                }
                else
                {
                    XtraMessageBox.Show("Must be > 0");
                }
            }
            catch
            {
                XtraMessageBox.Show("Please Enter a Number (int,float,doule) !");
            }
            
        }

        private void btnGetDataFromSQL_Click(object sender, EventArgs e)
        {
            List<FPGrowth_Item> list = BLL_Receipt.getListForFPGrowth();
            gridControl_top.DataSource = list;
        }

        private async void btnLoadDataToFirebase_Click(object sender, EventArgs e)
        {
            // create data to SQL
            //InsertDataToSql();
            try
            {
                double minsup = double.Parse(txtMinsup.Text);
                double confidence = double.Parse(txtConfidence.Text);
                int numberRecord = int.Parse(txtNumberRecord.Text);
                if (GeneralMethods.isNumberTypeDouble(minsup.ToString()) &&
                    GeneralMethods.isNumberTypeDouble(confidence.ToString()) &&
                    GeneralMethods.isDigit(numberRecord.ToString(),false))
                {
                    // update FPGrowth to firebase  
                    List<FPGrowth_Item> list = BLL_FPGrowth.getResult(minsup, confidence);
                    if(await FB_FPGrowth.pushToFirebaseAsync(minsup,confidence, numberRecord))
                        XtraMessageBox.Show("Upload Success!");
                    else
                    {
                        XtraMessageBox.Show("error on firebase!");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Must be > 0");
                }
            }
            catch
            {
                XtraMessageBox.Show("Please Enter a Number (int,float,doule) !");
            }
        }

        void InsertDataToSql()
        {
            for (int i = 0; i < 1000; i++)//tao hoa don
            {
                Random rd = new Random();
                int count = rd.Next(8);//so luong mon
                RECEIPT rc = new RECEIPT();
                rc.ADDRESS_RECEIPT = "HCM";
                rc.ID_CUSTOMER = "-N3Mz27GMSqHrwI-nA72";
                rc.ID_METHOD = "METHOD02";
                rc.ID_VOUCHER = "VOUCHER202261233859776";
                rc.ID_RECEIPT = GeneralMethods.createID(i.ToString());
                rc.STATE_RECEIPT = 3;
                rc.TOTAL_PRODUCT = count;
                rc.TOTAL_PRICE = 0;
                rc.POINT = 0;
                rc.DATE_CREATE = DateTime.Now;
                BLL_Receipt.insertReceipt(rc);//them hd
                List<PRODUCT> lstProduct = BLL_Product.getProducts();
                for (int j = 0; j <= count; j++)//tao chi tiet hoa don
                {
                    Random rd2 = new Random();
                    int ID = rd2.Next(lstProduct.Count);
                    PRODUCT pro = lstProduct[ID];//random mon
                    lstProduct.RemoveAt(ID);
                    DETAIL_RECEIPT dt_rc = new DETAIL_RECEIPT();//tao CTHD
                    dt_rc.ID_DETAIL_RECEIPT = rc.ID_RECEIPT + pro.ID_PRODUCT;
                    dt_rc.ID_RECEIPT = rc.ID_RECEIPT;
                    dt_rc.ID_PRODUCT = pro.ID_PRODUCT;
                    dt_rc.PRICE = pro.PRICE_PRODUCT;
                    dt_rc.QUANTITY = 1;
                    //Them CTHD vao DB
                    if (!BLL_Receipt.insertDetailReceipt(dt_rc))
                    {
                        Console.WriteLine("Co Loi");
                        return;
                    }
                }
                Console.WriteLine(i + "\t" + rc.ID_RECEIPT);
            }
        }
    }
}