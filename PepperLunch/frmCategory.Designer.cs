
namespace PepperLunch
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionCtrlEGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_AddCate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_RemoveCate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_UpdateCate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.gridView_Category = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_Category = new DevExpress.XtraGrid.GridControl();
            this.txtGroupCate = new Modify_Control.EditText_Letter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameCate = new Modify_Control.EditText_Letter();
            this.fluentDesignFormContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.tableLayoutPanel1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(723, 545);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl_Category, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 545);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.txtNameCate, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtGroupCate, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(717, 74);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(110, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group Category";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionCtrlEGroup,
            this.accordionCtrlE_AddCate,
            this.accordionCtrlE_RemoveCate,
            this.accordionCtrlE_UpdateCate});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 545);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionCtrlEGroup
            // 
            this.accordionCtrlEGroup.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlEGroup.Appearance.Normal.Options.UseFont = true;
            this.accordionCtrlEGroup.Height = 35;
            this.accordionCtrlEGroup.Name = "accordionCtrlEGroup";
            this.accordionCtrlEGroup.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlEGroup.Text = "CATEGORY";
            this.accordionCtrlEGroup.Click += new System.EventHandler(this.accordionCtrlEGroup_Click);
            // 
            // accordionCtrlE_AddCate
            // 
            this.accordionCtrlE_AddCate.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_AddCate.Appearance.Hovered.Options.UseFont = true;
            this.accordionCtrlE_AddCate.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_AddCate.Appearance.Normal.Options.UseFont = true;
            this.accordionCtrlE_AddCate.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_AddCate.Appearance.Pressed.Options.UseFont = true;
            this.accordionCtrlE_AddCate.Expanded = true;
            this.accordionCtrlE_AddCate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlE_AddCate.ImageOptions.Image")));
            this.accordionCtrlE_AddCate.Name = "accordionCtrlE_AddCate";
            this.accordionCtrlE_AddCate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_AddCate.Text = "Add Category";
            this.accordionCtrlE_AddCate.Click += new System.EventHandler(this.accordionCtrlE_AddCate_Click);
            // 
            // accordionCtrlE_RemoveCate
            // 
            this.accordionCtrlE_RemoveCate.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_RemoveCate.Appearance.Hovered.Options.UseFont = true;
            this.accordionCtrlE_RemoveCate.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_RemoveCate.Appearance.Normal.Options.UseFont = true;
            this.accordionCtrlE_RemoveCate.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_RemoveCate.Appearance.Pressed.Options.UseFont = true;
            this.accordionCtrlE_RemoveCate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlE_RemoveCate.ImageOptions.Image")));
            this.accordionCtrlE_RemoveCate.Name = "accordionCtrlE_RemoveCate";
            this.accordionCtrlE_RemoveCate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_RemoveCate.Text = "Remove Category";
            this.accordionCtrlE_RemoveCate.Click += new System.EventHandler(this.accordionCtrlE_RemoveCate_Click);
            // 
            // accordionCtrlE_UpdateCate
            // 
            this.accordionCtrlE_UpdateCate.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_UpdateCate.Appearance.Hovered.Options.UseFont = true;
            this.accordionCtrlE_UpdateCate.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_UpdateCate.Appearance.Normal.Options.UseFont = true;
            this.accordionCtrlE_UpdateCate.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_UpdateCate.Appearance.Pressed.Options.UseFont = true;
            this.accordionCtrlE_UpdateCate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlE_UpdateCate.ImageOptions.Image")));
            this.accordionCtrlE_UpdateCate.Name = "accordionCtrlE_UpdateCate";
            this.accordionCtrlE_UpdateCate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_UpdateCate.Text = "Update Category";
            this.accordionCtrlE_UpdateCate.Click += new System.EventHandler(this.accordionCtrlE_UpdateCate_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(983, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // gridView_Category
            // 
            this.gridView_Category.GridControl = this.gridControl_Category;
            this.gridView_Category.Name = "gridView_Category";
            // 
            // gridControl_Category
            // 
            this.gridControl_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Category.Location = new System.Drawing.Point(3, 112);
            this.gridControl_Category.MainView = this.gridView_Category;
            this.gridControl_Category.Name = "gridControl_Category";
            this.gridControl_Category.Size = new System.Drawing.Size(717, 430);
            this.gridControl_Category.TabIndex = 0;
            this.gridControl_Category.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Category});
            // 
            // txtGroupCate
            // 
            this.txtGroupCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGroupCate.Location = new System.Drawing.Point(289, 3);
            this.txtGroupCate.Name = "txtGroupCate";
            this.txtGroupCate.Size = new System.Drawing.Size(280, 28);
            this.txtGroupCate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(110, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of Category";
            // 
            // txtNameCate
            // 
            this.txtNameCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameCate.Location = new System.Drawing.Point(289, 40);
            this.txtNameCate.Name = "txtNameCate";
            this.txtNameCate.Size = new System.Drawing.Size(280, 28);
            this.txtNameCate.TabIndex = 1;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 584);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmCategory";
            this.NavigationControl = this.accordionControl1;
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlEGroup;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_AddCate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_UpdateCate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_RemoveCate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl_Category;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Category;
        private Modify_Control.EditText_Letter txtGroupCate;
        private Modify_Control.EditText_Letter txtNameCate;
        private System.Windows.Forms.Label label1;
    }
}