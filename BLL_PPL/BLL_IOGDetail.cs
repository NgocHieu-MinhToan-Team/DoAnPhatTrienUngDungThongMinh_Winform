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
        public BLL_IOGDetail() { }
        public static List<DETAIL_IMPORT> getList(string ID_IOG)
        {
            return DAL_IOGDetail.getListByID(ID_IOG);
        }
        public static bool insert(DETAIL_IMPORT data)
        {
            try
            {
                if (DAL_IOGDetail.insert(data))
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

        public static bool delete(DETAIL_IMPORT data)
        {
            try
            {
                if (DAL_IOGDetail.delete(data))
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

        public static bool update(DETAIL_IMPORT data)
        {
            try
            {
                if (DAL_IOGDetail.update(data))
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
