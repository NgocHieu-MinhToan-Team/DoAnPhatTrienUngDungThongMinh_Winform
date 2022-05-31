using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DTO_PPL;
using DAL_PPL;
using FireBase_PPL;

namespace BLL_PPL
{
    public class BLL_Synchronized
    {
        public BLL_Synchronized() { }
        #region Category
        // pull data from firebase
        public static async Task<List<CATEGORY>> getCategoriesFromFireBase()
        {
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Category.getEntire();
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }
        // pull and compare 
        public static async Task<List<CATEGORY>> getCategoriesNotSync()
        {
            List<CATEGORY> list = DAL_Category.getCategories();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Category.getEntireNotSync(list);
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }

        // sync from sql to firebase
        public  static async Task<bool> updateCategoriesToFirebaseAsync()
        {
            List<CATEGORY> list = DAL_Category.getCategories();
            //check connect to firebase
            var client =  ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                bool result = await FB_Category.updateToFirebaseAsync(list);
                return result;
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }

        #endregion
        #region Dish
        // pull data from firebase
        public static async Task<List<PRODUCT>> getProductsFromFireBase()
        {
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Product.getEntire();
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }
        // pull and compare 
        public static async Task<List<PRODUCT>> getProductsNotSync()
        {
            List<PRODUCT> list = DAL_Product.getProducts();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Product.getEntireNotSync(list);
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }


        // sync from sql to firebase
        public static async Task<bool> updateProductsToFirebaseAsync()
        {
            List<PRODUCT> list = DAL_Product.getProducts();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                bool result = await FB_Product.updateToFirebaseAsync(list);
                return result;
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }
        #endregion
        #region Receipt
        // pull data from firebase
        public static async Task<List<RECEIPT_FULL>> getReceiptsFromFireBase()
        {
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Receipt.getEntire();
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }
        // pull and compare 
        public static async Task<List<RECEIPT_FULL>> getReceiptsNotSync()
        {
            List<RECEIPT_FULL> list =DAL_Receipt.getReceipts();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Receipt.getEntireNotSync(list);
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }

        // sync from sql to firebase
        public static async Task<bool> updateReceiptsFromFirebaseAsync()
        {
            List<RECEIPT_FULL> list = DAL_Receipt.getReceipts();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                bool result = await FB_Receipt.updateFromFirebaseAsync(list);
                return result;
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }

        public static async Task<bool> updateReceiptsToFirebaseAsync()
        {
            List<RECEIPT_FULL> list = DAL_Receipt.getReceipts();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                bool result = await FB_Receipt.updateToFirebaseAsync(list);
                return result;
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }

        #endregion
        #region Customer
        // pull data from firebase
        public static async Task<List<Customer>> getCustomersFromFireBase()
        {
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Customer.getEntire();
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }
        // pull and compare 
        public static async Task<List<Customer>> getCustomersNotSync()
        {
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Customer.getEntireNotSync();
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }

        // sync from sql to firebase
        public static async Task<bool> updateCustomersFromFirebaseAsync()
        {
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                
                if(await FB_Customer.updateFromFirebaseAsync())
                    return true;
                else
                {
                    MessageBox.Show("No data changed from firebase !");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }

        public static async Task<bool> updateCustomersToFirebaseAsync()
        {
            List<CUSTOMER> list = DAL_Customer.getCustomers();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                bool result = await FB_Customer.updateToFirebaseAsync(list);
                return result;
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }

        #endregion
        #region News
        public static async Task<bool> updateNewsToFirebaseAsync(string ID_PROMOTION)
        {
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                bool result = await FB_News.updateToFirebaseAsync(ID_PROMOTION);
                return result;
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }
        #endregion
        #region Voucher
        public static async Task<bool> updateVoucherToFirebaseAsync(string ID_PROMOTION)
        {
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                bool result = await FB_Voucher.updateToFirebaseAsync(ID_PROMOTION);
                return result;
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }
        #endregion
        #region Method
        public static async Task<bool> updateMethodToFirebaseAsync()
        {
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                bool result = await FB_Voucher.updateMethodToFirebaseAsync();
                return result;
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }
        #endregion
    }
}
