using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
using FireSharp.Response;

namespace FireBase_PPL
{
    public class FB_Category
    {
        //get state connect firebase
        static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();

        //get one category
        public static async Task<CATEGORY> getCategory(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<CATEGORY>();
            }
            return null;
        }


        //get list of Categories
        public static async Task<List<CATEGORY>> getListCategories(List<CATEGORY> listOfSql)
        {
            List<CATEGORY> listOfFirebase = new List<CATEGORY>();
            try
            {
                foreach (CATEGORY itemOfSql in listOfSql)
                {
                    CATEGORY itemOfFirebase = await getCategory("Database/Category/" + itemOfSql.ID_CATEGORY.ToString() + "/");
                    //get and synchronous data of sql with data of firebase
                    // if item of firebase have existed
                    if (itemOfFirebase != null)
                    {
                        listOfFirebase.Add(itemOfFirebase);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return listOfFirebase;

        }
        public static async Task<List<CATEGORY>> getCategoriesNotSync(List<CATEGORY> listOfSql)
        {
            List<CATEGORY> listNotSync  = new List<CATEGORY>();
            try
            {
                foreach (CATEGORY itemOfSql in listOfSql)
                {
                    CATEGORY itemOfFirebase = await getCategory("Database/Category/" + itemOfSql.ID_CATEGORY.ToString() + "/");
                    if (itemOfFirebase != null)
                    {
                        if(itemOfFirebase.GROUP_CATEGORY != itemOfSql.GROUP_CATEGORY 
                        || itemOfFirebase.NAME_CATEGORY != itemOfSql.NAME_CATEGORY)
                        {
                            listNotSync.Add(itemOfSql);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return listNotSync;

        }
        public static bool synchronizedCategoriesToFirebase(List<CATEGORY> listOfSql)
        {
            
            try
            {
                // delete node parent
                ConnectFireBase.FirebaseDeleteData("Database/Category");
                // insert again entire data from sql to firebase
                foreach (CATEGORY itemOfSql in listOfSql)
                {
                    ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Category/" + itemOfSql.ID_CATEGORY + "/");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;

        }

    }
}
