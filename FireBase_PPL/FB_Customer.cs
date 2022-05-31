using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_PPL;
using DAL_PPL;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FireBase_PPL
{
    public class FB_Customer
    {
        //get Client from  firebase
        static IFirebaseClient client = ConnectFireBase.CreateFirebaseClient();
        
        public static async Task<Customer> getOne(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<Customer>();
            }
            return null;
        }


        // get all node on branch Category
        private static async Task<Dictionary<string, Customer>> getEntireOnBranch(string rootName)
        {
            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync(rootName);
                return response.ResultAs<Dictionary<string, Customer>>();
            }
            return null;
        }


        //get list receipt
        public static async Task<List<Customer>> getEntire()
        {
            List<Customer> listOfFirebase = new List<Customer>();
            Dictionary<string, Customer> listData = await getEntireOnBranch("Database/Customer");
            try
            {
                // convert from Dictionary to list 
                if (listData != null)
                {
                    listOfFirebase = listData.Values.ToList();
                    //foreach (var itemData in listData)
                    //{
                    //    CUSTOMER itemOfFirebase = itemData.Value;
                    //    listOfFirebase.Add(itemOfFirebase);
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return listOfFirebase;

        }


        // get receipt that was not synchronized 
        public static async Task<List<Customer>> getEntireNotSync()
        {
            //list will return 
            List<Customer> listNotSync = new List<Customer>();
            List<CUSTOMER> listOfSql = DAL_Customer.getCustomers();
            //Dictionary<string, Customer> listOfFirebase = await getEntireOnBranch("Database/Customer");
            Dictionary<string, Customer> listOfFirebase = await getEntireOnBranch("Database/Customer");

            try
            {
                // loop through list on firebase
                foreach (Customer itemOfFirebase in listOfFirebase.Values)
                {
                    foreach (CUSTOMER itemOfSql in listOfSql)
                    {
                        // case update 
                        if (Customer.compareCustomer(itemOfSql, itemOfFirebase) == 2 || Customer.compareCustomer(itemOfSql, itemOfFirebase) == 1)
                        {
                            listNotSync.Add(itemOfFirebase);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return listNotSync;

        }
        // update data on firebase 
        public static async Task<bool> updateFromFirebaseAsync()
        {
            //list will return 
            List<Customer> listOfFirebase = await getEntireNotSync();
            List<CUSTOMER> listOfSql = DAL_Customer.getCustomers();
            try
            {
                if (listOfFirebase == null)
                {
                    return false;
                }
                // loop through list on firebase
                foreach (Customer itemOfFirebase in listOfFirebase)
                {
                    foreach (CUSTOMER itemOfSql in listOfSql)
                    {
                        // case update 
                        if (Customer.compareCustomer(itemOfSql, itemOfFirebase) == 2)
                        {
                            // parse 
                            itemOfFirebase.date_OF_BIRTH.Trim().Replace('/', '-');
                            itemOfFirebase.date_OF_BIRTH.Replace(' ', 'T');
                            itemOfFirebase.date_CREATE.Trim().Replace('/', '-');
                            itemOfFirebase.date_CREATE.Replace(' ', 'T');
                            CUSTOMER customerParse = new CUSTOMER();
                            customerParse.SURNAME_CUSTOMER = itemOfFirebase.surname_CUSTOMER;
                            customerParse.NAME_CUSTOMER = itemOfFirebase.name_CUSTOMER;
                            customerParse.DATE_OF_BIRTH = DateTime.Parse(itemOfFirebase.date_OF_BIRTH);
                            customerParse.DATE_CREATE = DateTime.Parse(itemOfFirebase.date_CREATE);
                            customerParse.GENDER_CUSTOMER = itemOfFirebase.gender_CUSTOMER;
                            customerParse.ADDRESS_CUSTOMER = itemOfFirebase.address_CUSTOMER;
                            customerParse.PHONE_CUSTOMER = itemOfFirebase.phone_CUSTOMER;
                            customerParse.PASSWORD_CUSTOMER = itemOfFirebase.password_CUSTOMER;
                            customerParse.POINT = itemOfFirebase.point;
                            DAL_Customer.updateCustomer(customerParse);
                            break;
                        }
                        //  case new 
                        else if (Customer.compareCustomer(itemOfSql, itemOfFirebase) == 1)
                        {
                            // parse 
                            itemOfFirebase.date_OF_BIRTH.Trim().Replace('/', '-');
                            itemOfFirebase.date_OF_BIRTH.Replace(' ', 'T');
                            itemOfFirebase.date_CREATE.Trim().Replace('/', '-');
                            itemOfFirebase.date_CREATE.Replace(' ', 'T');
                            CUSTOMER customerParse = new CUSTOMER();
                            customerParse.ID_CUSTOMER = itemOfFirebase.id_CUSTOMER;
                            customerParse.SURNAME_CUSTOMER = itemOfFirebase.surname_CUSTOMER;
                            customerParse.NAME_CUSTOMER = itemOfFirebase.name_CUSTOMER;
                            customerParse.DATE_OF_BIRTH = DateTime.Parse(itemOfFirebase.date_OF_BIRTH);
                            customerParse.DATE_CREATE = DateTime.Parse(itemOfFirebase.date_CREATE);
                            customerParse.DATE_UPDATE = DateTime.Now;
                            customerParse.MAIL_CUSTOMER = "NONE";
                            customerParse.GENDER_CUSTOMER = itemOfFirebase.gender_CUSTOMER;
                            customerParse.ADDRESS_CUSTOMER = itemOfFirebase.address_CUSTOMER;
                            customerParse.PHONE_CUSTOMER = itemOfFirebase.phone_CUSTOMER;
                            customerParse.PASSWORD_CUSTOMER = itemOfFirebase.password_CUSTOMER;
                            customerParse.POINT = itemOfFirebase.point;
                            customerParse.TYPE_CUSTOMER = "TYPECUS01";
                            DAL_Customer.insertCustomer(customerParse);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;

        }

        public static async Task<bool> updateToFirebaseAsync(List<CUSTOMER> listOfSql)
        {

            try
            {


                foreach (CUSTOMER itemOfSql in listOfSql)
                {
                    await ConnectFireBase.FirebaseInsertData(itemOfSql, "Database/Customer/" + itemOfSql.ID_CUSTOMER.ToString() + "/");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;

        }
    }
}
