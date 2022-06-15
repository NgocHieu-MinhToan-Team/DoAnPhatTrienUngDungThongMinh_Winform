
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
            this.gridControl_detailProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView_detailProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_RECIPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME_EN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME_INGREDIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WEIGHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_Ingredient = new DevExpress.XtraGrid.GridControl();
            this.gridView_Ingredient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.INGREDIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOpenIngredient = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_detailProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detailProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingredient)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.tableLayoutMain.ColumnCount = 4;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutMain.Controls.Add(this.gridControl_detailProduct, 0, 0);
            this.tableLayoutMain.Controls.Add(this.gridControl_Ingredient, 2, 0);
            this.tableLayoutMain.Controls.Add(this.btnOpenIngredient, 3, 0);
            this.tableLayoutMain.Controls.Add(this.btnRemove, 1, 2);
            this.tableLayoutMain.Controls.Add(this.btnAdd, 1, 1);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutMain.RowCount = 4;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1325, 693);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // gridControl_detailProduct
            // 
            this.gridControl_detailProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_detailProduct.Location = new System.Drawing.Point(13, 13);
            this.gridControl_detailProduct.MainView = this.gridView_detailProduct;
            this.gridControl_detailProduct.Name = "gridControl_detailProduct";
            this.tableLayoutMain.SetRowSpan(this.gridControl_detailProduct, 4);
            this.gridControl_detailProduct.Size = new System.Drawing.Size(646, 667);
            this.gridControl_detailProduct.TabIndex = 6;
            this.gridControl_detailProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_detailProduct});
            // 
            // gridView_detailProduct
            // 
            this.gridView_detailProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_RECIPE,
            this.NAME_EN,
            this.NAME_INGREDIENT,
            this.WEIGHT});
            this.gridView_detailProduct.GridControl = this.gridControl_detailProduct;
            this.gridView_detailProduct.Name = "gridView_detailProduct";
            this.gridView_detailProduct.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView_detailProduct_ValidatingEditor);
            // 
            // ID_RECIPE
            // 
            this.ID_RECIPE.Caption = "ID";
            this.ID_RECIPE.FieldName = "ID_DETAIL";
            this.ID_RECIPE.MinWidth = 25;
            this.ID_RECIPE.Name = "ID_RECIPE";
            this.ID_RECIPE.OptionsColumn.AllowEdit = false;
            this.ID_RECIPE.Visible = true;
            this.ID_RECIPE.VisibleIndex = 0;
            this.ID_RECIPE.Width = 94;
            // 
            // NAME_EN
            // 
            this.NAME_EN.Caption = "ENGLISH";
            this.NAME_EN.FieldName = "NAME_PRODUCT_EN";
            this.NAME_EN.MinWidth = 25;
            this.NAME_EN.Name = "NAME_EN";
            this.NAME_EN.OptionsColumn.AllowEdit = false;
            this.NAME_EN.Visible = true;
            this.NAME_EN.VisibleIndex = 1;
            this.NAME_EN.Width = 94;
            // 
            // NAME_INGREDIENT
            // 
            this.NAME_INGREDIENT.Caption = "INGREDIENT";
            this.NAME_INGREDIENT.FieldName = "NAME_INGREDIENT";
            this.NAME_INGREDIENT.MinWidth = 25;
            this.NAME_INGREDIENT.Name = "NAME_INGREDIENT";
            this.NAME_INGREDIENT.OptionsColumn.AllowEdit = false;
            this.NAME_INGREDIENT.Visible = true;
            this.NAME_INGREDIENT.VisibleIndex = 2;
            this.NAME_INGREDIENT.Width = 94;
            // 
            // WEIGHT
            // 
            this.WEIGHT.Caption = "WEIGHT";
            this.WEIGHT.FieldName = "WEIGHT_DETAIL";
            this.WEIGHT.MinWidth = 25;
            this.WEIGHT.Name = "WEIGHT";
            this.WEIGHT.Visible = true;
            this.WEIGHT.VisibleIndex = 3;
            this.WEIGHT.Width = 94;
            // 
            // gridControl_Ingredient
            // 
            this.gridControl_Ingredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Ingredient.Location = new System.Drawing.Point(730, 13);
            this.gridControl_Ingredient.MainView = this.gridView_Ingredient;
            this.gridControl_Ingredient.Name = "gridControl_Ingredient";
            this.tableLayoutMain.SetRowSpan(this.gridControl_Ingredient, 4);
            this.gridControl_Ingredient.Size = new System.Drawing.Size(516, 667);
            this.gridControl_Ingredient.TabIndex = 0;
            this.gridControl_Ingredient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Ingredient});
            // 
            // gridView_Ingredient
            // 
            this.gridView_Ingredient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.INGREDIENT});
            this.gridView_Ingredient.GridControl = this.gridControl_Ingredient;
            this.gridView_Ingredient.Name = "gridView_Ingredient";
            this.gridView_Ingredient.OptionsBehavior.Editable = false;
            this.gridView_Ingredient.OptionsFind.AlwaysVisible = true;
            this.gridView_Ingredient.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Ingredient_RowClick);
            // 
            // INGREDIENT
            // 
            this.INGREDIENT.Caption = "INGREDIENT";
            this.INGREDIENT.FieldName = "NAME_INGREDIENT";
            this.INGREDIENT.MinWidth = 25;
            this.INGREDIENT.Name = "INGREDIENT";
            this.INGREDIENT.Visible = true;
            this.INGREDIENT.VisibleIndex = 0;
            this.INGREDIENT.Width = 94;
            // 
            // btnOpenIngredient
            // 
            this.btnOpenIngredient.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnOpenIngredient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOpenIngredient.ImageOptions.SvgImage")));
            this.btnOpenIngredient.Location = new System.Drawing.Point(1252, 13);
            this.btnOpenIngredient.Name = "btnOpenIngredient";
            this.btnOpenIngredient.Size = new System.Drawing.Size(60, 58);
            this.btnOpenIngredient.TabIndex = 2;
            this.btnOpenIngredient.Click += new System.EventHandler(this.btnOpenIngredient_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRemove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemove.ImageOptions.SvgImage")));
            this.btnRemove.Location = new System.Drawing.Point(665, 348);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(59, 128);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(665, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 128);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 693);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "frmRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecipe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRecipe_FormClosing);
            this.Load += new System.EventHandler(this.frmRecipe_Load);
            this.tableLayoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_detailProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_detailProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingredient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private DevExpress.XtraGrid.GridControl gridControl_detailProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_detailProduct;
        private DevExpress.XtraGrid.GridControl gridControl_Ingredient;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Ingredient;
        private DevExpress.XtraEditors.SimpleButton btnOpenIngredient;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraGrid.Columns.GridColumn ID_RECIPE;
        private DevExpress.XtraGrid.Columns.GridColumn NAME_EN;
        private DevExpress.XtraGrid.Columns.GridColumn NAME_INGREDIENT;
        private DevExpress.XtraGrid.Columns.GridColumn WEIGHT;
        private DevExpress.XtraGrid.Columns.GridColumn INGREDIENT;
    }
}