using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_Recipe
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_Recipe() { }
        // get data just include flag = 0 : not delete
        public static List<DETAIL_PRODUCT> getList(string ID_PRODUCT)
        {
            return db.DETAIL_PRODUCTs.Where(t=>t.FLAG_DEL==0 && t.ID_PRODUCT==ID_PRODUCT).ToList();
        }

        public static List<RECIPE_JOIN> getRecipeJoin(string ID_PRODUCT)
        {
            List<RECIPE_JOIN> list = db.RECIPE_JOINs.Where(t => t.FLAG_DEL == 0 && t.ID_PRODUCT == ID_PRODUCT).ToList();
            return list;
        }



        public static bool add(DETAIL_PRODUCT data)
        {
            try
            {
                data.FLAG_DEL = 0;
                db.DETAIL_PRODUCTs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool remove(DETAIL_PRODUCT data)
        {
            try
            {
                DETAIL_PRODUCT itemDelete = db.DETAIL_PRODUCTs.SingleOrDefault(t => t.ID_DETAIL == data.ID_DETAIL);
                db.DETAIL_PRODUCTs.DeleteOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool update(DETAIL_PRODUCT data)
        {
            try
            {
                DETAIL_PRODUCT itemUpdate = db.DETAIL_PRODUCTs.SingleOrDefault(t => t.ID_DETAIL == data.ID_DETAIL);
                itemUpdate.ID_PRODUCT = data.ID_PRODUCT;
                itemUpdate.ID_INGREDIENT = data.ID_INGREDIENT;
                itemUpdate.WEIGHT_DETAIL = data.WEIGHT_DETAIL;
                itemUpdate.FLAG_DEL = 0;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
