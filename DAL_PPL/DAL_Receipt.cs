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

        public static List<RECEIPT_FULL> getReceipts()
        {
            var listAnonymous = from receipt in db.RECEIPT_FULLs
                                select new
                                {
                                    ID_RECEIPT=receipt.ID_RECEIPT,
                                    ID_VOUCHER = receipt.ID_VOUCHER,
                                    ID_CUSTOMER=receipt.ID_CUSTOMER,
                                    ID_METHOD=receipt.ID_METHOD,
                                    DATE_CREATE = receipt.DATE_CREATE,
                                    TOTAL_PRODUCT = receipt.TOTAL_PRODUCT,
                                    TOTAL_PRICE = receipt.TOTAL_PRICE,
                                    POINT = receipt.POINT,
                                    PERCENT_REDUCTION = receipt.PERCENT_REDUCTION,
                                    AMOUNT_REDUCTION = receipt.AMOUNT_REDUCTION,
                                    ADDRESS_CUSTOMER = receipt.ADDRESS_CUSTOMER,
                                    MAIL_CUSTOMER = receipt.MAIL_CUSTOMER,
                                    NAME_CUSTOMER = receipt.NAME_CUSTOMER,
                                    SURNAME_CUSTOMER = receipt.SURNAME_CUSTOMER,
                                    PHONE_CUSTOMER = receipt.PHONE_CUSTOMER,
                                    NAME_METHOD = receipt.NAME_METHOD,
                                    TYPE_METHOD = receipt.TYPE_METHOD,
                                    STATE_RECEIPT = receipt.STATE_RECEIPT
                                };
            List<RECEIPT_FULL> list = new List<RECEIPT_FULL>();
            foreach (var itemAnonymous in listAnonymous)
            {
                RECEIPT_FULL item = new RECEIPT_FULL();
                item.ID_RECEIPT = itemAnonymous.ID_RECEIPT;
                item.ID_VOUCHER = itemAnonymous.ID_VOUCHER;
                item.ID_CUSTOMER = itemAnonymous.ID_CUSTOMER;
                item.ID_METHOD = itemAnonymous.ID_METHOD;
                item.DATE_CREATE = itemAnonymous.DATE_CREATE;
                item.TOTAL_PRODUCT = itemAnonymous.TOTAL_PRODUCT;
                item.TOTAL_PRICE = itemAnonymous.TOTAL_PRICE;
                item.POINT = itemAnonymous.POINT;
                item.PERCENT_REDUCTION = itemAnonymous.PERCENT_REDUCTION;
                item.AMOUNT_REDUCTION = itemAnonymous.AMOUNT_REDUCTION;
                item.ADDRESS_CUSTOMER = itemAnonymous.ADDRESS_CUSTOMER;
                item.NAME_CUSTOMER = itemAnonymous.NAME_CUSTOMER;
                item.SURNAME_CUSTOMER = itemAnonymous.SURNAME_CUSTOMER;
                item.PHONE_CUSTOMER = itemAnonymous.PHONE_CUSTOMER;
                item.NAME_METHOD = itemAnonymous.NAME_METHOD;
                item.TYPE_METHOD = itemAnonymous.TYPE_METHOD;
                item.STATE_RECEIPT = itemAnonymous.STATE_RECEIPT;
                list.Add(item);
            }
            return list;
        }

        public static List<RECEIPT_FULL> readReceiptToExport()
        {
            return getReceipts();
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

        public static bool insertDetailReceipt(DETAIL_RECEIPT data)
        {
            try
            {
                // convert RECEIPT_FULL to RECEIPT
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
            catch
            {
                return false;
            }
        }

        public static bool insertReceipt(RECEIPT data)
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
                item.ADDRESS_RECEIPT = data.ADDRESS_RECEIPT;
                db.RECEIPTs.InsertOnSubmit(item);
                db.SubmitChanges();
                return true;
            }
            catch
            {
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

    }
}
