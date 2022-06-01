
namespace PepperLunch
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.gridControl_product = new DevExpress.XtraGrid.GridControl();
            this.gridView_product = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_detailProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView_detailProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenIngredient = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_Ingredient = new DevExpress.XtraGrid.GridControl();
            this.gridView_Ingredient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtWeight = new Modify_Control.EditText_Digit();
            this.tableLayoutMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_detailProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detailProduct)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.tableLayoutMain.ColumnCount = 3;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMain.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutMain.Controls.Add(this.gridControl_detailProduct, 1, 0);
            this.tableLayoutMain.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 363F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1325, 693);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(23, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox2.Size = new System.Drawing.Size(251, 647);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Dish Here";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cbbCategory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gridControl_product, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.93023F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.06977F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(211, 586);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(103, 29);
            this.cbbCategory.TabIndex = 2;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // gridControl_product
            // 
            this.gridControl_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_product.Location = new System.Drawing.Point(3, 125);
            this.gridControl_product.MainView = this.gridView_product;
            this.gridControl_product.Name = "gridControl_product";
            this.gridControl_product.Size = new System.Drawing.Size(205, 458);
            this.gridControl_product.TabIndex = 3;
            this.gridControl_product.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_product});
            // 
            // gridView_product
            // 
            this.gridView_product.GridControl = this.gridControl_product;
            this.gridView_product.Name = "gridView_product";
            this.gridView_product.OptionsBehavior.Editable = false;
            this.gridView_product.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_product_RowClick);
            // 
            // gridControl_detailProduct
            // 
            this.gridControl_detailProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_detailProduct.Location = new System.Drawing.Point(280, 23);
            this.gridControl_detailProduct.MainView = this.gridView_detailProduct;
            this.gridControl_detailProduct.Name = "gridControl_detailProduct";
            this.gridControl_detailProduct.Size = new System.Drawing.Size(636, 647);
            this.gridControl_detailProduct.TabIndex = 6;
            this.gridControl_detailProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_detailProduct});
            // 
            // gridView_detailProduct
            // 
            this.gridView_detailProduct.GridControl = this.gridControl_detailProduct;
            this.gridView_detailProduct.Name = "gridView_detailProduct";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOpenIngredient, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRemove, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.gridControl_Ingredient, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtWeight, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(922, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(380, 647);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 58);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOpenIngredient
            // 
            this.btnOpenIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenIngredient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOpenIngredient.ImageOptions.SvgImage")));
            this.btnOpenIngredient.Location = new System.Drawing.Point(307, 3);
            this.btnOpenIngredient.Name = "btnOpenIngredient";
            this.btnOpenIngredient.Size = new System.Drawing.Size(70, 58);
            this.btnOpenIngredient.TabIndex = 2;
            this.btnOpenIngredient.Text = "Open frmIngredient";
            this.btnOpenIngredient.Click += new System.EventHandler(this.btnOpenIngredient_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemove.ImageOptions.SvgImage")));
            this.btnRemove.Location = new System.Drawing.Point(3, 67);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 58);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gridControl_Ingredient
            // 
            this.gridControl_Ingredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Ingredient.Location = new System.Drawing.Point(79, 3);
            this.gridControl_Ingredient.MainView = this.gridView_Ingredient;
            this.gridControl_Ingredient.Name = "gridControl_Ingredient";
            this.tableLayoutPanel3.SetRowSpan(this.gridControl_Ingredient, 3);
            this.gridControl_Ingredient.Size = new System.Drawing.Size(222, 641);
            this.gridControl_Ingredient.TabIndex = 0;
            this.gridControl_Ingredient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Ingredient});
            // 
            // gridView_Ingredient
            // 
            this.gridView_Ingredient.GridControl = this.gridControl_Ingredient;
            this.gridView_Ingredient.Name = "gridView_Ingredient";
            this.gridView_Ingredient.OptionsBehavior.Editable = false;
            this.gridView_Ingredient.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Ingredient_RowClick);
            // 
            // txtWeight
            // 
            this.txtWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWeight.Location = new System.Drawing.Point(3, 131);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.Name = "fProperties";
            this.txtWeight.Size = new System.Drawing.Size(70, 28);
            this.txtWeight.TabIndex = 4;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 693);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "frmRecipe";
            this.Text = "frmIngredient";
            this.Load += new System.EventHandler(this.frmRecipe_Load);
            this.tableLayoutMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_detailProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detailProduct)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private DevExpress.XtraGrid.GridControl gridControl_detailProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_detailProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbbCategory;
        private DevExpress.XtraGrid.GridControl gridControl_product;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraGrid.GridControl gridControl_Ingredient;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Ingredient;
        private DevExpress.XtraEditors.SimpleButton btnOpenIngredient;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private Modify_Control.EditText_Digit txtWeight;
    }
}