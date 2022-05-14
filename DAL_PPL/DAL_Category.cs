using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;
using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_Category
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_Category() { }
        public static List<CATEGORY> getCategories()
        {
            var listAnonymous = from cate in db.CATEGORies
                                where cate.FLAG_DEL == 0
                                select new
                                {
                                    ID_CATEGORY=cate.ID_CATEGORY,
                                    NAME_CATEGORY=cate.NAME_CATEGORY,
                                    GROUP_CATEGORY = cate.GROUP_CATEGORY,
                                    FLAG_DEL=cate.FLAG_DEL
                                };
            List<CATEGORY> list = new List<CATEGORY>();
            foreach (var itemAnonymous in listAnonymous)
            {
                CATEGORY item = new CATEGORY();
                item.ID_CATEGORY = itemAnonymous.ID_CATEGORY;
                item.NAME_CATEGORY = itemAnonymous.NAME_CATEGORY;
                item.GROUP_CATEGORY = itemAnonymous.GROUP_CATEGORY;
                list.Add(item);
            }
            return list;
        }

        public static bool insertCategories(CATEGORY data)
        {
            try
            {
                db.CATEGORies.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool deleteCategories(CATEGORY data)
        {
            try
            {
                CATEGORY itemDelete = db.CATEGORies.SingleOrDefault(t => t.ID_CATEGORY == data.ID_CATEGORY);
                itemDelete.FLAG_DEL = 1;
                db.SubmitChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public static bool updateCategories(CATEGORY data)
        {
            try
            {
                CATEGORY itemUpdate = db.CATEGORies.SingleOrDefault(t => t.ID_CATEGORY == data.ID_CATEGORY);
                itemUpdate.GROUP_CATEGORY = data.GROUP_CATEGORY;
                itemUpdate.NAME_CATEGORY = data.NAME_CATEGORY;
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
