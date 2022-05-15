
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
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.tableLayout_wrapper = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView_fromFirebase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView_yetSync = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayou_CURDofFromFirebase = new System.Windows.Forms.TableLayoutPanel();
            this.btnSyncTo = new DevExpress.XtraEditors.SimpleButton();
            this.lblMilisecond = new System.Windows.Forms.Label();
            this.tableLayout_CURDofYetSync = new System.Windows.Forms.TableLayoutPanel();
            this.btnSyncDown = new DevExpress.XtraEditors.SimpleButton();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionCtrl_Category = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_Dish = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_Customer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_Receipt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.lblMilisecondeNotSync = new System.Windows.Forms.Label();
            this.fluentDesignFormContainer1.SuspendLayout();
            this.tableLayout_wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_fromFirebase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_yetSync)).BeginInit();
            this.tableLayou_CURDofFromFirebase.SuspendLayout();
            this.tableLayout_CURDofYetSync.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.tableLayout_wrapper);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(907, 676);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tableLayout_wrapper
            // 
            this.tableLayout_wrapper.ColumnCount = 2;
            this.tableLayout_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayout_wrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_wrapper.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayout_wrapper.Controls.Add(this.gridControl2, 0, 1);
            this.tableLayout_wrapper.Controls.Add(this.tableLayou_CURDofFromFirebase, 1, 0);
            this.tableLayout_wrapper.Controls.Add(this.tableLayout_CURDofYetSync, 1, 1);
            this.tableLayout_wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_wrapper.Location = new System.Drawing.Point(0, 0);
            this.tableLayout_wrapper.Name = "tableLayout_wrapper";
            this.tableLayout_wrapper.RowCount = 2;
            this.tableLayout_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_wrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_wrapper.Size = new System.Drawing.Size(907, 676);
            this.tableLayout_wrapper.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView_fromFirebase;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(764, 332);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_fromFirebase});
            // 
            // gridView_fromFirebase
            // 
            this.gridView_fromFirebase.GridControl = this.gridControl1;
            this.gridView_fromFirebase.Name = "gridView_fromFirebase";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 341);
            this.gridControl2.MainView = this.gridView_yetSync;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(764, 332);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_yetSync});
            // 
            // gridView_yetSync
            // 
            this.gridView_yetSync.GridControl = this.gridControl2;
            this.gridView_yetSync.Name = "gridView_yetSync";
            // 
            // tableLayou_CURDofFromFirebase
            // 
            this.tableLayou_CURDofFromFirebase.ColumnCount = 1;
            this.tableLayou_CURDofFromFirebase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayou_CURDofFromFirebase.Controls.Add(this.lblMilisecondeNotSync, 0, 2);
            this.tableLayou_CURDofFromFirebase.Controls.Add(this.btnSyncTo, 0, 1);
            this.tableLayou_CURDofFromFirebase.Controls.Add(this.lblMilisecond, 0, 0);
            this.tableLayou_CURDofFromFirebase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayou_CURDofFromFirebase.Location = new System.Drawing.Point(773, 3);
            this.tableLayou_CURDofFromFirebase.Name = "tableLayou_CURDofFromFirebase";
            this.tableLayou_CURDofFromFirebase.RowCount = 4;
            this.tableLayou_CURDofFromFirebase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayou_CURDofFromFirebase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayou_CURDofFromFirebase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayou_CURDofFromFirebase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayou_CURDofFromFirebase.Size = new System.Drawing.Size(131, 332);
            this.tableLayou_CURDofFromFirebase.TabIndex = 2;
            // 
            // btnSyncTo
            // 
            this.btnSyncTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSyncTo.Location = new System.Drawing.Point(3, 74);
            this.btnSyncTo.Name = "btnSyncTo";
            this.btnSyncTo.Size = new System.Drawing.Size(125, 29);
            this.btnSyncTo.TabIndex = 0;
            this.btnSyncTo.Text = "Sync To Firebase";
            this.btnSyncTo.Click += new System.EventHandler(this.btnSyncTo_Click);
            // 
            // lblMilisecond
            // 
            this.lblMilisecond.AutoSize = true;
            this.lblMilisecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMilisecond.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilisecond.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMilisecond.Location = new System.Drawing.Point(3, 0);
            this.lblMilisecond.Name = "lblMilisecond";
            this.lblMilisecond.Size = new System.Drawing.Size(125, 71);
            this.lblMilisecond.TabIndex = 1;
            this.lblMilisecond.Text = "Time Load : 0 ms";
            this.lblMilisecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout_CURDofYetSync
            // 
            this.tableLayout_CURDofYetSync.ColumnCount = 1;
            this.tableLayout_CURDofYetSync.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_CURDofYetSync.Controls.Add(this.btnSyncDown, 0, 1);
            this.tableLayout_CURDofYetSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout_CURDofYetSync.Location = new System.Drawing.Point(773, 341);
            this.tableLayout_CURDofYetSync.Name = "tableLayout_CURDofYetSync";
            this.tableLayout_CURDofYetSync.RowCount = 2;
            this.tableLayout_CURDofYetSync.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_CURDofYetSync.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayout_CURDofYetSync.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayout_CURDofYetSync.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout_CURDofYetSync.Size = new System.Drawing.Size(131, 332);
            this.tableLayout_CURDofYetSync.TabIndex = 3;
            // 
            // btnSyncDown
            // 
            this.btnSyncDown.Location = new System.Drawing.Point(3, 75);
            this.btnSyncDown.Name = "btnSyncDown";
            this.btnSyncDown.Size = new System.Drawing.Size(125, 29);
            this.btnSyncDown.TabIndex = 1;
            this.btnSyncDown.Text = "Sync Down To SQL";
            this.btnSyncDown.Click += new System.EventHandler(this.btnSyncDown_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
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
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1167, 39);
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
            // lblMilisecondeNotSync
            // 
            this.lblMilisecondeNotSync.AutoSize = true;
            this.lblMilisecondeNotSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMilisecondeNotSync.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilisecondeNotSync.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMilisecondeNotSync.Location = new System.Drawing.Point(3, 142);
            this.lblMilisecondeNotSync.Name = "lblMilisecondeNotSync";
            this.lblMilisecondeNotSync.Size = new System.Drawing.Size(125, 60);
            this.lblMilisecondeNotSync.TabIndex = 2;
            this.lblMilisecondeNotSync.Text = "Time Not Sync : 0 ms";
            this.lblMilisecondeNotSync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHandleFirebase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 715);
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
            this.tableLayout_wrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_fromFirebase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_yetSync)).EndInit();
            this.tableLayou_CURDofFromFirebase.ResumeLayout(false);
            this.tableLayou_CURDofFromFirebase.PerformLayout();
            this.tableLayout_CURDofYetSync.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrl_Category;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayout_wrapper;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_fromFirebase;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_yetSync;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_Dish;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_Customer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_Receipt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private System.Windows.Forms.TableLayoutPanel tableLayou_CURDofFromFirebase;
        private DevExpress.XtraEditors.SimpleButton btnSyncTo;
        private DevExpress.XtraEditors.SimpleButton btnSyncDown;
        private System.Windows.Forms.TableLayoutPanel tableLayout_CURDofYetSync;
        private System.Windows.Forms.Label lblMilisecond;
        private System.Windows.Forms.Label lblMilisecondeNotSync;
    }
}