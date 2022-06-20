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

        public static List<IMPORT> getImportsByStatus(int status)
        {
            return db.IMPORTs.Where(t => t.FLAG_DEL == 0 && t.STATE_IMPORT == status).ToList();
        }

        public static List<IMPORT> getImportsByStatus(int status, string ID_SUPPLIER)
        {
            return db.IMPORTs.Where(t => t.FLAG_DEL == 0 && t.STATE_IMPORT == status && t.ID_SUPPLIER==ID_SUPPLIER).ToList();
        }
       

        public static bool insert(IMPORT data)
        {
            try
            {
                data.FLAG_DEL = 0;
                db.IMPORTs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool delete(string ID)
        {
            try
            {
                IMPORT itemDelete = db.IMPORTs.SingleOrDefault(t => t.ID_IOG == ID);
                db.IMPORTs.DeleteOnSubmit(itemDelete);
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

        public static bool updateNote(IMPORT data)
        {
            try
            {
                IMPORT item = db.IMPORTs.SingleOrDefault(t => t.ID_IOG == data.ID_IOG);
                item.NOTE = data.NOTE;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateTotalPrice(IMPORT data)
        {
            try
            {
                IMPORT item = db.IMPORTs.SingleOrDefault(t => t.ID_IOG == data.ID_IOG);
                // get detail import 
                List<DETAIL_IMPORT> listDetail = db.DETAIL_IMPORTs.Where(t => t.ID_IOG == item.ID_IOG).ToList();
                int? total = 0;
                foreach(DETAIL_IMPORT i in listDetail)
                {
                    total += (i.QUANTITY * i.PRICE);
                }
                item.TOTAL_PRICE = total;
                item.DATE_DELIVERY = DateTime.Now;
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
