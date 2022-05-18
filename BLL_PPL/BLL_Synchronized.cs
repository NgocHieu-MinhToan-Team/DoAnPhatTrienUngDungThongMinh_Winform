﻿using System;
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
            var client = ConnectFireBase.CreateFirebaseClient();
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
    }
}
