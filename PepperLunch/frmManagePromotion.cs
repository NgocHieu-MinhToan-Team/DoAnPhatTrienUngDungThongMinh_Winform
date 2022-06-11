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
using DevExpress.XtraEditors;

namespace PepperLunch
{
    public partial class frmManagePromotion : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        const int PROMOTION = 0;
        const int VOUCHER = 1;
        static int status;
        static string static_ID_PROMOTION;
        public string static_USERNAME_STAFF { get; set; }
        public frmManagePromotion()
        {
            InitializeComponent();
        }

        private void frmManagePromotion_Load(object sender, EventArgs e)
        {

            loadPromotion();
        }

        private void btnAddPromotion_Click(object sender, EventArgs e)
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



        private void btnUpdatePromotion_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_main.GetSelectedRows();
            if (arrRowSelected != null)
            {
                PROMOTION pro = (PROMOTION)gridView_main.GetRow(arrRowSelected[0]);
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

        private void btnRemovePromotion_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_main.GetSelectedRows();
            if (arrRowSelected != null)
            {
                PROMOTION pro = (PROMOTION)gridView_main.GetRow(arrRowSelected[0]);
                BLL_Promotion.deletePromotion(pro);
                loadPromotion();
            }
        }

        void loadPromotion()
        {
            cbbPromotion.DataSource = BLL_Promotion.getPromotions();
            cbbPromotion.DisplayMember = "NAME_PROMOTION";
            cbbPromotion.ValueMember = "ID_PROMOTION";
            gridView_main.Columns.Clear();
            // load data for gridview promotion
            gridControl_main.DataSource = BLL_Promotion.getPromotions();
            gridView_main.Columns["STAFF"].Visible = false;
            gridView_main.Columns["FLAG_DEL"].Visible = false;
           
        }
        void loadVoucher(string ID_PROMOTION)
        {
            // load combobox
            cbbVoucher_typeCustomer.DataSource = BLL_Customer.getTypeCustomers();
            cbbVoucher_typeCustomer.DisplayMember = "NAME_TYPE";
            cbbVoucher_typeCustomer.ValueMember = "TYPE_CUSTOMER";


            gridView_main.Columns.Clear();
            gridView_main.RefreshData();
            gridControl_main.DataSource = BLL_Voucher.getVouchers(ID_PROMOTION);
            gridView_main.Columns["PROMOTION"].Visible = false;
            gridView_main.Columns["STAFF"].Visible = false;
           

        }
        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            VOUCHER vou = new VOUCHER();
            vou.ID_VOUCHER = GeneralMethods.createID("VOUCHER");
            vou.ID_PROMOTION = cbbPromotion.SelectedValue.ToString(); 
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
            int[] arrRowSelected = gridView_main.GetSelectedRows();
            if (arrRowSelected != null)
            {
                VOUCHER vou = (VOUCHER)gridView_main.GetRow(arrRowSelected[0]);
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
            int[] arrRowSelected = gridView_main.GetSelectedRows();
            if (arrRowSelected != null)
            {
                VOUCHER vou = (VOUCHER)gridView_main.GetRow(arrRowSelected[0]);
                // load on textbox
                BLL_Voucher.deleteVoucher(vou);
                loadVoucher(static_ID_PROMOTION);
            }
        }
        private void accordionControlElement_news_Click(object sender, EventArgs e)
        {
            frmNews frm = new frmNews();
            frm.ID_PROMOTION = static_ID_PROMOTION;
            frm.USERNAME_STAFF = static_USERNAME_STAFF;
            frm.ShowDialog();
        }

        private void accordionControlElement_Promotion_Click(object sender, EventArgs e)
        {
            loadPromotion();
            status = PROMOTION;
        }

        private void accordionControlElement_voucher_Click(object sender, EventArgs e)
        {
            if (cbbPromotion.SelectedValue != null)
            {
                loadVoucher(cbbPromotion.SelectedValue.ToString());
                status = VOUCHER;
            }
            else
            {
                XtraMessageBox.Show("Please choose a promotion");
            }
        }

        private void gridView_main_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // click row promotion -> load data of table voucher and news
            int[] arrRowSelected = gridView_main.GetSelectedRows();
            if (arrRowSelected != null)
            {
                if (status == PROMOTION)
                {
                    PROMOTION pro = (PROMOTION)gridView_main.GetRow(arrRowSelected[0]);
                    // load on textbox
                    static_ID_PROMOTION = pro.ID_PROMOTION;
                    txtNamePromotion.Text = pro.NAME_PROMOTION;
                    datePromotion_dayStart.Value = (DateTime)pro.DATE_START;
                    datePromotion_dayEnd.Value = (DateTime)pro.DATE_END;
                }
                if (status == VOUCHER)
                {
                    VOUCHER vou = (VOUCHER)gridView_main.GetRow(arrRowSelected[0]);
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
        }

        private void cbbPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbbPromotion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbPromotion.SelectedValue != null)
            {
                string ID = cbbPromotion.SelectedValue.ToString();
                loadVoucher(ID);
                static_ID_PROMOTION = ID;
                status = VOUCHER;
                
            }
        }
    }
}
