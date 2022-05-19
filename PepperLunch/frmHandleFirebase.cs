using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_PPL;
using BLL_PPL;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraGrid.Views.Grid;
using System.Threading.Tasks;

namespace PepperLunch
{
    public partial class frmHandleFirebase : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private string type=null;
        // declare type 
        private static string typeCATEGORY = "Category";
        private static string typeDISH = "Dish";
        private static string typeCUSTOMER = "Customer";
        private static string typeRECEIPT = "Receipt";

        public frmHandleFirebase()
        {
            InitializeComponent();
        }
        #region Navigation Click
        private void frmHandleFirebase_Load(object sender, EventArgs e)
        {
            // clear grid 
            clearDataOnGridView();
            changeObject(typeCATEGORY);
            hanldeOnCategory();
        }

        private void accordionCtrl_Category_Click(object sender, EventArgs e)
        {
            // clear grid 
            clearDataOnGridView();
            changeObject(typeCATEGORY);
            hanldeOnCategory();
        }
        
        private void accordionCtrlE_Dish_Click(object sender, EventArgs e)
        {
            changeObject(typeDISH);
            hanldeOnProduct();
        }

        private void accordionCtrlE_Customer_Click(object sender, EventArgs e)
        {
            changeObject(typeCUSTOMER);

        }

        private void accordionCtrlE_Receipt_Click(object sender, EventArgs e)
        {
            changeObject(typeRECEIPT);

        }
        #endregion
        #region button click
        private  void btnSyncTo_Click(object sender, EventArgs e)
        {
            if (type == typeCATEGORY)
            {
                // clear grid 
                clearDataOnGridView();
                syncCategory();
                return;
            }
            if (type == typeDISH)
            {
                // clear grid 
                clearDataOnGridView();
                syncProduct();
                return;
            }
            if (type == typeCUSTOMER)
            {
                MessageBox.Show("" + typeCUSTOMER);
                return;
            }
            if (type == typeRECEIPT)
            {
                MessageBox.Show("" + typeRECEIPT);
                return;
            }
            else
            {
                MessageBox.Show("please choose type of object need sync");
            }

        }


        private void btnSyncDown_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
        #region Handle On Object
        private void hanldeOnCategory()
        {
            //start measure time excute 
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            loadCategoryAsync();
            // end measure time excute 
            watch1.Stop();
            lblMilisecond.Text = "Time Load : " + watch1.ElapsedMilliseconds.ToString() + " ms";


            //start measure time excute 
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            loadNotSyncCategoryAsync();
            // end measure time excute 
            watch2.Stop();
            lblMilisecondeNotSync.Text = "Time Not Sync : " + watch2.ElapsedMilliseconds.ToString() + " ms";


        }
        private void hanldeOnProduct()
        {
            //start measure time excute 
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            loadProductsAsync();

            // end measure time excute 
            watch1.Stop();
            lblMilisecond.Text = "Time Load : " + watch1.ElapsedMilliseconds.ToString() + " ms";


            //start measure time excute 
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            loadNotSyncProductAsync();
            // end measure time excute 
            watch2.Stop();
            lblMilisecondeNotSync.Text = "Time Not Sync : " + watch2.ElapsedMilliseconds.ToString() + " ms";

        }
        #region Handle Sync Click
        async void syncCategory()
        {
            
            //start measure time excute 
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            turnOffControls();
            await BLL_Synchronized.updateCategoriesToFirebaseAsync();
            await BLL_Synchronized.getCategoriesFromFireBase();
            watch1.Stop();
            lblMilisecond.Text = "Time Load : " + watch1.ElapsedMilliseconds.ToString() + " ms";


            //start measure time excute 
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            loadNotSyncCategoryAsync();
            // end measure time excute 
            watch2.Stop();
            lblMilisecondeNotSync.Text = "Time Not Sync : " + watch2.ElapsedMilliseconds.ToString() + " ms";
            turnOnControls();

        }
        async void syncProduct()
        {
            
            //start measure time excute 
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            turnOffControls();
            await BLL_Synchronized.updateProductsToFirebaseAsync();
            await BLL_Synchronized.getProductsFromFireBase();

            watch1.Stop();
            lblMilisecond.Text = "Time Load : " + watch1.ElapsedMilliseconds.ToString() + " ms";


            //start measure time excute 
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            loadNotSyncProductAsync();
            // end measure time excute 
            watch2.Stop();
            lblMilisecondeNotSync.Text = "Time Not Sync : " + watch2.ElapsedMilliseconds.ToString() + " ms";

            turnOnControls();
        }
        #endregion
        #region Handle Load
        async void loadCategoryAsync()
        {
            gridView_sync.ShowLoadingPanel();
            List<CATEGORY> listOfFirebase = await BLL_Synchronized.getCategoriesFromFireBase();
            gridControl_top.DataSource = listOfFirebase;
            gridView_sync.Columns["FLAG_DEL"].Visible = false;
            gridView_sync.HideLoadingPanel();

        }
        async void loadProductsAsync()
        {
            gridView_sync.ShowLoadingPanel();
            List<PRODUCT> listOfFirebase = await BLL_Synchronized.getProductsFromFireBase();

            gridControl_top.DataSource = listOfFirebase;
            gridView_sync.Columns["FLAG_DEL"].Visible = false;
            gridView_sync.HideLoadingPanel();

        }
        #endregion
        #region Handle Load Not Sync
        async void loadNotSyncCategoryAsync()
        {
            // load data from sql and filter 
            gridView_notSync.ShowLoadingPanel();
            List<CATEGORY> listOfLocal = await BLL_Synchronized.getCategoriesNotSync();
            gridControl_bottom.DataSource = listOfLocal;
            gridView_notSync.Columns["FLAG_DEL"].Visible = false;
            gridView_notSync.HideLoadingPanel();
        }
        async void loadNotSyncProductAsync()
        {
            // load data from sql and filter 
            gridView_notSync.ShowLoadingPanel();
            List<PRODUCT> listOfLocal = await BLL_Synchronized.getProductsNotSync();
            gridControl_bottom.DataSource = listOfLocal;
            gridView_notSync.Columns["FLAG_DEL"].Visible = false;
            gridView_notSync.HideLoadingPanel();
        }
        #endregion


        #endregion

     

        #region Change info when choose items
            private void changeObject(string _type)
            {
                type = _type;
                btnSyncTo.Text = "Sync " + type + " To Firebase";
                btnSyncDown.Text = "Sync " + type + " Down To SQL ";
            }
            private void turnOnControls()
            {
                foreach (AccordionControlElement element in accordionControl1.Elements)
                {
                    element.Enabled = true;
                }
                btnSyncTo.Enabled = true;
                btnSyncDown.Enabled = true;

            }
            private void turnOffControls()
            {
                foreach (AccordionControlElement element in accordionControl1.Elements)
                {
                    element.Enabled = false;
                }
                btnSyncTo.Enabled = false;
                btnSyncDown.Enabled = false;
            }
            void clearDataOnGridView()
            {
                gridView_sync.Columns.Clear();
                gridView_notSync.Columns.Clear();

            }
        #endregion

    }
}
