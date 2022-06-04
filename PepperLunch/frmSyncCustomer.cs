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

namespace PepperLunch
{
    public partial class frmSyncCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmSyncCustomer()
        {
            InitializeComponent();
        }

        private void frmSyncCustomer_Load(object sender, EventArgs e)
        {
            //loadCustomersAsync();
            //loadNotSyncCustomerAsync();
        }

        private void btnSyncTo_Click(object sender, EventArgs e)
        {
            syncCustomerToFirebase();
        }

        private void btnSyncDown_Click(object sender, EventArgs e)
        {
            //syncCustomerFromFirebase();
        }

        async void loadCustomersAsync()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            gridView_sync.ShowLoadingPanel();
            //handle start
            List<Customer> listOfFirebase = await BLL_Synchronized.getCustomersFromFireBase();
            gridControl_top.DataSource = listOfFirebase;
            //handle end
            gridView_sync.HideLoadingPanel();
            watch.Stop();
            lblMilisecond.Text = "Time Load From Firebase : " + watch.ElapsedMilliseconds.ToString() + " ms";
        }

        async void loadNotSyncCustomerAsync()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            gridView_notSync.ShowLoadingPanel();
            //handle start
            List<Customer> listOfLocal = await BLL_Synchronized.getCustomersNotSync();
            gridControl_bottom.DataSource = listOfLocal;
            //handle end
            gridView_notSync.HideLoadingPanel();
            watch.Stop();
            lblMilisecond.Text = "Time Load Not Sync : " + watch.ElapsedMilliseconds.ToString() + " ms";
        }

        async void syncCustomerFromFirebase()
        {
            turnOffControls();
            //start measure time excute 
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await BLL_Synchronized.updateCustomersFromFirebaseAsync();
            loadCustomersAsync();
            //start measure time excute 
            loadNotSyncCustomerAsync();
            // end measure time excute 
            watch.Stop();
           string result = watch.ElapsedMilliseconds.ToString() + " ms";
            MessageBox.Show("Total Time is : "+result);
            turnOnControls();
        }

        async void syncCustomerToFirebase()
        {
            turnOffControls();
            //start measure time excute 
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await BLL_Synchronized.updateCustomersToFirebaseAsync();
            //loadCustomersAsync();
            //start measure time excute 
            //loadNotSyncCustomerAsync();
            // end measure time excute 
            watch.Stop();
            string result = watch.ElapsedMilliseconds.ToString() + " ms";
            MessageBox.Show("Total Time is : " + result);
            turnOnControls();
        }

        private void turnOnControls()
        {
            btnSyncTo.Enabled = true;
            btnSyncDown.Enabled = true;

        }
        private void turnOffControls()
        {
            btnSyncTo.Enabled = false;
            btnSyncDown.Enabled = false;
        }
    }
}