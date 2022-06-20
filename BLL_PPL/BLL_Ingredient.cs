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
    public class BLL_Ingredient
    {
        public BLL_Ingredient() { }

        public static List<INGREDIENT> getList()
        {
            List<INGREDIENT> list = DAL_Ingredient.getList();
            return list;
        }

        public static List<INGREDIENT> getListByID_SUPPLIER(string ID_SUPPLIER)
        {
            List<INGREDIENT> list = DAL_Ingredient.getListByID_SUPPLIER(ID_SUPPLIER);
            return list;
        }
        public static List<SUPPLIER> getListSupplier ()
        {
            List<SUPPLIER> list = DAL_Ingredient.getListSupplier();
            return list;
        }


        public static bool add(INGREDIENT data)
        {
            try
            {
                if (DAL_Ingredient.add(data))
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

        public static bool remove(INGREDIENT data)
        {
            try
            {
                if (DAL_Ingredient.remove(data))
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

        public static bool update(INGREDIENT data)
        {
            try
            {
                if (DAL_Ingredient.update(data))
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

        public static bool checkNameExist(string name, string id_supplier)
        {
            INGREDIENT item = getListByID_SUPPLIER(id_supplier).SingleOrDefault(t => t.NAME_INGREDIENT == name);
            if (item != null)
            {
                return false;
            }
            return true;
        }

    }
}
