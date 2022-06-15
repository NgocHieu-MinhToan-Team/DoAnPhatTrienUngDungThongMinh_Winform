
namespace PepperLunch
{
    partial class frmManagePromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePromotion));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.tblLayout_Main = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl_main = new DevExpress.XtraGrid.GridControl();
            this.gridView_main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbPromotion = new System.Windows.Forms.ComboBox();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.tblLayout_Voucher = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmountReduction = new Modify_Control.EditText_Digit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtVoucherQuantity = new Modify_Control.EditText_Digit();
            this.dateVoucher_dayStart = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.dateVoucher_dayEnd = new System.Windows.Forms.DateTimePicker();
            this.txtTypeReducion = new Modify_Control.EditText_DigitOrLetter();
            this.txtPercentReducion = new Modify_Control.EditText_Digit();
            this.cbbVoucher_typeCustomer = new System.Windows.Forms.ComboBox();
            this.btnAddVoucher = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateVoucher = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveVoucher = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.accordionContentContainer_promotion = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.tblLayout_Promotion = new System.Windows.Forms.TableLayoutPanel();
            this.datePromotion_dayStart = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNamePromotion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.datePromotion_dayEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAddPromotion = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemovePromotion = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdatePromotion = new DevExpress.XtraEditors.SimpleButton();
            this.accordionControlElement_Promotion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_voucher = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_news = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            this.tblLayout_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            this.accordionContentContainer1.SuspendLayout();
            this.tblLayout_Voucher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountReduction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeReducion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentReducion.Properties)).BeginInit();
            this.accordionContentContainer_promotion.SuspendLayout();
            this.tblLayout_Promotion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePromotion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Appearance.BackColor = System.Drawing.Color.Black;
            this.fluentDesignFormContainer1.Appearance.Options.UseBackColor = true;
            this.fluentDesignFormContainer1.Controls.Add(this.tblLayout_Main);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(569, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(705, 718);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tblLayout_Main
            // 
            this.tblLayout_Main.BackColor = System.Drawing.Color.Transparent;
            this.tblLayout_Main.ColumnCount = 1;
            this.tblLayout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.29448F));
            this.tblLayout_Main.Controls.Add(this.gridControl_main, 0, 1);
            this.tblLayout_Main.Controls.Add(this.groupBox1, 0, 0);
            this.tblLayout_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Main.Location = new System.Drawing.Point(0, 0);
            this.tblLayout_Main.Name = "tblLayout_Main";
            this.tblLayout_Main.Padding = new System.Windows.Forms.Padding(50);
            this.tblLayout_Main.RowCount = 2;
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 523F));
            this.tblLayout_Main.Size = new System.Drawing.Size(705, 718);
            this.tblLayout_Main.TabIndex = 1;
            // 
            // gridControl_main
            // 
            this.gridControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_main.Location = new System.Drawing.Point(53, 148);
            this.gridControl_main.MainView = this.gridView_main;
            this.gridControl_main.Name = "gridControl_main";
            this.gridControl_main.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl_main.Size = new System.Drawing.Size(599, 517);
            this.gridControl_main.TabIndex = 0;
            this.gridControl_main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_main});
            // 
            // gridView_main
            // 
            this.gridView_main.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView_main.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView_main.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridView_main.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView_main.GridControl = this.gridControl_main;
            this.gridView_main.Name = "gridView_main";
            this.gridView_main.OptionsBehavior.Editable = false;
            this.gridView_main.OptionsView.ShowGroupPanel = false;
            this.gridView_main.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_main_RowClick);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbPromotion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(53, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Promotion";
            // 
            // cbbPromotion
            // 
            this.cbbPromotion.FormattingEnabled = true;
            this.cbbPromotion.Location = new System.Drawing.Point(19, 37);
            this.cbbPromotion.Name = "cbbPromotion";
            this.cbbPromotion.Size = new System.Drawing.Size(193, 29);
            this.cbbPromotion.TabIndex = 0;
            this.cbbPromotion.SelectedIndexChanged += new System.EventHandler(this.cbbPromotion_SelectedIndexChanged);
            this.cbbPromotion.SelectedValueChanged += new System.EventHandler(this.cbbPromotion_SelectedValueChanged);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Controls.Add(this.accordionContentContainer1);
            this.accordionControl1.Controls.Add(this.accordionContentContainer_promotion);
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement_Promotion,
            this.accordionControlElement_voucher,
            this.accordionControlElement_news});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(569, 718);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionContentContainer1
            // 
            this.accordionContentContainer1.Controls.Add(this.tblLayout_Voucher);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Size = new System.Drawing.Size(546, 308);
            this.accordionContentContainer1.TabIndex = 2;
            // 
            // tblLayout_Voucher
            // 
            this.tblLayout_Voucher.BackColor = System.Drawing.Color.Black;
            this.tblLayout_Voucher.ColumnCount = 4;
            this.tblLayout_Voucher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_Voucher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_Voucher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_Voucher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayout_Voucher.Controls.Add(this.labelControl2, 0, 0);
            this.tblLayout_Voucher.Controls.Add(this.labelControl15, 0, 3);
            this.tblLayout_Voucher.Controls.Add(this.txtAmountReduction, 1, 3);
            this.tblLayout_Voucher.Controls.Add(this.labelControl16, 2, 3);
            this.tblLayout_Voucher.Controls.Add(this.txtVoucherQuantity, 3, 3);
            this.tblLayout_Voucher.Controls.Add(this.dateVoucher_dayStart, 1, 0);
            this.tblLayout_Voucher.Controls.Add(this.labelControl1, 2, 0);
            this.tblLayout_Voucher.Controls.Add(this.labelControl12, 0, 1);
            this.tblLayout_Voucher.Controls.Add(this.dateVoucher_dayEnd, 3, 0);
            this.tblLayout_Voucher.Controls.Add(this.txtTypeReducion, 1, 1);
            this.tblLayout_Voucher.Controls.Add(this.txtPercentReducion, 3, 1);
            this.tblLayout_Voucher.Controls.Add(this.cbbVoucher_typeCustomer, 1, 2);
            this.tblLayout_Voucher.Controls.Add(this.btnAddVoucher, 0, 4);
            this.tblLayout_Voucher.Controls.Add(this.btnUpdateVoucher, 1, 4);
            this.tblLayout_Voucher.Controls.Add(this.btnRemoveVoucher, 2, 4);
            this.tblLayout_Voucher.Controls.Add(this.labelControl13, 0, 2);
            this.tblLayout_Voucher.Controls.Add(this.labelControl14, 2, 1);
            this.tblLayout_Voucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Voucher.Location = new System.Drawing.Point(0, 0);
            this.tblLayout_Voucher.Name = "tblLayout_Voucher";
            this.tblLayout_Voucher.Padding = new System.Windows.Forms.Padding(10);
            this.tblLayout_Voucher.RowCount = 5;
            this.tblLayout_Voucher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_Voucher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_Voucher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_Voucher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_Voucher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_Voucher.Size = new System.Drawing.Size(546, 308);
            this.tblLayout_Voucher.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(13, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 21);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Day Start";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl15.Location = new System.Drawing.Point(13, 184);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(68, 21);
            this.labelControl15.TabIndex = 18;
            this.labelControl15.Text = "Max Cost";
            // 
            // txtAmountReduction
            // 
            this.txtAmountReduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmountReduction.Location = new System.Drawing.Point(144, 184);
            this.txtAmountReduction.Name = "txtAmountReduction";
            this.txtAmountReduction.Properties.Name = "fProperties";
            this.txtAmountReduction.Size = new System.Drawing.Size(125, 28);
            this.txtAmountReduction.TabIndex = 20;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl16.Location = new System.Drawing.Point(275, 184);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(63, 21);
            this.labelControl16.TabIndex = 19;
            this.labelControl16.Text = "Quantity";
            // 
            // txtVoucherQuantity
            // 
            this.txtVoucherQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVoucherQuantity.Location = new System.Drawing.Point(406, 184);
            this.txtVoucherQuantity.Name = "txtVoucherQuantity";
            this.txtVoucherQuantity.Properties.Name = "fProperties";
            this.txtVoucherQuantity.Size = new System.Drawing.Size(127, 28);
            this.txtVoucherQuantity.TabIndex = 21;
            // 
            // dateVoucher_dayStart
            // 
            this.dateVoucher_dayStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateVoucher_dayStart.Location = new System.Drawing.Point(144, 13);
            this.dateVoucher_dayStart.Name = "dateVoucher_dayStart";
            this.dateVoucher_dayStart.Size = new System.Drawing.Size(125, 28);
            this.dateVoucher_dayStart.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(275, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 21);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Day End";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl12.Location = new System.Drawing.Point(13, 70);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(109, 21);
            this.labelControl12.TabIndex = 15;
            this.labelControl12.Text = "Type Reducion";
            // 
            // dateVoucher_dayEnd
            // 
            this.dateVoucher_dayEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateVoucher_dayEnd.Location = new System.Drawing.Point(406, 13);
            this.dateVoucher_dayEnd.Name = "dateVoucher_dayEnd";
            this.dateVoucher_dayEnd.Size = new System.Drawing.Size(127, 28);
            this.dateVoucher_dayEnd.TabIndex = 11;
            // 
            // txtTypeReducion
            // 
            this.txtTypeReducion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTypeReducion.Location = new System.Drawing.Point(144, 70);
            this.txtTypeReducion.Name = "txtTypeReducion";
            this.txtTypeReducion.Size = new System.Drawing.Size(125, 28);
            this.txtTypeReducion.TabIndex = 25;
            // 
            // txtPercentReducion
            // 
            this.txtPercentReducion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPercentReducion.Location = new System.Drawing.Point(406, 70);
            this.txtPercentReducion.Name = "txtPercentReducion";
            this.txtPercentReducion.Properties.Name = "fProperties";
            this.txtPercentReducion.Size = new System.Drawing.Size(127, 28);
            this.txtPercentReducion.TabIndex = 14;
            // 
            // cbbVoucher_typeCustomer
            // 
            this.tblLayout_Voucher.SetColumnSpan(this.cbbVoucher_typeCustomer, 3);
            this.cbbVoucher_typeCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbVoucher_typeCustomer.FormattingEnabled = true;
            this.cbbVoucher_typeCustomer.Location = new System.Drawing.Point(144, 127);
            this.cbbVoucher_typeCustomer.Name = "cbbVoucher_typeCustomer";
            this.cbbVoucher_typeCustomer.Size = new System.Drawing.Size(389, 29);
            this.cbbVoucher_typeCustomer.TabIndex = 13;
            // 
            // btnAddVoucher
            // 
            this.btnAddVoucher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddVoucher.ImageOptions.SvgImage")));
            this.btnAddVoucher.Location = new System.Drawing.Point(13, 241);
            this.btnAddVoucher.Name = "btnAddVoucher";
            this.btnAddVoucher.Size = new System.Drawing.Size(48, 50);
            this.btnAddVoucher.TabIndex = 22;
            this.btnAddVoucher.Click += new System.EventHandler(this.btnAddVoucher_Click);
            // 
            // btnUpdateVoucher
            // 
            this.btnUpdateVoucher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdateVoucher.ImageOptions.SvgImage")));
            this.btnUpdateVoucher.Location = new System.Drawing.Point(144, 241);
            this.btnUpdateVoucher.Name = "btnUpdateVoucher";
            this.btnUpdateVoucher.Size = new System.Drawing.Size(48, 50);
            this.btnUpdateVoucher.TabIndex = 24;
            this.btnUpdateVoucher.Click += new System.EventHandler(this.btnUpdateVoucher_Click);
            // 
            // btnRemoveVoucher
            // 
            this.btnRemoveVoucher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemoveVoucher.ImageOptions.SvgImage")));
            this.btnRemoveVoucher.Location = new System.Drawing.Point(275, 241);
            this.btnRemoveVoucher.Name = "btnRemoveVoucher";
            this.btnRemoveVoucher.Size = new System.Drawing.Size(48, 50);
            this.btnRemoveVoucher.TabIndex = 23;
            this.btnRemoveVoucher.Text = "Remove Voucher";
            this.btnRemoveVoucher.Click += new System.EventHandler(this.btnRemoveVoucher_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl13.Location = new System.Drawing.Point(13, 127);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(112, 21);
            this.labelControl13.TabIndex = 16;
            this.labelControl13.Text = "Type Customer";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl14.Location = new System.Drawing.Point(275, 70);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(52, 21);
            this.labelControl14.TabIndex = 17;
            this.labelControl14.Text = "Max %";
            // 
            // accordionContentContainer_promotion
            // 
            this.accordionContentContainer_promotion.Controls.Add(this.tblLayout_Promotion);
            this.accordionContentContainer_promotion.Name = "accordionContentContainer_promotion";
            this.accordionContentContainer_promotion.Size = new System.Drawing.Size(546, 188);
            this.accordionContentContainer_promotion.TabIndex = 3;
            // 
            // tblLayout_Promotion
            // 
            this.tblLayout_Promotion.BackColor = System.Drawing.Color.Black;
            this.tblLayout_Promotion.ColumnCount = 3;
            this.tblLayout_Promotion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_Promotion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tblLayout_Promotion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tblLayout_Promotion.Controls.Add(this.datePromotion_dayStart, 1, 1);
            this.tblLayout_Promotion.Controls.Add(this.labelControl3, 0, 0);
            this.tblLayout_Promotion.Controls.Add(this.txtNamePromotion, 1, 0);
            this.tblLayout_Promotion.Controls.Add(this.labelControl4, 0, 1);
            this.tblLayout_Promotion.Controls.Add(this.labelControl5, 0, 2);
            this.tblLayout_Promotion.Controls.Add(this.datePromotion_dayEnd, 1, 2);
            this.tblLayout_Promotion.Controls.Add(this.btnAddPromotion, 2, 0);
            this.tblLayout_Promotion.Controls.Add(this.btnRemovePromotion, 2, 2);
            this.tblLayout_Promotion.Controls.Add(this.btnUpdatePromotion, 2, 1);
            this.tblLayout_Promotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_Promotion.Location = new System.Drawing.Point(0, 0);
            this.tblLayout_Promotion.Name = "tblLayout_Promotion";
            this.tblLayout_Promotion.Padding = new System.Windows.Forms.Padding(10);
            this.tblLayout_Promotion.RowCount = 3;
            this.tblLayout_Promotion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_Promotion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_Promotion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout_Promotion.Size = new System.Drawing.Size(546, 188);
            this.tblLayout_Promotion.TabIndex = 10;
            // 
            // datePromotion_dayStart
            // 
            this.datePromotion_dayStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePromotion_dayStart.Location = new System.Drawing.Point(169, 69);
            this.datePromotion_dayStart.Name = "datePromotion_dayStart";
            this.datePromotion_dayStart.Size = new System.Drawing.Size(306, 28);
            this.datePromotion_dayStart.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl3.Location = new System.Drawing.Point(13, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(123, 21);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Name Promotion";
            // 
            // txtNamePromotion
            // 
            this.txtNamePromotion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNamePromotion.Location = new System.Drawing.Point(169, 13);
            this.txtNamePromotion.Name = "txtNamePromotion";
            this.txtNamePromotion.Size = new System.Drawing.Size(306, 28);
            this.txtNamePromotion.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl4.Location = new System.Drawing.Point(13, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 21);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Day Start";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl5.Location = new System.Drawing.Point(13, 125);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 21);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Day End";
            // 
            // datePromotion_dayEnd
            // 
            this.datePromotion_dayEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datePromotion_dayEnd.Location = new System.Drawing.Point(169, 125);
            this.datePromotion_dayEnd.Name = "datePromotion_dayEnd";
            this.datePromotion_dayEnd.Size = new System.Drawing.Size(306, 28);
            this.datePromotion_dayEnd.TabIndex = 12;
            // 
            // btnAddPromotion
            // 
            this.btnAddPromotion.AutoSize = true;
            this.btnAddPromotion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddPromotion.ImageOptions.SvgImage")));
            this.btnAddPromotion.Location = new System.Drawing.Point(481, 13);
            this.btnAddPromotion.Name = "btnAddPromotion";
            this.btnAddPromotion.Size = new System.Drawing.Size(46, 44);
            this.btnAddPromotion.TabIndex = 14;
            this.btnAddPromotion.Click += new System.EventHandler(this.btnAddPromotion_Click);
            // 
            // btnRemovePromotion
            // 
            this.btnRemovePromotion.AutoSize = true;
            this.btnRemovePromotion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemovePromotion.ImageOptions.SvgImage")));
            this.btnRemovePromotion.Location = new System.Drawing.Point(481, 125);
            this.btnRemovePromotion.Name = "btnRemovePromotion";
            this.btnRemovePromotion.Size = new System.Drawing.Size(46, 44);
            this.btnRemovePromotion.TabIndex = 15;
            this.btnRemovePromotion.Click += new System.EventHandler(this.btnRemovePromotion_Click);
            // 
            // btnUpdatePromotion
            // 
            this.btnUpdatePromotion.AutoSize = true;
            this.btnUpdatePromotion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdatePromotion.ImageOptions.SvgImage")));
            this.btnUpdatePromotion.Location = new System.Drawing.Point(481, 69);
            this.btnUpdatePromotion.Name = "btnUpdatePromotion";
            this.btnUpdatePromotion.Size = new System.Drawing.Size(46, 44);
            this.btnUpdatePromotion.TabIndex = 13;
            this.btnUpdatePromotion.Click += new System.EventHandler(this.btnUpdatePromotion_Click);
            // 
            // accordionControlElement_Promotion
            // 
            this.accordionControlElement_Promotion.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement_Promotion.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement_Promotion.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement_Promotion.Appearance.Normal.ForeColor = System.Drawing.Color.FloralWhite;
            this.accordionControlElement_Promotion.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement_Promotion.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement_Promotion.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement_Promotion.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement_Promotion.ContentContainer = this.accordionContentContainer_promotion;
            this.accordionControlElement_Promotion.Expanded = true;
            this.accordionControlElement_Promotion.Height = 40;
            this.accordionControlElement_Promotion.Name = "accordionControlElement_Promotion";
            this.accordionControlElement_Promotion.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_Promotion.Text = "PROMOTION";
            this.accordionControlElement_Promotion.Click += new System.EventHandler(this.accordionControlElement_Promotion_Click);
            // 
            // accordionControlElement_voucher
            // 
            this.accordionControlElement_voucher.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement_voucher.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement_voucher.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement_voucher.Appearance.Normal.ForeColor = System.Drawing.Color.FloralWhite;
            this.accordionControlElement_voucher.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement_voucher.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement_voucher.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement_voucher.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement_voucher.ContentContainer = this.accordionContentContainer1;
            this.accordionControlElement_voucher.Expanded = true;
            this.accordionControlElement_voucher.Height = 40;
            this.accordionControlElement_voucher.Name = "accordionControlElement_voucher";
            this.accordionControlElement_voucher.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_voucher.Text = "VOUCHER";
            this.accordionControlElement_voucher.Click += new System.EventHandler(this.accordionControlElement_voucher_Click);
            // 
            // accordionControlElement_news
            // 
            this.accordionControlElement_news.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement_news.Appearance.Normal.ForeColor = System.Drawing.Color.FloralWhite;
            this.accordionControlElement_news.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement_news.Appearance.Normal.Options.UseForeColor = true;
            this.accordionControlElement_news.Height = 40;
            this.accordionControlElement_news.Name = "accordionControlElement_news";
            this.accordionControlElement_news.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_news.Text = "NEWS";
            this.accordionControlElement_news.Click += new System.EventHandler(this.accordionControlElement_news_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1274, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // frmManagePromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 757);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmManagePromotion";
            this.NavigationControl = this.accordionControl1;
            this.Text = "frmManagePromotion";
            this.Load += new System.EventHandler(this.frmManagePromotion_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.tblLayout_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            this.accordionContentContainer1.ResumeLayout(false);
            this.tblLayout_Voucher.ResumeLayout(false);
            this.tblLayout_Voucher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountReduction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeReducion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPercentReducion.Properties)).EndInit();
            this.accordionContentContainer_promotion.ResumeLayout(false);
            this.tblLayout_Promotion.ResumeLayout(false);
            this.tblLayout_Promotion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamePromotion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_Promotion;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Main;
        private DevExpress.XtraGrid.GridControl gridControl_main;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_main;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Voucher;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dateVoucher_dayStart;
        private System.Windows.Forms.DateTimePicker dateVoucher_dayEnd;
        private System.Windows.Forms.ComboBox cbbVoucher_typeCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private Modify_Control.EditText_DigitOrLetter txtTypeReducion;
        private DevExpress.XtraEditors.SimpleButton btnAddVoucher;
        private Modify_Control.EditText_Digit txtVoucherQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private Modify_Control.EditText_Digit txtAmountReduction;
        private Modify_Control.EditText_Digit txtPercentReducion;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton btnRemoveVoucher;
        private DevExpress.XtraEditors.SimpleButton btnUpdateVoucher;
        private System.Windows.Forms.TableLayoutPanel tblLayout_Promotion;
        private System.Windows.Forms.DateTimePicker datePromotion_dayStart;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNamePromotion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker datePromotion_dayEnd;
        private DevExpress.XtraEditors.SimpleButton btnAddPromotion;
        private DevExpress.XtraEditors.SimpleButton btnRemovePromotion;
        private DevExpress.XtraEditors.SimpleButton btnUpdatePromotion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_news;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_voucher;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer_promotion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbPromotion;
    }
}