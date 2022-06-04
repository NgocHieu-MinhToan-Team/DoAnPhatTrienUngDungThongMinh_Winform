using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PPL;
using DTO_PPL;

namespace PepperLunch
{
    public partial class frmPromotion : DevExpress.XtraEditors.XtraForm
    {
        static string static_ID_PROMOTION;
        static string static_ID_NEWS;
        public string static_USERNAME_STAFF { get; set; }
        public frmPromotion()
        {
            InitializeComponent();
        }

        private void frmPromotion_Load(object sender, EventArgs e)
        {
            loadPromotion();
        }
        private void btnAddPromotion_Click_1(object sender, EventArgs e)
        {
            PROMOTION pro = new PROMOTION();
            pro.ID_PROMOTION = GeneralMethods.createID("PROMOTION");
            pro.NAME_PROMOTION = txtNamePromotion.Text;
            pro.USERNAME_STAFF = static_USERNAME_STAFF;
            pro.DATE_CREATE = DateTime.Today;
            pro.DATE_START = datePromotion_dayStart.Value;
            pro.DATE_END = datePromotion_dayEnd.Value;
            BLL_Promotion.insertPromotion(pro);
            //reload table
            loadPromotion();
        }

        private void btnRemovePromotion_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_promotion.GetSelectedRows();
            if (arrRowSelected != null)
            {
                PROMOTION pro = (PROMOTION)gridView_promotion.GetRow(arrRowSelected[0]);
                BLL_Promotion.deletePromotion(pro);
                loadPromotion();
                loadNews(pro.ID_PROMOTION);
                loadVoucher(pro.ID_PROMOTION);
            }
        }

