using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PPL
{
    public class Customer
    {

        public string id_CUSTOMER, surname_CUSTOMER, name_CUSTOMER;
        public string date_OF_BIRTH, date_CREATE;
        public int gender_CUSTOMER;
        public string address_CUSTOMER, phone_CUSTOMER, password_CUSTOMER;
        public int point;
        public Customer() { }

        public static bool isEqual(CUSTOMER CUSTOMER_SQL,Customer CUSTOMER_FB)
        {
            try
            {
                // parse 
                CUSTOMER_FB.date_OF_BIRTH.Trim().Replace('/', '-');
                CUSTOMER_FB.date_OF_BIRTH.Replace(' ', 'T');
                CUSTOMER_FB.date_CREATE.Trim().Replace('/', '-');
                CUSTOMER_FB.date_CREATE.Replace(' ', 'T');
                // case : Customer update infomation 
                if (CUSTOMER_SQL.ID_CUSTOMER == CUSTOMER_FB.id_CUSTOMER)
                {
                    // check change of customer
                    if (CUSTOMER_SQL.SURNAME_CUSTOMER == CUSTOMER_FB.surname_CUSTOMER &&
                        CUSTOMER_SQL.NAME_CUSTOMER == CUSTOMER_FB.name_CUSTOMER &&
                        CUSTOMER_SQL.DATE_OF_BIRTH.Value.Date == DateTime.Parse(CUSTOMER_FB.date_OF_BIRTH).Date &&
                        CUSTOMER_SQL.DATE_CREATE.Value.Date == DateTime.Parse(CUSTOMER_FB.date_CREATE).Date &&
                        CUSTOMER_SQL.GENDER_CUSTOMER == CUSTOMER_FB.gender_CUSTOMER &&
                        CUSTOMER_SQL.ADDRESS_CUSTOMER == CUSTOMER_FB.address_CUSTOMER &&
                        CUSTOMER_SQL.PHONE_CUSTOMER == CUSTOMER_FB.phone_CUSTOMER &&
                        CUSTOMER_SQL.PASSWORD_CUSTOMER == CUSTOMER_FB.password_CUSTOMER &&
                        CUSTOMER_SQL.POINT == CUSTOMER_FB.point)
                    {
                        // no change
                        return true;
                    }
                    else
                    {
                        // update 
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                Console.WriteLine("input  null");
                return false;
            }
        }

        public static List<CUSTOMER> parseList(List<Customer> listOld)
        {
            List<CUSTOMER> listNew = new List<CUSTOMER>();
            foreach (Customer old in listOld)
            {
                old.date_OF_BIRTH.Trim().Replace('/', '-');
                old.date_OF_BIRTH.Replace(' ', 'T');
                old.date_CREATE.Trim().Replace('/', '-');
                old.date_CREATE.Replace(' ', 'T');
                CUSTOMER customerParse = new CUSTOMER();
                customerParse.ID_CUSTOMER = old.id_CUSTOMER;
                customerParse.SURNAME_CUSTOMER = old.surname_CUSTOMER;
                customerParse.NAME_CUSTOMER = old.name_CUSTOMER;
                customerParse.DATE_OF_BIRTH = DateTime.Parse(old.date_OF_BIRTH);
                customerParse.DATE_CREATE = DateTime.Parse(old.date_CREATE);
                customerParse.GENDER_CUSTOMER = old.gender_CUSTOMER;
                customerParse.ADDRESS_CUSTOMER = old.address_CUSTOMER;
                customerParse.PHONE_CUSTOMER = old.phone_CUSTOMER;
                customerParse.PASSWORD_CUSTOMER = old.password_CUSTOMER;
                customerParse.POINT = old.point;
                listNew.Add(customerParse);
            }

            return listNew;
        }
    }
}
