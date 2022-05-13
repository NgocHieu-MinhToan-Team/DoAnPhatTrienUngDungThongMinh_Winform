
namespace PepperLunch
{
    partial class frmProduct
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
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.gridControl_Product = new DevExpress.XtraGrid.GridControl();
            this.gridView_product = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionCtrlE_Category = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionItem_AddCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionItem_UpdateCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionItem_RemoveCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_upLoadFirebase = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.gridControl_Product);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(312, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(849, 708);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // gridControl_Product
            // 
            this.gridControl_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Product.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Product.MainView = this.gridView_product;
            this.gridControl_Product.Name = "gridControl_Product";
            this.gridControl_Product.Size = new System.Drawing.Size(849, 708);
            this.gridControl_Product.TabIndex = 0;
            this.gridControl_Product.UseEmbeddedNavigator = true;
            this.gridControl_Product.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_product});
            // 
            // gridView_product
            // 
            this.gridView_product.GridControl = this.gridControl_Product;
            this.gridView_product.Name = "gridView_product";
            this.gridView_product.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_product.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_product.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView_product_InitNewRow);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionCtrlE_Category});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(312, 708);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionCtrlE_Category
            // 
            this.accordionCtrlE_Category.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionItem_AddCategory,
            this.accordionItem_UpdateCategory,
            this.accordionItem_RemoveCategory,
            this.accordionCtrlE_upLoadFirebase});
            this.accordionCtrlE_Category.Expanded = true;
            this.accordionCtrlE_Category.Name = "accordionCtrlE_Category";
            this.accordionCtrlE_Category.Text = "Category";
            this.accordionCtrlE_Category.Click += new System.EventHandler(this.accordionCtrlE_Category_Click);
            // 
            // accordionItem_AddCategory
            // 
            this.accordionItem_AddCategory.Name = "accordionItem_AddCategory";
            this.accordionItem_AddCategory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionItem_AddCategory.Text = "Add Category";
            this.accordionItem_AddCategory.Click += new System.EventHandler(this.accordionItem_AddCategory_Click);
            // 
            // accordionItem_UpdateCategory
            // 
            this.accordionItem_UpdateCategory.Name = "accordionItem_UpdateCategory";
            this.accordionItem_UpdateCategory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionItem_UpdateCategory.Text = "Update Category";
            this.accordionItem_UpdateCategory.Click += new System.EventHandler(this.accordionItem_UpdateCategory_Click);
            // 
            // accordionItem_RemoveCategory
            // 
            this.accordionItem_RemoveCategory.Name = "accordionItem_RemoveCategory";
            this.accordionItem_RemoveCategory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionItem_RemoveCategory.Text = "Remove Category";
            this.accordionItem_RemoveCategory.Click += new System.EventHandler(this.accordionItem_RemoveCategory_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1161, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Update Category";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Add Category";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Element1";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6,
            this.accordionControlElement7});
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Update Category";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "Add Category";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Element1";
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement9,
            this.accordionControlElement10});
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Text = "Update Category";
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Add Category";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Element1";
            // 
            // accordionCtrlE_upLoadFirebase
            // 
            this.accordionCtrlE_upLoadFirebase.Name = "accordionCtrlE_upLoadFirebase";
            this.accordionCtrlE_upLoadFirebase.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_upLoadFirebase.Text = "Up Load to Firebase";
            this.accordionCtrlE_upLoadFirebase.Click += new System.EventHandler(this.accordionCtrlE_upLoadFirebase_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 747);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmProduct";
            this.NavigationControl = this.accordionControl1;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_Category;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraGrid.GridControl gridControl_Product;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionItem_AddCategory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionItem_UpdateCategory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionItem_RemoveCategory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_product;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_upLoadFirebase;
    }
}