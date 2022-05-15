using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using BLL_PPL;
using DTO_PPL;

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
            LoadData(false);
        }

          void LoadData(bool isSynchronous)
        {
            //load categories
            List<CATEGORY> listCate = BLL_Category.getCategories();
            // group by GROUP CATEGORY
            var results = listCate.GroupBy(n => new { n.GROUP_CATEGORY }).Select(g => new { g.Key.GROUP_CATEGORY }).ToList();
            foreach (var item in results)
            {
                AccordionControlElement group = new AccordionControlElement();
                group.Name = item.GROUP_CATEGORY;
                group.Style = ElementStyle.Group;
                //element.Tag = 'tag';
                group.Text = item.GROUP_CATEGORY;
                foreach (CATEGORY cate in listCate.Where(t => t.GROUP_CATEGORY == item.GROUP_CATEGORY))
                {
                    AccordionControlElement element = new AccordionControlElement();
                    element.Name = cate.ID_CATEGORY;
                    element.Style = ElementStyle.Item;
                    //element.Tag = 'tag';
                    element.Text = cate.NAME_CATEGORY;
                    // event click item 
                    element.Click += Element_Click;

                    group.Elements.AddRange(new AccordionControlElement[] { element });
                }
                accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { group });
            }
        }

        private void Element_Click(object sender, EventArgs e)
        {
            try
            {
                AccordionControlElement element = sender as AccordionControlElement;
                loadProductByID_Category(element.Name);
            }
            catch
            {
                MessageBox.Show("Render UI Categories Error");
            }
        }

       

        private void loadProductByID_Category(string ID_Category)
        {
            gridControl_Product.DataSource = BLL_Product.getProducts().Where(t => t.ID_CATEGORY == ID_Category).ToList<PRODUCT>();
            gridView1.Columns["FLAG_DEL"].Visible = false;
        }


    }
}
