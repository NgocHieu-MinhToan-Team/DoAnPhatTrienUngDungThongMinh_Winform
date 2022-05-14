using BLL_PPL;
using DevExpress.XtraBars;
using DTO_PPL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PepperLunch
{
    public partial class frmCategory : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        List<CATEGORY> list = new List<CATEGORY>();
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadData(false);

        }
        async void LoadData(bool isSynchronous)
        {
            list = await BLL_Category.getCategoriesAsync(isSynchronous);
            gridControl_Category.DataSource = list;
            gridView_Category.Columns["FLAG_DEL"].Visible = false;
            loadComboboxGroupCate(list);
        }

        void loadComboboxGroupCate(List<CATEGORY> list)
        {
            cbbGroupCate.DataSource = list.GroupBy(n => new { n.GROUP_CATEGORY }).Select(g => new { g.Key.GROUP_CATEGORY }).ToList();
            cbbGroupCate.DisplayMember = "GROUP_CATEGORY";
            cbbGroupCate.ValueMember = "GROUP_CATEGORY";
        }

        private void accordionCtrlEGroup_Click(object sender, EventArgs e)
        {
            //none
        }

        private void accordionCtrlE_AddCate_Click(object sender, EventArgs e)
        {
            if (txtNameCate.Text != null && cbbGroupCate.Text!=null)
            {
                CATEGORY data = new CATEGORY();
                data.ID_CATEGORY = GeneralMethods.createID("CATE");
                data.GROUP_CATEGORY = cbbGroupCate.Text;
                data.NAME_CATEGORY = txtNameCate.Text;
                data.FLAG_DEL = 0;
                if (BLL_Category.insertCategories(data))
                {
                    LoadData(false);
                }
            }
        }

        private void accordionCtrlE_RemoveCate_Click(object sender, EventArgs e)
        {
            int[] index= gridView_Category.GetSelectedRows();
            if (index.Length > 0)
            {
                CATEGORY data = (CATEGORY)gridView_Category.GetRow(index[0]);
                if (BLL_Category.deleteCategories(data))
                    LoadData(false);
            }
        }

        private void accordionCtrlE_UpdateCate_Click(object sender, EventArgs e)
        {
            int[] index = gridView_Category.GetSelectedRows();
            if (txtNameCate.Text != null && cbbGroupCate.Text != null)
            {
                CATEGORY data = (CATEGORY)gridView_Category.GetRow(index[0]);
                data.GROUP_CATEGORY = cbbGroupCate.Text;
                data.NAME_CATEGORY = txtNameCate.Text;
                if (BLL_Category.updateCategories(data))
                {
                    LoadData(false);
                }
            }
        }

        private void gridView_Category_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] index = gridView_Category.GetSelectedRows();
            if (index.Length > 0)
            {
                CATEGORY data = (CATEGORY)gridView_Category.GetRow(index[0]);
                cbbGroupCate.Text = data.GROUP_CATEGORY;
                txtNameCate.Text = data.NAME_CATEGORY;
            }
        }

    }
}
