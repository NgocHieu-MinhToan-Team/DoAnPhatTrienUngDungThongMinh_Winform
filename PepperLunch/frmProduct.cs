using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using BLL_PPL;
using DTO_PPL;
using DevExpress.XtraEditors;

namespace PepperLunch
{
    public partial class frmProduct : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        string ID_CATE = null;
        public frmProduct()
        {
            InitializeComponent();

        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadData(false);
            ID_CATE = "IDLMON01";
            loadProductByID_Category("IDLMON01");
            txtNameEN.Text = "";
            txtNameVN.Text = "";
            txtPrice.Text = "";
            txtURL.Text = "";
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
                ID_CATE = element.Name;
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
        }

        private void gridControl_Product_Click(object sender, EventArgs e)
        {
            int[] index = gridView1.GetSelectedRows();
            if (index.Length > 0)
            {
                PRODUCT pro = (PRODUCT)gridView1.GetRow(index[0]);
                txtNameEN.Text = pro.NAME_PRODUCT_EN;
                txtNameVN.Text = pro.NAME_PRODUCT_VN;
                txtPrice.Text = pro.PRICE_PRODUCT.ToString();
                txtURL.Text = pro.IMAGE_PRODUCT;
            }
        }

        private void repositoryItemButtonEdit_ShowRecipe_Click(object sender, EventArgs e)
        {
            int[] index = gridView1.GetSelectedRows();
            if (index.Length > 0)
            {
                PRODUCT pro = (PRODUCT)gridView1.GetRow(index[0]);
                frmRecipe frm = new frmRecipe();
                frmRecipe.ID_PRODUCT = pro.ID_PRODUCT;
                frm.ShowDialog();
            }
           
        }

        private void repositoryItemButtonEdit_Update_Click(object sender, EventArgs e)
        {
            int[] index = gridView1.GetSelectedRows();
            if (index.Length > 0)
            {
                try
                {
                    PRODUCT pro = (PRODUCT)gridView1.GetRow(index[0]);
                    if(pro.NAME_PRODUCT_EN.Trim()=="" || pro.NAME_PRODUCT_VN.Trim()=="" || !GeneralMethods.isDigit(pro.PRICE_PRODUCT.ToString().Trim(), false))
                    {
                        XtraMessageBox.Show("Values are not null and FieldName Price must be number!");
                        loadProductByID_Category(ID_CATE);
                        return;
                    }
                    if (Int32.Parse(pro.PRICE_PRODUCT.ToString()) <= 0)
                    {
                        XtraMessageBox.Show("Price must be >0");
                        loadProductByID_Category(ID_CATE);
                        return;
                    }
                    BLL_Product.updateProduct(pro);
                    loadProductByID_Category(ID_CATE);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameEN.Text.Trim() == "" || txtNameVN.Text.Trim() == "" || !GeneralMethods.isDigit(txtPrice.Text.Trim(), false))
                {
                    XtraMessageBox.Show("Values are not null and FieldName Price must be number!");
                    return;
                }
              
                PRODUCT pro = new PRODUCT();
                pro.ID_PRODUCT = GeneralMethods.createID("PRO");
                pro.ID_CATEGORY = ID_CATE;
                pro.NAME_PRODUCT_EN = txtNameEN.Text;
                pro.NAME_PRODUCT_VN = txtNameVN.Text;
                pro.PRICE_PRODUCT = Int32.Parse(txtPrice.Text);
                pro.IMAGE_PRODUCT = txtURL.Text;
                BLL_Product.insertProduct(pro);
                loadProductByID_Category(ID_CATE);
                //open recipe 
                frmRecipe frmrecipe = new frmRecipe();
                frmRecipe.ID_PRODUCT = pro.ID_PRODUCT;
                frmrecipe.FormClosing += Frmrecipe_FormClosing;
                frmrecipe.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                XtraMessageBox.Show("Not be null");
            }
            
        }

        private void Frmrecipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            Program.frmcontainer.barBtn_Product.PerformClick();
        }
    }
}
