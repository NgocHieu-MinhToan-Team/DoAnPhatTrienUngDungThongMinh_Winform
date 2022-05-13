using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DAL_PPL;
using DTO_PPL;
using FireBase_PPL;
using FireSharp.Interfaces;

namespace BLL_PPL
{
    public class BLL_Category
    {
        public BLL_Category() { }
        public  static List<CATEGORY> getCategories()
        {
            return DAL_Category.getCategories();
        }
        //gui du lieu len firebase
        public static bool insertCategoriesToFirebase()
        {
            try
            {
                List<CATEGORY> listFromSql = DAL_Category.getCategories();//tao doi tuong
                IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();//tao client de ket noi
                int i = 1;
                foreach (CATEGORY item in listFromSql)
                {
                    // Thêm nút làm ID trước vd "Database/.../" + ID 
                    ConnectFireBase.FirebaseInsertData(client, item, "Database/Category/"+ i.ToString());
                    i++;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


    }
}
