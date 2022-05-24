using DTO_PPL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PPL
{
    public class DAL_Promotion
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();

        public DAL_Promotion() { }

        public static List<PROMOTION> getPromotions()
        {
            var listAnonymous = from pro in db.PROMOTIONs
                                where pro.FLAG_DEL==0
                                select new
                                {
                                    ID_PROMOTION=pro.ID_PROMOTION,
                                    NAME_PROMOTION= pro.NAME_PROMOTION,
                                    USERNAME_STAFF= pro.USERNAME_STAFF,
                                    DATE_CREATE=pro.DATE_CREATE,
                                    DATE_START=pro.DATE_START,
                                    DATE_END=pro.DATE_END,
                                };
            List<PROMOTION> list = new List<PROMOTION>();
            foreach (var itemAnonymous in listAnonymous)
            {
                PROMOTION item = new PROMOTION();
                item.ID_PROMOTION = itemAnonymous.ID_PROMOTION;
                item.NAME_PROMOTION = itemAnonymous.NAME_PROMOTION;
                item.USERNAME_STAFF = itemAnonymous.USERNAME_STAFF;
                item.DATE_CREATE = itemAnonymous.DATE_CREATE;
                item.DATE_START = itemAnonymous.DATE_START;
                item.DATE_END = itemAnonymous.DATE_END;
                list.Add(item);
            }
            return list;
        }


        public static bool insertPromotion(PROMOTION data)
        {
            try
            {
                data.FLAG_DEL = 0;
                db.PROMOTIONs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deletePromotion(PROMOTION data)
        {
            try
            {
                PROMOTION itemDelete = db.PROMOTIONs.SingleOrDefault(t => t.ID_PROMOTION == data.ID_PROMOTION);
                itemDelete.FLAG_DEL = 1;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updatePromotion(PROMOTION data)
        {
            try
            {
                PROMOTION itemUpdate = db.PROMOTIONs.SingleOrDefault(t => t.ID_PROMOTION == data.ID_PROMOTION);
                itemUpdate.NAME_PROMOTION = data.NAME_PROMOTION;
                itemUpdate.USERNAME_STAFF = data.USERNAME_STAFF;
                itemUpdate.DATE_CREATE = data.DATE_CREATE;
                itemUpdate.DATE_START = data.DATE_START;
                itemUpdate.DATE_END = data.DATE_END;
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
