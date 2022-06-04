using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
using DAL_PPL;
using System.Windows;

namespace BLL_PPL
{
    public class BLL_Voucher
    {
        public BLL_Voucher() { }

        public static List<VOUCHER> getVouchers(string ID_PROMOTION)
        {
            List<VOUCHER> list = DAL_Voucher.getVouchers(ID_PROMOTION);
            return list;
        }

        public static List<METHOD> getVouchers()
        {
            List<METHOD> list = DAL_Voucher.getMethods();
            return list;
        }

        public static bool insertVoucher(VOUCHER data)
        {
            try
            {
                if (DAL_Voucher.insertVoucher(data))
                {
                    MessageBox.Show("Insert 1 record Sucessfully for " + data.ID_PROMOTION.ToString());
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

        public static bool deleteVoucher(VOUCHER data)
        {
            try
            {
                if (DAL_Voucher.deleteVoucher(data))
                {
                    MessageBox.Show("Delete Sucessfully 1 record of " + data.ID_PROMOTION.ToString());
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

        public static bool updateVoucher(VOUCHER data)
        {
            try
            {
                if (DAL_Voucher.updateVoucher(data))
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
