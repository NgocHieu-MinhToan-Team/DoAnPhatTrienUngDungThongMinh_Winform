
namespace PepperLunch
{
    partial class frmConfirmImport
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
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_IOGDetail = new DevExpress.XtraGrid.GridControl();
            this.gridView_IOGDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_DETAIL_IOG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrice = new Modify_Control.EditText_Digit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantity = new Modify_Control.EditText_Digit();
            this.tableLayoutPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_IOGDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_IOGDetail)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.12676F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.87324F));
            this.tableLayoutPanel_Main.Controls.Add(this.gridControl_IOGDetail, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1040, 577);
            this.tableLayoutPanel_Main.TabIndex = 1;
            // 
            // gridControl_IOGDetail
            // 
            this.gridControl_IOGDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_IOGDetail.Location = new System.Drawing.Point(23, 23);
            this.gridControl_IOGDetail.MainView = this.gridView_IOGDetail;
            this.gridControl_IOGDetail.Name = "gridControl_IOGDetail";
            this.gridControl_IOGDetail.Size = new System.Drawing.Size(705, 531);
            this.gridControl_IOGDetail.TabIndex = 1;
            this.gridControl_IOGDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_IOGDetail});
            this.gridControl_IOGDetail.Click += new System.EventHandler(this.gridControl_IOGDetail_Click);
            // 
            // gridView_IOGDetail
            // 
            this.gridView_IOGDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_DETAIL_IOG,
            this.gridColumn1,
            this.PRICE,
            this.COUNT});
            this.gridView_IOGDetail.GridControl = this.gridControl_IOGDetail;
            this.gridView_IOGDetail.Name = "gridView_IOGDetail";
            this.gridView_IOGDetail.OptionsBehavior.Editable = false;
            this.gridView_IOGDetail.OptionsFind.AlwaysVisible = true;
            this.gridView_IOGDetail.RowHeight = 40;
            this.gridView_IOGDetail.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_IOGDetail_RowClick);
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
            this.gridColumn1.Caption = "NAME INGREDIENT";
            this.gridColumn1.FieldName = "NAME_INGREDIENT";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 94;
            // 
            // PRICE
            // 
            this.PRICE.Caption = "PRICE";
            this.PRICE.FieldName = "PRICE";
            this.PRICE.MinWidth = 25;
            this.PRICE.Name = "PRICE";
            this.PRICE.OptionsColumn.AllowEdit = false;
            this.PRICE.Visible = true;
            this.PRICE.VisibleIndex = 2;
            this.PRICE.Width = 94;
            // 
            // COUNT
            // 
            this.COUNT.Caption = "QUANTITY";
            this.COUNT.FieldName = "QUANTITY";
            this.COUNT.MinWidth = 25;
            this.COUNT.Name = "COUNT";
            this.COUNT.OptionsColumn.AllowEdit = false;
            this.COUNT.Visible = true;
            this.COUNT.VisibleIndex = 3;
            this.COUNT.Width = 94;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(734, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.74388F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 531);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnConfirm);
            this.groupControl1.Controls.Add(this.txtPrice);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtQuantity);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(277, 525);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Set Item";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 21);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Enter Price";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(32, 201);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(119, 41);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(32, 148);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(202, 28);
            this.txtPrice.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 21);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Enter quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(32, 78);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(202, 28);
            this.txtQuantity.TabIndex = 4;
            // 
            // frmConfirmImport
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 577);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Name = "frmConfirmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Import Of Goods";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfirmImport_FormClosing);
            this.Load += new System.EventHandler(this.frmConfirmImport_Load);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_IOGDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_IOGDetail)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private DevExpress.XtraGrid.GridControl gridControl_IOGDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_IOGDetail;
        private DevExpress.XtraGrid.Columns.GridColumn ID_DETAIL_IOG;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn COUNT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private Modify_Control.EditText_Digit txtQuantity;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Modify_Control.EditText_Digit txtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}