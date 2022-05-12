using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_Product
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_Product() { }
        public static List<PRODUCT> getProducts()
        {
            //var query = from p in db.PRODUCTs select p.;

            return db.PRODUCTs.Select(t => t).ToList<PRODUCT>();
        }
    }
}
