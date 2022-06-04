using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
using DAL_PPL;
using FireSharp.Response;

namespace FireBase_PPL
{
    public class FB_News
    {
        //get state connect firebase
        static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();
        // update data on firebase 
        //
        public static async Task<bool> updateToFirebaseAsync(string ID_PROMOTION)
        {
            try
            {
                // get news by promotion
                List<NEW> listOfSql = DAL_NEW.getNews(ID_PROMOTION);
                // update news
                await ConnectFireBase.FirebaseDeleteData("Database/News");
                foreach (NEW itemOfSql in listOfSql)
                {
                    await ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/News/" + itemOfSql.ID_NEWS.ToString() + "/");
                    List<IMAGE_NEW> listOfImage = DAL_NEW.getImageNews(itemOfSql.ID_NEWS);
                    // add image into news
                    foreach (IMAGE_NEW itemOfImage in listOfImage)
                    {
                        await ConnectFireBase.FirebaseInsertData(itemOfImage, "Database/News/" + itemOfSql.ID_NEWS.ToString() + "/Image/" + itemOfImage.ID_IMAGE.ToString() + "/");
                    }
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
