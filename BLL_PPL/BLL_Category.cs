using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PPL;
using DTO_PPL;

namespace BLL_PPL
{
    public class BLL_Category
    {
        public BLL_Category() { }
        public  static List<CATEGORY> getCategories()
        {
            return DAL_Category.getCategories();
        }
    }
}
