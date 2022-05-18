
namespace PepperLunch
{
    partial class frmHandleFirebase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandleFirebase));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.tblLayout_wrapper = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayout_top = new System.Windows.Forms.TableLayoutPanel();
            this.btnSyncTo = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_top = new DevExpress.XtraGrid.GridControl();
            this.gridView_sync = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tblLayout_topHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblMilisecond = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tblLayout_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_bottom = new DevExpress.XtraGrid.GridControl();
            this.gridView_notSync = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSyncDown = new DevExpress.XtraEditors.SimpleButton();
            this.tblLayout_bottomHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblMilisecondeNotSync = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrl_Category = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_Dish = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_Customer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_Receipt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormContainer1.SuspendLayout();
            this.tblLayout_wrapper.SuspendLayout();
            this.tblLayout_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_sync)).BeginInit();
            this.tblLayout_topHeader.SuspendLayout();
            this.tblLayout_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_notSync)).BeginInit();
            this.tblLayout_bottomHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.tblLayout_wrapper);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1064, 676);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tblLayout_wrapper
            // 
            this.tblLayout_wrapper.ColumnCount = 1;
            this.tblLayout_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblLayout_wrapper.Controls.Add(this.tblLayout_top, 0, 0);
            this.tblLayout_wrapper.Controls.Add(this.tblLayout_bottom, 0, 1);
            this.tblLayout_wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_wrapper.Location = new System.Drawing.Point(0, 0);
            this.tblLayout_wrapper.Name = "tblLayout_wrapper";
            this.tblLayout_wrapper.RowCount = 2;
            this.tblLayout_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout_wrapper.Size = new System.Drawing.Size(1064, 676);
            this.tblLayout_wrapper.TabIndex = 0;
            // 
            // tblLayout_top
            // 
            this.tblLayout_top.ColumnCount = 2;
            this.tblLayout_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayout_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_top.Controls.Add(this.btnSyncTo, 1, 1);
            this.tblLayout_top.Controls.Add(this.gridControl_top, 0, 1);
            this.tblLayout_top.Controls.Add(this.tblLayout_topHeader, 0, 0);
            this.tblLayout_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_top.Location = new System.Drawing.Point(3, 3);
            this.tblLayout_top.Name = "tblLayout_top";
            this.tblLayout_top.RowCount = 2;
            this.tblLayout_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblLayout_top.Size = new System.Drawing.Size(1058, 332);
            this.tblLayout_top.TabIndex = 4;
            // 
            // btnSyncTo
            // 
            this.btnSyncTo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncTo.Appearance.Options.UseFont = true;
            this.btnSyncTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSyncTo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSyncTo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSyncTo.ImageOptions.SvgImage")));
            this.btnSyncTo.Location = new System.Drawing.Point(849, 36);
            this.btnSyncTo.Name = "btnSyncTo";
            this.btnSyncTo.Size = new System.Drawing.Size(206, 77);
            this.btnSyncTo.TabIndex = 0;
            this.btnSyncTo.Text = "Sync To Firebase";
            this.btnSyncTo.Click += new System.EventHandler(this.btnSyncTo_Click);
            // 
            // gridControl_top
            // 
            this.gridControl_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_top.Location = new System.Drawing.Point(3, 36);
            this.gridControl_top.MainView = this.gridView_sync;
            this.gridControl_top.Name = "gridControl_top";
            this.gridControl_top.Size = new System.Drawing.Size(840, 293);
            this.gridControl_top.TabIndex = 0;
            this.gridControl_top.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_sync});
            // 
            // gridView_sync
            // 
            this.gridView_sync.GridControl = this.gridControl_top;
            this.gridView_sync.Name = "gridView_sync";
            // 
            // tblLayout_topHeader
            // 
            this.tblLayout_topHeader.BackColor = System.Drawing.Color.DarkOrange;
            this.tblLayout_topHeader.ColumnCount = 2;
            this.tblLayout_top.SetColumnSpan(this.tblLayout_topHeader, 2);
            this.tblLayout_topHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayout_topHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_topHeader.Controls.Add(this.lblMilisecond, 1, 0);
            this.tblLayout_topHeader.Controls.Add(this.labelControl1, 0, 0);
            this.tblLayout_topHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_topHeader.Location = new System.Drawing.Point(3, 3);
            this.tblLayout_topHeader.Name = "tblLayout_topHeader";
            this.tblLayout_topHeader.RowCount = 1;
            this.tblLayout_topHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_topHeader.Size = new System.Drawing.Size(1052, 27);
            this.tblLayout_topHeader.TabIndex = 2;
            // 
            // lblMilisecond
            // 
            this.lblMilisecond.AutoSize = true;
            this.lblMilisecond.BackColor = System.Drawing.Color.Transparent;
            this.lblMilisecond.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilisecond.ForeColor = System.Drawing.Color.White;
            this.lblMilisecond.Location = new System.Drawing.Point(844, 0);
            this.lblMilisecond.Name = "lblMilisecond";
            this.lblMilisecond.Size = new System.Drawing.Size(155, 21);
            this.lblMilisecond.TabIndex = 1;
            this.lblMilisecond.Text = "Time Load : 0 ms";
            this.lblMilisecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(356, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Data Get From Branch Firebase";
            // 
            // tblLayout_bottom
            // 
            this.tblLayout_bottom.ColumnCount = 2;
            this.tblLayout_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayout_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_bottom.Controls.Add(this.gridControl_bottom, 0, 1);
            this.tblLayout_bottom.Controls.Add(this.btnSyncDown, 1, 1);
            this.tblLayout_bottom.Controls.Add(this.tblLayout_bottomHeader, 0, 0);
            this.tblLayout_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_bottom.Location = new System.Drawing.Point(3, 341);
            this.tblLayout_bottom.Name = "tblLayout_bottom";
            this.tblLayout_bottom.RowCount = 2;
            this.tblLayout_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblLayout_bottom.Size = new System.Drawing.Size(1058, 332);
            this.tblLayout_bottom.TabIndex = 5;
            // 
            // gridControl_bottom
            // 
            this.gridControl_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_bottom.Location = new System.Drawing.Point(3, 36);
            this.gridControl_bottom.MainView = this.gridView_notSync;
            this.gridControl_bottom.Name = "gridControl_bottom";
            this.gridControl_bottom.Size = new System.Drawing.Size(840, 293);
            this.gridControl_bottom.TabIndex = 1;
            this.gridControl_bottom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_notSync});
            // 
            // gridView_notSync
            // 
            this.gridView_notSync.GridControl = this.gridControl_bottom;
            this.gridView_notSync.Name = "gridView_notSync";
            // 
            // btnSyncDown
            // 
            this.btnSyncDown.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncDown.Appearance.Options.UseFont = true;
            this.btnSyncDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSyncDown.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSyncDown.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSyncDown.ImageOptions.SvgImage")));
            this.btnSyncDown.Location = new System.Drawing.Point(849, 36);
            this.btnSyncDown.Name = "btnSyncDown";
            this.btnSyncDown.Size = new System.Drawing.Size(206, 77);
            this.btnSyncDown.TabIndex = 1;
            this.btnSyncDown.Text = "Sync Down To SQL";
            this.btnSyncDown.Click += new System.EventHandler(this.btnSyncDown_Click);
            // 
            // tblLayout_bottomHeader
            // 
            this.tblLayout_bottomHeader.BackColor = System.Drawing.Color.DarkOrange;
            this.tblLayout_bottomHeader.ColumnCount = 2;
            this.tblLayout_bottom.SetColumnSpan(this.tblLayout_bottomHeader, 2);
            this.tblLayout_bottomHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblLayout_bottomHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_bottomHeader.Controls.Add(this.lblMilisecondeNotSync, 1, 0);
            this.tblLayout_bottomHeader.Controls.Add(this.labelControl2, 0, 0);
            this.tblLayout_bottomHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_bottomHeader.Location = new System.Drawing.Point(3, 3);
            this.tblLayout_bottomHeader.Name = "tblLayout_bottomHeader";
            this.tblLayout_bottomHeader.RowCount = 1;
            this.tblLayout_bottomHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_bottomHeader.Size = new System.Drawing.Size(1052, 27);
            this.tblLayout_bottomHeader.TabIndex = 3;
            // 
            // lblMilisecondeNotSync
            // 
            this.lblMilisecondeNotSync.AutoSize = true;
            this.lblMilisecondeNotSync.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilisecondeNotSync.ForeColor = System.Drawing.Color.White;
            this.lblMilisecondeNotSync.Location = new System.Drawing.Point(844, 0);
            this.lblMilisecondeNotSync.Name = "lblMilisecondeNotSync";
            this.lblMilisecondeNotSync.Size = new System.Drawing.Size(190, 21);
            this.lblMilisecondeNotSync.TabIndex = 2;
            this.lblMilisecondeNotSync.Text = "Time Not Sync : 0 ms";
            this.lblMilisecondeNotSync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(272, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data Not Synchronized";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionCtrl_Category,
            this.accordionCtrlE_Dish,
            this.accordionCtrlE_Customer,
            this.accordionCtrlE_Receipt});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 676);
            this.accordionControl1.TabIndex = 1;
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Appearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.accordionControlElement2.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accordionControlElement2.Height = 50;
            this.accordionControlElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "FIREBASE";
            // 
            // accordionCtrl_Category
            // 
            this.accordionCtrl_Category.Appearance.Hovered.BackColor = System.Drawing.Color.White;
            this.accordionCtrl_Category.Appearance.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.accordionCtrl_Category.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionCtrl_Category.Appearance.Hovered.Options.UseForeColor = true;
            this.accordionCtrl_Category.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionCtrl_Category.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrl_Category.Expanded = true;
            this.accordionCtrl_Category.Height = 40;
            this.accordionCtrl_Category.Name = "accordionCtrl_Category";
            this.accordionCtrl_Category.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrl_Category.Text = "CATEGORY";
            this.accordionCtrl_Category.Click += new System.EventHandler(this.accordionCtrl_Category_Click);
            // 
            // accordionCtrlE_Dish
            // 
            this.accordionCtrlE_Dish.Appearance.Hovered.BackColor = System.Drawing.Color.White;
            this.accordionCtrlE_Dish.Appearance.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.accordionCtrlE_Dish.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionCtrlE_Dish.Appearance.Hovered.Options.UseForeColor = true;
            this.accordionCtrlE_Dish.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionCtrlE_Dish.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrlE_Dish.Height = 40;
            this.accordionCtrlE_Dish.Name = "accordionCtrlE_Dish";
            this.accordionCtrlE_Dish.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_Dish.Text = "DISH";
            this.accordionCtrlE_Dish.Click += new System.EventHandler(this.accordionCtrlE_Dish_Click);
            // 
            // accordionCtrlE_Customer
            // 
            this.accordionCtrlE_Customer.Appearance.Hovered.BackColor = System.Drawing.Color.White;
            this.accordionCtrlE_Customer.Appearance.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.accordionCtrlE_Customer.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionCtrlE_Customer.Appearance.Hovered.Options.UseForeColor = true;
            this.accordionCtrlE_Customer.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionCtrlE_Customer.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrlE_Customer.Height = 40;
            this.accordionCtrlE_Customer.Name = "accordionCtrlE_Customer";
            this.accordionCtrlE_Customer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_Customer.Text = "CUSTOMER";
            this.accordionCtrlE_Customer.Click += new System.EventHandler(this.accordionCtrlE_Customer_Click);
            // 
            // accordionCtrlE_Receipt
            // 
            this.accordionCtrlE_Receipt.Appearance.Hovered.BackColor = System.Drawing.Color.White;
            this.accordionCtrlE_Receipt.Appearance.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.accordionCtrlE_Receipt.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionCtrlE_Receipt.Appearance.Hovered.Options.UseForeColor = true;
            this.accordionCtrlE_Receipt.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionCtrlE_Receipt.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrlE_Receipt.Height = 40;
            this.accordionCtrlE_Receipt.Name = "accordionCtrlE_Receipt";
            this.accordionCtrlE_Receipt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_Receipt.Text = "RECEIPT";
            this.accordionCtrlE_Receipt.Click += new System.EventHandler(this.accordionCtrlE_Receipt_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1324, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Hovered.BackColor = System.Drawing.Color.White;
            this.accordionControlElement1.Appearance.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.accordionControlElement1.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionControlElement1.Appearance.Hovered.Options.UseForeColor = true;
            this.accordionControlElement1.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionControlElement1.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement1.Height = 40;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Element4";
            // 
            // frmHandleFirebase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 715);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmHandleFirebase";
            this.NavigationControl = this.accordionControl1;
            this.Text = "frmHandleFirebase";
            this.Load += new System.EventHandler(this.frmHandleFirebase_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.tblLayout_wrapper.ResumeLayout(false);
            this.tblLayout_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_sync)).EndInit();
            this.tblLayout_topHeader.ResumeLayout(false);
            this.tblLayout_topHeader.PerformLayout();
            this.tblLayout_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_notSync)).EndInit();
            this.tblLayout_bottomHeader.ResumeLayout(false);
            this.tblLayout_bottomHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrl_Category;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.TableLayoutPanel tblLayout_wrapper;
        private DevExpress.XtraGrid.GridControl gridControl_top;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_sync;
        private DevExpress.XtraGrid.GridControl gridControl_bottom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_notSync;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_Dish;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_Customer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_Receipt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraEditors.SimpleButton btnSyncTo;
        private DevExpress.XtraEditors.SimpleButton btnSyncDown;
        private System.Windows.Forms.Label lblMilisecond;
        private System.Windows.Forms.Label lblMilisecondeNotSync;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private System.Windows.Forms.TableLayoutPanel tblLayout_top;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tblLayout_bottom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TableLayoutPanel tblLayout_topHeader;
        private System.Windows.Forms.TableLayoutPanel tblLayout_bottomHeader;
    }
}