using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO_PPL
{
    public class Order
    {
        public Dictionary<string, Dictionary<string, Detail_Order>> order;
        public Order() { }
    }
}
