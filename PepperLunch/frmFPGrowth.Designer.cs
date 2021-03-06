
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
            this.gridControl_train = new DevExpress.XtraGrid.GridControl();
            this.gridView_train = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtNumberRecord = new Modify_Control.EditText_Digit();
            this.btnTrain = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEdit_minSup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEdit_confidence = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl_sql = new DevExpress.XtraGrid.GridControl();
            this.gridView_sql = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnCreateData = new DevExpress.XtraEditors.SimpleButton();
            this.tblLayout_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_train)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_train)).BeginInit();
            this.tableLayoutPanel_mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberRecord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_minSup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_confidence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_sql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_sql)).BeginInit();
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
            this.tblLayout_Main.Controls.Add(this.gridControl_train, 2, 1);
            this.tblLayout_Main.Controls.Add(this.labelControl2, 2, 0);
            this.tblLayout_Main.Controls.Add(this.tableLayoutPanel_mid, 1, 1);
            this.tblLayout_Main.Controls.Add(this.gridControl_sql, 0, 1);
            this.tblLayout_Main.Controls.Add(this.btnCreateData, 1, 0);
            this.tblLayout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Main.Location = new System.Drawing.Point(0, 0);
            this.tblLayout_Main.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tblLayout_Main.Name = "tblLayout_Main";
            this.tblLayout_Main.RowCount = 3;
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.17241F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.05502F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.903714F));
            this.tblLayout_Main.Size = new System.Drawing.Size(1717, 1142);
            this.tblLayout_Main.TabIndex = 5;
            // 
            // btnGetDataFromSQL
            // 
            this.btnGetDataFromSQL.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDataFromSQL.Appearance.Options.UseFont = true;
            this.btnGetDataFromSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetDataFromSQL.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGetDataFromSQL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGetDataFromSQL.ImageOptions.SvgImage")));
            this.btnGetDataFromSQL.Location = new System.Drawing.Point(5, 1034);
            this.btnGetDataFromSQL.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetDataFromSQL.Name = "btnGetDataFromSQL";
            this.btnGetDataFromSQL.Size = new System.Drawing.Size(676, 94);
            this.btnGetDataFromSQL.TabIndex = 0;
            this.btnGetDataFromSQL.Text = "Load From SQL";
            this.btnGetDataFromSQL.Click += new System.EventHandler(this.btnGetDataFromSQL_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(676, 106);
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
            this.btnLoadDataToFirebase.Location = new System.Drawing.Point(1034, 1034);
            this.btnLoadDataToFirebase.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLoadDataToFirebase.Name = "btnLoadDataToFirebase";
            this.btnLoadDataToFirebase.Size = new System.Drawing.Size(678, 94);
            this.btnLoadDataToFirebase.TabIndex = 1;
            this.btnLoadDataToFirebase.Text = "Push To Firebase";
            this.btnLoadDataToFirebase.Click += new System.EventHandler(this.btnLoadDataToFirebase_Click);
            // 
            // gridControl_train
            // 
            this.gridControl_train.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_train.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl_train.Location = new System.Drawing.Point(1034, 121);
            this.gridControl_train.MainView = this.gridView_train;
            this.gridControl_train.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl_train.Name = "gridControl_train";
            this.gridControl_train.Size = new System.Drawing.Size(678, 903);
            this.gridControl_train.TabIndex = 1;
            this.gridControl_train.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_train});
            // 
            // gridView_train
            // 
            this.gridView_train.DetailHeight = 550;
            this.gridView_train.FixedLineWidth = 3;
            this.gridView_train.GridControl = this.gridControl_train;
            this.gridView_train.Name = "gridView_train";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.Location = new System.Drawing.Point(1034, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(678, 106);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data After Trainning";
            // 
            // tableLayoutPanel_mid
            // 
            this.tableLayoutPanel_mid.ColumnCount = 1;
            this.tableLayoutPanel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_mid.Controls.Add(this.groupControl3, 0, 3);
            this.tableLayoutPanel_mid.Controls.Add(this.btnTrain, 0, 2);
            this.tableLayoutPanel_mid.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel_mid.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_mid.Location = new System.Drawing.Point(691, 121);
            this.tableLayoutPanel_mid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel_mid.Name = "tableLayoutPanel_mid";
            this.tableLayoutPanel_mid.Padding = new System.Windows.Forms.Padding(33, 31, 33, 31);
            this.tableLayoutPanel_mid.RowCount = 4;
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_mid.Size = new System.Drawing.Size(333, 903);
            this.tableLayoutPanel_mid.TabIndex = 6;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtNumberRecord);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(38, 666);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(257, 99);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Number Record ";
            // 
            // txtNumberRecord
            // 
            this.txtNumberRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumberRecord.Location = new System.Drawing.Point(3, 45);
            this.txtNumberRecord.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNumberRecord.Name = "txtNumberRecord";
            this.txtNumberRecord.Size = new System.Drawing.Size(251, 48);
            this.txtNumberRecord.TabIndex = 0;
            // 
            // btnTrain
            // 
            this.btnTrain.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Appearance.Options.UseFont = true;
            this.btnTrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrain.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTrain.ImageOptions.SvgImage")));
            this.btnTrain.Location = new System.Drawing.Point(38, 456);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(257, 94);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "Training";
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxEdit_minSup);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(38, 246);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(257, 99);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Min Sup Input";
            // 
            // comboBoxEdit_minSup
            // 
            this.comboBoxEdit_minSup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEdit_minSup.Location = new System.Drawing.Point(3, 45);
            this.comboBoxEdit_minSup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxEdit_minSup.Name = "comboBoxEdit_minSup";
            this.comboBoxEdit_minSup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_minSup.Properties.Items.AddRange(new object[] {
            "0",
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9",
            "1"});
            this.comboBoxEdit_minSup.Size = new System.Drawing.Size(251, 48);
            this.comboBoxEdit_minSup.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.comboBoxEdit_confidence);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(38, 36);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(257, 96);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Confidence Input";
            // 
            // comboBoxEdit_confidence
            // 
            this.comboBoxEdit_confidence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEdit_confidence.Location = new System.Drawing.Point(3, 45);
            this.comboBoxEdit_confidence.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxEdit_confidence.Name = "comboBoxEdit_confidence";
            this.comboBoxEdit_confidence.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_confidence.Properties.Items.AddRange(new object[] {
            "0",
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9",
            "1"});
            this.comboBoxEdit_confidence.Size = new System.Drawing.Size(251, 48);
            this.comboBoxEdit_confidence.TabIndex = 2;
            // 
            // gridControl_sql
            // 
            this.gridControl_sql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_sql.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl_sql.Location = new System.Drawing.Point(5, 121);
            this.gridControl_sql.MainView = this.gridView_sql;
            this.gridControl_sql.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl_sql.Name = "gridControl_sql";
            this.gridControl_sql.Size = new System.Drawing.Size(676, 903);
            this.gridControl_sql.TabIndex = 0;
            this.gridControl_sql.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_sql});
            // 
            // gridView_sql
            // 
            this.gridView_sql.DetailHeight = 550;
            this.gridView_sql.FixedLineWidth = 3;
            this.gridView_sql.GridControl = this.gridControl_sql;
            this.gridView_sql.Name = "gridView_sql";
            // 
            // btnCreateData
            // 
            this.btnCreateData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateData.Location = new System.Drawing.Point(691, 5);
            this.btnCreateData.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(333, 106);
            this.btnCreateData.TabIndex = 7;
            this.btnCreateData.Text = "Create Data Train";
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // frmFPGrowth
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 1142);
            this.Controls.Add(this.tblLayout_Main);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmFPGrowth";
            this.Text = "frmFPGrowth";
            this.Load += new System.EventHandler(this.frmSyncCustomer_Load);
            this.tblLayout_Main.ResumeLayout(false);
            this.tblLayout_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_train)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_train)).EndInit();
            this.tableLayoutPanel_mid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberRecord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_minSup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_confidence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_sql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_sql)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout_Main;
        private DevExpress.XtraGrid.GridControl gridControl_sql;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_sql;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadDataToFirebase;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGetDataFromSQL;
        private DevExpress.XtraGrid.GridControl gridControl_train;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_train;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_mid;
        private DevExpress.XtraEditors.SimpleButton btnTrain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Modify_Control.EditText_Digit txtNumberRecord;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_minSup;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_confidence;
        private DevExpress.XtraEditors.SimpleButton btnCreateData;
    }
}