using DTO_PPL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PPL;
using System.Windows;

namespace BLL_PPL
{
    public class BLL_Recipe
    {
        public static List<DETAIL_PRODUCT> getList(string ID_PRODUCT)
        {
            return DAL_Recipe.getList(ID_PRODUCT);
        }

        public static List<RECIPE_JOIN> getRecipeJoin(string ID_PRODUCT)
        {
            List<RECIPE_JOIN> list =DAL_Recipe.getRecipeJoin(ID_PRODUCT);
            return list;
        }



        public static bool add(DETAIL_PRODUCT data)
        {
            try
            {
                if (DAL_Recipe.add(data))
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

        public static bool remove(DETAIL_PRODUCT data)
        {
            try
            {
                if (DAL_Recipe.remove(data))
                {
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

        public static bool update(DETAIL_PRODUCT data)
        {
            try
            {
                if (DAL_Recipe.update(data))
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

        public static bool validate(string weight)
        {
            if(GeneralMethods.isDigit(weight.ToString(), false))
            {
                if (Convert.ToInt32(weight)>0)
                    return true;
            }
            return false;
        }

    }
}
