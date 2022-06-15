using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_Customer
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();

        public DAL_Customer() { }

        public static List<CUSTOMER> getCustomers()
        {
            var listAnonymous = from cus in db.CUSTOMERs
                                select new
                                {
                                    cus.ID_CUSTOMER,
                                    cus.NAME_CUSTOMER,
                                    cus.SURNAME_CUSTOMER,
                                    cus.GENDER_CUSTOMER,
                                    cus.DATE_CREATE,
                                    cus.DATE_UPDATE,
                                    cus.DATE_OF_BIRTH,
                                    cus.PHONE_CUSTOMER,
                                    cus.MAIL_CUSTOMER,
                                    cus.PASSWORD_CUSTOMER,
                                    cus.ADDRESS_CUSTOMER,
                                    cus.POINT,
                                    cus.TYPE_CUSTOMER, 
                                };
            List<CUSTOMER> list = new List<CUSTOMER>();
            foreach (var itemAnonymous in listAnonymous)
            {
                CUSTOMER item = new CUSTOMER();
                item.ID_CUSTOMER = itemAnonymous.ID_CUSTOMER;
                item.NAME_CUSTOMER = itemAnonymous.NAME_CUSTOMER;
                item.SURNAME_CUSTOMER = itemAnonymous.SURNAME_CUSTOMER;
                item.GENDER_CUSTOMER = itemAnonymous.GENDER_CUSTOMER;
                item.DATE_CREATE = itemAnonymous.DATE_CREATE;
                item.DATE_UPDATE = itemAnonymous.DATE_UPDATE;
                item.DATE_OF_BIRTH = itemAnonymous.DATE_OF_BIRTH;
                item.PHONE_CUSTOMER = itemAnonymous.PHONE_CUSTOMER;
                item.MAIL_CUSTOMER = itemAnonymous.MAIL_CUSTOMER;
                item.PASSWORD_CUSTOMER = itemAnonymous.PASSWORD_CUSTOMER;
                item.ADDRESS_CUSTOMER = itemAnonymous.ADDRESS_CUSTOMER;
                item.POINT = itemAnonymous.POINT;
                item.TYPE_CUSTOMER = itemAnonymous.TYPE_CUSTOMER;
                list.Add(item);
            }
            return list;
        }


        public static List<CUSTOMER_TYPE> getTypeCutomers()
        {
            return db.CUSTOMER_TYPEs.Select(t => t).ToList<CUSTOMER_TYPE>();
        }

        public static bool insertCustomer(CUSTOMER data)
        {
            try
            {
                db.CUSTOMERs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool deleteCustomer(CUSTOMER data)
        {
            try
            {
                CUSTOMER itemDelete = db.CUSTOMERs.SingleOrDefault(t => t.ID_CUSTOMER == data.ID_CUSTOMER);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updateCustomer(CUSTOMER data)
        {
            try
            {
                CUSTOMER itemUpdate = db.CUSTOMERs.SingleOrDefault(t => t.ID_CUSTOMER == data.ID_CUSTOMER);
                itemUpdate.NAME_CUSTOMER = data.NAME_CUSTOMER;
                itemUpdate.SURNAME_CUSTOMER = data.SURNAME_CUSTOMER;
                itemUpdate.GENDER_CUSTOMER = data.GENDER_CUSTOMER;
                itemUpdate.DATE_CREATE = data.DATE_CREATE;
                itemUpdate.DATE_UPDATE = data.DATE_UPDATE;
                itemUpdate.DATE_OF_BIRTH = data.DATE_OF_BIRTH;
                itemUpdate.PHONE_CUSTOMER = data.PHONE_CUSTOMER;
                itemUpdate.MAIL_CUSTOMER = data.MAIL_CUSTOMER;
                itemUpdate.PASSWORD_CUSTOMER = data.PASSWORD_CUSTOMER;
                itemUpdate.ADDRESS_CUSTOMER = data.ADDRESS_CUSTOMER;
                itemUpdate.POINT = data.POINT;
                itemUpdate.TYPE_CUSTOMER = data.TYPE_CUSTOMER;
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
