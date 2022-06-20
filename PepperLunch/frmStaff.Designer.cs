
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
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.dateEdit_birth = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new Modify_Control.EditText_DigitOrLetter();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new Modify_Control.EditText_DigitOrLetter();
            this.txtPassword = new Modify_Control.EditText_DigitOrLetter();
            this.txtSurname = new Modify_Control.EditText_Letter();
            this.txtName = new Modify_Control.EditText_Letter();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new Modify_Control.EditText_Digit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_staff = new DevExpress.XtraGrid.GridControl();
            this.gridView_Staff = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ROLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox_role = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox_gender = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlEle_newStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlEle_updateStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionCtrlEle_removeStaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.dxError_cbbGender = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxError_username = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_birth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_birth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError_cbbGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError_username)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.BackgroundImage = global::PepperLunch.Properties.Resources.bg_ppl;
            this.fluentDesignFormContainer1.Controls.Add(this.tablePanel1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(239, 39);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(851, 553);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 7.77F)});
            this.tablePanel1.Controls.Add(this.tablePanel3);
            this.tablePanel1.Controls.Add(this.gridControl_staff);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F)});
            this.tablePanel1.Size = new System.Drawing.Size(851, 553);
            this.tablePanel1.TabIndex = 0;
            // 
            // tablePanel3
            // 
            this.tablePanel1.SetColumn(this.tablePanel3, 0);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel3.Controls.Add(this.labelControl9);
            this.tablePanel3.Controls.Add(this.cbbRole);
            this.tablePanel3.Controls.Add(this.cbbGender);
            this.tablePanel3.Controls.Add(this.dateEdit_birth);
            this.tablePanel3.Controls.Add(this.labelControl1);
            this.tablePanel3.Controls.Add(this.labelControl8);
            this.tablePanel3.Controls.Add(this.labelControl2);
            this.tablePanel3.Controls.Add(this.txtAddress);
            this.tablePanel3.Controls.Add(this.labelControl7);
            this.tablePanel3.Controls.Add(this.txtUsername);
            this.tablePanel3.Controls.Add(this.txtPassword);
            this.tablePanel3.Controls.Add(this.txtSurname);
            this.tablePanel3.Controls.Add(this.txtName);
            this.tablePanel3.Controls.Add(this.labelControl6);
            this.tablePanel3.Controls.Add(this.txtPhone);
            this.tablePanel3.Controls.Add(this.labelControl5);
            this.tablePanel3.Controls.Add(this.labelControl3);
            this.tablePanel3.Controls.Add(this.labelControl4);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(3, 3);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Padding = new System.Windows.Forms.Padding(20);
            this.tablePanel1.SetRow(this.tablePanel3, 0);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel3.Size = new System.Drawing.Size(845, 132);
            this.tablePanel3.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.tablePanel3.SetColumn(this.labelControl9, 2);
            this.labelControl9.Location = new System.Drawing.Point(292, 86);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.tablePanel3.SetRow(this.labelControl9, 2);
            this.labelControl9.Size = new System.Drawing.Size(33, 21);
            this.labelControl9.TabIndex = 34;
            this.labelControl9.Text = "Role";
            // 
            // cbbRole
            // 
            this.tablePanel3.SetColumn(this.cbbRole, 3);
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(382, 86);
            this.cbbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRole.Name = "cbbRole";
            this.tablePanel3.SetRow(this.cbbRole, 2);
            this.cbbRole.Size = new System.Drawing.Size(171, 29);
            this.cbbRole.TabIndex = 37;
            // 
            // cbbGender
            // 
            this.tablePanel3.SetColumn(this.cbbGender, 5);
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Location = new System.Drawing.Point(650, 24);
            this.cbbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbbGender.Name = "cbbGender";
            this.tablePanel3.SetRow(this.cbbGender, 0);
            this.cbbGender.Size = new System.Drawing.Size(171, 29);
            this.cbbGender.TabIndex = 38;
            // 
            // dateEdit_birth
            // 
            this.tablePanel3.SetColumn(this.dateEdit_birth, 5);
            this.dateEdit_birth.EditValue = null;
            this.dateEdit_birth.Location = new System.Drawing.Point(650, 86);
            this.dateEdit_birth.Margin = new System.Windows.Forms.Padding(4);
            this.dateEdit_birth.Name = "dateEdit_birth";
            this.dateEdit_birth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_birth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel3.SetRow(this.dateEdit_birth, 2);
            this.dateEdit_birth.Size = new System.Drawing.Size(171, 22);
            this.dateEdit_birth.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.tablePanel3.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(23, 25);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel3.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(75, 21);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Username";
            // 
            // labelControl8
            // 
            this.tablePanel3.SetColumn(this.labelControl8, 4);
            this.labelControl8.Location = new System.Drawing.Point(560, 86);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel3.SetRow(this.labelControl8, 2);
            this.labelControl8.Size = new System.Drawing.Size(98, 21);
            this.labelControl8.TabIndex = 25;
            this.labelControl8.Text = "Date Of Birth";
            // 
            // labelControl2
            // 
            this.tablePanel3.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(23, 56);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel3.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(71, 21);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Password";
            // 
            // txtAddress
            // 
            this.tablePanel3.SetColumn(this.txtAddress, 1);
            this.txtAddress.Location = new System.Drawing.Point(113, 86);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.tablePanel3.SetRow(this.txtAddress, 2);
            this.txtAddress.Size = new System.Drawing.Size(171, 22);
            this.txtAddress.TabIndex = 33;
            // 
            // labelControl7
            // 
            this.tablePanel3.SetColumn(this.labelControl7, 0);
            this.labelControl7.Location = new System.Drawing.Point(23, 86);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel3.SetRow(this.labelControl7, 2);
            this.labelControl7.Size = new System.Drawing.Size(60, 21);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Address";
            // 
            // txtUsername
            // 
            this.tablePanel3.SetColumn(this.txtUsername, 1);
            this.txtUsername.Location = new System.Drawing.Point(113, 24);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Name = "fProperties";
            this.tablePanel3.SetRow(this.txtUsername, 0);
            this.txtUsername.Size = new System.Drawing.Size(171, 23);
            this.txtUsername.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.tablePanel3.SetColumn(this.txtPassword, 1);
            this.txtPassword.Location = new System.Drawing.Point(113, 55);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Name = "fProperties";
            this.tablePanel3.SetRow(this.txtPassword, 1);
            this.txtPassword.Size = new System.Drawing.Size(171, 23);
            this.txtPassword.TabIndex = 30;
            // 
            // txtSurname
            // 
            this.tablePanel3.SetColumn(this.txtSurname, 3);
            this.txtSurname.Location = new System.Drawing.Point(382, 55);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.tablePanel3.SetRow(this.txtSurname, 1);
            this.txtSurname.Size = new System.Drawing.Size(171, 23);
            this.txtSurname.TabIndex = 31;
            // 
            // txtName
            // 
            this.tablePanel3.SetColumn(this.txtName, 3);
            this.txtName.Location = new System.Drawing.Point(382, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.tablePanel3.SetRow(this.txtName, 0);
            this.txtName.Size = new System.Drawing.Size(171, 23);
            this.txtName.TabIndex = 27;
            // 
            // labelControl6
            // 
            this.tablePanel3.SetColumn(this.labelControl6, 4);
            this.labelControl6.Location = new System.Drawing.Point(560, 56);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel3.SetRow(this.labelControl6, 1);
            this.labelControl6.Size = new System.Drawing.Size(45, 21);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Phone";
            // 
            // txtPhone
            // 
            this.tablePanel3.SetColumn(this.txtPhone, 5);
            this.txtPhone.Location = new System.Drawing.Point(650, 55);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Name = "fProperties";
            this.tablePanel3.SetRow(this.txtPhone, 1);
            this.txtPhone.Size = new System.Drawing.Size(171, 23);
            this.txtPhone.TabIndex = 29;
            // 
            // labelControl5
            // 
            this.tablePanel3.SetColumn(this.labelControl5, 4);
            this.labelControl5.Location = new System.Drawing.Point(560, 25);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel3.SetRow(this.labelControl5, 0);
            this.labelControl5.Size = new System.Drawing.Size(53, 21);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Gender";
            // 
            // labelControl3
            // 
            this.tablePanel3.SetColumn(this.labelControl3, 2);
            this.labelControl3.Location = new System.Drawing.Point(291, 25);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel3.SetRow(this.labelControl3, 0);
            this.labelControl3.Size = new System.Drawing.Size(43, 21);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Name";
            // 
            // labelControl4
            // 
            this.tablePanel3.SetColumn(this.labelControl4, 2);
            this.labelControl4.Location = new System.Drawing.Point(291, 56);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel3.SetRow(this.labelControl4, 1);
            this.labelControl4.Size = new System.Drawing.Size(65, 21);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Surname";
            // 
            // gridControl_staff
            // 
            this.tablePanel1.SetColumn(this.gridControl_staff, 0);
            this.gridControl_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_staff.Location = new System.Drawing.Point(3, 141);
            this.gridControl_staff.MainView = this.gridView_Staff;
            this.gridControl_staff.Name = "gridControl_staff";
            this.gridControl_staff.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox_role,
            this.repositoryItemComboBox_gender});
            this.tablePanel1.SetRow(this.gridControl_staff, 1);
            this.gridControl_staff.Size = new System.Drawing.Size(845, 409);
            this.gridControl_staff.TabIndex = 0;
            this.gridControl_staff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Staff});
            // 
            // gridView_Staff
            // 
            this.gridView_Staff.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.ROLE,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn10,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView_Staff.FixedLineWidth = 3;
            this.gridView_Staff.GridControl = this.gridControl_staff;
            this.gridView_Staff.Name = "gridView_Staff";
            this.gridView_Staff.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Staff_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "USERNAME";
            this.gridColumn1.FieldName = "USERNAME_STAFF";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "PASSWORD";
            this.gridColumn2.FieldName = "PASSWORD_STAFF";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID GROUP";
            this.gridColumn3.FieldName = "ID_GROUP";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // ROLE
            // 
            this.ROLE.Caption = "CHOOSE ROLE ";
            this.ROLE.ColumnEdit = this.repositoryItemComboBox_role;
            this.ROLE.FieldName = "ROLE";
            this.ROLE.MinWidth = 25;
            this.ROLE.Name = "ROLE";
            this.ROLE.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.ROLE.Visible = true;
            this.ROLE.VisibleIndex = 3;
            this.ROLE.Width = 94;
            // 
            // repositoryItemComboBox_role
            // 
            this.repositoryItemComboBox_role.AutoHeight = false;
            this.repositoryItemComboBox_role.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox_role.Name = "repositoryItemComboBox_role";
            this.repositoryItemComboBox_role.SelectedValueChanged += new System.EventHandler(this.repositoryItemComboBox_role_SelectedValueChanged);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "SURNAME";
            this.gridColumn4.FieldName = "SURNAME_STAFF";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "NAME";
            this.gridColumn5.FieldName = "NAME_STAFF";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "GENDER";
            this.gridColumn6.FieldName = "GENDER_STAFF";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "CHOOSE GENDER";
            this.gridColumn10.ColumnEdit = this.repositoryItemComboBox_gender;
            this.gridColumn10.FieldName = "GENDER";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            this.gridColumn10.Width = 94;
            // 
            // repositoryItemComboBox_gender
            // 
            this.repositoryItemComboBox_gender.AutoHeight = false;
            this.repositoryItemComboBox_gender.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown)});
            this.repositoryItemComboBox_gender.Name = "repositoryItemComboBox_gender";
            this.repositoryItemComboBox_gender.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemComboBox_gender.SelectedValueChanged += new System.EventHandler(this.repositoryItemComboBox_gender_SelectedValueChanged);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "DATE OF BIRTH";
            this.gridColumn7.FieldName = "DATE_OF_BIRTH";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "ADDRESS";
            this.gridColumn8.FieldName = "ADDRESS_STAFF";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 9;
            this.gridColumn8.Width = 94;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "PHONE";
            this.gridColumn9.FieldName = "NUMBER_PHONE";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 10;
            this.gridColumn9.Width = 94;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(16)))));
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.Hint.BackColor = System.Drawing.Color.Red;
            this.accordionControl1.Appearance.Hint.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionCtrlEle_newStaff,
            this.accordionCtrlEle_updateStaff,
            this.accordionCtrlEle_removeStaff});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(239, 553);
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
            this.accordionControlElement1.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Height = 40;
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement1.Text = "Staff";
            // 
            // accordionCtrlEle_newStaff
            // 
            this.accordionCtrlEle_newStaff.Expanded = true;
            this.accordionCtrlEle_newStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlEle_newStaff.ImageOptions.Image")));
            this.accordionCtrlEle_newStaff.Name = "accordionCtrlEle_newStaff";
            this.accordionCtrlEle_newStaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlEle_newStaff.Text = "New Staff";
            this.accordionCtrlEle_newStaff.Click += new System.EventHandler(this.accordionCtrlEle_newStaff_Click);
            // 
            // accordionCtrlEle_updateStaff
            // 
            this.accordionCtrlEle_updateStaff.Expanded = true;
            this.accordionCtrlEle_updateStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlEle_updateStaff.ImageOptions.Image")));
            this.accordionCtrlEle_updateStaff.Name = "accordionCtrlEle_updateStaff";
            this.accordionCtrlEle_updateStaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlEle_updateStaff.Text = "Update Staff";
            this.accordionCtrlEle_updateStaff.Click += new System.EventHandler(this.accordionCtrlEle_updateStaff_Click);
            // 
            // accordionCtrlEle_removeStaff
            // 
            this.accordionCtrlEle_removeStaff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionCtrlEle_removeStaff.ImageOptions.Image")));
            this.accordionCtrlEle_removeStaff.Name = "accordionCtrlEle_removeStaff";
            this.accordionCtrlEle_removeStaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionCtrlEle_removeStaff.Text = "Remove Staff";
            this.accordionCtrlEle_removeStaff.Click += new System.EventHandler(this.accordionCtrlEle_removeStaff_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1090, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // dxError_cbbGender
            // 
            this.dxError_cbbGender.ContainerControl = this;
            // 
            // dxError_username
            // 
            this.dxError_username.ContainerControl = this;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 592);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmStaff";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Staffs";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.tablePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_birth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_birth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError_cbbGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError_username)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridControl_staff;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Staff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlEle_newStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlEle_updateStaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionCtrlEle_removeStaff;
        private DevExpress.XtraEditors.DateEdit dateEdit_birth;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private Modify_Control.EditText_DigitOrLetter txtAddress;
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
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxError_username;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn ROLE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox_role;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox_gender;
    }
}