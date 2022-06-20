
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
            this.gridControl_Category = new DevExpress.XtraGrid.GridControl();
            this.gridView_Category = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtNameCate = new Modify_Control.EditText_Letter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbGroupCate = new System.Windows.Forms.ComboBox();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.tableLayoutPanel_input = new System.Windows.Forms.TableLayoutPanel();
            this.accordionCtrlEGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_AddCate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_RemoveCate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_UpdateCate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            this.accordionContentContainer1.SuspendLayout();
            this.tableLayoutPanel_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.tableLayoutPanel1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(307, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(676, 545);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl_Category, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(40);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.935484F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.06451F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 545);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridControl_Category
            // 
            this.gridControl_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Category.Location = new System.Drawing.Point(43, 52);
            this.gridControl_Category.MainView = this.gridView_Category;
            this.gridControl_Category.Name = "gridControl_Category";
            this.gridControl_Category.Size = new System.Drawing.Size(590, 450);
            this.gridControl_Category.TabIndex = 0;
            this.gridControl_Category.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Category});
            // 
            // gridView_Category
            // 
            this.gridView_Category.GridControl = this.gridControl_Category;
            this.gridView_Category.Name = "gridView_Category";
            this.gridView_Category.OptionsBehavior.Editable = false;
            this.gridView_Category.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Category_RowClick);
            // 
            // txtNameCate
            // 
            this.txtNameCate.Location = new System.Drawing.Point(15, 109);
            this.txtNameCate.Name = "txtNameCate";
            this.txtNameCate.Size = new System.Drawing.Size(254, 28);
            this.txtNameCate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(15, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of Category";
            // 
            // cbbGroupCate
            // 
            this.cbbGroupCate.FormattingEnabled = true;
            this.cbbGroupCate.Location = new System.Drawing.Point(15, 41);
            this.cbbGroupCate.Name = "cbbGroupCate";
            this.cbbGroupCate.Size = new System.Drawing.Size(254, 29);
            this.cbbGroupCate.TabIndex = 4;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Controls.Add(this.accordionContentContainer1);
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionCtrlEGroup,
            this.accordionCtrlE_AddCate,
            this.accordionCtrlE_RemoveCate,
            this.accordionCtrlE_UpdateCate});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(307, 545);
            this.accordionControl1.TabIndex = 1;
            // 
            // accordionContentContainer1
            // 
            this.accordionContentContainer1.Controls.Add(this.tableLayoutPanel_input);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Size = new System.Drawing.Size(284, 144);
            this.accordionContentContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel_input
            // 
            this.tableLayoutPanel_input.ColumnCount = 1;
            this.tableLayoutPanel_input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_input.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel_input.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel_input.Controls.Add(this.cbbGroupCate, 0, 1);
            this.tableLayoutPanel_input.Controls.Add(this.txtNameCate, 0, 3);
            this.tableLayoutPanel_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_input.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_input.Name = "tableLayoutPanel_input";
            this.tableLayoutPanel_input.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.tableLayoutPanel_input.RowCount = 4;
            this.tableLayoutPanel_input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_input.Size = new System.Drawing.Size(284, 144);
            this.tableLayoutPanel_input.TabIndex = 0;
            // 
            // accordionCtrlEGroup
            // 
            this.accordionCtrlEGroup.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlEGroup.Appearance.Normal.ForeColor = System.Drawing.Color.Goldenrod;
            this.accordionCtrlEGroup.Appearance.Normal.Options.UseFont = true;
            this.accordionCtrlEGroup.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrlEGroup.Appearance.Normal.Options.UseTextOptions = true;
            this.accordionCtrlEGroup.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accordionCtrlEGroup.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.accordionCtrlEGroup.ContentContainer = this.accordionContentContainer1;
            this.accordionCtrlEGroup.Expanded = true;
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
            this.accordionCtrlE_AddCate.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_AddCate.Appearance.Normal.ForeColor = System.Drawing.Color.FloralWhite;
            this.accordionCtrlE_AddCate.Appearance.Normal.Options.UseFont = true;
            this.accordionCtrlE_AddCate.Appearance.Normal.Options.UseForeColor = true;
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
            this.accordionCtrlE_RemoveCate.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_RemoveCate.Appearance.Normal.ForeColor = System.Drawing.Color.FloralWhite;
            this.accordionCtrlE_RemoveCate.Appearance.Normal.Options.UseFont = true;
            this.accordionCtrlE_RemoveCate.Appearance.Normal.Options.UseForeColor = true;
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
            this.accordionCtrlE_UpdateCate.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionCtrlE_UpdateCate.Appearance.Normal.ForeColor = System.Drawing.Color.FloralWhite;
            this.accordionCtrlE_UpdateCate.Appearance.Normal.Options.UseFont = true;
            this.accordionCtrlE_UpdateCate.Appearance.Normal.Options.UseForeColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            this.accordionContentContainer1.ResumeLayout(false);
            this.tableLayoutPanel_input.ResumeLayout(false);
            this.tableLayoutPanel_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl_Category;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Category;
        private Modify_Control.EditText_Letter txtNameCate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbGroupCate;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_input;
    }
}