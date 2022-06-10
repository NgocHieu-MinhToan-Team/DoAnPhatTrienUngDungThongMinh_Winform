
namespace PepperLunch
{
    partial class frmIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngredients));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl_Ingredient = new DevExpress.XtraGrid.GridControl();
            this.gridView_Ingredient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNameIngredient = new DevExpress.XtraEditors.TextEdit();
            this.btnAddIngredient = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateIngredient = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveIngredient = new DevExpress.XtraEditors.SimpleButton();
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingredient)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameIngredient.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 647);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl_Ingredient);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox1.Size = new System.Drawing.Size(509, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredients";
            // 
            // gridControl_Ingredient
            // 
            this.gridControl_Ingredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Ingredient.Location = new System.Drawing.Point(12, 34);
            this.gridControl_Ingredient.MainView = this.gridView_Ingredient;
            this.gridControl_Ingredient.Name = "gridControl_Ingredient";
            this.gridControl_Ingredient.Size = new System.Drawing.Size(485, 386);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.20236F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.13163F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.46955F));
            this.tableLayoutPanel3.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtNameIngredient, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnAddIngredient, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdateIngredient, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveIngredient, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbbSupplier, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 451);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.10714F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.89286F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(509, 183);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Supplier";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(3, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(145, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Name Ingredient";
            // 
            // txtNameIngredient
            // 
            this.txtNameIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameIngredient.Location = new System.Drawing.Point(172, 55);
            this.txtNameIngredient.Name = "txtNameIngredient";
            this.txtNameIngredient.Size = new System.Drawing.Size(183, 28);
            this.txtNameIngredient.TabIndex = 3;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngredient.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddIngredient.Appearance.Options.UseFont = true;
            this.btnAddIngredient.Appearance.Options.UseForeColor = true;
            this.btnAddIngredient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddIngredient.Location = new System.Drawing.Point(361, 3);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(145, 31);
            this.btnAddIngredient.TabIndex = 4;
            this.btnAddIngredient.Text = "Add";
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnUpdateIngredient
            // 
            this.btnUpdateIngredient.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateIngredient.Appearance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdateIngredient.Appearance.Options.UseFont = true;
            this.btnUpdateIngredient.Appearance.Options.UseForeColor = true;
            this.btnUpdateIngredient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateIngredient.Location = new System.Drawing.Point(361, 55);
            this.btnUpdateIngredient.Name = "btnUpdateIngredient";
            this.btnUpdateIngredient.Size = new System.Drawing.Size(145, 32);
            this.btnUpdateIngredient.TabIndex = 5;
            this.btnUpdateIngredient.Text = "Update";
            this.btnUpdateIngredient.Click += new System.EventHandler(this.btnUpdateIngredient_Click);
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveIngredient.Appearance.ForeColor = System.Drawing.Color.Brown;
            this.btnRemoveIngredient.Appearance.Options.UseFont = true;
            this.btnRemoveIngredient.Appearance.Options.UseForeColor = true;
            this.btnRemoveIngredient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveIngredient.Location = new System.Drawing.Point(361, 109);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(145, 32);
            this.btnRemoveIngredient.TabIndex = 6;
            this.btnRemoveIngredient.Text = "Remove";
            this.btnRemoveIngredient.Click += new System.EventHandler(this.btnRemoveIngredient_Click);
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(172, 3);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(183, 29);
            this.cbbSupplier.TabIndex = 7;
            // 
            // frmIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 647);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmIngredients.IconOptions.SvgImage")));
            this.Name = "frmIngredients";
            this.Text = "Ingredients";
            this.Load += new System.EventHandler(this.frmIngredients_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Ingredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Ingredient)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameIngredient.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControl_Ingredient;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Ingredient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNameIngredient;
        private DevExpress.XtraEditors.SimpleButton btnAddIngredient;
        private DevExpress.XtraEditors.SimpleButton btnUpdateIngredient;
        private DevExpress.XtraEditors.SimpleButton btnRemoveIngredient;
        private System.Windows.Forms.ComboBox cbbSupplier;
    }
}