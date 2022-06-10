
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_left = new System.Windows.Forms.TableLayoutPanel();
            this.tabPaneImport = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage_HistoryImport = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tableLayoutPanel_history = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_historyImport = new DevExpress.XtraGrid.GridControl();
            this.gridView_historyImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID_IOG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_SUPPLIER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_STAFF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE_IOG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOTAL_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit_detail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabNavigationPage_OrderingImport = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tableLayoutPanel_Ordering = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_OrderingImport = new DevExpress.XtraGrid.GridControl();
            this.gridView_OrderingImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Detele = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit_detele = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox_Ordering = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Inputs = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker_dateCreate = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneImport)).BeginInit();
            this.tabPaneImport.SuspendLayout();
            this.tabNavigationPage_HistoryImport.SuspendLayout();
            this.tableLayoutPanel_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_historyImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_historyImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit_detail)).BeginInit();
            this.tabNavigationPage_OrderingImport.SuspendLayout();
            this.tableLayoutPanel_Ordering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_OrderingImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OrderingImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit_detele)).BeginInit();
            this.groupBox_Ordering.SuspendLayout();
            this.tableLayoutPanel_Inputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.2635F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_left, 0, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1093, 718);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel_left
            // 
            this.tableLayoutPanel_left.ColumnCount = 1;
            this.tableLayoutPanel_left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_left.Controls.Add(this.tabPaneImport, 0, 0);
            this.tableLayoutPanel_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_left.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_left.Name = "tableLayoutPanel_left";
            this.tableLayoutPanel_left.RowCount = 1;
            this.tableLayoutPanel_left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.84832F));
            this.tableLayoutPanel_left.Size = new System.Drawing.Size(1087, 712);
            this.tableLayoutPanel_left.TabIndex = 2;
            // 
            // tabPaneImport
            // 
            this.tabPaneImport.Controls.Add(this.tabNavigationPage_HistoryImport);
            this.tabPaneImport.Controls.Add(this.tabNavigationPage_OrderingImport);
            this.tabPaneImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneImport.Location = new System.Drawing.Point(3, 3);
            this.tabPaneImport.Name = "tabPaneImport";
            this.tabPaneImport.PageProperties.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPaneImport.PageProperties.AppearanceCaption.Options.UseFont = true;
            this.tabPaneImport.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage_HistoryImport,
            this.tabNavigationPage_OrderingImport});
            this.tabPaneImport.RegularSize = new System.Drawing.Size(1081, 706);
            this.tabPaneImport.SelectedPage = this.tabNavigationPage_HistoryImport;
            this.tabPaneImport.Size = new System.Drawing.Size(1081, 706);
            this.tabPaneImport.TabIndex = 1;
            this.tabPaneImport.Text = "tabPane1";
            this.tabPaneImport.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPaneImport_SelectedPageChanged);
            // 
            // tabNavigationPage_HistoryImport
            // 
            this.tabNavigationPage_HistoryImport.Caption = "History Imports";
            this.tabNavigationPage_HistoryImport.Controls.Add(this.tableLayoutPanel_history);
            this.tabNavigationPage_HistoryImport.Name = "tabNavigationPage_HistoryImport";
            this.tabNavigationPage_HistoryImport.Size = new System.Drawing.Size(1081, 670);
            // 
            // tableLayoutPanel_history
            // 
            this.tableLayoutPanel_history.ColumnCount = 1;
            this.tableLayoutPanel_history.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_history.Controls.Add(this.gridControl_historyImport, 0, 0);
            this.tableLayoutPanel_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_history.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_history.Name = "tableLayoutPanel_history";
            this.tableLayoutPanel_history.RowCount = 1;
            this.tableLayoutPanel_history.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_history.Size = new System.Drawing.Size(1081, 670);
            this.tableLayoutPanel_history.TabIndex = 1;
            // 
            // gridControl_historyImport
            // 
            this.gridControl_historyImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_historyImport.Location = new System.Drawing.Point(3, 3);
            this.gridControl_historyImport.MainView = this.gridView_historyImport;
            this.gridControl_historyImport.Name = "gridControl_historyImport";
            this.gridControl_historyImport.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit_detail});
            this.gridControl_historyImport.Size = new System.Drawing.Size(1075, 664);
            this.gridControl_historyImport.TabIndex = 0;
            this.gridControl_historyImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_historyImport});
            this.gridControl_historyImport.Click += new System.EventHandler(this.gridControl_historyImport_Click);
            // 
            // gridView_historyImport
            // 
            this.gridView_historyImport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID_IOG,
            this.ID_SUPPLIER,
            this.ID_STAFF,
            this.DATE_IOG,
            this.TOTAL_PRICE,
            this.NOTE,
            this.gridColumn1});
            this.gridView_historyImport.GridControl = this.gridControl_historyImport;
            this.gridView_historyImport.Name = "gridView_historyImport";
            // 
            // ID_IOG
            // 
            this.ID_IOG.Caption = "ID IMPORT OF GOODS";
            this.ID_IOG.FieldName = "ID_IOG";
            this.ID_IOG.MinWidth = 25;
            this.ID_IOG.Name = "ID_IOG";
            this.ID_IOG.Visible = true;
            this.ID_IOG.VisibleIndex = 0;
            this.ID_IOG.Width = 94;
            // 
            // ID_SUPPLIER
            // 
            this.ID_SUPPLIER.Caption = "ID SUPPLIER";
            this.ID_SUPPLIER.FieldName = "ID_SUPPLIER";
            this.ID_SUPPLIER.MinWidth = 25;
            this.ID_SUPPLIER.Name = "ID_SUPPLIER";
            this.ID_SUPPLIER.Visible = true;
            this.ID_SUPPLIER.VisibleIndex = 1;
            this.ID_SUPPLIER.Width = 94;
            // 
            // ID_STAFF
            // 
            this.ID_STAFF.Caption = "ID STAFF";
            this.ID_STAFF.FieldName = "USERNAME_STAFF";
            this.ID_STAFF.MinWidth = 25;
            this.ID_STAFF.Name = "ID_STAFF";
            this.ID_STAFF.Visible = true;
            this.ID_STAFF.VisibleIndex = 2;
            this.ID_STAFF.Width = 94;
            // 
            // DATE_IOG
            // 
            this.DATE_IOG.Caption = "DATE CREATE";
            this.DATE_IOG.FieldName = "DATE_IOG";
            this.DATE_IOG.MinWidth = 25;
            this.DATE_IOG.Name = "DATE_IOG";
            this.DATE_IOG.Visible = true;
            this.DATE_IOG.VisibleIndex = 3;
            this.DATE_IOG.Width = 94;
            // 
            // TOTAL_PRICE
            // 
            this.TOTAL_PRICE.Caption = "TOTAL PRICE";
            this.TOTAL_PRICE.FieldName = "TOTAL_PRICE";
            this.TOTAL_PRICE.MinWidth = 25;
            this.TOTAL_PRICE.Name = "TOTAL_PRICE";
            this.TOTAL_PRICE.Visible = true;
            this.TOTAL_PRICE.VisibleIndex = 4;
            this.TOTAL_PRICE.Width = 94;
            // 
            // NOTE
            // 
            this.NOTE.Caption = "NOTE";
            this.NOTE.FieldName = "NOTE";
            this.NOTE.MinWidth = 25;
            this.NOTE.Name = "NOTE";
            this.NOTE.Visible = true;
            this.NOTE.VisibleIndex = 5;
            this.NOTE.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Control";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit_detail;
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 94;
            // 
            // repositoryItemButtonEdit_detail
            // 
            this.repositoryItemButtonEdit_detail.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.repositoryItemButtonEdit_detail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit_detail.Name = "repositoryItemButtonEdit_detail";
            this.repositoryItemButtonEdit_detail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit_detail.Click += new System.EventHandler(this.repositoryItemButtonEdit_detail_Click);
            // 
            // tabNavigationPage_OrderingImport
            // 
            this.tabNavigationPage_OrderingImport.Caption = "Ordering Import";
            this.tabNavigationPage_OrderingImport.Controls.Add(this.tableLayoutPanel_Ordering);
            this.tabNavigationPage_OrderingImport.Name = "tabNavigationPage_OrderingImport";
            this.tabNavigationPage_OrderingImport.Size = new System.Drawing.Size(1081, 670);
            // 
            // tableLayoutPanel_Ordering
            // 
            this.tableLayoutPanel_Ordering.ColumnCount = 2;
            this.tableLayoutPanel_Ordering.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Ordering.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Ordering.Controls.Add(this.gridControl_OrderingImport, 0, 0);
            this.tableLayoutPanel_Ordering.Controls.Add(this.groupBox_Ordering, 1, 0);
            this.tableLayoutPanel_Ordering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Ordering.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Ordering.Name = "tableLayoutPanel_Ordering";
            this.tableLayoutPanel_Ordering.RowCount = 1;
            this.tableLayoutPanel_Ordering.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Ordering.Size = new System.Drawing.Size(1081, 670);
            this.tableLayoutPanel_Ordering.TabIndex = 0;
            // 
            // gridControl_OrderingImport
            // 
            this.gridControl_OrderingImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_OrderingImport.Location = new System.Drawing.Point(3, 3);
            this.gridControl_OrderingImport.MainView = this.gridView_OrderingImport;
            this.gridControl_OrderingImport.Name = "gridControl_OrderingImport";
            this.gridControl_OrderingImport.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit_detele});
            this.gridControl_OrderingImport.Size = new System.Drawing.Size(858, 664);
            this.gridControl_OrderingImport.TabIndex = 2;
            this.gridControl_OrderingImport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_OrderingImport});
            // 
            // gridView_OrderingImport
            // 
            this.gridView_OrderingImport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.Detele});
            this.gridView_OrderingImport.GridControl = this.gridControl_OrderingImport;
            this.gridView_OrderingImport.Name = "gridView_OrderingImport";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID IMPORT OF GOODS";
            this.gridColumn2.FieldName = "ID_IOG";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID SUPPLIER";
            this.gridColumn3.FieldName = "ID_SUPPLIER";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID STAFF";
            this.gridColumn4.FieldName = "USERNAME_STAFF";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "DATE CREATE";
            this.gridColumn5.FieldName = "DATE_IOG";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "TOTAL PRICE";
            this.gridColumn6.FieldName = "TOTAL_PRICE";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "NOTE";
            this.gridColumn7.FieldName = "NOTE";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 94;
            // 
            // Detele
            // 
            this.Detele.Caption = "gridColumn8";
            this.Detele.ColumnEdit = this.repositoryItemButtonEdit_detele;
            this.Detele.MinWidth = 25;
            this.Detele.Name = "Detele";
            this.Detele.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.Detele.Visible = true;
            this.Detele.VisibleIndex = 6;
            this.Detele.Width = 94;
            // 
            // repositoryItemButtonEdit_detele
            // 
            this.repositoryItemButtonEdit_detele.AutoHeight = false;
            this.repositoryItemButtonEdit_detele.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.repositoryItemButtonEdit_detele.Name = "repositoryItemButtonEdit_detele";
            this.repositoryItemButtonEdit_detele.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit_detele.Click += new System.EventHandler(this.repositoryItemButtonEdit_detele_Click);
            // 
            // groupBox_Ordering
            // 
            this.groupBox_Ordering.Controls.Add(this.tableLayoutPanel_Inputs);
            this.groupBox_Ordering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Ordering.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Ordering.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox_Ordering.Location = new System.Drawing.Point(867, 3);
            this.groupBox_Ordering.Name = "groupBox_Ordering";
            this.groupBox_Ordering.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox_Ordering.Size = new System.Drawing.Size(211, 664);
            this.groupBox_Ordering.TabIndex = 1;
            this.groupBox_Ordering.TabStop = false;
            this.groupBox_Ordering.Text = "Handle a Import Of Goods";
            // 
            // tableLayoutPanel_Inputs
            // 
            this.tableLayoutPanel_Inputs.ColumnCount = 1;
            this.tableLayoutPanel_Inputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Inputs.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel_Inputs.Controls.Add(this.btnCreate, 0, 6);
            this.tableLayoutPanel_Inputs.Controls.Add(this.txtNote, 0, 5);
            this.tableLayoutPanel_Inputs.Controls.Add(this.labelControl5, 0, 4);
            this.tableLayoutPanel_Inputs.Controls.Add(this.dateTimePicker_dateCreate, 0, 3);
            this.tableLayoutPanel_Inputs.Controls.Add(this.labelControl2, 0, 2);
            this.tableLayoutPanel_Inputs.Controls.Add(this.cbbSupplier, 0, 1);
            this.tableLayoutPanel_Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Inputs.Location = new System.Drawing.Point(20, 42);
            this.tableLayoutPanel_Inputs.Name = "tableLayoutPanel_Inputs";
            this.tableLayoutPanel_Inputs.RowCount = 9;
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel_Inputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel_Inputs.Size = new System.Drawing.Size(171, 602);
            this.tableLayoutPanel_Inputs.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 21);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Supplier";
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreate.ImageOptions.SvgImage")));
            this.btnCreate.Location = new System.Drawing.Point(3, 243);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(165, 34);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(3, 203);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(165, 34);
            this.txtNote.TabIndex = 15;
            this.txtNote.Text = "";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(3, 163);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 21);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Note";
            // 
            // dateTimePicker_dateCreate
            // 
            this.dateTimePicker_dateCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_dateCreate.Location = new System.Drawing.Point(3, 123);
            this.dateTimePicker_dateCreate.Name = "dateTimePicker_dateCreate";
            this.dateTimePicker_dateCreate.Size = new System.Drawing.Size(165, 29);
            this.dateTimePicker_dateCreate.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Date Create";
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(3, 43);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(165, 30);
            this.cbbSupplier.TabIndex = 9;
            this.cbbSupplier.SelectedValueChanged += new System.EventHandler(this.cbbSupplier_SelectedValueChanged);
            // 
            // frmImport
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.WindowText;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 718);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Name = "frmImport";
            this.Text = "frmImport";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneImport)).EndInit();
            this.tabPaneImport.ResumeLayout(false);
            this.tabNavigationPage_HistoryImport.ResumeLayout(false);
            this.tableLayoutPanel_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_historyImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_historyImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit_detail)).EndInit();
            this.tabNavigationPage_OrderingImport.ResumeLayout(false);
            this.tableLayoutPanel_Ordering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_OrderingImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_OrderingImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit_detele)).EndInit();
            this.groupBox_Ordering.ResumeLayout(false);
            this.tableLayoutPanel_Inputs.ResumeLayout(false);
            this.tableLayoutPanel_Inputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.GroupBox groupBox_Ordering;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Inputs;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbbSupplier;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateCreate;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_left;
        private DevExpress.XtraBars.Navigation.TabPane tabPaneImport;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage_HistoryImport;
        private DevExpress.XtraGrid.GridControl gridControl_historyImport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_historyImport;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage_OrderingImport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit_detail;
        private DevExpress.XtraGrid.Columns.GridColumn ID_IOG;
        private DevExpress.XtraGrid.Columns.GridColumn ID_SUPPLIER;
        private DevExpress.XtraGrid.Columns.GridColumn ID_STAFF;
        private DevExpress.XtraGrid.Columns.GridColumn DATE_IOG;
        private DevExpress.XtraGrid.Columns.GridColumn TOTAL_PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn NOTE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_history;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Ordering;
        private DevExpress.XtraGrid.GridControl gridControl_OrderingImport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_OrderingImport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn Detele;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit_detele;
        private System.Windows.Forms.RichTextBox txtNote;
    }
}