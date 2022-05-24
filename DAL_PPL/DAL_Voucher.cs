using DTO_PPL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PPL
{
    public class DAL_Voucher
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_Voucher() { }
        // get data just include flag = 0 : not delete
        public static List<VOUCHER> getVouchers(string ID_PROMOTION)
        {
            var listAnonymous = from vou in db.VOUCHERs
                                where vou.FLAG_DEL == 0 && vou.ID_PROMOTION == ID_PROMOTION
                                select new
                                {
                                    ID_VOUCHER = vou.ID_VOUCHER,
                                    USERNAME_STAFF = vou.USERNAME_STAFF,
                                    ID_PROMOTION = vou.ID_PROMOTION,
                                    DATE_CREATE = vou.DATE_CREATE,
                                    DATE_START = vou.DATE_START,
                                    DATE_END = vou.DATE_END,
                                    TYPE_REDUCTION = vou.TYPE_REDUCTION,
                                    TYPE_CUSTOMER = vou.TYPE_CUSTOMER,
                                    PERCENT_REDUCTION = vou.PERCENT_REDUCTION,
                                    AMOUNT_REDUCTION = vou.AMOUNT_REDUCTION,
                                    QUANTITY_VOUCHER = vou.QUANTITY_VOUCHER,
                                };
            List<VOUCHER> list = new List<VOUCHER>();
            foreach (var itemAnonymous in listAnonymous)
            {
                VOUCHER item = new VOUCHER();
                item.ID_VOUCHER = itemAnonymous.ID_VOUCHER;
                item.USERNAME_STAFF = itemAnonymous.USERNAME_STAFF;
                item.ID_PROMOTION = itemAnonymous.ID_PROMOTION;
                item.DATE_CREATE = itemAnonymous.DATE_CREATE;
                item.DATE_START = itemAnonymous.DATE_START;
                item.DATE_END = itemAnonymous.DATE_END;
                item.TYPE_REDUCTION = itemAnonymous.TYPE_REDUCTION;
                item.TYPE_CUSTOMER = itemAnonymous.TYPE_CUSTOMER;
                item.PERCENT_REDUCTION = itemAnonymous.PERCENT_REDUCTION;
                item.AMOUNT_REDUCTION = itemAnonymous.AMOUNT_REDUCTION;
                item.QUANTITY_VOUCHER = itemAnonymous.QUANTITY_VOUCHER;
                //item.FLAG_DEL = item.FLAG_DEL;
                list.Add(item);
            }
            return list;
        }

        public static bool insertVoucher(VOUCHER data)
        {
            try
            {
                data.FLAG_DEL = 0;
                db.VOUCHERs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool deleteVoucher(VOUCHER data)
        {
            try
            {
                VOUCHER itemDelete = db.VOUCHERs.SingleOrDefault(t => t.ID_VOUCHER == data.ID_VOUCHER);
                itemDelete.FLAG_DEL = 1;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updateVoucher(VOUCHER data)
        {
            try
            {
                VOUCHER itemUpdate = db.VOUCHERs.SingleOrDefault(t => t.ID_VOUCHER == data.ID_VOUCHER);
                itemUpdate.USERNAME_STAFF = data.USERNAME_STAFF;
                itemUpdate.ID_PROMOTION = data.ID_PROMOTION;
                itemUpdate.DATE_CREATE = data.DATE_CREATE;
                itemUpdate.DATE_START = data.DATE_START;
                itemUpdate.DATE_END = data.DATE_END;
                itemUpdate.TYPE_REDUCTION = data.TYPE_REDUCTION;
                itemUpdate.TYPE_CUSTOMER = data.TYPE_CUSTOMER;
                itemUpdate.PERCENT_REDUCTION = data.PERCENT_REDUCTION;
                itemUpdate.AMOUNT_REDUCTION = data.AMOUNT_REDUCTION;
                itemUpdate.QUANTITY_VOUCHER = data.QUANTITY_VOUCHER;
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
