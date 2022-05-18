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
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<RECEIPT>();
            }
            return null;
        }


        //get list Receipts
        public static async Task<List<RECEIPT>> getListReceipts(string rootName,List<RECEIPT> listOfSql)
        {
            List<RECEIPT> listOfFirebase = new List<RECEIPT>();
            try
            {
                foreach (RECEIPT itemOfSql in listOfSql)
                {
                    RECEIPT itemOfFirebase = await getReceipt(rootName + "/" + itemOfSql.ID_RECEIPT.ToString()+"/");
                    if (itemOfFirebase != null)
                    {
                        listOfFirebase.Add(itemOfFirebase);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return listOfFirebase;

        }
        

    }
}
