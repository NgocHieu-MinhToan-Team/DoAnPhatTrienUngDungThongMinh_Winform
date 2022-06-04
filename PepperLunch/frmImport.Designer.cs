
namespace PepperLunch
{
    partial class frmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_IOG = new DevExpress.XtraGrid.GridControl();
            this.gridView_IOG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel_Right = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_dateCreate = new System.Windows.Forms.DateTimePicker();
            this.btnAddDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.lblTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalQuantity = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_IOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_IOG)).BeginInit();
            this.tableLayoutPanel_Right.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel_Inputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_Main.Controls.Add(this.gridControl_IOG, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Right, 1, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1120, 718);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // gridControl_IOG
            // 
            this.gridControl_IOG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_IOG.Location = new System.Drawing.Point(3, 3);
            this.gridControl_IOG.MainView = this.gridView_IOG;
            this.gridControl_IOG.Name = "gridControl_IOG";
            this.gridControl_IOG.Size = new System.Drawing.Size(778, 712);
            this.gridControl_IOG.TabIndex = 0;
            this.gridControl_IOG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_IOG});
            // 
            // gridView_IOG
            // 
            this.gridView_IOG.GridControl = this.gridControl_IOG;
            this.gridView_IOG.Name = "gridView_IOG";
            this.gridView_IOG.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_IOG_RowClick);
            // 
            // tableLayoutPanel_Right
            // 
            this.tableLayoutPanel_Right.ColumnCount = 1;
            this.tableLayoutPanel_Right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Right.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Right.Location = new System.Drawing.Point(787, 3);
            this.tableLayoutPanel_Right.Name = "tableLayoutPanel_Right";
            this.tableLayoutPanel_Right.RowCount = 5;
            this.tableLayoutPanel_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_Right.Size = new System.Drawing.Size(330, 712);
            this.tableLayoutPanel_Right.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel_Inputs);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel_Right.SetRowSpan(this.groupBox1, 5);
            this.groupBox1.Size = new System.Drawing.Size(324, 706);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Import Of Goods";
            // 
            // tableLayoutPanel_Inputs
            // 
            this.tableLayoutPanel_Inputs.ColumnCount = 4;
            this.tableLayoutPanel_Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Inputs.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel_Inputs.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel_Inputs.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel_Inputs.Controls.Add(this.labelControl4, 0, 3);
            this.tableLayoutPanel_Inputs.Controls.Add(this.labelControl5, 0, 4);
            this.tableLayoutPanel_Inputs.Controls.Add(this.txtNote, 1, 4);
            this.tableLayoutPanel_Inputs.Controls.Add(this.cbbSupplier, 1, 0);
            this.tableLayoutPanel_Inputs.Controls.Add(this.dateTimePicker_dateCreate, 1, 1);
            this.tableLayoutPanel_Inputs.Controls.Add(this.btnAddDetail, 3, 5);
            this.tableLayoutPanel_Inputs.Controls.Add(this.btnUpdate, 1, 5);
            this.tableLayoutPanel_Inputs.Controls.Add(this.btnRemove, 2, 5);
            this.tableLayoutPanel_Inputs.Controls.Add(this.btnCreate, 0, 5);
            this.tableLayoutPanel_Inputs.Controls.Add(this.lblTotalPrice, 1, 2);
            this.tableLayoutPanel_Inputs.Controls.Add(this.lblTotalQuantity, 1, 3);
            this.tableLayoutPanel_Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Inputs.Location = new System.Drawing.Point(20, 42);
            this.tableLayoutPanel_Inputs.Name = "tableLayoutPanel_Inputs";
            this.tableLayoutPanel_Inputs.RowCount = 7;
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Inputs.Size = new System.Drawing.Size(284, 644);
            this.tableLayoutPanel_Inputs.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl3.Location = new System.Drawing.Point(3, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Total Price";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(3, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Date Create";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 21);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Supplier";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl4.Location = new System.Drawing.Point(3, 195);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 21);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Total Quantity";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl5.Location = new System.Drawing.Point(3, 259);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 21);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Note";
            // 
            // txtNote
            // 
            this.tableLayoutPanel_Inputs.SetColumnSpan(this.txtNote, 2);
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNote.Location = new System.Drawing.Point(74, 259);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(136, 56);
            this.txtNote.TabIndex = 8;
            this.txtNote.Text = "";
            // 
            // cbbSupplier
            // 
            this.tableLayoutPanel_Inputs.SetColumnSpan(this.cbbSupplier, 3);
            this.cbbSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(74, 3);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(207, 30);
            this.cbbSupplier.TabIndex = 9;
            // 
            // dateTimePicker_dateCreate
            // 
            this.tableLayoutPanel_Inputs.SetColumnSpan(this.dateTimePicker_dateCreate, 2);
            this.dateTimePicker_dateCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker_dateCreate.Location = new System.Drawing.Point(74, 67);
            this.dateTimePicker_dateCreate.Name = "dateTimePicker_dateCreate";
            this.dateTimePicker_dateCreate.Size = new System.Drawing.Size(136, 29);
            this.dateTimePicker_dateCreate.TabIndex = 10;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDetail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddDetail.ImageOptions.SvgImage")));
            this.btnAddDetail.Location = new System.Drawing.Point(216, 323);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(65, 58);
            this.btnAddDetail.TabIndex = 5;
            this.btnAddDetail.Text = "Add Details";
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(74, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 58);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemove.ImageOptions.SvgImage")));
            this.btnRemove.Location = new System.Drawing.Point(145, 323);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 58);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreate.ImageOptions.SvgImage")));
            this.btnCreate.Location = new System.Drawing.Point(3, 323);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(65, 58);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "New";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Appearance.Options.UseFont = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(74, 131);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(115, 21);
            this.lblTotalPrice.TabIndex = 11;
            this.lblTotalPrice.Text = "labelControl6";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Appearance.Options.UseFont = true;
            this.lblTotalQuantity.Location = new System.Drawing.Point(74, 195);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(115, 21);
            this.lblTotalQuantity.TabIndex = 12;
            this.lblTotalQuantity.Text = "labelControl7";
            // 
            // frmImport
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.WindowText;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 718);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Name = "frmImport";
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_IOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_IOG)).EndInit();
            this.tableLayoutPanel_Right.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel_Inputs.ResumeLayout(false);
            this.tableLayoutPanel_Inputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private DevExpress.XtraGrid.GridControl gridControl_IOG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_IOG;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Right;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Inputs;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.ComboBox cbbSupplier;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateCreate;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnAddDetail;
        private DevExpress.XtraEditors.LabelControl lblTotalPrice;
        private DevExpress.XtraEditors.LabelControl lblTotalQuantity;
    }
}