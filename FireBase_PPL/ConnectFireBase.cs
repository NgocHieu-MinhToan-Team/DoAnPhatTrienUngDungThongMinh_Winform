using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// lib firebase 
using FireSharp.Config;
using FireSharp.Interfaces;


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
    }
}
