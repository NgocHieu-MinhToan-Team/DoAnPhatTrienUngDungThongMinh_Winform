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
        // pull data from firebase
        public static async Task<List<CATEGORY>> getCategoriesFromFireBase()
        {
            List<CATEGORY> list = DAL_Category.getFullCategories();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Category.getListCategories(list);
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }

        public static async Task<List<CATEGORY>> getCategoriesNotSync()
        {
            List<CATEGORY> list = DAL_Category.getFullCategories();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //get data from firebase
                return await FB_Category.getCategoriesNotSync(list);
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return null;
            }
        }

        // sync from sql to firebase
        public static bool synchronizedCategoriesToFireBase()
        {
            List<CATEGORY> list = DAL_Category.getCategories();
            //check connect to firebase
            var client = ConnectFireBase.CreateFirebaseClient();
            if (client != null)
            {
                //sync here
                bool result = FB_Category.synchronizedCategoriesToFirebase(list);
                return result;
            }
            else
            {
                MessageBox.Show("Interet have a problem ? cannot retrieve data from firebase");
                return false;
            }
        }
    }
}
