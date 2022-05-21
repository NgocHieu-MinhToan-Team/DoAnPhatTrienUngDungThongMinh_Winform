using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
using DAL_PPL;
using System.Windows;

namespace BLL_PPL
{
    public class BLL_Customer
    {
        public BLL_Customer() { }
        public static List<CUSTOMER> getCustomers()
        {
            return DAL_Customer.getCustomers();
        }

        public static bool deleteReceipt(CUSTOMER data)
        {
            try
            {
                if (DAL_Customer.deleteCustomer(data))
                {
                    MessageBox.Show("Delete Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Delete Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
