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
        private void frmHandleFirebase_Load(object sender, EventArgs e)
        {
            changeObject(typeCATEGORY);
        }
       
        private void accordionCtrl_Category_Click(object sender, EventArgs e)
        {
            changeObject(typeCATEGORY);
            hanldeOnCategory();
        }

        private void accordionCtrlE_Dish_Click(object sender, EventArgs e)
        {
            changeObject(typeDISH);
        }

        private void accordionCtrlE_Customer_Click(object sender, EventArgs e)
        {
            changeObject(typeCUSTOMER);

        }

        private void accordionCtrlE_Receipt_Click(object sender, EventArgs e)
        {
            changeObject(typeRECEIPT);

        }

        private void btnSyncTo_Click(object sender, EventArgs e)
        {
            if(type == typeCATEGORY)
            {
                BLL_Synchronized.synchronizedCategoriesToFireBase();
                hanldeOnCategory();
                return;
            }
            if (type == typeDISH)
            {
                MessageBox.Show("" + typeDISH);
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
            if (type == typeCATEGORY)
            {
                MessageBox.Show("Chua co chuc nang nay" + typeDISH);
                return;
            }
            if (type == typeDISH)
            {
                MessageBox.Show("" + typeDISH);
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
        private void changeObject(string _type)
        {
            type = _type;
            btnSyncTo.Text = "Sync " + type + " To Firebase";
            btnSyncDown.Text = "Sync " + type + " Down To SQL ";
        }

        private async void hanldeOnCategory()
        {
            // load data firebase
            turnOffControls();
            gridView_fromFirebase.ShowLoadingPanel();
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            List<CATEGORY> listOfFirebase = await BLL_Synchronized.getCategoriesFromFireBase();
            gridControl1.DataSource = listOfFirebase;
            watch1.Stop();
            gridView_fromFirebase.HideLoadingPanel();
            lblMilisecond.Text = "Time Load : " +watch1.ElapsedMilliseconds.ToString() + " ms";



            // load data from sql and filter 
            gridView_yetSync.ShowLoadingPanel();
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            List<CATEGORY> listOfLocal = await BLL_Synchronized.getCategoriesNotSync();
            gridControl2.DataSource = listOfLocal;
            watch2.Stop();
            gridView_yetSync.HideLoadingPanel();
            lblMilisecondeNotSync.Text ="Time Not Sync : " +watch2.ElapsedMilliseconds.ToString() + " ms";
            turnOnControls();
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

        private void turnOnControls()
        {
            foreach (AccordionControlElement element in accordionControl1.Elements)
            {
                element.Enabled = true;
            }
            btnSyncTo.Enabled = true;
            btnSyncDown.Enabled = true;

        }

    }
}
