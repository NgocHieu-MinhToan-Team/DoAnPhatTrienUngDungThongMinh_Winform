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
    public class BLL_Promotion
    {
        public BLL_Promotion() { }

        public static List<PROMOTION> getPromotions()
        {
            List<PROMOTION> list = DAL_Promotion.getPromotions();
            return list;
        }

        public static bool insertPromotion(PROMOTION data)
        {
            try
            {
                if (DAL_Promotion.insertPromotion(data))
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

        public static bool deletePromotion(PROMOTION data)
        {
            try
            {
                if (DAL_Promotion.deletePromotion(data))
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

        public static bool updatePromotion(PROMOTION data)
        {
            try
            {
                if (DAL_Promotion.updatePromotion(data))
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
