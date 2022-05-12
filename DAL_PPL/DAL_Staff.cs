using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DTO_PPL;
using System.Data;

namespace DAL_PPL
{
    public class DAL_Staff
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_Staff()
        {

        }

        public  List<STAFF> readStaff()
        {
            return db.STAFFs.Select(t => t).ToList<STAFF>();
        }


        public  List<GROUP_USER> readGroupUser()
        {
            return db.GROUP_USERs.Select(t => t).ToList<GROUP_USER>();
        }

        public  bool createStaff(STAFF staff)
        {
            db.STAFFs.InsertOnSubmit(staff);
            return true;
        }

    }
}
