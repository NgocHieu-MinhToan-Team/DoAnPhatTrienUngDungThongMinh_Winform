using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_PPL;
using DAL_PPL;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FireBase_PPL
{
    public class FB_Customer
    {
        //get Client from  firebase
        static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();
        
        public static async Task<CUSTOMER> getOne(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<CUSTOMER>();
            }
            return null;
        }


        // get all node on branch Category
        private static async Task<Dictionary<string, CUSTOMER>> getEntireOnBranch(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<Dictionary<string, CUSTOMER>>();
            }
            return null;
        }


        //get list receipt
        public static async Task<List<CUSTOMER>> getEntire()
        {
            List<CUSTOMER> listOfFirebase = new List<CUSTOMER>();
            Dictionary<string, CUSTOMER> listData = await getEntireOnBranch("Database/Customer");
            try
            {
                // convert from Dictionary to list 
                if (listData != null)
                {
                    foreach (var itemData in listData)
                    {
                        CUSTOMER itemOfFirebase = itemData.Value;
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


        // get receipt that was not synchronized 
        public static async Task<List<CUSTOMER>> getEntireNotSync(List<CUSTOMER> listOfSql)
        {
            List<CUSTOMER> listNotSync = new List<CUSTOMER>();
            try
            {

                foreach (CUSTOMER itemOfSql in listOfSql)
                {
                    CUSTOMER itemOfFirebase = await getOne("Database/Customer/" + itemOfSql.ID_CUSTOMER.ToString() + "/");
                    if (itemOfFirebase != null)
                    {
                        //if (itemOfFirebase.GROUP_CATEGORY != itemOfSql.GROUP_CATEGORY
                        //|| itemOfFirebase.NAME_CATEGORY != itemOfSql.NAME_CATEGORY)
                        //{
                        //    listNotSync.Add(itemOfSql);
                        //}
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




        public static async Task<bool> updateFromFirebaseAsync(List<CUSTOMER> listOfSql)
        {

            try
            {
                //get all firebase
                Dictionary<string, CUSTOMER> listOfFirebase = await getEntireOnBranch("Database/Customer");
                foreach (var itemOfFirebase in listOfFirebase)
                {
                    CUSTOMER itemOfSql = listOfSql.SingleOrDefault(t => t.ID_CUSTOMER == itemOfFirebase.Value.ID_CUSTOMER);
                    if (itemOfSql != null && itemOfSql.TYPE_CUSTOMER != itemOfFirebase.Value.TYPE_CUSTOMER)
                    {
                        //update if exist and state not like
                        DAL_Customer.updateCustomer(itemOfFirebase.Value);
                    }
                    else
                    {
                        // insert 
                        DAL_Customer.updateCustomer(itemOfFirebase.Value);
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

        public static async Task<bool> updateToFirebaseAsync(List<CUSTOMER> listOfSql)
        {

            try
            {

                await ConnectFireBase.FirebaseDeleteData("Database/Customer");

                foreach (CUSTOMER itemOfSql in listOfSql)
                {
                    await ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Customer/" + itemOfSql.ID_CUSTOMER.ToString() + "/");
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
