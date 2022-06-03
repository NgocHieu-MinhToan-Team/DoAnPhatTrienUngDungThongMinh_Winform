using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_IOG
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_IOG() { }
        public static List<IMPORT> getList()
        {
            return db.IMPORTs.Where(t=>t.FLAG_DEL==0).ToList();
        }

        public static bool insert(IMPORT data)
        {
            try
            {
                db.IMPORTs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool delete(IMPORT data)
        {
            try
            {
                IMPORT itemDelete = db.IMPORTs.SingleOrDefault(t => t.ID_IOG == data.ID_IOG);
                itemDelete.FLAG_DEL = 1;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool update(IMPORT data)
        {
            try
            {
                IMPORT item = db.IMPORTs.SingleOrDefault(t => t.ID_IOG == data.ID_IOG);
                item.ID_SUPPLIER = data.ID_SUPPLIER;
                item.USERNAME_STAFF = data.USERNAME_STAFF;
                item.DATE_IOG = data.DATE_IOG;
                item.TOTAL_PRICE = data.TOTAL_PRICE;
                item.NOTE = data.NOTE;
                item.FLAG_DEL = 0;
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
