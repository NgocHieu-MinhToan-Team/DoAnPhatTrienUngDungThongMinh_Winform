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
        public static List<DETAIL_PRODUCT> getList()
        {
            var listAnonymous = from recipe in db.DETAIL_PRODUCTs
                                where recipe.FLAG_DEL == 0
                                select new
                                {
                                    ID_DETAIL = recipe.ID_DETAIL,
                                    ID_PRODUCT = recipe.ID_PRODUCT,
                                    ID_INGREDIENT = recipe.ID_INGREDIENT,
                                    WEIGHT_DETAIL = recipe.WEIGHT_DETAIL,
                                };
            List<DETAIL_PRODUCT> list = new List<DETAIL_PRODUCT>();
            foreach (var itemAnonymous in listAnonymous)
            {
                DETAIL_PRODUCT item = new DETAIL_PRODUCT();
                item.ID_DETAIL = itemAnonymous.ID_DETAIL;
                item.ID_PRODUCT = itemAnonymous.ID_PRODUCT;
                item.ID_INGREDIENT = itemAnonymous.ID_INGREDIENT;
                item.WEIGHT_DETAIL = itemAnonymous.WEIGHT_DETAIL;
                list.Add(item);
            }
            return list;
        }

        public static List<RECIPE_JOIN> getRecipeJoin()
        {
            List<RECIPE_JOIN> list = db.RECIPE_JOINs.Select(t=>t).ToList<RECIPE_JOIN>();
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
                itemDelete.FLAG_DEL = 1;
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
