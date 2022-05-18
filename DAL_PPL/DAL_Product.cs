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
            var listAnonymous = from pro in db.PRODUCTs
                                where pro.FLAG_DEL == 0
                                select new
                                {
                                    ID_PRODUCT = pro.ID_PRODUCT,
                                    ID_CATEGORY=pro.ID_CATEGORY,
                                    NAME_PRODUCT_EN = pro.NAME_PRODUCT_EN,
                                    NAME_PRODUCT_VN = pro.NAME_PRODUCT_VN,
                                    PRICE_PRODUCT = pro.PRICE_PRODUCT,
                                    IMAGE_PRODUCT=pro.IMAGE_PRODUCT,
                                    //FLAG_DEL=pro.FLAG_DEL
                                };
            List<PRODUCT> list = new List<PRODUCT>();
            foreach (var itemAnonymous in listAnonymous)
            {
                PRODUCT item = new PRODUCT();
                item.ID_PRODUCT = itemAnonymous.ID_PRODUCT;
                item.ID_CATEGORY = itemAnonymous.ID_CATEGORY;
                item.NAME_PRODUCT_EN = itemAnonymous.NAME_PRODUCT_EN;
                item.NAME_PRODUCT_VN = itemAnonymous.NAME_PRODUCT_VN;
                item.PRICE_PRODUCT = itemAnonymous.PRICE_PRODUCT;
                item.IMAGE_PRODUCT = itemAnonymous.IMAGE_PRODUCT;
                //item.FLAG_DEL = item.FLAG_DEL;
                list.Add(item);
            }
            return list;
        }
        
        public static bool insertProduct(PRODUCT data)
        {
            try
            {
                data.FLAG_DEL = 0;
                db.PRODUCTs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool deleteProduct(PRODUCT data)
        {
            try
            {
                PRODUCT itemDelete = db.PRODUCTs.SingleOrDefault(t => t.ID_PRODUCT == data.ID_PRODUCT);
                itemDelete.FLAG_DEL = 1;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updateProduct(PRODUCT data)
        {
            try
            {
                PRODUCT itemUpdate = db.PRODUCTs.SingleOrDefault(t => t.ID_PRODUCT == data.ID_PRODUCT);
                itemUpdate.ID_PRODUCT = data.ID_PRODUCT;
                itemUpdate.ID_CATEGORY = data.ID_CATEGORY;
                itemUpdate.NAME_PRODUCT_EN = data.NAME_PRODUCT_EN;
                itemUpdate.NAME_PRODUCT_VN = data.NAME_PRODUCT_VN;
                itemUpdate.PRICE_PRODUCT = data.PRICE_PRODUCT;
                itemUpdate.IMAGE_PRODUCT = data.IMAGE_PRODUCT;
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
