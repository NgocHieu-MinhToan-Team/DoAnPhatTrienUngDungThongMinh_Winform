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
using DevExpress.XtraEditors;

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
        }

        private void accordionCtrlE_Customer_Click(object sender, EventArgs e)
        {
            frmFPGrowth newFrm = new frmFPGrowth();
            newFrm.Show();
        }

        #endregion
        void clearDataOnGridView()
        {
        }

        private void accordionCtrl_SyncToFirebase_Click(object sender, EventArgs e)
        {
        }

        private async void btnSyncFood_Click(object sender, EventArgs e)
        {
            //handle start
            SplashScreenManager.ShowForm(typeof(waitFrmLoading));

            if (await BLL_Synchronized.updateCategoriesToFirebaseAsync())
            {
                XtraMessageBox.Show("Load complete");
            }
            else
            {
                XtraMessageBox.Show("HAS ERROR");

            }
            //handle end
            SplashScreenManager.CloseForm();

        }

        private async void svgImage_food_Click(object sender, EventArgs e)
        {

           
        }

        private void svgImage_News_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnSyncNews_Click(object sender, EventArgs e)
        {
            if (cbbPromotion.SelectedValue != null)
            {
                
                SplashScreenManager.ShowForm(typeof(waitFrmLoading));

                if (await BLL_Synchronized.updateNewsToFirebaseAsync(cbbPromotion.SelectedValue.ToString()))
                {
                    XtraMessageBox.Show("Load complete");
                }
                else
                {
                    XtraMessageBox.Show("HAS ERROR");

                }
                //handle end
                SplashScreenManager.CloseForm();

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
                //handle start
                SplashScreenManager.ShowForm(typeof(waitFrmLoading));

                if (await BLL_Synchronized.updateVoucherToFirebaseAsync(cbbPromotion.SelectedValue.ToString()))
                {
                    XtraMessageBox.Show("Load complete");
                }
                else
                {
                    XtraMessageBox.Show("HAS ERROR");

                }
                //handle end
                SplashScreenManager.CloseForm();

                
                //handle end

            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Promotion để cập nhật !");
            }
        }

        private async void btnSyncMethodPay_Click(object sender, EventArgs e)
        {
            //handle start
            
            SplashScreenManager.ShowForm(typeof(waitFrmLoading));

            if (await BLL_Synchronized.updateMethodToFirebaseAsync())
            {
                XtraMessageBox.Show("Load complete");
            }
            else
            {
                XtraMessageBox.Show("HAS ERROR");

            }
            //handle end
            SplashScreenManager.CloseForm();

            //handle end
        }

    }
}
