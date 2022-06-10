using BLL_PPL;
using DTO_PPL;
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

namespace PepperLunch
{
    public partial class frmConfirmImport : DevExpress.XtraEditors.XtraForm
    {
        public string ID_IOG { get; set; }
        List<DETAIL_IMPORT> listDetail;
        BLL_IOGDetail bll_iogDetail = new BLL_IOGDetail();

        public frmConfirmImport()
        {
            InitializeComponent();

        }

        private void frmConfirmImport_Load(object sender, EventArgs e)
        {
            loadData();
            this.Text += " " + ID_IOG;
        }

        void loadData()
        {
            listDetail = bll_iogDetail.getList(ID_IOG);
            gridControl_IOGDetail.DataSource = listDetail;
        }


        private void gridView_IOGDetail_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }


        private void frmConfirmImport_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void repositoryItemButtonEdit_Confirm_Click(object sender, EventArgs e)
        {
            txtQuantity.Visible = false;
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            IMPORT imp = BLL_IOG.getList().SingleOrDefault(t => t.ID_IOG == ID_IOG);
            string note = imp.NOTE;
            int[] arrRowSelected = gridView_IOGDetail.GetSelectedRows();
            if (arrRowSelected.Length > 0)
            {
                 DETAIL_IMPORT item = (DETAIL_IMPORT)gridView_IOGDetail.GetRow(arrRowSelected[0]);
                // update only price
                if (txtQuantity.Visible == false)
                {
                    item.PRICE =Int32.Parse(txtPrice.Text);
                    bll_iogDetail.update(item);
                }
                else
                {
                    int number = (int)(item.QUANTITY - Int32.Parse(txtQuantity.Text));
                    if (number > 0)
                    {
                        note += "{ " + item.ID_INGREDIENT + " Thiếu " + Math.Abs(number).ToString() + " }, ";
                    }
                    //redundant / thừa
                    if (number < 0)
                    {
                        note += "{ " + item.ID_INGREDIENT + " Thừa " + Math.Abs(number).ToString() + " }, ";
                    }
                    item.PRICE = Int32.Parse(txtPrice.Text);
                    item.QUANTITY = Int32.Parse(txtQuantity.Text);
                    bll_iogDetail.update(item);

                    IMPORT import = new IMPORT();
                    import.ID_IOG = ID_IOG;
                    import.NOTE = note;
                    BLL_IOG.updateNote(import);
                }
                gridView_IOGDetail.DeleteRow(arrRowSelected[0]);
               
            }
        }

        private void repositoryItemButtonEdit_Incorrect_Click(object sender, EventArgs e)
        {
            txtQuantity.Visible = true;
        }
    }
}