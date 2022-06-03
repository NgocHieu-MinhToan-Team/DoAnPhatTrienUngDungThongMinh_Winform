
namespace PepperLunch
{
    partial class frmContainer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContainer));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_staff = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_receipt = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_customer = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Import = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_signOut = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Product = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Category = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_SyncManual = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Promotion = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Ingredient = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage_manager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Firebase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.Blue;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barBtn_staff,
            this.barBtn_receipt,
            this.barButtonItem2,
            this.barBtn_customer,
            this.barBtn_Import,
            this.barBtn_signOut,
            this.barBtn_Product,
            this.barBtn_Category,
            this.barBtn_SyncManual,
            this.barBtn_Promotion,
            this.barBtn_Ingredient});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 26;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsStubGlyphs.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.OptionsStubGlyphs.UseFont = true;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage_manager});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon.Size = new System.Drawing.Size(1261, 186);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barBtn_staff
            // 
            this.barBtn_staff.Caption = "Staff";
            this.barBtn_staff.Id = 10;
            this.barBtn_staff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_staff.ImageOptions.SvgImage")));
            this.barBtn_staff.ItemAppearance.Hovered.BackColor = System.Drawing.Color.White;
            this.barBtn_staff.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barBtn_staff.ItemInMenuAppearance.Hovered.BackColor = System.Drawing.Color.Blue;
            this.barBtn_staff.ItemInMenuAppearance.Hovered.Options.UseBackColor = true;
            this.barBtn_staff.LargeWidth = 70;
            this.barBtn_staff.Name = "barBtn_staff";
            this.barBtn_staff.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_staff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_staff_ItemClick);
            // 
            // barBtn_receipt
            // 
            this.barBtn_receipt.Caption = "Receipts";
            this.barBtn_receipt.Id = 11;
            this.barBtn_receipt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_receipt.ImageOptions.SvgImage")));
            this.barBtn_receipt.ItemAppearance.Hovered.BackColor = System.Drawing.Color.White;
            this.barBtn_receipt.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barBtn_receipt.LargeWidth = 70;
            this.barBtn_receipt.Name = "barBtn_receipt";
            this.barBtn_receipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Receipt_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Customers";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barBtn_customer
            // 
            this.barBtn_customer.Caption = "Customers";
            this.barBtn_customer.Id = 16;
            this.barBtn_customer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_customer.ImageOptions.SvgImage")));
            this.barBtn_customer.ItemAppearance.Hovered.BackColor = System.Drawing.Color.White;
            this.barBtn_customer.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barBtn_customer.Name = "barBtn_customer";
            this.barBtn_customer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_customer_ItemClick);
            // 
            // barBtn_Import
            // 
            this.barBtn_Import.Caption = "Import Of Goods";
            this.barBtn_Import.Id = 17;
            this.barBtn_Import.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_Import.ImageOptions.SvgImage")));
            this.barBtn_Import.ItemAppearance.Hovered.BackColor = System.Drawing.Color.White;
            this.barBtn_Import.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barBtn_Import.Name = "barBtn_Import";
            this.barBtn_Import.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Import_ItemClick);
            // 
            // barBtn_signOut
            // 
            this.barBtn_signOut.Caption = "Sign Out";
            this.barBtn_signOut.Id = 18;
            this.barBtn_signOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_signOut.ImageOptions.SvgImage")));
            this.barBtn_signOut.ItemAppearance.Hovered.BackColor = System.Drawing.Color.White;
            this.barBtn_signOut.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barBtn_signOut.Name = "barBtn_signOut";
            this.barBtn_signOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_signOut_ItemClick_1);
            // 
            // barBtn_Product
            // 
            this.barBtn_Product.Caption = "Dishes";
            this.barBtn_Product.Id = 19;
            this.barBtn_Product.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_Product.ImageOptions.SvgImage")));
            this.barBtn_Product.Name = "barBtn_Product";
            this.barBtn_Product.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Product_ItemClick);
            // 
            // barBtn_Category
            // 
            this.barBtn_Category.Caption = "Categories";
            this.barBtn_Category.Id = 20;
            this.barBtn_Category.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_Category.ImageOptions.SvgImage")));
            this.barBtn_Category.Name = "barBtn_Category";
            this.barBtn_Category.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Category_ItemClick);
            // 
            // barBtn_SyncManual
            // 
            this.barBtn_SyncManual.Caption = "Sync Manual";
            this.barBtn_SyncManual.Id = 23;
            this.barBtn_SyncManual.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_SyncManual.ImageOptions.SvgImage")));
            this.barBtn_SyncManual.Name = "barBtn_SyncManual";
            this.barBtn_SyncManual.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_SyncManual_ItemClick);
            // 
            // barBtn_Promotion
            // 
            this.barBtn_Promotion.Caption = "Promotion";
            this.barBtn_Promotion.Id = 24;
            this.barBtn_Promotion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_Promotion.ImageOptions.SvgImage")));
            this.barBtn_Promotion.Name = "barBtn_Promotion";
            this.barBtn_Promotion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Promotion_ItemClick);
            // 
            // barBtn_Ingredient
            // 
            this.barBtn_Ingredient.Caption = "Ingredients";
            this.barBtn_Ingredient.Id = 25;
            this.barBtn_Ingredient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtn_Ingredient.ImageOptions.SvgImage")));
            this.barBtn_Ingredient.ImageOptions.SvgImageSize = new System.Drawing.Size(100, 100);
            this.barBtn_Ingredient.Name = "barBtn_Ingredient";
            this.barBtn_Ingredient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Ingredient_ItemClick);
            // 
            // ribbonPage_manager
            // 
            this.ribbonPage_manager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup_Firebase,
            this.ribbonPageGroup4});
            this.ribbonPage_manager.Name = "ribbonPage_manager";
            this.ribbonPage_manager.Text = "Manage";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_staff);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_receipt);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_customer);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_Import);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Manage Restaurant";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_Category);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_Product);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_Promotion);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_Ingredient);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Manage Menu";
            // 
            // ribbonPageGroup_Firebase
            // 
            this.ribbonPageGroup_Firebase.ItemLinks.Add(this.barBtn_SyncManual);
            this.ribbonPageGroup_Firebase.Name = "ribbonPageGroup_Firebase";
            this.ribbonPageGroup_Firebase.Text = "Firebase";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtn_signOut);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "System";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 635);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1261, 31);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sign out";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.ItemAppearance.Hovered.BackColor = System.Drawing.Color.White;
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barButtonItem3.LargeWidth = 70;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // frmContainer
            // 
            this.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::PepperLunch.Properties.Resources.bg_white;
            this.ClientSize = new System.Drawing.Size(1261, 666);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = global::PepperLunch.Properties.Resources.peper_logo;
            this.IsMdiContainer = true;
            this.Name = "frmContainer";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Management Pepper Lunch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_manager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtn_staff;
        private DevExpress.XtraBars.BarButtonItem barBtn_receipt;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barBtn_customer;
        private DevExpress.XtraBars.BarButtonItem barBtn_Import;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barBtn_signOut;
        private DevExpress.XtraBars.BarButtonItem barBtn_Product;
        private DevExpress.XtraBars.BarButtonItem barBtn_Category;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Firebase;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtn_SyncManual;
        private DevExpress.XtraBars.BarButtonItem barBtn_Promotion;
        public DevExpress.XtraBars.BarButtonItem barBtn_Ingredient;
    }
}