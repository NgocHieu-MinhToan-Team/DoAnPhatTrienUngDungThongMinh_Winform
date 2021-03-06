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
using DevExpress.XtraSplashScreen;

namespace PepperLunch
{
    public partial class frmFPGrowth : DevExpress.XtraEditors.XtraForm
    {

        double minsup = 0;
        double confidence = 0;
        public frmFPGrowth()
        {
            InitializeComponent();
        }

        private void frmSyncCustomer_Load(object sender, EventArgs e)
        {
            List<FPGrowth_Item> list = BLL_Receipt.getListForFPGrowth();
            gridView_sql.Columns.Clear();
            gridControl_sql.DataSource = list;
            btnLoadDataToFirebase.Enabled = false;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            try
            {
                if(!GeneralMethods.isNumberTypeDouble(comboBoxEdit_minSup.SelectedItem.ToString())
                    || !GeneralMethods.isNumberTypeDouble(comboBoxEdit_confidence.SelectedItem.ToString())){
                    XtraMessageBox.Show("Input is invalid or null");
                    return;
                }
                minsup = double.Parse(comboBoxEdit_minSup.SelectedItem.ToString());
                confidence = double.Parse(comboBoxEdit_confidence.SelectedItem.ToString());
                if (minsup >= 0 && minsup <= 1 && confidence >= 0 && confidence <= 1)
                {

                    List<FPGrowth_Item> list = BLL_Receipt.getListForFPGrowth();
                    string[] data = new string[list.Count];
                    for (int i = 0; i < list.Count; i++)
                    {
                        data[i] = (i + 1).ToString() + "\t" + list[i].detail;
                    }
                    File.WriteAllLines("input.txt", data);
                    gridControl_train.DataSource = BLL_FPGrowth.getResult(minsup,confidence);
                    XtraMessageBox.Show("Training Success!");
                    btnLoadDataToFirebase.Enabled = true;

                }
                else
                {
                    XtraMessageBox.Show("Must be > 0");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                XtraMessageBox.Show("Please Enter a Number (int,float,doule) !");
            }
            
        }

        private void btnGetDataFromSQL_Click(object sender, EventArgs e)
        {
            gridView_sql.ShowLoadingPanel();
            List<FPGrowth_Item> list = BLL_Receipt.getListForFPGrowth();
            gridControl_sql.DataSource = list;
            gridView_sql.HideLoadingPanel();
        }

        private async void btnLoadDataToFirebase_Click(object sender, EventArgs e)
        {
            // create data to SQL
            //InsertDataToSql();
            try
            {
                SplashScreenManager.ShowForm(typeof(waitFrmLoading));
                int numberRecord = int.Parse(txtNumberRecord.Text);
                //if (GeneralMethods.isNumberTypeDouble(minsup.ToString()) &&
                //    GeneralMethods.isNumberTypeDouble(confidence.ToString()) &&
                //GeneralMethods.isDigit(numberRecord.ToString(),false))
                if (GeneralMethods.isDigit(numberRecord.ToString(), false))
                {
                    // update FPGrowth to firebase  
                    List<FPGrowth_Item> list = BLL_FPGrowth.getResult(minsup, confidence);
                    if(await FB_FPGrowth.pushToFirebaseAsync(minsup,confidence, numberRecord))
                    {
                        XtraMessageBox.Show("Upload Success!");
                        btnLoadDataToFirebase.Enabled = false;
                    }
                    else
                    {
                        XtraMessageBox.Show("error on firebase!");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Must be > 0");
                }
                SplashScreenManager.CloseForm();

            }
            catch
            {
                XtraMessageBox.Show("Please Enter a Number (int,float,doule) !");
            }
        }

        void InsertDataToSql()
        {
            SplashScreenManager.ShowForm(typeof(waitFrmLoading));
            for (int i = 0; i < 1000; i++)//tao hoa don
            {
                Random rd = new Random();
                int count = rd.Next(8);//so luong mon
                RECEIPT rc = new RECEIPT();
                rc.ADDRESS_RECEIPT = "HCM";
                rc.ID_CUSTOMER = "-N3Mz27GMSqHrwI-nA72";
                rc.ID_METHOD = "METHOD02";
                rc.ID_VOUCHER = null;
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
            SplashScreenManager.CloseForm();
        }

        private void btnCreateData_Click(object sender, EventArgs e)
        {
            InsertDataToSql();
        }
    }
}