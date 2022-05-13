using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using BLL_PPL;
using DTO_PPL;
using DevExpress.XtraGrid;
using DevExpress.CodeParser;
using DevExpress.XtraGrid;
using System.Windows.Controls;
using DevExpress.XtraEditors.Repository;
using PepperLunch.PopupForm;

namespace PepperLunch
{
    public partial class frmProduct : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmProduct()
        {
            InitializeComponent();

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            List<CATEGORY> listCate = BLL_Category.getCategories();
            // group by GROUP CATEGORY
            var results = listCate.GroupBy(n => new { n.GROUP_CATEGORY }).Select(g => new { g.Key.GROUP_CATEGORY}).ToList();
            foreach(var item in results)
            {
                AccordionControlElement group = new AccordionControlElement();
                group.Name = item.GROUP_CATEGORY;
                group.Style = ElementStyle.Group;
                //element.Tag = 'tag';
                group.Text = item.GROUP_CATEGORY;
                foreach (CATEGORY cate in listCate.Where(t=>t.GROUP_CATEGORY==item.GROUP_CATEGORY))
                {
                    AccordionControlElement element = new AccordionControlElement();
                    element.Name = cate.ID_CATEGORY;
                    element.Style= ElementStyle.Item;
                    //element.Tag = 'tag';
                    element.Text =cate.NAME_CATEGORY ;
                    // event click item 
                    element.Click += Element_Click;
                    
                    group.Elements.AddRange(new AccordionControlElement[] {element});
                }
                accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {group});
            }


        }

        private void Element_Click(object sender, EventArgs e)
        {
            try
            {
                AccordionControlElement element = sender as AccordionControlElement;
                loadDataByID_Category(element.Name);
            }
            catch
            {
                MessageBox.Show("Render UI Categories Error");
            }
        }

       

        private void loadDataByID_Category(string ID_Category)
        {
            refreshGridView();
            gridControl_Product.DataSource = BLL_Product.getProducts().Where(t => t.ID_CATEGORY == ID_Category).ToList<PRODUCT>();
            gridView_product.Columns["FLAG_DEL"].Visible = false;
        }

        private void accordionCtrlE_Category_Click(object sender, EventArgs e)
        {
            refreshGridView();
            gridControl_Product.DataSource = BLL_Category.getCategories();
            gridView_product.Columns["FLAG_DEL"].Visible = false;
            //gridView_product.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            //{
            //    Caption = "Control",
            //    //ColumnEdit = new RepositoryItemCheckEdit() { },
            //    VisibleIndex = 0,
            //    Width = 25,
            //    UnboundType = DevExpress.Data.UnboundColumnType.Boolean
            //});
        }

        private void accordionItem_AddCategory_Click(object sender, EventArgs e)
        {
            gridView_product.AddNewRow();
            }

        private void accordionItem_UpdateCategory_Click(object sender, EventArgs e)
        {

        }

        private void accordionItem_RemoveCategory_Click(object sender, EventArgs e)
        {

        }

        void refreshGridView()
        {
            gridControl_Product.DataSource = "";
            gridView_product.Columns.Clear();
          
        }

        private void gridView_product_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }
        
    }
}
