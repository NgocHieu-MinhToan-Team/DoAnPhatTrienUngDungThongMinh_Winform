
namespace PepperLunch
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tblPane_title = new DevExpress.Utils.Layout.TablePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpassword = new Modify_Control.EditText_DigitOrLetter();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.txtusername = new Modify_Control.EditText_Letter();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.tblPane_title)).BeginInit();
            this.tblPane_title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPane_title
            // 
            this.tblPane_title.Appearance.BackColor = System.Drawing.Color.White;
            this.tblPane_title.Appearance.Options.UseBackColor = true;
            this.tblPane_title.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tblPane_title.Controls.Add(this.panel1);
            this.tblPane_title.Controls.Add(this.tablePanel3);
            this.tblPane_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPane_title.Location = new System.Drawing.Point(0, 0);
            this.tblPane_title.Name = "tblPane_title";
            this.tblPane_title.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 178.8004F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tblPane_title.Size = new System.Drawing.Size(579, 793);
            this.tblPane_title.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.tblPane_title.SetColumn(this.panel1, 0);
            this.panel1.Controls.Add(this.tablePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 182);
            this.panel1.Name = "panel1";
            this.tblPane_title.SetRow(this.panel1, 1);
            this.panel1.Size = new System.Drawing.Size(573, 608);
            this.panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.tablePanel1.SetColumn(this.btnLogin, 0);
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(27, 363);
            this.btnLogin.Name = "btnLogin";
            this.tablePanel1.SetRow(this.btnLogin, 3);
            this.btnLogin.Size = new System.Drawing.Size(519, 74);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogin_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.tablePanel1.SetColumn(this.groupBox2, 0);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.tablePanel1.SetRow(this.groupBox2, 2);
            this.groupBox2.Size = new System.Drawing.Size(519, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpassword.Location = new System.Drawing.Point(10, 35);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtpassword.Properties.PasswordChar = '•';
            this.txtpassword.Size = new System.Drawing.Size(499, 44);
            this.txtpassword.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 0);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(519, 112);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sign In";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupbox1
            // 
            this.groupbox1.AutoSize = true;
            this.tablePanel1.SetColumn(this.groupbox1, 0);
            this.groupbox1.Controls.Add(this.txtusername);
            this.groupbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupbox1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox1.Location = new System.Drawing.Point(27, 139);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Padding = new System.Windows.Forms.Padding(10);
            this.tablePanel1.SetRow(this.groupbox1, 1);
            this.groupbox1.Size = new System.Drawing.Size(519, 106);
            this.groupbox1.TabIndex = 5;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Username";
            // 
            // txtusername
            // 
            this.txtusername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtusername.EnterMoveNextControl = true;
            this.txtusername.Location = new System.Drawing.Point(10, 35);
            this.txtusername.Name = "txtusername";
            this.txtusername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtusername.Size = new System.Drawing.Size(499, 44);
            this.txtusername.TabIndex = 0;
            this.txtusername.Tag = "1";
            // 
            // tablePanel3
            // 
            this.tablePanel3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel3.Appearance.Options.UseBackColor = true;
            this.tblPane_title.SetColumn(this.tablePanel3, 0);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel3.Controls.Add(this.panel3);
            this.tablePanel3.Controls.Add(this.label3);
            this.tablePanel3.Location = new System.Drawing.Point(3, 3);
            this.tablePanel3.Name = "tablePanel3";
            this.tblPane_title.SetRow(this.tablePanel3, 0);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.19F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 19.05F)});
            this.tablePanel3.Size = new System.Drawing.Size(573, 173);
            this.tablePanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PepperLunch.Properties.Resources.peper_logo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel3.SetColumn(this.panel3, 1);
            this.panel3.Location = new System.Drawing.Point(194, 33);
            this.panel3.Name = "panel3";
            this.tablePanel3.SetRow(this.panel3, 1);
            this.panel3.Size = new System.Drawing.Size(185, 96);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel3.SetColumn(this.label3, 0);
            this.tablePanel3.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.tablePanel3.SetRow(this.label3, 0);
            this.label3.Size = new System.Drawing.Size(567, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = " (ペッパーランチ Peppaa-ranchi)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 21.92F)});
            this.tablePanel1.Controls.Add(this.btnLogin);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.groupBox2);
            this.tablePanel1.Controls.Add(this.groupbox1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Padding = new System.Windows.Forms.Padding(24);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F)});
            this.tablePanel1.Size = new System.Drawing.Size(573, 608);
            this.tablePanel1.TabIndex = 7;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::PepperLunch.Properties.Resources.bg_white;
            this.ClientSize = new System.Drawing.Size(579, 793);
            this.Controls.Add(this.tblPane_title);
            this.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmLogin.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPane_title)).EndInit();
            this.tblPane_title.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            this.groupbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.tablePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tblPane_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private Modify_Control.EditText_Letter txtusername;
        private Modify_Control.EditText_DigitOrLetter txtpassword;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
    }
}