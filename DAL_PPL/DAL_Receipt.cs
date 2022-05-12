using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_Receipt
    {
        RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_Receipt()
        {

        }

        public List<RECEIPT> readReceipt()
        {
            return db.RECEIPTs.Select(t => t).ToList<RECEIPT>();
        }

        public List<RECEIPT_FULL> readReceiptToExport()
        {
            return db.RECEIPT_FULLs.Select(t => t).ToList<RECEIPT_FULL>();
        }



    }
}