        private void btnUpdatePromotion_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_promotion.GetSelectedRows();
            if (arrRowSelected != null)
            {
                PROMOTION pro = (PROMOTION)gridView_promotion.GetRow(arrRowSelected[0]);
                pro.NAME_PROMOTION = txtNamePromotion.Text;
                pro.USERNAME_STAFF = static_USERNAME_STAFF;
                pro.DATE_CREATE = DateTime.Today;
                pro.DATE_START = datePromotion_dayStart.Value;
                pro.DATE_END = datePromotion_dayEnd.Value;
                BLL_Promotion.updatePromotion(pro);
                //reload
                loadPromotion();

            }

        }

        private void gridView_promotion_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // click row promotion -> load data of table voucher and news
            int[] arrRowSelected = gridView_promotion.GetSelectedRows();
            if (arrRowSelected != null)
            {
                PROMOTION pro = (PROMOTION)gridView_promotion.GetRow(arrRowSelected[0]);
                // load on textbox
                static_ID_PROMOTION = pro.ID_PROMOTION;
                txtNamePromotion.Text = pro.NAME_PROMOTION;
                datePromotion_dayStart.Value = (DateTime)pro.DATE_START;
                datePromotion_dayEnd.Value = (DateTime)pro.DATE_END;
                // load data for gridview voucher
                loadVoucher(pro.ID_PROMOTION);
                // load data for gridview news
                loadNews(pro.ID_PROMOTION);
            }

        }
        void loadPromotion()
        {
            // load data for gridview promotion
            gridControl_Promotion.DataSource = BLL_Promotion.getPromotions();
            gridView_promotion.Columns["STAFF"].Visible = false;
            gridView_promotion.Columns["FLAG_DEL"].Visible = false;

        }
        void loadVoucher(string ID_PROMOTION)
        {
            gridControl_Voucher.DataSource = BLL_Voucher.getVouchers(ID_PROMOTION);
            gridView_Voucher.Columns["PROMOTION"].Visible = false;
            gridView_Voucher.Columns["STAFF"].Visible = false;
            // load combobox
            cbbVoucher_typeCustomer.DataSource = BLL_Customer.getTypeCustomers();
            cbbVoucher_typeCustomer.DisplayMember = "NAME_TYPE";
            cbbVoucher_typeCustomer.ValueMember = "TYPE_CUSTOMER";

        }
        void loadNews(string ID_PROMOTION)
        {
            gridControl_News.DataSource = BLL_News.getNews(ID_PROMOTION);
            gridView_News.Columns["FLAG_DEL"].Visible = false;
            gridView_News.Columns["STAFF"].Visible = false;
        }

        void loadImageNews(string ID_NEWS)
        {
            gridControl_NewsImage.DataSource = BLL_News.getImageNews(ID_NEWS);
            gridView_NewImage.Columns["NEW"].Visible = false;

        }

        private void gridView_Voucher_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // click row voucher 
            int[] arrRowSelected = gridView_Voucher.GetSelectedRows();
            if (arrRowSelected != null)
            {
                VOUCHER vou = (VOUCHER)gridView_Voucher.GetRow(arrRowSelected[0]);
                // load on textbox
                dateVoucher_dayStart.Value = (DateTime)vou.DATE_START;
                dateVoucher_dayEnd.Value = (DateTime)vou.DATE_END;
                txtTypeReducion.Text = vou.TYPE_REDUCTION;
                cbbVoucher_typeCustomer.SelectedValue = vou.TYPE_CUSTOMER;
                txtPercentReducion.Text = vou.PERCENT_REDUCTION.ToString();
                txtAmountReduction.Text = vou.AMOUNT_REDUCTION.ToString();
                txtVoucherQuantity.Text = vou.QUANTITY_VOUCHER.ToString();
            }
        }

        private void gridView_News_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // click row news
            int[] arrRowSelected = gridView_News.GetSelectedRows();
            if (arrRowSelected != null)
            {
                NEW news = (NEW)gridView_News.GetRow(arrRowSelected[0]);
                static_ID_NEWS = news.ID_NEWS;
                // load on textbox
                txtTitleNews.Text = news.TITLE;
                txtContentNews.Text = news.CONTENT;
                dateNews_dayStart.Value = (DateTime)news.DATE_VISIBLE;
                dateNews_dayEnd.Value = (DateTime)news.DATE_HIDDEN;
                loadImageNews(static_ID_NEWS);
            }
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            VOUCHER vou = new VOUCHER();
            vou.ID_VOUCHER = GeneralMethods.createID("VOUCHER");
            vou.ID_PROMOTION = static_ID_PROMOTION;
            vou.USERNAME_STAFF = static_USERNAME_STAFF;
            vou.DATE_CREATE = DateTime.Today;
            vou.DATE_START = dateVoucher_dayStart.Value;
            vou.DATE_END = dateVoucher_dayEnd.Value;
            vou.TYPE_REDUCTION = txtTypeReducion.Text;
            vou.TYPE_CUSTOMER = cbbVoucher_typeCustomer.SelectedValue.ToString();
            vou.PERCENT_REDUCTION = int.Parse(txtPercentReducion.Text);
            vou.AMOUNT_REDUCTION = int.Parse(txtAmountReduction.Text);
            vou.QUANTITY_VOUCHER = int.Parse(txtVoucherQuantity.Text);
            BLL_Voucher.insertVoucher(vou);
            //reload table
            loadVoucher(static_ID_PROMOTION);
        }

        private void btnUpdateVoucher_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_Voucher.GetSelectedRows();
            if (arrRowSelected != null)
            {
                VOUCHER vou = (VOUCHER)gridView_Voucher.GetRow(arrRowSelected[0]);
                vou.USERNAME_STAFF = static_USERNAME_STAFF;
                vou.DATE_CREATE = DateTime.Today;
                vou.DATE_START = dateVoucher_dayStart.Value;
                vou.DATE_END = dateVoucher_dayEnd.Value;
                vou.TYPE_REDUCTION = txtTypeReducion.Text;
                vou.TYPE_CUSTOMER = cbbVoucher_typeCustomer.SelectedValue.ToString();
                vou.PERCENT_REDUCTION = int.Parse(txtPercentReducion.Text);
                vou.AMOUNT_REDUCTION = int.Parse(txtAmountReduction.Text);
                vou.QUANTITY_VOUCHER = int.Parse(txtVoucherQuantity.Text);
                BLL_Voucher.updateVoucher(vou);
                loadVoucher(static_ID_PROMOTION);
            }
        }

        private void btnRemoveVoucher_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_Voucher.GetSelectedRows();
            if (arrRowSelected != null)
            {
                VOUCHER vou = (VOUCHER)gridView_Voucher.GetRow(arrRowSelected[0]);
                // load on textbox
                BLL_Voucher.deleteVoucher(vou);
                loadVoucher(static_ID_PROMOTION);
            }
        }

        private void btnAddNews_Click(object sender, EventArgs e)
        {
            NEW vou = new NEW();
            vou.ID_NEWS = GeneralMethods.createID("NEWS");
            vou.ID_PROMOTION = static_ID_PROMOTION;
            vou.USERNAME_STAFF = static_USERNAME_STAFF;
            vou.TITLE = txtTitleNews.Text;
            vou.CONTENT = txtContentNews.Text;
            vou.DATE_VISIBLE = dateNews_dayStart.Value;
            vou.DATE_HIDDEN = dateNews_dayEnd.Value;
            BLL_News.insertNews(vou);
            //reload table
            loadNews(static_ID_PROMOTION);
        }

        private void btnUpdateNews_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_News.GetSelectedRows();
            if (arrRowSelected != null)
            {
                NEW vou = (NEW)gridView_News.GetRow(arrRowSelected[0]);
                vou.ID_PROMOTION = static_ID_PROMOTION;
                vou.USERNAME_STAFF = static_USERNAME_STAFF;
                vou.TITLE = txtTitleNews.Text;
                vou.CONTENT = txtContentNews.Text;
                vou.DATE_VISIBLE = dateNews_dayStart.Value;
                vou.DATE_HIDDEN = dateNews_dayEnd.Value;
                BLL_News.updateNews(vou);
                loadNews(static_ID_PROMOTION);
            }
        }

        private void btnRemoveNews_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_News.GetSelectedRows();
            if (arrRowSelected != null)
            {
                NEW vou = (NEW)gridView_News.GetRow(arrRowSelected[0]);
                // load on textbox
                BLL_News.deleteNews(vou);
                loadNews(static_ID_PROMOTION);
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            IMAGE_NEW img = new IMAGE_NEW();
            img.ID_IMAGE = GeneralMethods.createID("firebaseURLimage");
            img.ID_NEWS = static_ID_NEWS;
            img.PATH_IMAGE = txtPathImage.Text;
            BLL_News.insertImageNews(img);
            loadImageNews(static_ID_NEWS);
        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_NewImage.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMAGE_NEW vou = (IMAGE_NEW)gridView_NewImage.GetRow(arrRowSelected[0]);
                vou.PATH_IMAGE =txtPathImage.Text;
                vou.ID_NEWS = static_ID_NEWS;
                BLL_News.updateImageNews(vou);
                loadImageNews(static_ID_NEWS);
            }
        }
    }
}