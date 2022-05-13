using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepperLunch.PopupForm
{
    public partial class frmPopupAddCategory : DevExpress.XtraEditors.XtraForm
    {
        public frmPopupAddCategory()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
            this.Hide();
        }
    }
}