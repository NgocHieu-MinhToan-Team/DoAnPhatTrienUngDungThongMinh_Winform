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
    public class BLL_IOG
    {
        public BLL_IOG() { }
        public static List<IMPORT> getList()
        {
            return DAL_IOG.getList();
        }

        public static List<IMPORT> getImportsByStatus(int status)
        {
            if(status==0 || status == 1)
            {
                return DAL_IOG.getImportsByStatus(status);
            }
            else
            {
                MessageBox.Show("Having not status" + status);
                return null;
            }
        }

        public static List<IMPORT> getImportsByStatus(int status, string ID_SUPPLIER)
        {
            if (status == 0 || status == 1)
            {
                return DAL_IOG.getImportsByStatus(status, ID_SUPPLIER);
            }
            else
            {
                MessageBox.Show("Having not status" + status);
                return null;
            }
        }


        public static bool insert(IMPORT data)
        {
            try
            {
                if (DAL_IOG.insert(data))
                {
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

        public static bool delete(IMPORT data)
        {
            try
            {
                if (DAL_IOG.delete(data))
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
        
        public static bool updateNote(IMPORT data)
        {
            try
            {
                if (DAL_IOG.updateNote(data))
                {
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

        public static bool update(IMPORT data)
        {
            try
            {
                if (DAL_IOG.update(data))
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

        public static bool updateTotalPrice(IMPORT data)
        {
            try
            {
                if (DAL_IOG.updateTotalPrice(data))
                {
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
