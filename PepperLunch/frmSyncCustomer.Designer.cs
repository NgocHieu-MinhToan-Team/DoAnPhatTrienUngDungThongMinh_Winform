
namespace PepperLunch
{
    partial class frmSyncCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSyncCustomer));
            this.tblLayout_Main = new System.Windows.Forms.TableLayoutPanel();
            this.btnSyncTo = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_top = new DevExpress.XtraGrid.GridControl();
            this.gridView_sync = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_bottom = new DevExpress.XtraGrid.GridControl();
            this.gridView_notSync = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSyncDown = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblMilisecond = new System.Windows.Forms.Label();
            this.lblMilisecondeNotSync = new System.Windows.Forms.Label();
            this.tblLayout_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_sync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_notSync)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayout_Main
            // 
            this.tblLayout_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tblLayout_Main.ColumnCount = 2;
            this.tblLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout_Main.Controls.Add(this.btnSyncTo, 1, 1);
            this.tblLayout_Main.Controls.Add(this.gridControl_top, 0, 1);
            this.tblLayout_Main.Controls.Add(this.gridControl_bottom, 0, 3);
            this.tblLayout_Main.Controls.Add(this.btnSyncDown, 1, 3);
            this.tblLayout_Main.Controls.Add(this.labelControl2, 0, 2);
            this.tblLayout_Main.Controls.Add(this.labelControl1, 0, 0);
            this.tblLayout_Main.Controls.Add(this.lblMilisecond, 1, 0);
            this.tblLayout_Main.Controls.Add(this.lblMilisecondeNotSync, 1, 2);
            this.tblLayout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Main.Location = new System.Drawing.Point(0, 0);
            this.tblLayout_Main.Name = "tblLayout_Main";
            this.tblLayout_Main.RowCount = 4;
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayout_Main.Size = new System.Drawing.Size(1112, 727);
            this.tblLayout_Main.TabIndex = 5;
            // 
            // btnSyncTo
            // 
            this.btnSyncTo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncTo.Appearance.Options.UseFont = true;
            this.btnSyncTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSyncTo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSyncTo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSyncTo.ImageOptions.SvgImage")));
            this.btnSyncTo.Location = new System.Drawing.Point(1003, 75);
            this.btnSyncTo.Name = "btnSyncTo";
            this.btnSyncTo.Size = new System.Drawing.Size(106, 77);
            this.btnSyncTo.TabIndex = 0;
            this.btnSyncTo.Text = "Sync To Firebase";
            this.btnSyncTo.Click += new System.EventHandler(this.btnSyncTo_Click);
            // 
            // gridControl_top
            // 
            this.gridControl_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_top.Location = new System.Drawing.Point(3, 75);
            this.gridControl_top.MainView = this.gridView_sync;
            this.gridControl_top.Name = "gridControl_top";
            this.gridControl_top.Size = new System.Drawing.Size(994, 284);
            this.gridControl_top.TabIndex = 0;
            this.gridControl_top.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_sync});
            // 
            // gridView_sync
            // 
            this.gridView_sync.GridControl = this.gridControl_top;
            this.gridView_sync.Name = "gridView_sync";
            // 
            // gridControl_bottom
            // 
            this.gridControl_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_bottom.Location = new System.Drawing.Point(3, 437);
            this.gridControl_bottom.MainView = this.gridView_notSync;
            this.gridControl_bottom.Name = "gridControl_bottom";
            this.gridControl_bottom.Size = new System.Drawing.Size(994, 287);
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
            this.btnSyncDown.Location = new System.Drawing.Point(1003, 437);
            this.btnSyncDown.Name = "btnSyncDown";
            this.btnSyncDown.Size = new System.Drawing.Size(106, 77);
            this.btnSyncDown.TabIndex = 1;
            this.btnSyncDown.Text = "Sync Down To SQL";
            this.btnSyncDown.Click += new System.EventHandler(this.btnSyncDown_Click);
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
            this.labelControl2.Location = new System.Drawing.Point(3, 365);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(994, 66);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data On DB SQL Serve Not Sync";
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
            this.labelControl1.Size = new System.Drawing.Size(994, 66);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Data On Firebase";
            // 
            // lblMilisecond
            // 
            this.lblMilisecond.AutoSize = true;
            this.lblMilisecond.BackColor = System.Drawing.Color.Transparent;
            this.lblMilisecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMilisecond.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilisecond.ForeColor = System.Drawing.Color.White;
            this.lblMilisecond.Location = new System.Drawing.Point(1003, 0);
            this.lblMilisecond.Name = "lblMilisecond";
            this.lblMilisecond.Size = new System.Drawing.Size(106, 72);
            this.lblMilisecond.TabIndex = 1;
            this.lblMilisecond.Text = "Time Load : 0 ms";
            this.lblMilisecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMilisecondeNotSync
            // 
            this.lblMilisecondeNotSync.AutoSize = true;
            this.lblMilisecondeNotSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMilisecondeNotSync.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilisecondeNotSync.ForeColor = System.Drawing.Color.White;
            this.lblMilisecondeNotSync.Location = new System.Drawing.Point(1003, 362);
            this.lblMilisecondeNotSync.Name = "lblMilisecondeNotSync";
            this.lblMilisecondeNotSync.Size = new System.Drawing.Size(106, 72);
            this.lblMilisecondeNotSync.TabIndex = 2;
            this.lblMilisecondeNotSync.Text = "Time Not Sync : 0 ms";
            this.lblMilisecondeNotSync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSyncCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 727);
            this.Controls.Add(this.tblLayout_Main);
            this.Name = "frmSyncCustomer";
            this.Text = "frmSyncCustomer";
            this.Load += new System.EventHandler(this.frmSyncCustomer_Load);
            this.tblLayout_Main.ResumeLayout(false);
            this.tblLayout_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_sync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_notSync)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout_Main;
        private DevExpress.XtraEditors.SimpleButton btnSyncTo;
        private DevExpress.XtraGrid.GridControl gridControl_top;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_sync;
        private System.Windows.Forms.Label lblMilisecond;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl_bottom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_notSync;
        private DevExpress.XtraEditors.SimpleButton btnSyncDown;
        private System.Windows.Forms.Label lblMilisecondeNotSync;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}