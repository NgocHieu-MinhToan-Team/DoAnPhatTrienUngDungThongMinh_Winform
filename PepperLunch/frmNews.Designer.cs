
namespace PepperLunch
{
    partial class frmNews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNews));
            this.gridControl_NewsImage = new DevExpress.XtraGrid.GridControl();
            this.gridView_NewImage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tblLayout_News = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTitleNews = new DevExpress.XtraEditors.TextEdit();
            this.btnAddNews = new DevExpress.XtraEditors.SimpleButton();
            this.dateNews_dayEnd = new System.Windows.Forms.DateTimePicker();
            this.dateNews_dayStart = new System.Windows.Forms.DateTimePicker();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtContentNews = new DevExpress.XtraEditors.TextEdit();
            this.btnRemoveNews = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateNews = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_News = new DevExpress.XtraGrid.GridControl();
            this.gridView_News = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tblLayout_NewsImage = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtPathImage = new DevExpress.XtraEditors.TextEdit();
            this.btnAddImage = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateImage = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NewsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NewImage)).BeginInit();
            this.tblLayout_News.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitleNews.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContentNews.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_News)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_News)).BeginInit();
            this.tblLayout_NewsImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathImage.Properties)).BeginInit();
            this.tableLayoutPanel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_NewsImage
            // 
            this.gridControl_NewsImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_NewsImage.Location = new System.Drawing.Point(825, 3);
            this.gridControl_NewsImage.MainView = this.gridView_NewImage;
            this.gridControl_NewsImage.Name = "gridControl_NewsImage";
            this.gridControl_NewsImage.Size = new System.Drawing.Size(347, 451);
            this.gridControl_NewsImage.TabIndex = 9;
            this.gridControl_NewsImage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_NewImage});
            // 
            // gridView_NewImage
            // 
            this.gridView_NewImage.GridControl = this.gridControl_NewsImage;
            this.gridView_NewImage.Name = "gridView_NewImage";
            this.gridView_NewImage.OptionsBehavior.Editable = false;
            // 
            // tblLayout_News
            // 
            this.tblLayout_News.BackColor = System.Drawing.Color.Black;
            this.tblLayout_News.ColumnCount = 5;
            this.tblLayout_News.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_News.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_News.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_News.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_News.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tblLayout_News.Controls.Add(this.labelControl6, 0, 0);
            this.tblLayout_News.Controls.Add(this.txtTitleNews, 0, 1);
            this.tblLayout_News.Controls.Add(this.btnAddNews, 4, 0);
            this.tblLayout_News.Controls.Add(this.dateNews_dayEnd, 3, 1);
            this.tblLayout_News.Controls.Add(this.dateNews_dayStart, 2, 1);
            this.tblLayout_News.Controls.Add(this.labelControl8, 3, 0);
            this.tblLayout_News.Controls.Add(this.labelControl7, 2, 0);
            this.tblLayout_News.Controls.Add(this.labelControl17, 1, 0);
            this.tblLayout_News.Controls.Add(this.txtContentNews, 1, 1);
            this.tblLayout_News.Controls.Add(this.btnRemoveNews, 4, 2);
            this.tblLayout_News.Controls.Add(this.btnUpdateNews, 4, 1);
            this.tblLayout_News.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_News.Location = new System.Drawing.Point(3, 460);
            this.tblLayout_News.Name = "tblLayout_News";
            this.tblLayout_News.Padding = new System.Windows.Forms.Padding(20);
            this.tblLayout_News.RowCount = 3;
            this.tblLayout_News.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_News.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_News.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_News.Size = new System.Drawing.Size(816, 190);
            this.tblLayout_News.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(23, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(175, 44);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Title";
            // 
            // txtTitleNews
            // 
            this.txtTitleNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitleNews.Location = new System.Drawing.Point(23, 73);
            this.txtTitleNews.Name = "txtTitleNews";
            this.txtTitleNews.Size = new System.Drawing.Size(175, 28);
            this.txtTitleNews.TabIndex = 10;
            // 
            // btnAddNews
            // 
            this.btnAddNews.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddNews.ImageOptions.SvgImage")));
            this.btnAddNews.Location = new System.Drawing.Point(747, 23);
            this.btnAddNews.Name = "btnAddNews";
            this.btnAddNews.Size = new System.Drawing.Size(46, 43);
            this.btnAddNews.TabIndex = 14;
            this.btnAddNews.Text = "simpleButton5";
            this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
            // 
            // dateNews_dayEnd
            // 
            this.dateNews_dayEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNews_dayEnd.Location = new System.Drawing.Point(566, 73);
            this.dateNews_dayEnd.Name = "dateNews_dayEnd";
            this.dateNews_dayEnd.Size = new System.Drawing.Size(175, 28);
            this.dateNews_dayEnd.TabIndex = 12;
            // 
            // dateNews_dayStart
            // 
            this.dateNews_dayStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNews_dayStart.Location = new System.Drawing.Point(385, 73);
            this.dateNews_dayStart.Name = "dateNews_dayStart";
            this.dateNews_dayStart.Size = new System.Drawing.Size(175, 28);
            this.dateNews_dayStart.TabIndex = 11;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl8.Location = new System.Drawing.Point(566, 23);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(175, 44);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Day End";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl7.Location = new System.Drawing.Point(385, 23);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(175, 44);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Day Start";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl17.Location = new System.Drawing.Point(204, 23);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(175, 44);
            this.labelControl17.TabIndex = 16;
            this.labelControl17.Text = "Content";
            // 
            // txtContentNews
            // 
            this.txtContentNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContentNews.Location = new System.Drawing.Point(204, 73);
            this.txtContentNews.Name = "txtContentNews";
            this.txtContentNews.Size = new System.Drawing.Size(175, 28);
            this.txtContentNews.TabIndex = 17;
            // 
            // btnRemoveNews
            // 
            this.btnRemoveNews.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemoveNews.ImageOptions.SvgImage")));
            this.btnRemoveNews.Location = new System.Drawing.Point(747, 123);
            this.btnRemoveNews.Name = "btnRemoveNews";
            this.btnRemoveNews.Size = new System.Drawing.Size(46, 43);
            this.btnRemoveNews.TabIndex = 15;
            this.btnRemoveNews.Click += new System.EventHandler(this.btnRemoveNews_Click);
            // 
            // btnUpdateNews
            // 
            this.btnUpdateNews.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateNews.ImageOptions.SvgImage")));
            this.btnUpdateNews.Location = new System.Drawing.Point(747, 73);
            this.btnUpdateNews.Name = "btnUpdateNews";
            this.btnUpdateNews.Size = new System.Drawing.Size(46, 43);
            this.btnUpdateNews.TabIndex = 13;
            this.btnUpdateNews.Click += new System.EventHandler(this.btnUpdateNews_Click);
            // 
            // gridControl_News
            // 
            this.gridControl_News.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_News.Location = new System.Drawing.Point(3, 3);
            this.gridControl_News.MainView = this.gridView_News;
            this.gridControl_News.Name = "gridControl_News";
            this.gridControl_News.Size = new System.Drawing.Size(816, 451);
            this.gridControl_News.TabIndex = 18;
            this.gridControl_News.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_News});
            // 
            // gridView_News
            // 
            this.gridView_News.GridControl = this.gridControl_News;
            this.gridView_News.Name = "gridView_News";
            this.gridView_News.OptionsBehavior.Editable = false;
            this.gridView_News.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_News_RowClick);
            // 
            // tblLayout_NewsImage
            // 
            this.tblLayout_NewsImage.BackColor = System.Drawing.Color.Black;
            this.tblLayout_NewsImage.ColumnCount = 2;
            this.tblLayout_NewsImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_NewsImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_NewsImage.Controls.Add(this.labelControl9, 0, 0);
            this.tblLayout_NewsImage.Controls.Add(this.txtPathImage, 0, 1);
            this.tblLayout_NewsImage.Controls.Add(this.btnAddImage, 0, 2);
            this.tblLayout_NewsImage.Controls.Add(this.btnUpdateImage, 1, 2);
            this.tblLayout_NewsImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_NewsImage.Location = new System.Drawing.Point(825, 460);
            this.tblLayout_NewsImage.Name = "tblLayout_NewsImage";
            this.tblLayout_NewsImage.Padding = new System.Windows.Forms.Padding(20);
            this.tblLayout_NewsImage.RowCount = 3;
            this.tblLayout_NewsImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_NewsImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_NewsImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_NewsImage.Size = new System.Drawing.Size(347, 190);
            this.tblLayout_NewsImage.TabIndex = 19;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.tblLayout_NewsImage.SetColumnSpan(this.labelControl9, 2);
            this.labelControl9.Location = new System.Drawing.Point(23, 23);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(176, 21);
            this.labelControl9.TabIndex = 6;
            this.labelControl9.Text = "Url Image from firebase";
            // 
            // txtPathImage
            // 
            this.tblLayout_NewsImage.SetColumnSpan(this.txtPathImage, 2);
            this.txtPathImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPathImage.Location = new System.Drawing.Point(23, 73);
            this.txtPathImage.Name = "txtPathImage";
            this.txtPathImage.Size = new System.Drawing.Size(301, 28);
            this.txtPathImage.TabIndex = 10;
            // 
            // btnAddImage
            // 
            this.btnAddImage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddImage.ImageOptions.SvgImage")));
            this.btnAddImage.Location = new System.Drawing.Point(23, 123);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(113, 44);
            this.btnAddImage.TabIndex = 13;
            this.btnAddImage.Text = "New";
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateImage.ImageOptions.SvgImage")));
            this.btnUpdateImage.Location = new System.Drawing.Point(176, 123);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(113, 44);
            this.btnUpdateImage.TabIndex = 14;
            this.btnUpdateImage.Text = "Update";
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_main.Controls.Add(this.tblLayout_NewsImage, 1, 1);
            this.tableLayoutPanel_main.Controls.Add(this.tblLayout_News, 0, 1);
            this.tableLayoutPanel_main.Controls.Add(this.gridControl_NewsImage, 1, 0);
            this.tableLayoutPanel_main.Controls.Add(this.gridControl_News, 0, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 2;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(1175, 653);
            this.tableLayoutPanel_main.TabIndex = 20;
            // 
            // frmNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 653);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Name = "frmNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNews";
            this.Load += new System.EventHandler(this.frmNews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NewsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_NewImage)).EndInit();
            this.tblLayout_News.ResumeLayout(false);
            this.tblLayout_News.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitleNews.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContentNews.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_News)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_News)).EndInit();
            this.tblLayout_NewsImage.ResumeLayout(false);
            this.tblLayout_NewsImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathImage.Properties)).EndInit();
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_NewsImage;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_NewImage;
        private System.Windows.Forms.TableLayoutPanel tblLayout_News;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTitleNews;
        private DevExpress.XtraEditors.SimpleButton btnAddNews;
        private System.Windows.Forms.DateTimePicker dateNews_dayEnd;
        private System.Windows.Forms.DateTimePicker dateNews_dayStart;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtContentNews;
        private DevExpress.XtraEditors.SimpleButton btnRemoveNews;
        private DevExpress.XtraEditors.SimpleButton btnUpdateNews;
        private DevExpress.XtraGrid.GridControl gridControl_News;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_News;
        private System.Windows.Forms.TableLayoutPanel tblLayout_NewsImage;
        private DevExpress.XtraEditors.SimpleButton btnAddImage;
        private DevExpress.XtraEditors.SimpleButton btnUpdateImage;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtPathImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
    }
}