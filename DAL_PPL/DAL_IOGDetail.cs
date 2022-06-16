using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_IOGDetail
    {
         RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_IOGDetail() { }
        public  List<DETAIL_IMPORT> getListByID(string ID_IOG)
        {
            return db.DETAIL_IMPORTs.Where(t => t.ID_IOG==ID_IOG).ToList();
        }

        public List<IOGDETAIL_JOIN> getListJoinByID(string ID_IOG)
        {
            return db.IOGDETAIL_JOINs.Where(t => t.ID_IOG == ID_IOG).ToList();
        }



        public  bool insert(DETAIL_IMPORT data)
        {
            try
            {
                db.DETAIL_IMPORTs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public  bool delete(string ID)
        {
            try
            {
                DETAIL_IMPORT itemDelete = db.DETAIL_IMPORTs.SingleOrDefault(t => t.ID_DETAIL_IOG == ID);
                db.DETAIL_IMPORTs.DeleteOnSubmit(itemDelete);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public  bool update(DETAIL_IMPORT data)
        {
            try
            {
                DETAIL_IMPORT item = db.DETAIL_IMPORTs.SingleOrDefault(t => t.ID_DETAIL_IOG == data.ID_DETAIL_IOG);
                item.PRICE = data.PRICE;
                item.QUANTITY = data.QUANTITY;
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
