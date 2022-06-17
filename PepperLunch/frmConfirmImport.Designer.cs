
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
            this.tableLayoutPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_IOGDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_IOGDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.12676F));
            this.tableLayoutPanel_Main.Controls.Add(this.gridControl_IOGDetail, 0, 0);
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
            this.gridControl_IOGDetail.Size = new System.Drawing.Size(994, 531);
            this.gridControl_IOGDetail.TabIndex = 1;
            this.gridControl_IOGDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_IOGDetail});
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
            this.gridView_IOGDetail.OptionsFind.AlwaysVisible = true;
            this.gridView_IOGDetail.RowHeight = 40;
            this.gridView_IOGDetail.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_IOGDetail_CellValueChanged);
            this.gridView_IOGDetail.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView_IOGDetail_ValidatingEditor);
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
    }
}