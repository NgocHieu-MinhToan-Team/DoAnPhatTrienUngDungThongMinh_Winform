
namespace PepperLunch.PopupForm
{
    partial class frmPopupAddCategory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNameCate = new Modify_Control.EditText_Letter();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_groupCate = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.65289F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.34711F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNameCate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbb_groupCate, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 141);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Group Category";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Name Category";
            // 
            // txtNameCate
            // 
            this.txtNameCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameCate.Location = new System.Drawing.Point(199, 73);
            this.txtNameCate.Name = "txtNameCate";
            this.txtNameCate.Size = new System.Drawing.Size(158, 28);
            this.txtNameCate.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(363, 23);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 29);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbb_groupCate
            // 
            this.cbb_groupCate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_groupCate.FormattingEnabled = true;
            this.cbb_groupCate.Location = new System.Drawing.Point(199, 23);
            this.cbb_groupCate.Name = "cbb_groupCate";
            this.cbb_groupCate.Size = new System.Drawing.Size(158, 29);
            this.cbb_groupCate.TabIndex = 5;
            // 
            // frmPopupAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::PepperLunch.Properties.Resources.bg_white;
            this.ClientSize = new System.Drawing.Size(517, 141);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IconOptions.Image = global::PepperLunch.Properties.Resources.peper_logo;
            this.Name = "frmPopupAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPopupAddCategory";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Modify_Control.EditText_Letter txtNameCate;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private System.Windows.Forms.ComboBox cbb_groupCate;
    }
}