using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_PPL;

namespace PepperLunch
{
    public partial class frmCustomer : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BLL_Customer.getCustomers();
        }
    }
}
