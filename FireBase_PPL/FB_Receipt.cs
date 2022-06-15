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
        public FB_Receipt() { }

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

        public static async Task<List<RECEIPT>> getEntireNotSync()
        {
            // list new 
            List<RECEIPT> listNotSync = new List<RECEIPT>();
            List<RECEIPT> listOfFirebase = await getEntire();// get entire fb
            List<RECEIPT> listOfSql = DAL_Receipt.getList();// get entire sql
            try
            {
                // loop through list on firebase
                foreach (RECEIPT itemOfFirebase in listOfFirebase)
                {
                    // check exits 
                    RECEIPT isExist = listOfSql.SingleOrDefault(t => t.ID_RECEIPT == itemOfFirebase.ID_RECEIPT);
                    // if not exist => add to list
                    if (isExist == null && itemOfFirebase.STATE_RECEIPT==0)
                    {
                        listNotSync.Add(itemOfFirebase);
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
        public static bool isEqual(RECEIPT SQL, RECEIPT FB)
        {
            try
            {
                // parse 
                FB.DATE_CREATE.ToString().Trim().Replace('/', '-');
                FB.DATE_CREATE.ToString().Replace(' ', 'T');
                // case : Customer update infomation 
                if (SQL.ID_RECEIPT == FB.ID_RECEIPT)
                {
                    // check change of customer
                    if (SQL.ID_VOUCHER == FB.ID_VOUCHER &&
                        SQL.ID_CUSTOMER == FB.ID_CUSTOMER &&
                        SQL.DATE_CREATE.Value.Date == DateTime.Parse(FB.DATE_CREATE.ToString()).Date &&
                        SQL.ID_METHOD == FB.ID_METHOD &&
                        SQL.TOTAL_PRODUCT == FB.TOTAL_PRODUCT &&
                        SQL.TOTAL_PRICE == FB.TOTAL_PRICE &&
                        SQL.POINT == FB.POINT &&
                        SQL.ADDRESS_RECEIPT == FB.ADDRESS_RECEIPT &&
                        SQL.STATE_RECEIPT == FB.STATE_RECEIPT)
                    {
                        // no change
                        return true;
                    }
                    else
                    {
                        // update 
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                Console.WriteLine("input  null");
                return false;
            }
        }

        public static async Task<bool> updateEntireReceiptFromFirebase(int status)
        {
            try
            {
                List<RECEIPT> list = await getEntireNotSync();
                if (list.Count == 0)
                {
                    return false;
                }
                // insert receipt
                foreach (RECEIPT item in list)
                {
                    if (!await updateReceiptFromFirebase(item, status))
                    {
                        return false;
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static async Task<bool> updateReceiptFromFirebase(RECEIPT receipt,int status)
        {
            try
            {
                if (!await checkInventory(receipt))
                {
                    return false;
                }
                else
                {
                    await updateInventory(receipt);
                }
                // get all detail 
                List<DETAIL_RECEIPT> listAllDetail = await getDetailReceiptFromFirebase();
                // insert receipt
                    // if not  exist in sql
                if (!isExistReceipt(receipt))
                {
                    // insert receipt to sql
                    DAL_Receipt.insertReceipt(receipt,status);
                    // insert detail receipt by idReceipt  to sql
                    List<DETAIL_RECEIPT> listDetail = listAllDetail.Where(t => t.ID_RECEIPT == receipt.ID_RECEIPT).ToList();
                    foreach (DETAIL_RECEIPT detail in listDetail)
                    {
                        DAL_Receipt.insertDetailReceipt(detail);
                    }
                    // update state to firebase
                    await updateStatusReceipt(receipt, status);
                }
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private static async Task<bool> checkInventory(RECEIPT receipt)
        {
            List<DETAIL_RECEIPT> listAllDetail = await getDetailReceiptFromFirebase();
            List<DETAIL_RECEIPT> listDetail = listAllDetail.Where(t => t.ID_RECEIPT == receipt.ID_RECEIPT).ToList();
            foreach(DETAIL_RECEIPT item in listDetail)
            {

                // get list recipe 
                foreach(DETAIL_PRODUCT recipe in DAL_Recipe.getList(item.ID_PRODUCT))
                {
                    // get inventory by Id food
                    int inventory = (int)DAL_Ingredient.getList().SingleOrDefault(t => t.ID_INGREDIENT == recipe.ID_INGREDIENT).INVENTORY;
                    // 
                    int curentWeight = (int)(recipe.WEIGHT_DETAIL * item.QUANTITY);
                    // curentWeight exceeded inventory
                    if (inventory <= curentWeight)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static async Task<bool> updateInventory(RECEIPT receipt)
        {
            List<DETAIL_RECEIPT> listAllDetail = await getDetailReceiptFromFirebase();
            List<DETAIL_RECEIPT> listDetail = listAllDetail.Where(t => t.ID_RECEIPT == receipt.ID_RECEIPT).ToList();
            foreach (DETAIL_RECEIPT item in listDetail)
            {

                // get list recipe 
                foreach (DETAIL_PRODUCT recipe in DAL_Recipe.getList(item.ID_PRODUCT))
                {
                    // get inventory by Id food
                    int inventory = (int)DAL_Ingredient.getList().SingleOrDefault(t => t.ID_INGREDIENT == recipe.ID_INGREDIENT).INVENTORY;
                    // 
                    int curentWeight = (int)(recipe.WEIGHT_DETAIL * item.QUANTITY);
                    // curentWeight exceeded inventory
                    if (inventory <= curentWeight)
                    {
                        return false;
                    }
                    else
                    {
                        // update inventory
                        DAL_Ingredient.update(recipe.ID_INGREDIENT, curentWeight);
                    }
                }
            }
            return true;
        }


        public static async Task<bool> updateStatusReceipt(RECEIPT receipt,int status)
        {
            try
            {
                // update state to firebase
                string rootName = "Database/Order/" + receipt.ID_CUSTOMER + "/" + receipt.ID_RECEIPT + "/status";
                await ConnectFireBase.FirebaseInsertData(status, rootName);
                // update state to sql
                DAL_Receipt.updateStateReceipt(receipt.ID_RECEIPT,status);
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // detail receipt
        public static async Task<bool> updateDetailReceiptFromFirebase()
        {
            try
            {
                List<DETAIL_RECEIPT> listDetail = await getDetailReceiptFromFirebase();
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

        // check exist
        public static bool isExistReceipt(RECEIPT obj)
        {
            bool rs = DAL_Receipt.getList().Any(t => t.ID_RECEIPT == obj.ID_RECEIPT);
            return rs;
        }

    }
}
