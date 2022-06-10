
namespace PepperLunch
{
    partial class frmIOGDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIOGDetail));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_IOGDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView_IOGDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_DETAIL_IOG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_Ingredient = new DevExpress.XtraGrid.GridControl();
            this.gridView_Ingredient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NAME_INGREDIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_IOGDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_IOGDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingredient)).BeginInit();
            this.tableLayoutPanel_mid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.BackColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel_Main.ColumnCount = 3;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.555556F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel_Main.Controls.Add(this.labelControl4, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.gridControl_IOGDetail, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.gridControl_Ingredient, 2, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_mid, 1, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.labelControl1, 2, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1063, 601);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(23, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(675, 44);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "List Of Detail IOG";
            // 
            // gridControl_IOGDetail
            // 
            this.gridControl_IOGDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_IOGDetail.Location = new System.Drawing.Point(23, 73);
            this.gridControl_IOGDetail.MainView = this.gridView_IOGDetail;
            this.gridControl_IOGDetail.Name = "gridControl_IOGDetail";
            this.gridControl_IOGDetail.Size = new System.Drawing.Size(675, 452);
            this.gridControl_IOGDetail.TabIndex = 1;
            this.gridControl_IOGDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_IOGDetail});
            // 
            // gridView_IOGDetail
            // 
            this.gridView_IOGDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_DETAIL_IOG,
            this.gridColumn1,
            this.COUNT});
            this.gridView_IOGDetail.GridControl = this.gridControl_IOGDetail;
            this.gridView_IOGDetail.Name = "gridView_IOGDetail";
            this.gridView_IOGDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_IOGDetail_CellValueChanged);
            // 
            // ID_DETAIL_IOG
            // 
            this.ID_DETAIL_IOG.Caption = "ID_DETAIL_IOG";
            this.ID_DETAIL_IOG.FieldName = "ID_DETAIL_IOG";
            this.ID_DETAIL_IOG.MinWidth = 25;
            this.ID_DETAIL_IOG.Name = "ID_DETAIL_IOG";
            this.ID_DETAIL_IOG.OptionsColumn.AllowEdit = false;
            this.ID_DETAIL_IOG.Visible = true;
            this.ID_DETAIL_IOG.VisibleIndex = 0;
            this.ID_DETAIL_IOG.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID_INGREDIENT";
            this.gridColumn1.FieldName = "ID_INGREDIENT";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 94;
            // 
            // COUNT
            // 
            this.COUNT.Caption = "QUANTITY";
            this.COUNT.FieldName = "QUANTITY";
            this.COUNT.MinWidth = 25;
            this.COUNT.Name = "COUNT";
            this.COUNT.Visible = true;
            this.COUNT.VisibleIndex = 2;
            this.COUNT.Width = 94;
            // 
            // gridControl_Ingredient
            // 
            this.gridControl_Ingredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Ingredient.Location = new System.Drawing.Point(760, 73);
            this.gridControl_Ingredient.MainView = this.gridView_Ingredient;
            this.gridControl_Ingredient.Name = "gridControl_Ingredient";
            this.gridControl_Ingredient.Size = new System.Drawing.Size(280, 452);
            this.gridControl_Ingredient.TabIndex = 2;
            this.gridControl_Ingredient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Ingredient});
            // 
            // gridView_Ingredient
            // 
            this.gridView_Ingredient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NAME_INGREDIENT});
            this.gridView_Ingredient.GridControl = this.gridControl_Ingredient;
            this.gridView_Ingredient.Name = "gridView_Ingredient";
            this.gridView_Ingredient.OptionsFind.AlwaysVisible = true;
            // 
            // NAME_INGREDIENT
            // 
            this.NAME_INGREDIENT.Caption = "NAME INGREDIENT";
            this.NAME_INGREDIENT.FieldName = "NAME_INGREDIENT";
            this.NAME_INGREDIENT.MinWidth = 25;
            this.NAME_INGREDIENT.Name = "NAME_INGREDIENT";
            this.NAME_INGREDIENT.Visible = true;
            this.NAME_INGREDIENT.VisibleIndex = 0;
            this.NAME_INGREDIENT.Width = 94;
            // 
            // tableLayoutPanel_mid
            // 
            this.tableLayoutPanel_mid.ColumnCount = 1;
            this.tableLayoutPanel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_mid.Controls.Add(this.btnAdd, 0, 1);
            this.tableLayoutPanel_mid.Controls.Add(this.btnRemove, 0, 2);
            this.tableLayoutPanel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mid.Location = new System.Drawing.Point(704, 73);
            this.tableLayoutPanel_mid.Name = "tableLayoutPanel_mid";
            this.tableLayoutPanel_mid.RowCount = 4;
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_mid.Size = new System.Drawing.Size(50, 452);
            this.tableLayoutPanel_mid.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(3, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 129);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRemove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemove.ImageOptions.SvgImage")));
            this.btnRemove.Location = new System.Drawing.Point(3, 228);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(44, 129);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(760, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(280, 44);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "List Of Ingredients";
            // 
            // frmIOGDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 601);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmIOGDetail.IconOptions.SvgImage")));
            this.Name = "frmIOGDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Import Of Good";
            this.Load += new System.EventHandler(this.frmIOGDetail_Load);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_IOGDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_IOGDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingredient)).EndInit();
            this.tableLayoutPanel_mid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private DevExpress.XtraGrid.GridControl gridControl_IOGDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_IOGDetail;
        private DevExpress.XtraGrid.GridControl gridControl_Ingredient;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Ingredient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_mid;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ID_DETAIL_IOG;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn COUNT;
        private DevExpress.XtraGrid.Columns.GridColumn NAME_INGREDIENT;
    }
}