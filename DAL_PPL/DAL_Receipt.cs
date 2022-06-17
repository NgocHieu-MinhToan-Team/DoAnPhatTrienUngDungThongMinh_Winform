using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_Receipt
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_Receipt(){ }
        public static List<RECEIPT> getList()
        {
            return db.RECEIPTs.Select(t => t).ToList();
        }
        
        public static List<RECEIPT> getListForFPGrowth()
        {
            return db.RECEIPTs.Where(t => t.STATE_RECEIPT==3).ToList();
        }

        public static List<DETAIL_RECEIPT> getDetailReceiptList(string ID)
        {
            return db.DETAIL_RECEIPTs.Where(t => t.ID_RECEIPT==ID).ToList();
        }
        public static List<RECEIPT_FULL> getReceiptsJoin(string ID)
        {
            return db.RECEIPT_FULLs.Where(t=>t.ID_RECEIPT==ID && t.STATE_RECEIPT==3).ToList();
        }
        public static List<DETAILRECEIPT_JOIN> getDetailReceiptsJoin(string ID)
        {
            return db.DETAILRECEIPT_JOINs.Where(t => t.ID_RECEIPT == ID).ToList();
        }

        public static bool insertReceipt(RECEIPT_FULL data)
        {
            try
            {
                // convert RECEIPT_FULL to RECEIPT
                RECEIPT item = new RECEIPT();
                item.ID_RECEIPT = data.ID_RECEIPT;
                item.ID_VOUCHER = data.ID_VOUCHER;
                item.ID_CUSTOMER = data.ID_CUSTOMER;
                item.ID_METHOD = data.ID_METHOD;
                item.DATE_CREATE = data.DATE_CREATE;
                item.TOTAL_PRODUCT = data.TOTAL_PRODUCT;
                item.TOTAL_PRICE = data.TOTAL_PRICE;
                item.POINT = data.POINT;
                item.STATE_RECEIPT = data.STATE_RECEIPT;
                db.RECEIPTs.InsertOnSubmit(item);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool insertReceipt(RECEIPT data)
        {
            try
            {
                RECEIPT item = new RECEIPT();
                item.ID_RECEIPT = data.ID_RECEIPT;
                item.ID_VOUCHER = data.ID_VOUCHER;
                item.ID_CUSTOMER = data.ID_CUSTOMER;
                item.ID_METHOD = data.ID_METHOD;
                item.DATE_CREATE = data.DATE_CREATE;
                item.TOTAL_PRODUCT = data.TOTAL_PRODUCT;
                item.TOTAL_PRICE = data.TOTAL_PRICE;
                item.POINT = data.POINT;
                item.STATE_RECEIPT = data.STATE_RECEIPT;
                db.RECEIPTs.InsertOnSubmit(item);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool insertDetailReceipt(DETAIL_RECEIPT data)
        {
            try
            {
                DETAIL_RECEIPT item = new DETAIL_RECEIPT();
                item.ID_DETAIL_RECEIPT = data.ID_DETAIL_RECEIPT;
                item.ID_RECEIPT = data.ID_RECEIPT;
                item.ID_PRODUCT = data.ID_PRODUCT;
                item.PRICE = data.PRICE;
                item.QUANTITY = data.QUANTITY;
                db.DETAIL_RECEIPTs.InsertOnSubmit(item);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool insertReceipt(RECEIPT data,int STATUS)
        {
            try
            {
                // convert RECEIPT_FULL to RECEIPT
                RECEIPT item = new RECEIPT();
                item.ID_RECEIPT = data.ID_RECEIPT;
                item.ID_VOUCHER = data.ID_VOUCHER;
                item.ID_CUSTOMER = data.ID_CUSTOMER;
                item.ID_METHOD = data.ID_METHOD;
                item.DATE_CREATE = data.DATE_CREATE;
                item.TOTAL_PRODUCT = data.TOTAL_PRODUCT;
                item.TOTAL_PRICE = data.TOTAL_PRICE;
                item.POINT = data.POINT;
                item.STATE_RECEIPT = STATUS;
                item.ADDRESS_RECEIPT = data.ADDRESS_RECEIPT;
                db.RECEIPTs.InsertOnSubmit(item);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool deleteReceipt(RECEIPT_FULL data)
        {
            try
            {
                RECEIPT itemDelete = db.RECEIPTs.SingleOrDefault(t => t.ID_RECEIPT == data.ID_RECEIPT);
                db.RECEIPTs.DeleteOnSubmit(itemDelete);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updateReceipt(RECEIPT_FULL data)
        {
            try
            {
                RECEIPT item = db.RECEIPTs.SingleOrDefault(t => t.ID_RECEIPT == data.ID_RECEIPT);
                item.ID_VOUCHER = data.ID_VOUCHER;
                item.ID_CUSTOMER = data.ID_CUSTOMER;
                item.ID_METHOD = data.ID_METHOD;
                item.DATE_CREATE = data.DATE_CREATE;
                item.TOTAL_PRODUCT = data.TOTAL_PRODUCT;
                item.TOTAL_PRICE = data.TOTAL_PRICE;
                item.POINT = data.POINT;
                item.STATE_RECEIPT = data.STATE_RECEIPT;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateStateReceipt(string ID_RECEIPT,int status)
        {
            try
            {
                RECEIPT item = db.RECEIPTs.SingleOrDefault(t => t.ID_RECEIPT == ID_RECEIPT);
                item.STATE_RECEIPT = status;
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
