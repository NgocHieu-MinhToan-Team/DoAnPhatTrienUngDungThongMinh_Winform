using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_PPL;
using DTO_PPL;
using System.Threading.Tasks;

namespace PepperLunch
{
    public partial class frmCustomer : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadNotSyncCustomerFromFirebase();
            gridControl_Customer.DataSource = BLL_Customer.getCustomers();
        }

        private void accordionCtrlE_GetCustomerFromFirebase_Click(object sender, EventArgs e)
        {
            syncCustomerFromFirebase();
        }

        async void syncCustomerFromFirebase()
        {
            clearDataGrid();
            //start measure time excute 
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await BLL_Synchronized.updateCustomersFromFirebaseAsync();
            //start measure time excute 
            await loadNotSyncCustomerFromFirebase();
            gridControl_Customer.DataSource = BLL_Customer.getCustomers();

            // end measure time excute 
            watch.Stop();
            string result = watch.ElapsedMilliseconds.ToString() + " ms";
            MessageBox.Show("Total Time is : " + result);
        }

        //async void loadCustomersFromFirebase()
        //{
        //    gridView_sync.ShowLoadingPanel();
        //    //handle start
        //    List<CUSTOMER> listOfFirebase = await BLL_Synchronized.getCustomersFromFireBase();
        //    gridControl_top.DataSource = listOfFirebase;
        //    //handle end
        //    gridView_sync.HideLoadingPanel();
        //}

        async Task loadNotSyncCustomerFromFirebase()
        {
            clearDataGrid();
            var watch = System.Diagnostics.Stopwatch.StartNew();

            gridView_Firebase.ShowLoadingPanel();
            //handle start
            List<Customer> listOfLocal = await BLL_Synchronized.getCustomersNotSync();
            List<CUSTOMER> listNew = Customer.parseList(listOfLocal);
            gridControl_fromFirebase.DataSource = listNew;
            //handle end
            gridView_Firebase.HideLoadingPanel();
            watch.Stop();
            string timeLoad = "Time Load Not Sync : " + watch.ElapsedMilliseconds.ToString() + " ms";
            MessageBox.Show(timeLoad);
        }

        public void clearDataGrid()
        {
            gridView_Customer.Columns.Clear();
            gridView_Firebase.Columns.Clear();

        }
    }
}
