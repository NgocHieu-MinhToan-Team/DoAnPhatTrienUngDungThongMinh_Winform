using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
// lib firebase 
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FireBase_PPL
{
    public class FB_Receipt
    {
        // get client firebase
        //static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();
        public static IFirebaseClient CreateFirebaseClient()
        {

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "zYmLpaTpZnly0nflP3EpvVK0y53vxFXpiKR3UsG8",
                BasePath = "https://dbpepperlunch-default-rtdb.asia-southeast1.firebasedatabase.app/"
            };
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            return client;
        }
        public static async Task<RECEIPT> getReceipt(string rootName)
        {
            IFirebaseClient client = CreateFirebaseClient();
             
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<RECEIPT>();
            }
            return null;
        }

        // get list thong tin khoa
        //public static async Task<List<RECEIPT>> getListReceipt(string rootName)
        //{
        //    IFirebaseClient client = CreateFirebaseClient();
        //    List<RECEIPT> list = new List<RECEIPT>();
        //    bool reader = true;
        //    while (reader)
        //    {
        //        try
        //        {   
        //            RECEIPT item = await getReceipt(client,rootName);
        //            if (item == null)
        //            {
        //                reader = false;
        //                break;
        //            }
        //            list.Add(item);
        //        }
        //        catch (Exception ex)
        //        {
        //            reader = false;
        //        }
        //    }
        //    return list;

        //}
        //public static async void FirebaseInsertData(IFirebaseClient client, object data, string rootName)
        //{
        //    if (client != null)
        //    {
        //        await client.SetAsync(rootName, data);
        //    }
        //}
        //public static async void FirebaseDeleteData(IFirebaseClient client, string rootName)
        //{
        //    if (client != null)
        //    {
        //        await client.DeleteAsync(rootName);
        //    }
        //}
        //public static async void FirebaseUpdateData(IFirebaseClient client, object
        //data, string rootName)
        //{
        //    if (client != null)
        //    {
        //        await client.UpdateAsync(rootName, data);
        //    }
        //}

    }
}
