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

        public DAL_Staff() { }

        public static List<STAFF> getStaffs()
        {
            var listAnonymous = from staff in db.STAFFs
                                where staff.FLAG_DEL == 0
                                select new
                                {
                                    USERNAME_STAFF = staff.USERNAME_STAFF,
                                    PASSWORD_STAFF = staff.PASSWORD_STAFF,
                                    ID_GROUP = staff.ID_GROUP,
                                    SURNAME_STAFF = staff.SURNAME_STAFF,
                                    NAME_STAFF = staff.NAME_STAFF,
                                    GENDER_STAFF = staff.GENDER_STAFF,
                                    DATE_OF_BIRTH = staff.DATE_OF_BIRTH,
                                    ADDRESS_STAFF = staff.ADDRESS_STAFF,
                                    NUMBER_PHONE = staff.NUMBER_PHONE,
                                };
            List<STAFF> list = new List<STAFF>();
            foreach (var itemAnonymous in listAnonymous)
            {
                STAFF item = new STAFF();
                item.USERNAME_STAFF = itemAnonymous.USERNAME_STAFF;
                item.PASSWORD_STAFF = itemAnonymous.PASSWORD_STAFF;
                item.ID_GROUP = itemAnonymous.ID_GROUP;
                item.SURNAME_STAFF = itemAnonymous.SURNAME_STAFF;
                item.NAME_STAFF = itemAnonymous.NAME_STAFF;
                item.GENDER_STAFF = itemAnonymous.GENDER_STAFF;
                item.DATE_OF_BIRTH = itemAnonymous.DATE_OF_BIRTH;
                item.ADDRESS_STAFF = itemAnonymous.ADDRESS_STAFF;
                item.NUMBER_PHONE = itemAnonymous.NUMBER_PHONE;
                list.Add(item);
            }
            return list;
        }


        public static List<GROUP_USER> getGroupUsers()
        {
            return db.GROUP_USERs.Select(t => t).ToList<GROUP_USER>();
        }

        public static bool insertStaff(STAFF data)
        {
            try
            {
                db.STAFFs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteStaff(STAFF data)
        {
            try
            {
                STAFF itemDelete = db.STAFFs.SingleOrDefault(t => t.USERNAME_STAFF == data.USERNAME_STAFF);
                itemDelete.FLAG_DEL = 1;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updateStaff(STAFF data)
        {
            try
            {
                STAFF itemUpdate = db.STAFFs.SingleOrDefault(t => t.USERNAME_STAFF == data.USERNAME_STAFF);
                itemUpdate.USERNAME_STAFF = data.USERNAME_STAFF;
                itemUpdate.PASSWORD_STAFF = data.PASSWORD_STAFF;
                itemUpdate.ID_GROUP = data.ID_GROUP;
                itemUpdate.SURNAME_STAFF = data.SURNAME_STAFF;
                itemUpdate.NAME_STAFF = data.NAME_STAFF;
                itemUpdate.GENDER_STAFF = data.GENDER_STAFF;
                itemUpdate.DATE_OF_BIRTH = data.DATE_OF_BIRTH;
                itemUpdate.ADDRESS_STAFF = data.ADDRESS_STAFF;
                itemUpdate.NUMBER_PHONE = data.NUMBER_PHONE;
                itemUpdate.FLAG_DEL = 0;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
