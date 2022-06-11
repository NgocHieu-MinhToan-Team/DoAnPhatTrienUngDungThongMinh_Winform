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
    public partial class frmNews : DevExpress.XtraEditors.XtraForm
    {
        static string ID_NEWS=null;
        public string ID_PROMOTION { get; set; }
        public string USERNAME_STAFF { get; set; }

        public frmNews()
        {
            InitializeComponent();
        }

        

        void loadNews()
        {
            gridControl_News.DataSource = BLL_News.getNews(ID_PROMOTION);
            gridView_News.Columns["FLAG_DEL"].Visible = false;
            gridView_News.Columns["STAFF"].Visible = false;
        }

        void loadImageNews()
        {
            gridControl_NewsImage.DataSource = BLL_News.getImageNews(ID_NEWS);
            gridView_NewImage.Columns["NEW"].Visible = false;

        }

        private void gridView_News_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // click row news
            int[] arrRowSelected = gridView_News.GetSelectedRows();
            if (arrRowSelected != null)
            {
                btnAddImage.Enabled = btnUpdateImage.Enabled = true;
                NEW news = (NEW)gridView_News.GetRow(arrRowSelected[0]);
                // load on textbox
                ID_NEWS = news.ID_NEWS;
                txtTitleNews.Text = news.TITLE;
                txtContentNews.Text = news.CONTENT;
                dateNews_dayStart.Value = (DateTime)news.DATE_VISIBLE;
                dateNews_dayEnd.Value = (DateTime)news.DATE_HIDDEN;
                loadImageNews();
            }
        }

        private void frmNews_Load(object sender, EventArgs e)
        {
            btnAddImage.Enabled = btnUpdateImage.Enabled = false;
            loadNews();
        }

        private void btnAddNews_Click(object sender, EventArgs e)
        {
            NEW vou = new NEW();
            vou.ID_NEWS = GeneralMethods.createID("NEWS");
            vou.ID_PROMOTION = ID_PROMOTION;
            vou.USERNAME_STAFF = USERNAME_STAFF;
            vou.TITLE = txtTitleNews.Text;
            vou.CONTENT = txtContentNews.Text;
            vou.DATE_VISIBLE = dateNews_dayStart.Value;
            vou.DATE_HIDDEN = dateNews_dayEnd.Value;
            BLL_News.insertNews(vou);
            //reload table
            loadNews();
        }

        private void btnUpdateNews_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_News.GetSelectedRows();
            if (arrRowSelected != null)
            {
                NEW vou = (NEW)gridView_News.GetRow(arrRowSelected[0]);
                vou.ID_PROMOTION = ID_PROMOTION;
                vou.USERNAME_STAFF = USERNAME_STAFF;
                vou.TITLE = txtTitleNews.Text;
                vou.CONTENT = txtContentNews.Text;
                vou.DATE_VISIBLE = dateNews_dayStart.Value;
                vou.DATE_HIDDEN = dateNews_dayEnd.Value;
                BLL_News.updateNews(vou);
                loadNews();
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
                loadNews();
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            IMAGE_NEW img = new IMAGE_NEW();
            img.ID_IMAGE = GeneralMethods.createID("firebaseURLimage");
            img.ID_NEWS = ID_NEWS;
            img.PATH_IMAGE = txtPathImage.Text;
            BLL_News.insertImageNews(img);
            loadImageNews();
        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            int[] arrRowSelected = gridView_NewImage.GetSelectedRows();
            if (arrRowSelected != null)
            {
                IMAGE_NEW img = (IMAGE_NEW)gridView_NewImage.GetRow(arrRowSelected[0]);
                img.PATH_IMAGE = txtPathImage.Text;
                img.ID_NEWS = ID_NEWS;
                BLL_News.updateImageNews(img);
                loadImageNews();
            }
        }


    }
}