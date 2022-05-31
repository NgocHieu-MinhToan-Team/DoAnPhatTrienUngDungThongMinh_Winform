
namespace PepperLunch
{
    partial class frmReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceipt));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_receiptSql = new DevExpress.XtraGrid.GridControl();
            this.gridView_receiptSql = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_receiptFB = new DevExpress.XtraGrid.GridControl();
            this.gridView_receiptFB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_exportExcel = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_exportWord = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_removeReceipt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlE_SyncFromFirebase = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_receiptSql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_receiptSql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_receiptFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_receiptFB)).BeginInit();
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
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(963, 617);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl_receiptSql, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridControl_receiptFB, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 617);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridControl_receiptSql
            // 
            this.gridControl_receiptSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_receiptSql.Location = new System.Drawing.Point(3, 311);
            this.gridControl_receiptSql.MainView = this.gridView_receiptSql;
            this.gridControl_receiptSql.Name = "gridControl_receiptSql";
            this.gridControl_receiptSql.Size = new System.Drawing.Size(957, 303);
            this.gridControl_receiptSql.TabIndex = 2;
            this.gridControl_receiptSql.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_receiptSql});
            // 
            // gridView_receiptSql
            // 
            this.gridView_receiptSql.GridControl = this.gridControl_receiptSql;
            this.gridView_receiptSql.Name = "gridView_receiptSql";
            // 
            // gridControl_receiptFB
            // 
            this.gridControl_receiptFB.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridControl_receiptFB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_receiptFB.Location = new System.Drawing.Point(3, 3);
            this.gridControl_receiptFB.MainView = this.gridView_receiptFB;
            this.gridControl_receiptFB.Name = "gridControl_receiptFB";
            this.gridControl_receiptFB.Size = new System.Drawing.Size(957, 302);
            this.gridControl_receiptFB.TabIndex = 0;
            this.gridControl_receiptFB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_receiptFB});
            // 
            // gridView_receiptFB
            // 
            this.gridView_receiptFB.GridControl = this.gridControl_receiptFB;
            this.gridView_receiptFB.Name = "gridView_receiptFB";
            this.gridView_receiptFB.OptionsSelection.MultiSelect = true;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.White;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionCtrlE_exportExcel,
            this.accordionCtrlE_exportWord,
            this.accordionCtrlE_removeReceipt,
            this.accordionCtrlE_SyncFromFirebase});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(254, 617);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Hovered.BackColor = System.Drawing.Color.Black;
            this.accordionControlElement1.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionControlElement1.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.accordionControlElement1.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement1.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "RECEIPT";
            this.accordionControlElement1.VisibleInFooter = false;
            // 
            // accordionCtrlE_exportExcel
            // 
            this.accordionCtrlE_exportExcel.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.accordionCtrlE_exportExcel.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrlE_exportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlE_exportExcel.ImageOptions.Image")));
            this.accordionCtrlE_exportExcel.Name = "accordionCtrlE_exportExcel";
            this.accordionCtrlE_exportExcel.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_exportExcel.Text = "Export Receipt (Excel)";
            this.accordionCtrlE_exportExcel.Click += new System.EventHandler(this.accordionCtrlE_exportExcel_Click);
            // 
            // accordionCtrlE_exportWord
            // 
            this.accordionCtrlE_exportWord.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.accordionCtrlE_exportWord.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrlE_exportWord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlE_exportWord.ImageOptions.Image")));
            this.accordionCtrlE_exportWord.Name = "accordionCtrlE_exportWord";
            this.accordionCtrlE_exportWord.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_exportWord.Text = "Export Receipt (Word)";
            this.accordionCtrlE_exportWord.Click += new System.EventHandler(this.accordionCtrlE_exportWord_Click);
            // 
            // accordionCtrlE_removeReceipt
            // 
            this.accordionCtrlE_removeReceipt.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.accordionCtrlE_removeReceipt.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrlE_removeReceipt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlE_removeReceipt.ImageOptions.Image")));
            this.accordionCtrlE_removeReceipt.Name = "accordionCtrlE_removeReceipt";
            this.accordionCtrlE_removeReceipt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_removeReceipt.Text = "Delete Forever";
            this.accordionCtrlE_removeReceipt.Click += new System.EventHandler(this.accordionCtrlE_removeReceipt_Click);
            // 
            // accordionCtrlE_SyncFromFirebase
            // 
            this.accordionCtrlE_SyncFromFirebase.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.accordionCtrlE_SyncFromFirebase.Appearance.Normal.Options.UseForeColor = true;
            this.accordionCtrlE_SyncFromFirebase.Name = "accordionCtrlE_SyncFromFirebase";
            this.accordionCtrlE_SyncFromFirebase.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlE_SyncFromFirebase.Text = "Sync From Firebase";
            this.accordionCtrlE_SyncFromFirebase.Click += new System.EventHandler(this.accordionCtrlE_SyncFromFirebase_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1217, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 656);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmReceipt";
            this.NavigationControl = this.accordionControl1;
            this.Text = "frmReceipt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_receiptSql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_receiptSql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_receiptFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_receiptFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraGrid.GridControl gridControl_receiptFB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_receiptFB;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_exportExcel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_exportWord;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_removeReceipt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlE_SyncFromFirebase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl_receiptSql;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_receiptSql;
    }
}