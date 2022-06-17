
namespace PepperLunch
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_Customer = new DevExpress.XtraGrid.GridControl();
            this.gridView_Customer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_fromFirebase = new DevExpress.XtraGrid.GridControl();
            this.gridView_Firebase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionCtrlE_GetCustomerFromFirebase = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_fromFirebase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Firebase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.tableLayoutPanel1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(254, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(964, 646);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl_Customer, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gridControl_fromFirebase, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 646);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridControl_Customer
            // 
            this.gridControl_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Customer.Location = new System.Drawing.Point(3, 389);
            this.gridControl_Customer.MainView = this.gridView_Customer;
            this.gridControl_Customer.Name = "gridControl_Customer";
            this.gridControl_Customer.Size = new System.Drawing.Size(958, 254);
            this.gridControl_Customer.TabIndex = 0;
            this.gridControl_Customer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Customer});
            // 
            // gridView_Customer
            // 
            this.gridView_Customer.GridControl = this.gridControl_Customer;
            this.gridView_Customer.Name = "gridView_Customer";
            // 
            // gridControl_fromFirebase
            // 
            this.gridControl_fromFirebase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_fromFirebase.Location = new System.Drawing.Point(3, 67);
            this.gridControl_fromFirebase.MainView = this.gridView_Firebase;
            this.gridControl_fromFirebase.Name = "gridControl_fromFirebase";
            this.gridControl_fromFirebase.Size = new System.Drawing.Size(958, 252);
            this.gridControl_fromFirebase.TabIndex = 1;
            this.gridControl_fromFirebase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Firebase});
            // 
            // gridView_Firebase
            // 
            this.gridView_Firebase.GridControl = this.gridControl_fromFirebase;
            this.gridView_Firebase.Name = "gridView_Firebase";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionCtrlE_GetCustomerFromFirebase});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(254, 646);
            this.accordionControl1.TabIndex = 1;
            // 
            // accordionCtrlE_GetCustomerFromFirebase
            // 
            this.accordionCtrlE_GetCustomerFromFirebase.Appearance.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.accordionCtrlE_GetCustomerFromFirebase.Appearance.Hovered.Options.UseForeColor = true;
            this.accordionCtrlE_GetCustomerFromFirebase.Appearance.Normal.ForeColor = System.Drawing.Color.White;
            this.accordionCtrlE_GetCustomerFromFirebase.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrlE_GetCustomerFromFirebase.Height = 40;
            this.accordionCtrlE_GetCustomerFromFirebase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlE_GetCustomerFromFirebase.ImageOptions.Image")));
            this.accordionCtrlE_GetCustomerFromFirebase.Name = "accordionCtrlE_GetCustomerFromFirebase";
            this.accordionCtrlE_GetCustomerFromFirebase.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_GetCustomerFromFirebase.Text = "Sync From Firebase";
            this.accordionCtrlE_GetCustomerFromFirebase.Click += new System.EventHandler(this.accordionCtrlE_GetCustomerFromFirebase_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1218, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 685);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmCustomer";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_fromFirebase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Firebase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_GetCustomerFromFirebase;
        private DevExpress.XtraGrid.GridControl gridControl_Customer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Customer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl_fromFirebase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Firebase;
    }
}