
namespace PepperLunch
{
    partial class frmStaff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.gridControl_staff = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlEle_newStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionCtrlEle_updateStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionCtrlEle_removeStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new Modify_Control.EditText_Letter();
            this.txtUsername = new Modify_Control.EditText_DigitOrLetter();
            this.txtPhone = new Modify_Control.EditText_Digit();
            this.txtPassword = new Modify_Control.EditText_DigitOrLetter();
            this.txtSurname = new Modify_Control.EditText_Letter();
            this.btnCreateStaff = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new Modify_Control.EditText_DigitOrLetter();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit_birth = new DevExpress.XtraEditors.DateEdit();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.dxError_cbbGender = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            this.accordionContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_birth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_birth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxError_cbbGender)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.BackgroundImage = global::PepperLunch.Properties.Resources.bg_ppl;
            this.fluentDesignFormContainer1.Controls.Add(this.tablePanel1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(264, 39);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(755, 547);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 7.77F)});
            this.tablePanel1.Controls.Add(this.gridControl_staff);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 227.6003F)});
            this.tablePanel1.Size = new System.Drawing.Size(755, 547);
            this.tablePanel1.TabIndex = 0;
            // 
            // gridControl_staff
            // 
            this.tablePanel1.SetColumn(this.gridControl_staff, 0);
            this.gridControl_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_staff.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl_staff.Location = new System.Drawing.Point(2, 2);
            this.gridControl_staff.MainView = this.gridView1;
            this.gridControl_staff.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl_staff.Name = "gridControl_staff";
            this.tablePanel1.SetRow(this.gridControl_staff, 0);
            this.gridControl_staff.Size = new System.Drawing.Size(751, 543);
            this.gridControl_staff.TabIndex = 0;
            this.gridControl_staff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 267;
            this.gridView1.GridControl = this.gridControl_staff;
            this.gridView1.Name = "gridView1";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Hint.BackColor = System.Drawing.Color.Red;
            this.accordionControl1.Appearance.Hint.Options.UseBackColor = true;
            this.accordionControl1.Controls.Add(this.accordionContentContainer1);
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionCtrlEle_newStaff,
            this.accordionControlSeparator4,
            this.accordionCtrlEle_updateStaff,
            this.accordionControlSeparator2,
            this.accordionCtrlEle_removeStaff,
            this.accordionControlSeparator3,
            this.accordionControlSeparator1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(264, 547);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionContentContainer1
            // 
            this.accordionContentContainer1.Controls.Add(this.tablePanel2);
            this.accordionContentContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Size = new System.Drawing.Size(262, 370);
            this.accordionContentContainer1.TabIndex = 2;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Hovered.BackColor = System.Drawing.Color.Black;
            this.accordionControlElement1.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Hovered.Options.UseBackColor = true;
            this.accordionControlElement1.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Staff";
            // 
            // accordionCtrlEle_newStaff
            // 
            this.accordionCtrlEle_newStaff.ContentContainer = this.accordionContentContainer1;
            this.accordionCtrlEle_newStaff.Expanded = true;
            this.accordionCtrlEle_newStaff.Name = "accordionCtrlEle_newStaff";
            this.accordionCtrlEle_newStaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlEle_newStaff.Text = "New Staff";
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // accordionCtrlEle_updateStaff
            // 
            this.accordionCtrlEle_updateStaff.Expanded = true;
            this.accordionCtrlEle_updateStaff.Name = "accordionCtrlEle_updateStaff";
            this.accordionCtrlEle_updateStaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlEle_updateStaff.Text = "Update Staff";
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionCtrlEle_removeStaff
            // 
            this.accordionCtrlEle_removeStaff.Name = "accordionCtrlEle_removeStaff";
            this.accordionCtrlEle_removeStaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlEle_removeStaff.Text = "Remove Staff";
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1019, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // labelControl1
            // 
            this.tablePanel2.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(12, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(58, 16);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.tablePanel2.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(12, 50);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel2.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Password";
            // 
            // labelControl3
            // 
            this.tablePanel2.SetColumn(this.labelControl3, 0);
            this.labelControl3.Location = new System.Drawing.Point(12, 82);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel2.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(33, 16);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Name";
            // 
            // labelControl4
            // 
            this.tablePanel2.SetColumn(this.labelControl4, 0);
            this.labelControl4.Location = new System.Drawing.Point(12, 114);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel2.SetRow(this.labelControl4, 3);
            this.labelControl4.Size = new System.Drawing.Size(52, 16);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Surname";
            // 
            // labelControl5
            // 
            this.tablePanel2.SetColumn(this.labelControl5, 0);
            this.labelControl5.Location = new System.Drawing.Point(12, 146);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel2.SetRow(this.labelControl5, 4);
            this.labelControl5.Size = new System.Drawing.Size(41, 16);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Gender";
            // 
            // labelControl6
            // 
            this.tablePanel2.SetColumn(this.labelControl6, 0);
            this.labelControl6.Location = new System.Drawing.Point(12, 178);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel2.SetRow(this.labelControl6, 5);
            this.labelControl6.Size = new System.Drawing.Size(35, 16);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Phone";
            // 
            // labelControl8
            // 
            this.tablePanel2.SetColumn(this.labelControl8, 0);
            this.labelControl8.Location = new System.Drawing.Point(12, 242);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel2.SetRow(this.labelControl8, 7);
            this.labelControl8.Size = new System.Drawing.Size(73, 16);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Date Of Birth";
            // 
            // labelControl7
            // 
            this.tablePanel2.SetColumn(this.labelControl7, 0);
            this.labelControl7.Location = new System.Drawing.Point(12, 210);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel2.SetRow(this.labelControl7, 6);
            this.labelControl7.Size = new System.Drawing.Size(46, 16);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Address";
            // 
            // txtName
            // 
            this.tablePanel2.SetColumn(this.txtName, 1);
            this.tablePanel2.SetColumnSpan(this.txtName, 2);
            this.txtName.Location = new System.Drawing.Point(110, 79);
            this.txtName.Name = "txtName";
            this.tablePanel2.SetRow(this.txtName, 2);
            this.txtName.Size = new System.Drawing.Size(139, 22);
            this.txtName.TabIndex = 27;
            // 
            // txtUsername
            // 
            this.tablePanel2.SetColumn(this.txtUsername, 1);
            this.tablePanel2.SetColumnSpan(this.txtUsername, 2);
            this.txtUsername.Location = new System.Drawing.Point(110, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Name = "fProperties";
            this.tablePanel2.SetRow(this.txtUsername, 0);
            this.txtUsername.Size = new System.Drawing.Size(139, 22);
            this.txtUsername.TabIndex = 28;
            // 
            // txtPhone
            // 
            this.tablePanel2.SetColumn(this.txtPhone, 1);
            this.tablePanel2.SetColumnSpan(this.txtPhone, 2);
            this.txtPhone.Location = new System.Drawing.Point(110, 175);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Name = "fProperties";
            this.tablePanel2.SetRow(this.txtPhone, 5);
            this.txtPhone.Size = new System.Drawing.Size(139, 22);
            this.txtPhone.TabIndex = 29;
            // 
            // txtPassword
            // 
            this.tablePanel2.SetColumn(this.txtPassword, 1);
            this.tablePanel2.SetColumnSpan(this.txtPassword, 2);
            this.txtPassword.Location = new System.Drawing.Point(110, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Name = "fProperties";
            this.tablePanel2.SetRow(this.txtPassword, 1);
            this.txtPassword.Size = new System.Drawing.Size(139, 22);
            this.txtPassword.TabIndex = 30;
            // 
            // txtSurname
            // 
            this.tablePanel2.SetColumn(this.txtSurname, 1);
            this.tablePanel2.SetColumnSpan(this.txtSurname, 2);
            this.txtSurname.Location = new System.Drawing.Point(110, 111);
            this.txtSurname.Name = "txtSurname";
            this.tablePanel2.SetRow(this.txtSurname, 3);
            this.txtSurname.Size = new System.Drawing.Size(139, 22);
            this.txtSurname.TabIndex = 31;
            // 
            // btnCreateStaff
            // 
            this.btnCreateStaff.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStaff.Appearance.Options.UseFont = true;
            this.tablePanel2.SetColumn(this.btnCreateStaff, 1);
            this.btnCreateStaff.Location = new System.Drawing.Point(110, 301);
            this.btnCreateStaff.Name = "btnCreateStaff";
            this.tablePanel2.SetRow(this.btnCreateStaff, 9);
            this.btnCreateStaff.Size = new System.Drawing.Size(91, 28);
            this.btnCreateStaff.TabIndex = 32;
            this.btnCreateStaff.Text = "Create Staff";
            this.btnCreateStaff.Click += new System.EventHandler(this.btnCreateStaff_Click);
            // 
            // txtAddress
            // 
            this.tablePanel2.SetColumn(this.txtAddress, 1);
            this.tablePanel2.SetColumnSpan(this.txtAddress, 2);
            this.txtAddress.Location = new System.Drawing.Point(110, 207);
            this.txtAddress.Name = "txtAddress";
            this.tablePanel2.SetRow(this.txtAddress, 6);
            this.txtAddress.Size = new System.Drawing.Size(139, 22);
            this.txtAddress.TabIndex = 33;
            // 
            // labelControl9
            // 
            this.tablePanel2.SetColumn(this.labelControl9, 0);
            this.labelControl9.Location = new System.Drawing.Point(13, 274);
            this.labelControl9.Name = "labelControl9";
            this.tablePanel2.SetRow(this.labelControl9, 8);
            this.labelControl9.Size = new System.Drawing.Size(25, 16);
            this.labelControl9.TabIndex = 34;
            this.labelControl9.Text = "Role";
            // 
            // dateEdit_birth
            // 
            this.tablePanel2.SetColumn(this.dateEdit_birth, 1);
            this.tablePanel2.SetColumnSpan(this.dateEdit_birth, 2);
            this.dateEdit_birth.EditValue = null;
            this.dateEdit_birth.Location = new System.Drawing.Point(110, 239);
            this.dateEdit_birth.Name = "dateEdit_birth";
            this.dateEdit_birth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_birth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel2.SetRow(this.dateEdit_birth, 7);
            this.dateEdit_birth.Size = new System.Drawing.Size(139, 22);
            this.dateEdit_birth.TabIndex = 36;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel2.Controls.Add(this.cbbGender);
            this.tablePanel2.Controls.Add(this.cbbRole);
            this.tablePanel2.Controls.Add(this.dateEdit_birth);
            this.tablePanel2.Controls.Add(this.labelControl9);
            this.tablePanel2.Controls.Add(this.txtAddress);
            this.tablePanel2.Controls.Add(this.btnCreateStaff);
            this.tablePanel2.Controls.Add(this.txtSurname);
            this.tablePanel2.Controls.Add(this.txtPassword);
            this.tablePanel2.Controls.Add(this.txtPhone);
            this.tablePanel2.Controls.Add(this.txtUsername);
            this.tablePanel2.Controls.Add(this.txtName);
            this.tablePanel2.Controls.Add(this.labelControl7);
            this.tablePanel2.Controls.Add(this.labelControl8);
            this.tablePanel2.Controls.Add(this.labelControl6);
            this.tablePanel2.Controls.Add(this.labelControl5);
            this.tablePanel2.Controls.Add(this.labelControl4);
            this.tablePanel2.Controls.Add(this.labelControl3);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Padding = new System.Windows.Forms.Padding(10);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.4F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(262, 370);
            this.tablePanel2.TabIndex = 1;
            // 
            // cbbRole
            // 
            this.tablePanel2.SetColumn(this.cbbRole, 1);
            this.tablePanel2.SetColumnSpan(this.cbbRole, 2);
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(110, 270);
            this.cbbRole.Name = "cbbRole";
            this.tablePanel2.SetRow(this.cbbRole, 8);
            this.cbbRole.Size = new System.Drawing.Size(139, 24);
            this.cbbRole.TabIndex = 37;
            // 
            // cbbGender
            // 
            this.tablePanel2.SetColumn(this.cbbGender, 1);
            this.tablePanel2.SetColumnSpan(this.cbbGender, 2);
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Location = new System.Drawing.Point(110, 141);
            this.cbbGender.Name = "cbbGender";
            this.tablePanel2.SetRow(this.cbbGender, 4);
            this.cbbGender.Size = new System.Drawing.Size(139, 24);
            this.cbbGender.TabIndex = 38;
            // 
            // dxError_cbbGender
            // 
            this.dxError_cbbGender.ContainerControl = this;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 586);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStaff";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Staffs";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            this.accordionContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_birth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_birth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxError_cbbGender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridControl_staff;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlEle_newStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlEle_updateStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlEle_removeStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.DateEdit dateEdit_birth;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Modify_Control.EditText_DigitOrLetter txtAddress;
        private DevExpress.XtraEditors.SimpleButton btnCreateStaff;
        private Modify_Control.EditText_Letter txtSurname;
        private Modify_Control.EditText_DigitOrLetter txtPassword;
        private Modify_Control.EditText_Digit txtPhone;
        private Modify_Control.EditText_DigitOrLetter txtUsername;
        private Modify_Control.EditText_Letter txtName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.ComboBox cbbRole;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxError_cbbGender;
    }
}