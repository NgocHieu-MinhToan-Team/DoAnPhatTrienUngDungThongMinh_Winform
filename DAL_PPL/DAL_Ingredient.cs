using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;

namespace DAL_PPL
{
    public class DAL_Ingredient
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_Ingredient() { }
        // get data just include flag = 0 : not delete
        public static List<INGREDIENT> getList()
        {
            var listAnonymous = from ingre in db.INGREDIENTs
                                where ingre.FLAG_DEL == 0
                                select new
                                {
                                    ID_INGREDIENT = ingre.ID_INGREDIENT,
                                    ID_SUPPLIER = ingre.ID_SUPPLIER,
                                    NAME_INGREDIENT = ingre.NAME_INGREDIENT,
                                    INVENTORY = ingre.INVENTORY,
                                };
            List<INGREDIENT> list = new List<INGREDIENT>();
            foreach (var itemAnonymous in listAnonymous)
            {
                INGREDIENT item = new INGREDIENT();
                item.ID_INGREDIENT = itemAnonymous.ID_INGREDIENT;
                item.ID_SUPPLIER = itemAnonymous.ID_SUPPLIER;
                item.NAME_INGREDIENT = itemAnonymous.NAME_INGREDIENT;
                item.INVENTORY = itemAnonymous.INVENTORY;
                list.Add(item);
            }
            return list;
        }

        public static List<INGREDIENT> getListByID_SUPPLIER(string ID_SUPPLIER)
        {
            return db.INGREDIENTs.Where(t => t.ID_SUPPLIER==ID_SUPPLIER).ToList<INGREDIENT>();
        }

        public static List<SUPPLIER> getListSupplier()
        {
            return db.SUPPLIERs.Select(t => t).ToList<SUPPLIER>();
        }
        public static bool add(INGREDIENT data)
        {
            try
            {
                data.FLAG_DEL = 0;
                db.INGREDIENTs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool remove(INGREDIENT data)
        {
            try
            {
                INGREDIENT itemDelete = db.INGREDIENTs.SingleOrDefault(t => t.ID_INGREDIENT == data.ID_INGREDIENT);
                itemDelete.FLAG_DEL = 1;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool update(INGREDIENT data)
        {
            try
            {
                INGREDIENT itemUpdate = db.INGREDIENTs.SingleOrDefault(t => t.ID_INGREDIENT == data.ID_INGREDIENT);
                itemUpdate.ID_SUPPLIER = data.ID_SUPPLIER;
                itemUpdate.NAME_INGREDIENT = data.NAME_INGREDIENT;
                itemUpdate.INVENTORY = data.INVENTORY;
                itemUpdate.FLAG_DEL = 0;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool update(string ID_INGREDIENT,int weight)
        {
            try
            {
                INGREDIENT itemUpdate = db.INGREDIENTs.SingleOrDefault(t => t.ID_INGREDIENT == ID_INGREDIENT);
                itemUpdate.INVENTORY = itemUpdate.INVENTORY-weight;
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
