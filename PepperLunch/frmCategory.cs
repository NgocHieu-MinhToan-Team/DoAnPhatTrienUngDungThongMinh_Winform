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
            //cbb_GroupCate.DataSource = list.GroupBy(n => new { n.GROUP_CATEGORY }).Select(g => new { g.Key.GROUP_CATEGORY }).ToList();
            //cbb_GroupCate.DisplayMember = "GROUP_CATEGORY";
            //cbb_GroupCate.ValueMember = "GROUP_CATEGORY";
        }

        private void accordionCtrlEGroup_Click(object sender, EventArgs e)
        {
            //none
        }

        private void accordionCtrlE_AddCate_Click(object sender, EventArgs e)
        {
            if (txtNameCate.Text != null && txtGroupCate.Text!=null)
            {
                CATEGORY data = new CATEGORY();
                data.ID_CATEGORY = GeneralMethods.createID("CATE");
                data.GROUP_CATEGORY = txtGroupCate.Text;
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

        }
    }
}
