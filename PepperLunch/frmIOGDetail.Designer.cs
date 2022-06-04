
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
            this.gridControl_IOGDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView_IOGDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_Ingredient = new DevExpress.XtraGrid.GridControl();
            this.gridView_Ingredient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel_Left = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCount = new Modify_Control.EditText_Digit();
            this.txtPrice = new Modify_Control.EditText_Digit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_IOGDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_IOGDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingredient)).BeginInit();
            this.tableLayoutPanel_mid.SuspendLayout();
            this.tableLayoutPanel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.BackColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel_Main.ColumnCount = 3;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel_Main.Controls.Add(this.labelControl4, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.gridControl_IOGDetail, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.gridControl_Ingredient, 2, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_mid, 1, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.labelControl1, 2, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Left, 0, 2);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.51087F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.48913F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1404, 601);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // gridControl_IOGDetail
            // 
            this.gridControl_IOGDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_IOGDetail.Location = new System.Drawing.Point(23, 71);
            this.gridControl_IOGDetail.MainView = this.gridView_IOGDetail;
            this.gridControl_IOGDetail.Name = "gridControl_IOGDetail";
            this.gridControl_IOGDetail.Size = new System.Drawing.Size(648, 459);
            this.gridControl_IOGDetail.TabIndex = 1;
            this.gridControl_IOGDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_IOGDetail});
            // 
            // gridView_IOGDetail
            // 
            this.gridView_IOGDetail.GridControl = this.gridControl_IOGDetail;
            this.gridView_IOGDetail.Name = "gridView_IOGDetail";
            // 
            // gridControl_Ingredient
            // 
            this.gridControl_Ingredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Ingredient.Location = new System.Drawing.Point(731, 71);
            this.gridControl_Ingredient.MainView = this.gridView_Ingredient;
            this.gridControl_Ingredient.Name = "gridControl_Ingredient";
            this.gridControl_Ingredient.Size = new System.Drawing.Size(650, 459);
            this.gridControl_Ingredient.TabIndex = 2;
            this.gridControl_Ingredient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Ingredient});
            // 
            // gridView_Ingredient
            // 
            this.gridView_Ingredient.GridControl = this.gridControl_Ingredient;
            this.gridView_Ingredient.Name = "gridView_Ingredient";
            this.gridView_Ingredient.OptionsFind.AlwaysVisible = true;
            // 
            // tableLayoutPanel_mid
            // 
            this.tableLayoutPanel_mid.ColumnCount = 1;
            this.tableLayoutPanel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_mid.Controls.Add(this.btnAdd, 0, 1);
            this.tableLayoutPanel_mid.Controls.Add(this.btnRemove, 0, 2);
            this.tableLayoutPanel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mid.Location = new System.Drawing.Point(677, 71);
            this.tableLayoutPanel_mid.Name = "tableLayoutPanel_mid";
            this.tableLayoutPanel_mid.RowCount = 4;
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_mid.Size = new System.Drawing.Size(48, 459);
            this.tableLayoutPanel_mid.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(3, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 85);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRemove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemove.ImageOptions.SvgImage")));
            this.btnRemove.Location = new System.Drawing.Point(3, 231);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(42, 85);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tableLayoutPanel_Left
            // 
            this.tableLayoutPanel_Left.ColumnCount = 4;
            this.tableLayoutPanel_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Left.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel_Left.Controls.Add(this.labelControl3, 2, 0);
            this.tableLayoutPanel_Left.Controls.Add(this.txtCount, 1, 0);
            this.tableLayoutPanel_Left.Controls.Add(this.txtPrice, 3, 0);
            this.tableLayoutPanel_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Left.Location = new System.Drawing.Point(23, 536);
            this.tableLayoutPanel_Left.Name = "tableLayoutPanel_Left";
            this.tableLayoutPanel_Left.RowCount = 1;
            this.tableLayoutPanel_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Left.Size = new System.Drawing.Size(648, 42);
            this.tableLayoutPanel_Left.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(156, 36);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Count";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(327, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(156, 36);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Price";
            // 
            // txtCount
            // 
            this.txtCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCount.Location = new System.Drawing.Point(165, 3);
            this.txtCount.Name = "txtCount";
            this.txtCount.Properties.Name = "fProperties";
            this.txtCount.Size = new System.Drawing.Size(156, 28);
            this.txtCount.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(489, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Name = "fProperties";
            this.txtPrice.Size = new System.Drawing.Size(156, 28);
            this.txtPrice.TabIndex = 3;
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
            this.labelControl1.Location = new System.Drawing.Point(731, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(650, 42);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "List Of Ingredients";
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
            this.labelControl4.Size = new System.Drawing.Size(648, 42);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "List Of Detail IOG";
            // 
            // frmIOGDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 601);
            this.Controls.Add(this.tableLayoutPanel_Main);
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
            this.tableLayoutPanel_Left.ResumeLayout(false);
            this.tableLayoutPanel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Left;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Modify_Control.EditText_Digit txtCount;
        private Modify_Control.EditText_Digit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}