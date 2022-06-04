using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_PPL;
using DAL_PPL;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
// lib firebase 

namespace FireBase_PPL
{
    public class FB_Receipt
    {
        //get Client from  firebase
        static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();
        
        public static async Task<RECEIPT_FULL> getOne(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<RECEIPT_FULL>();
            }
            return null;
        }


        // get all node on branch Category
        private static async Task<Dictionary<string, RECEIPT_FULL>> getEntireOnBranch(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<Dictionary<string, RECEIPT_FULL>>();
            }
            return null;
        }


        //get list receipt
        public static async Task<List<RECEIPT_FULL>> getEntire()
        {
            List<RECEIPT_FULL> listOfFirebase = new List<RECEIPT_FULL>();
            Dictionary<string, RECEIPT_FULL> listData = await getEntireOnBranch("Database/Receipt");
            try
            {
                // convert from Dictionary to list 
                if (listData != null)
                {
                    foreach (var itemData in listData)
                    {
                        RECEIPT_FULL itemOfFirebase = itemData.Value;
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
        public static async Task<List<RECEIPT_FULL>> getEntireNotSync(List<RECEIPT_FULL> listOfSql)
        {
            List<RECEIPT_FULL> listNotSync = new List<RECEIPT_FULL>();
            Dictionary<string, RECEIPT_FULL> listData = await getEntireOnBranch("Database/Receipt");
            try
            {

                foreach (RECEIPT_FULL itemOfSql in listOfSql)
                {
                    RECEIPT_FULL itemOfFirebase = await getOne("Database/Receipt/" + itemOfSql.ID_RECEIPT.ToString() + "/");
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



        //
        public static async Task<bool> updateFromFirebaseAsync(List<RECEIPT_FULL> listOfSql)
        {

            try
            {
                //get all firebase
                Dictionary<string, RECEIPT_FULL> listOfFirebase = await getEntireOnBranch("Database/Receipt");
                foreach (var itemOfFirebase in listOfFirebase)
                {
                    RECEIPT_FULL itemOfSql = listOfSql.SingleOrDefault(t => t.ID_RECEIPT == itemOfFirebase.Value.ID_RECEIPT);
                    if(itemOfSql!=null && itemOfSql.STATE_RECEIPT != itemOfFirebase.Value.STATE_RECEIPT)
                    {
                        //update if exist and state not like
                        DAL_Receipt.updateReceipt(itemOfFirebase.Value);
                    }
                    else
                    {
                        // insert 
                        DAL_Receipt.insertReceipt(itemOfFirebase.Value);
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

        public static async Task<bool> updateToFirebaseAsync(List<RECEIPT_FULL> listOfSql)
        {

            try
            {

                await ConnectFireBase.FirebaseDeleteData("Database/Receipt");

                foreach (RECEIPT_FULL itemOfSql in listOfSql)
                {
                    await ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Receipt/" + itemOfSql.ID_RECEIPT.ToString() + "/");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public static async Task<bool> updateStatusReceiptAsync()
        {
            try
            {
                return await FB_Order.updateStatusReceipt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static async Task<List<RECEIPT>> getDataFromFirebaseAsync()
        {
            try
            {
                return await FB_Order.getEntire();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static async Task<bool> updateReceiptFromFirebase()
        {
            try
            {
                return await FB_Order.updateReceiptFromFirebase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
