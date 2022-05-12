using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;
using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_Category
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_Category() { }
        public static List<CATEGORY> getCategories()
        {
            return db.CATEGORies.Select(t => t).ToList<CATEGORY>();
        }
    }
}
