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
        public  static async Task<List<CATEGORY>> getCategoriesAsync(bool isSynchronous)
        {
            List<CATEGORY> list = DAL_Category.getCategories();
            // is Synchronous ? yes
            if (isSynchronous)
            {
                //check connect to firebase
                var client = ConnectFireBase.CreateFirebaseClient();
                if (client != null)
                {
                    //get data from firebase
                    return await FB_Category.getListCategories(list);
                }
                else
                {
                    //get data from sql
                    return list;
                }
            }
            // is Synchronous ? no
            else
            {
                return list;
            }
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


        //insert data to firebase
        public static bool insertCategoriesToFirebase()
        {
            try
            {
                List<CATEGORY> listFromSql = DAL_Category.getCategories();//tao doi tuong
                // loop through list data and insert each ID node
                foreach (CATEGORY item in listFromSql)
                {
                    ConnectFireBase.FirebaseInsertData(item, "Database/Category/"+ item.ID_CATEGORY.ToString());
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}
