using DTO_PPL;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PPL;

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
            Dictionary<string, Dictionary<string, Detail_Order>> listData = await getEntireOnBranch("Database/Order");
            Order order = new Order();
            order.order = await getEntireOnBranch("Database/Order");
            try
            {
                // convert from Dictionary to list 
                if (order != null)
                {
                    foreach (var detail_item in order.order)
                    {
                        Dictionary<string, Detail_Order> detail_order = detail_item.Value;


                        foreach (var item_detail_order in detail_order)
                        {
                            RECEIPT itemReceipt = new RECEIPT();
                            // get id customer 
                            itemReceipt.ID_CUSTOMER = item_detail_order.Value.id_CUSTOMER;
                            itemReceipt.ID_METHOD = item_detail_order.Value.id_METHOD;
                            itemReceipt.ID_RECEIPT = item_detail_order.Key;
                            itemReceipt.ID_VOUCHER = item_detail_order.Value.id_VOUCHER;
                            itemReceipt.STATE_RECEIPT = item_detail_order.Value.status;
                            itemReceipt.TOTAL_PRICE = (int?)item_detail_order.Value.total_PAYMENT;
                            itemReceipt.ADDRESS_RECEIPT = item_detail_order.Value.address;
                            itemReceipt.DATE_CREATE = DateTime.Now;
                            Dictionary<string, Cart_Item> list_cart = item_detail_order.Value.list_CART;
                            int total = 0;
                            foreach (var item_cart_item in list_cart)
                            {
                                total += item_cart_item.Value.soluong;

                            }
                            itemReceipt.TOTAL_PRODUCT = total;
                            itemReceipt.POINT = (int?)item_detail_order.Value.total_PAYMENT;
                            itemReceipt.STATE_RECEIPT = item_detail_order.Value.status;

                            listOfReceipt.Add(itemReceipt);

                        }
                    }
                }
                return listOfReceipt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static async Task<bool> updateReceiptFromFirebase()
        {
            try
            {
                List<RECEIPT> list = await getEntire();
                List<DETAIL_RECEIPT> listDetail = await getDetailReceiptFromFirebase();
                foreach (RECEIPT item in list)
                {
                    // insert receipt to sql
                    DAL_Receipt.insertReceipt(item);
                    // update state to firebase
                    string rootName = "Database/Order/" + item.ID_CUSTOMER + "/" + item.ID_RECEIPT + "/status";
                    await ConnectFireBase.FirebaseInsertData(1, rootName);

                }
                // insert detail receipt sql
                foreach (DETAIL_RECEIPT detail in listDetail)
                {
                    DAL_Receipt.insertDetailReceipt(detail);
                }
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static async Task<bool> updateStatusReceipt()
        {
            try            {
                List<RECEIPT> list = await getEntire();

                List<DETAIL_RECEIPT> listDetail = await getDetailReceiptFromFirebase();
                foreach (RECEIPT item in list)
                {
                    // update state to firebase
                    string rootName = "Database/Order/" + item.ID_CUSTOMER + "/" + item.ID_RECEIPT + "/status";
                    await ConnectFireBase.FirebaseInsertData(2, rootName);

                }
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static async Task<List<DETAIL_RECEIPT>> getDetailReceiptFromFirebase()
        {
            List<DETAIL_RECEIPT> listOfDetailReceipt = new List<DETAIL_RECEIPT>();
            Dictionary<string, Dictionary<string, Detail_Order>> listData = await getEntireOnBranch("Database/Order");
            Order order = new Order();
            order.order = await getEntireOnBranch("Database/Order");
            try
            {
                // convert from Dictionary to list 
                if (order != null)
                {
                    foreach (var detail_item in order.order)
                    {
                        Dictionary<string, Detail_Order> detail_order = detail_item.Value;
                        foreach (var item_detail_order in detail_order)
                        {
                            Dictionary<string, Cart_Item> list_cart = item_detail_order.Value.list_CART;
                            foreach (var item_cart_item in list_cart)
                            {
                                DETAIL_RECEIPT item = new DETAIL_RECEIPT();
                                Product product = item_cart_item.Value.product;
                                string id = "";
                                id = product.id_PRODUCT + item_detail_order.Key;
                                item.ID_DETAIL_RECEIPT = id;
                                item.ID_RECEIPT = item_detail_order.Key;
                                item.ID_PRODUCT = product.id_PRODUCT;
                                item.PRICE = (int?)product.price_PRODUCT;
                                item.QUANTITY = item_cart_item.Value.soluong;
                                listOfDetailReceipt.Add(item);
                            }

                        }
                    }
                }
                return listOfDetailReceipt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //// genderate key sync 
        //public static List<DETAIL_RECEIPT> getListDetailReceipt_SYNC(List<DETAIL_RECEIPT> listOld)
        //{
        //    List<DETAIL_RECEIPT> listNew = new List<DETAIL_RECEIPT>();
        //    foreach(DETAIL_RECEIPT itemOld in listOld)
        //    {
        //        DETAIL_RECEIPT itemNew = new DETAIL_RECEIPT();
        //        itemNew.ID_DETAIL_RECEIPT = GeneralMethods.createID("CTHD");
        //        itemNew.ID_RECEIPT = itemOld.ID_RECEIPT;
        //        itemNew.ID_PRODUCT = itemOld.ID_PRODUCT;
        //        itemNew.PRICE = itemOld.PRICE;
        //        itemNew.QUANTITY = itemOld.QUANTITY;
        //        listNew.Add(itemNew);
        //    }
        //    return listNew;
        //}



    }
}
