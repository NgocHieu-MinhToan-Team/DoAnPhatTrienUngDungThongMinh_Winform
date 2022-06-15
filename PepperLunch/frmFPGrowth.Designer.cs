
namespace PepperLunch
{
    partial class frmFPGrowth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFPGrowth));
            this.tblLayout_Main = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetDataFromSQL = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLoadDataToFirebase = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_bottom = new DevExpress.XtraGrid.GridControl();
            this.gridView_notSync = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.btnTrain = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMinsup = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtConfidence = new DevExpress.XtraEditors.TextEdit();
            this.gridControl_top = new DevExpress.XtraGrid.GridControl();
            this.gridView_sync = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tblLayout_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_notSync)).BeginInit();
            this.tableLayoutPanel_mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinsup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfidence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_sync)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayout_Main
            // 
            this.tblLayout_Main.BackColor = System.Drawing.Color.Transparent;
            this.tblLayout_Main.ColumnCount = 3;
            this.tblLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayout_Main.Controls.Add(this.btnGetDataFromSQL, 0, 2);
            this.tblLayout_Main.Controls.Add(this.labelControl1, 0, 0);
            this.tblLayout_Main.Controls.Add(this.btnLoadDataToFirebase, 2, 2);
            this.tblLayout_Main.Controls.Add(this.gridControl_bottom, 2, 1);
            this.tblLayout_Main.Controls.Add(this.labelControl2, 2, 0);
            this.tblLayout_Main.Controls.Add(this.tableLayoutPanel_mid, 1, 1);
            this.tblLayout_Main.Controls.Add(this.gridControl_top, 0, 1);
            this.tblLayout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Main.Location = new System.Drawing.Point(0, 0);
            this.tblLayout_Main.Name = "tblLayout_Main";
            this.tblLayout_Main.RowCount = 3;
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17241F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.09216F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.86658F));
            this.tblLayout_Main.Size = new System.Drawing.Size(1030, 727);
            this.tblLayout_Main.TabIndex = 5;
            // 
            // btnGetDataFromSQL
            // 
            this.btnGetDataFromSQL.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDataFromSQL.Appearance.Options.UseFont = true;
            this.btnGetDataFromSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetDataFromSQL.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGetDataFromSQL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGetDataFromSQL.ImageOptions.SvgImage")));
            this.btnGetDataFromSQL.Location = new System.Drawing.Point(3, 650);
            this.btnGetDataFromSQL.Name = "btnGetDataFromSQL";
            this.btnGetDataFromSQL.Size = new System.Drawing.Size(406, 60);
            this.btnGetDataFromSQL.TabIndex = 0;
            this.btnGetDataFromSQL.Text = "Load From SQL";
            this.btnGetDataFromSQL.Click += new System.EventHandler(this.btnGetDataFromSQL_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(406, 67);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Entire Receipts From SQL";
            // 
            // btnLoadDataToFirebase
            // 
            this.btnLoadDataToFirebase.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDataToFirebase.Appearance.Options.UseFont = true;
            this.btnLoadDataToFirebase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadDataToFirebase.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLoadDataToFirebase.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoadDataToFirebase.ImageOptions.SvgImage")));
            this.btnLoadDataToFirebase.Location = new System.Drawing.Point(621, 650);
            this.btnLoadDataToFirebase.Name = "btnLoadDataToFirebase";
            this.btnLoadDataToFirebase.Size = new System.Drawing.Size(406, 60);
            this.btnLoadDataToFirebase.TabIndex = 1;
            this.btnLoadDataToFirebase.Text = "Push To Firebase";
            this.btnLoadDataToFirebase.Click += new System.EventHandler(this.btnLoadDataToFirebase_Click);
            // 
            // gridControl_bottom
            // 
            this.gridControl_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_bottom.Location = new System.Drawing.Point(621, 76);
            this.gridControl_bottom.MainView = this.gridView_notSync;
            this.gridControl_bottom.Name = "gridControl_bottom";
            this.gridControl_bottom.Size = new System.Drawing.Size(406, 568);
            this.gridControl_bottom.TabIndex = 1;
            this.gridControl_bottom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_notSync});
            // 
            // gridView_notSync
            // 
            this.gridView_notSync.GridControl = this.gridControl_bottom;
            this.gridView_notSync.Name = "gridView_notSync";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.Location = new System.Drawing.Point(621, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(406, 67);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data After Trainning";
            // 
            // tableLayoutPanel_mid
            // 
            this.tableLayoutPanel_mid.ColumnCount = 1;
            this.tableLayoutPanel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_mid.Controls.Add(this.btnTrain, 0, 2);
            this.tableLayoutPanel_mid.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel_mid.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mid.Location = new System.Drawing.Point(415, 76);
            this.tableLayoutPanel_mid.Name = "tableLayoutPanel_mid";
            this.tableLayoutPanel_mid.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel_mid.RowCount = 3;
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_mid.Size = new System.Drawing.Size(200, 568);
            this.tableLayoutPanel_mid.TabIndex = 6;
            // 
            // btnTrain
            // 
            this.btnTrain.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Appearance.Options.UseFont = true;
            this.btnTrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrain.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTrain.ImageOptions.SvgImage")));
            this.btnTrain.Location = new System.Drawing.Point(23, 233);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(154, 60);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "Training";
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMinsup);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(23, 128);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(154, 58);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Min Sup Input";
            // 
            // txtMinsup
            // 
            this.txtMinsup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMinsup.Location = new System.Drawing.Point(2, 28);
            this.txtMinsup.Name = "txtMinsup";
            this.txtMinsup.Size = new System.Drawing.Size(150, 28);
            this.txtMinsup.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtConfidence);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(23, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(154, 55);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Confidence Input";
            // 
            // txtConfidence
            // 
            this.txtConfidence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfidence.Location = new System.Drawing.Point(2, 28);
            this.txtConfidence.Name = "txtConfidence";
            this.txtConfidence.Size = new System.Drawing.Size(150, 28);
            this.txtConfidence.TabIndex = 1;
            // 
            // gridControl_top
            // 
            this.gridControl_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_top.Location = new System.Drawing.Point(3, 76);
            this.gridControl_top.MainView = this.gridView_sync;
            this.gridControl_top.Name = "gridControl_top";
            this.gridControl_top.Size = new System.Drawing.Size(406, 568);
            this.gridControl_top.TabIndex = 0;
            this.gridControl_top.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_sync});
            // 
            // gridView_sync
            // 
            this.gridView_sync.GridControl = this.gridControl_top;
            this.gridView_sync.Name = "gridView_sync";
            // 
            // frmFPGrowth
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 727);
            this.Controls.Add(this.tblLayout_Main);
            this.Name = "frmFPGrowth";
            this.Text = "frmFPGrowth";
            this.Load += new System.EventHandler(this.frmSyncCustomer_Load);
            this.tblLayout_Main.ResumeLayout(false);
            this.tblLayout_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_notSync)).EndInit();
            this.tableLayoutPanel_mid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMinsup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtConfidence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_sync)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout_Main;
        private DevExpress.XtraGrid.GridControl gridControl_top;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_sync;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadDataToFirebase;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGetDataFromSQL;
        private DevExpress.XtraGrid.GridControl gridControl_bottom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_notSync;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_mid;
        private DevExpress.XtraEditors.SimpleButton btnTrain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtMinsup;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtConfidence;
    }
}