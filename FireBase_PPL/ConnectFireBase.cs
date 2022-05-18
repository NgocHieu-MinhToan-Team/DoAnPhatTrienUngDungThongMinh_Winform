using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// lib firebase 
using FireSharp.Config;
using FireSharp.Interfaces;
using DTO_PPL;


namespace FireBase_PPL
{
    public class ConnectFireBase
    {
        public static IFirebaseClient CreateFirebaseClient()
        {

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "zYmLpaTpZnly0nflP3EpvVK0y53vxFXpiKR3UsG8",
                BasePath = "https://dbpepperlunch-default-rtdb.asia-southeast1.firebasedatabase.app"
            };
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            return client;
        }

        public static async void FirebaseInsertData(CATEGORY data, string rootName)
        {
            IFirebaseClient client = CreateFirebaseClient();
            try
            {
                if (client != null)
                {
                    await client.SetAsync(rootName, data);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        public static async void FirebaseDeleteData( string rootName)
        {
            IFirebaseClient client = CreateFirebaseClient();

            if (client != null)
            {
                await client.DeleteAsync(rootName);
            }
        }
        public static async void FirebaseUpdateData(object data, string rootName)
        {
            IFirebaseClient client = CreateFirebaseClient();

            if (client != null)
            {
                await client.UpdateAsync(rootName, data);
            }
        }
    }
}
