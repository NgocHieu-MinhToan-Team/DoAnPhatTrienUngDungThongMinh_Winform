using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PPL
{
    public class Detail_Order
    {

        public string id_CUSTOMER, id_METHOD, id_VOUCHER,address;
        public int status;
        public float total_PAYMENT;
        public Dictionary<string, Cart_Item> list_CART;
        public Detail_Order() { }
    }
}
