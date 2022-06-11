using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
using DAL_PPL;
using System.Windows.Forms;

namespace BLL_PPL
{
    public class BLL_IOGDetail
    {
        DAL_IOGDetail bll_iogDetail = new DAL_IOGDetail();
        public BLL_IOGDetail() { }
        public  List<DETAIL_IMPORT> getList(string ID_IOG)
        {
            return bll_iogDetail.getListByID(ID_IOG);
        }

        public List<IOGDETAIL_JOIN> getListJoinByID(string ID_IOG)
        {
            return bll_iogDetail.getListJoinByID(ID_IOG);
        }

        public  bool insert(DETAIL_IMPORT data)
        {
            try
            {
                if (bll_iogDetail.insert(data))
                {
                    MessageBox.Show("Insert Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Insert Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public  bool validateIsNumber(string text1)
        {
            return GeneralMethods.isDigit(text1, false);
        }

        public  bool delete(DETAIL_IMPORT data)
        {
            try
            {
                if (bll_iogDetail.delete(data))
                {
                    MessageBox.Show("Delete Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Delete Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public  bool update(DETAIL_IMPORT data)
        {
            try
            {
                if (bll_iogDetail.update(data))
                {
                    MessageBox.Show("Update Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Update Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
