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
                    // if item of firebase don't have , perform insert into that
                    else
                    {
                        ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Category/" + itemOfSql.ID_CATEGORY.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return listOfFirebase;

        }

    }
}
