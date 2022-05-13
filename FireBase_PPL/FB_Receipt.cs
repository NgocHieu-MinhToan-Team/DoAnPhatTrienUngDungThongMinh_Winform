using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_PPL;
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
        
        public static async Task<RECEIPT> getReceipt(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetTaskAsync(rootName);
                return response.ResultAs<RECEIPT>();
            }
            return null;
        }

        public static async Task<Dictionary<string, List<RECEIPT>>> getID(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetTaskAsync(rootName);
                Dictionary<string, List<RECEIPT>> data = response.ResultAs<Dictionary<string, List<RECEIPT>>>();
                return data;
            }
            return null;
        }

        //get list Receipts
        //public static async Task<List<RECEIPT>> getListReceipt(string rootName)
        //{
        //    List<RECEIPT> list = new List<RECEIPT>();
        //    bool reader = true;
        //    while (reader)
        //    {
        //        try
        //        {
        //            // 
        //            var child = await getID(rootName);

        //            if (child == null)
        //            {
        //                reader = false;
        //                break;
        //            }
        //            else
        //            {
        //                RECEIPT item = await getReceipt(rootName + "/" +child.ToString());
        //                if (item == null)
        //                {
        //                    break;
        //                }
        //                list.Add(item);

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            reader = false;
        //        }
        //    }
        //    return list;

        //}
        public static async Task<List<RECEIPT>> getListReceipt(string rootName)
        {
            List<RECEIPT> list = new List<RECEIPT>();
            try
            {
                // 
                Dictionary<string, List<RECEIPT>> listChildOfParent=await getID(rootName);
                foreach(var child in listChildOfParent)
                {
                    //RECEIPT receipt = new RECEIPT();
                    //receipt = child.Value;
                    //list.Add(receipt);
                }
                return list;
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }

        }

    }
}
