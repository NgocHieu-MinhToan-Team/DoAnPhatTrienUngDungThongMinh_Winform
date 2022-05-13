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
    public class BLL_Product
    {
        public static List<PRODUCT> getProducts()
        {
            return DAL_Product.getProducts();
        }
       
    }
}
