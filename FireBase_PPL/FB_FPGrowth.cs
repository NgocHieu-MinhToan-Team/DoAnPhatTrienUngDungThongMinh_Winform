using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
using FP_Growth;
using DAL_PPL;

namespace FireBase_PPL
{
    public class FB_FPGrowth
    {

        public FB_FPGrowth() { }
        public static async Task<bool> pushToFirebaseAsync(double minsup,double confidence,int numberRecord)
        {

            try
            {
                List<FPGrowth_Item> list = TrainModel.Load(minsup, confidence);
                List<PRODUCT> listPro = DAL_Product.getProducts();
                List<CATEGORY> listCate = DAL_Category.getCategories();
                await ConnectFireBase.FirebaseDeleteData("Database/FPGrowth");
                if (numberRecord > list.Count)
                    return false;
                for(int i = 0; i < numberRecord; i++)
                {
                    string[] ID_PRODUCTs = list[i].detail.Split(',');
                    //await ConnectFireBase.FirebaseInsertData(null, "Database/ThuatToan/" + i.ToString() + "/");
                    CATEGORY cate = listCate[0];
                    await ConnectFireBase.FirebaseInsertData(cate, "Database/FPGrowth/" + cate.ID_CATEGORY.ToString()+i + "/");
                    foreach (string id in ID_PRODUCTs)
                    {
                        // get product
                        PRODUCT pro = listPro.SingleOrDefault(t => t.ID_PRODUCT == id);
                        //await ConnectFireBase.FirebaseInsertData(pro, "Database/ThuatToan/" + i.ToString() + "/" + pro.ID_PRODUCT + "/");

                        await ConnectFireBase.FirebaseInsertData(pro, "Database/FPGrowth/" + cate.ID_CATEGORY.ToString()+i + "/Dishes/" + pro.ID_PRODUCT + "/");
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
