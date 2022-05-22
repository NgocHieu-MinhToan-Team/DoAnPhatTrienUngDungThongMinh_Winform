using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
using DAL_PPL;
using FireSharp.Response;

namespace FireBase_PPL
{
    public class FB_Category
    {
        //get state connect firebase
        static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();
        
        //get one category
        public static async Task<CATEGORY> getOne(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<CATEGORY>();
            }
            return null;
        }

        // get all node on branch Category
        private static async Task<Dictionary<string, CATEGORY>> getEntireOnBranch(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<Dictionary<string, CATEGORY>>();
            }
            return null;
        }


        //get list category
        public static async Task<List<CATEGORY>> getEntire()
        {
            List<CATEGORY> listOfFirebase = new List<CATEGORY>();
            Dictionary<string, CATEGORY> listData = await getEntireOnBranch("Database/Category");
            try
            {
                // convert from Dictionary to list 
                if (listData != null)
                {
                    foreach (var itemData in listData)
                    {
                        CATEGORY itemOfFirebase = itemData.Value;
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

        // get categories that was not synchronized 
        public static async Task<List<CATEGORY>> getEntireNotSync(List<CATEGORY> listOfSql)
        {
            List<CATEGORY> listNotSync  = new List<CATEGORY>();
            Dictionary<string, CATEGORY> listData = await getEntireOnBranch("Database/Category");
            try
            {
                
                foreach (CATEGORY itemOfSql in listOfSql)
                {
                    CATEGORY itemOfFirebase = await getOne("Database/Category/" + itemOfSql.ID_CATEGORY.ToString() + "/");
                    if (itemOfFirebase != null)
                    {
                        if(itemOfFirebase.GROUP_CATEGORY != itemOfSql.GROUP_CATEGORY 
                        || itemOfFirebase.NAME_CATEGORY != itemOfSql.NAME_CATEGORY)
                        {
                            listNotSync.Add(itemOfSql);
                        }
                    }
                    else
                    {
                        listNotSync.Add(itemOfSql);
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
        // update data on firebase 
        


        //
        public static async Task<bool> updateToFirebaseAsync(List<CATEGORY> listOfSql)
        {

            try
            {
                List<PRODUCT> listProduct = DAL_Product.getProducts();
                // update node Cate
                await ConnectFireBase.FirebaseDeleteData("Database/Category");

                foreach (CATEGORY itemOfSql in listOfSql)
                {
                    await ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Category/" + itemOfSql.ID_CATEGORY.ToString() + "/"); 
                }

                // update node Cate and dish
                await ConnectFireBase.FirebaseDeleteData("Database/Category_Dish");

                foreach (CATEGORY itemOfSql in listOfSql)
                {
                    // add node cate
                    await ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Category_Dish/" + itemOfSql.ID_CATEGORY.ToString() + "/");
                    // add List node product after per cate
                    foreach(PRODUCT itemOfProduct in listProduct)
                    {
                        if(itemOfSql.ID_CATEGORY== itemOfProduct.ID_CATEGORY)
                            await ConnectFireBase.FirebaseInsertData(itemOfProduct, "Database/Category_Dish/" + itemOfSql.ID_CATEGORY.ToString() + "/Dishes/"+itemOfProduct.ID_PRODUCT+"/");
                    }

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
