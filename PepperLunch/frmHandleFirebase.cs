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


        public frmHandleFirebase()
        {
            InitializeComponent();
            cbbPromotion.DataSource = BLL_Promotion.getPromotions();
            cbbPromotion.DisplayMember = "NAME_PROMOTION";
            cbbPromotion.ValueMember = "ID_PROMOTION";
        }
        #region Navigation Click
        private void frmHandleFirebase_Load(object sender, EventArgs e)
        {
            btnSyncFood.Enabled = btnSyncNews.Enabled = false;
        }

        private void accordionCtrlE_Customer_Click(object sender, EventArgs e)
        {
            frmFPGrowth newFrm = new frmFPGrowth();
            newFrm.Show();
        }

        #endregion
        void clearDataOnGridView()
        {
            gridView_dataFromFB.Columns.Clear();
        }

        private void accordionCtrl_SyncToFirebase_Click(object sender, EventArgs e)
        {
            btnSyncFood.Enabled = btnSyncNews.Enabled = true;
        }

        private async void btnSyncFood_Click(object sender, EventArgs e)
        {
            clearDataOnGridView();
            gridView_dataFromFB.ShowLoadingPanel();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //handle start
            await BLL_Synchronized.updateCategoriesToFirebaseAsync();
            gridControl_dataFromFB.DataSource = await BLL_Synchronized.getCategoriesNotSync();
            //handle end
            watch.Stop();
            gridView_dataFromFB.HideLoadingPanel();
            string result =  watch.ElapsedMilliseconds.ToString() + " ms";
            MessageBox.Show("Total Time Sync is : " + result);
        }

        private async void svgImage_food_Click(object sender, EventArgs e)
        {
            clearDataOnGridView();

            gridView_dataFromFB.ShowLoadingPanel();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //handle start
            gridControl_dataFromFB.DataSource = await BLL_Synchronized.getCategoriesNotSync();
            //handle end
            watch.Stop();
            gridView_dataFromFB.HideLoadingPanel();
            string result =  watch.ElapsedMilliseconds.ToString() + " ms";
            MessageBox.Show("Total Time Load is : " + result);
        }

        private void svgImage_News_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này tương tự với Food nên chưa làm !");
        }

        private async void btnSyncNews_Click(object sender, EventArgs e)
        {
            if (cbbPromotion.SelectedValue != null)
            {
                clearDataOnGridView();
                gridView_dataFromFB.ShowLoadingPanel();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                //handle start
                await BLL_Synchronized.updateNewsToFirebaseAsync(cbbPromotion.SelectedValue.ToString());
                //handle end
                watch.Stop();
                gridView_dataFromFB.HideLoadingPanel();
                string result = watch.ElapsedMilliseconds.ToString() + " ms";
                MessageBox.Show("Total Time Sync is : " + result);

            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Promotion để cập nhật !");
            }
        }

        private async void btnSyncVoucher_Click(object sender, EventArgs e)
        {
            if (cbbPromotion.SelectedValue != null)
            {
                clearDataOnGridView();
                gridView_dataFromFB.ShowLoadingPanel();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                //handle start
                await BLL_Synchronized.updateVoucherToFirebaseAsync(cbbPromotion.SelectedValue.ToString());
                //handle end
                watch.Stop();
                gridView_dataFromFB.HideLoadingPanel();
                string result = watch.ElapsedMilliseconds.ToString() + " ms";
                MessageBox.Show("Total Time Sync is : " + result);

            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Promotion để cập nhật !");
            }
        }

        private async void btnSyncMethodPay_Click(object sender, EventArgs e)
        {
            clearDataOnGridView();
            gridView_dataFromFB.ShowLoadingPanel();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //handle start
            await BLL_Synchronized.updateMethodToFirebaseAsync();
            //handle end
            watch.Stop();
            gridView_dataFromFB.HideLoadingPanel();
            string result = watch.ElapsedMilliseconds.ToString() + " ms";
            MessageBox.Show("Total Time Sync is : " + result);
        }
    }
}
