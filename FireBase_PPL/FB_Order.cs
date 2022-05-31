using DTO_PPL;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireBase_PPL
{
    public class FB_Order
    {
        //get state connect firebase
        static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();

        //get one Order
        public static async Task<Order> getOne(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<Order>();
            }
            return null;
        }

        // get all node on branch Order
        private static async Task<Dictionary<string, Dictionary<string, Detail_Order>>> getEntireOnBranch(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<Dictionary<string, Dictionary<string, Detail_Order>>>();
            }
            return null;
        }


        //get list Order
        public static async Task<List<RECEIPT>> getEntire()
        {
            List<RECEIPT> listOfReceipt = new List<RECEIPT>();
            Dictionary<string, Dictionary<string,Detail_Order>> listData = await getEntireOnBranch("Database/Order");
            try
            {
                // convert from Dictionary to list 
                if (listData != null)
                {
                    foreach (var itemData in listData)
                    {
                       
                        //Order itemOrder = itemData.Value;
                        //Dictionary<string, Detail> detail = itemOrder.list_detail ;
                        //foreach(var itemDetail in detail)
                        //{
                        //    Detail detail_order = itemDetail.Value;
                        //    foreach(var order in detail_order.list_order)
                        //    {
                        //        Detail_Order dt_order = order.Value;
                        //    }
                            
                        //}
                        //RECEIPT itemReceipt = new RECEIPT();
                        //// get id customer 
                        //itemReceipt.ID_CUSTOMER = itemData.Key;
                        //foreach(var itemDetailOrder in itemOrder.)
                        //{
                        //    itemDetailOrder.
                        //}
                        //itemReceipt.ID_METHOD = "";
                        //itemReceipt.ID_RECEIPT = "";
                        //itemReceipt.ID_VOUCHER = "";
                        //itemReceipt.DATE_CREATE = "";
                        //itemReceipt.TOTAL_PRODUCT = "";
                        //itemReceipt.TOTAL_PRICE = "";
                        //itemReceipt.POINT = "";
                        //itemReceipt.STATE_RECEIPT = "";
                        //listOfReceipt.Add(itemOfFirebase);
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return listOfReceipt;

        }

        // get categories that was not synchronized 
        //public static async Task<List<Order>> getEntireNotSync(List<Order> listOfSql)
        //{
        //    List<Order> listNotSync = new List<Order>();
        //    Dictionary<string, Order> listData = await getEntireOnBranch("Database/Order");
        //    try
        //    {

        //        foreach (Order itemOfSql in listOfSql)
        //        {
        //            Order itemOfFirebase = await getOne("Database/Order/" + itemOfSql.ID_Order.ToString() + "/");
        //            if (itemOfFirebase != null)
        //            {
        //                if (itemOfFirebase.GROUP_Order != itemOfSql.GROUP_Order
        //                || itemOfFirebase.NAME_Order != itemOfSql.NAME_Order)
        //                {
        //                    listNotSync.Add(itemOfSql);
        //                }
        //            }
        //            else
        //            {
        //                listNotSync.Add(itemOfSql);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return null;
        //    }
        //    return listNotSync;

        //}
        // update data on firebase 

    }
}
