using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_PPL;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace FireBase_PPL
{
    public class FB_Product
    {
        //get state connect firebase
        static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();

        //get one PRODUCT
        public static async Task<PRODUCT> getOne(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<PRODUCT>();
            }
            return null;
        }

        // get all node on branch PRODUCT
        private static async Task<Dictionary<string, PRODUCT>> getEntireOnBranch(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<Dictionary<string, PRODUCT>>();
            }
            return null;
        }


        //get list PRODUCT
        public static async Task<List<PRODUCT>> getEntire()
        {
            List<PRODUCT> listOfFirebase = new List<PRODUCT>();
            Dictionary<string, PRODUCT> listData = await getEntireOnBranch("Database/Dish");
            try
            {
                // convert from Dictionary to list 
                if (listData != null)
                {
                    foreach (var itemData in listData)
                    {
                        PRODUCT itemOfFirebase = itemData.Value;
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
        public static async Task<List<PRODUCT>> getEntireNotSync(List<PRODUCT> listOfSql)
        {
            List<PRODUCT> listNotSync = new List<PRODUCT>();
            Dictionary<string, PRODUCT> listData = await getEntireOnBranch("Database/Dish");
            try
            {

                foreach (PRODUCT itemOfSql in listOfSql)
                {
                    PRODUCT itemOfFirebase = await getOne("Database/Dish/" + itemOfSql.ID_PRODUCT.ToString() + "/");
                    if (itemOfFirebase != null)
                    {
                        if (itemOfFirebase.ID_PRODUCT != itemOfSql.ID_PRODUCT
                        || itemOfFirebase.ID_CATEGORY != itemOfSql.ID_CATEGORY
                        || itemOfFirebase.NAME_PRODUCT_EN != itemOfSql.NAME_PRODUCT_EN
                        || itemOfFirebase.NAME_PRODUCT_VN != itemOfSql.NAME_PRODUCT_VN
                        || itemOfFirebase.PRICE_PRODUCT != itemOfSql.PRICE_PRODUCT
                        || itemOfFirebase.IMAGE_PRODUCT != itemOfSql.IMAGE_PRODUCT
                        )
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
        public static async Task<bool> updateToFirebaseAsync(List<PRODUCT> listOfSql)
        {

            try
            {

                await ConnectFireBase.FirebaseDeleteData("Database/Dish");

                foreach (PRODUCT itemOfSql in listOfSql)
                {
                    await ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Dish/" + itemOfSql.ID_PRODUCT.ToString() + "/");
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
