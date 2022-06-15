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
using BLL_PPL;
using FireBase_PPL;

namespace PepperLunch
{
    public partial class frmDetailReceipt : DevExpress.XtraEditors.XtraForm
    {
        public string ID { get; set; }
        public frmDetailReceipt()
        {
            InitializeComponent();
        }

        private void frmDetailReceipt_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BLL_Receipt.getDetailReceiptList(ID);
        }
    }
}