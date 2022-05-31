using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
using DAL_PPL;

namespace FireBase_PPL
{
    public class FB_Voucher
    {

        //get state connect firebase
        static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();
        // update data on firebase 
        //
        public static async Task<bool> updateToFirebaseAsync(string ID_PROMOTION)
        {
            try
            {
                // get VOUCHER by promotion
                List<VOUCHER> listOfSql = DAL_Voucher.getVouchers(ID_PROMOTION);
                // update news
                await ConnectFireBase.FirebaseDeleteData("Database/Voucher");
                foreach (VOUCHER itemOfSql in listOfSql)
                {
                    await ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Voucher/" + itemOfSql.ID_VOUCHER.ToString() + "/");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;

        }

        public static async Task<bool> updateMethodToFirebaseAsync()
        {
            try
            {
                // get VOUCHER by promotion
                List<METHOD> listOfSql = DAL_Voucher.getMethods();
                // update news
                await ConnectFireBase.FirebaseDeleteData("Database/Method");
                foreach (METHOD itemOfSql in listOfSql)
                {
                    await ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Method/" + itemOfSql.ID_METHOD.ToString() + "/");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;

        }
    }
}
