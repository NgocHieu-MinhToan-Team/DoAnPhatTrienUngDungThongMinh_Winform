using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DAL_PPL;
using DTO_PPL;
using FireBase_PPL;
using FireSharp.Interfaces;



namespace BLL_PPL
{
    public class BLL_Category
    {
        public BLL_Category() { }

        public static  List<CATEGORY> getCategories()
        {
            List<CATEGORY> list = DAL_Category.getCategories();
            return list;
        }

        public static bool insertCategories(CATEGORY data)
        {
            try
            {
                if (DAL_Category.insertCategories(data))
                {
                    MessageBox.Show("Insert Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Insert Data Failed !");
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool deleteCategories(CATEGORY data)
        {
            try
            {
                if (DAL_Category.deleteCategories(data))
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

        public static bool updateCategories(CATEGORY data)
        {
            try
            {
                if (DAL_Category.updateCategories(data))
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
