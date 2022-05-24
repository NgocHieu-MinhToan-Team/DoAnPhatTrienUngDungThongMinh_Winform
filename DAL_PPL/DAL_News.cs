using DTO_PPL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PPL
{
    public class DAL_NEW
    {
        static RestaurantPPLDataContext db = new RestaurantPPLDataContext();
        public DAL_NEW() { }
        public static List<NEW> getNews(string ID_PROMOTION)
        {
            var listAnonymous = from news in db.NEWs
                                where news.ID_PROMOTION== ID_PROMOTION
                                && news.FLAG_DEL==0
                                select new
                                {
                                    ID_NEWS = news.ID_NEWS,
                                    ID_PROMOTION = news.ID_PROMOTION,
                                    USERNAME_STAFF = news.USERNAME_STAFF,
                                    TITLE = news.TITLE,
                                    CONTENT = news.CONTENT,
                                    DATE_VISIBLE = news.DATE_VISIBLE,
                                    DATE_HIDDEN = news.DATE_HIDDEN,

                                };
            List<NEW> list = new List<NEW>();
            foreach (var itemAnonymous in listAnonymous)
            {
                NEW item = new NEW();
                item.ID_NEWS = itemAnonymous.ID_NEWS;
                item.ID_PROMOTION = itemAnonymous.ID_PROMOTION;
                item.USERNAME_STAFF = itemAnonymous.USERNAME_STAFF;
                item.TITLE = itemAnonymous.TITLE;
                item.CONTENT = itemAnonymous.CONTENT;
                item.DATE_VISIBLE = itemAnonymous.DATE_VISIBLE;
                item.DATE_HIDDEN = itemAnonymous.DATE_HIDDEN;
                list.Add(item);
            }
            return list;
        }

        public static bool insertNews(NEW data)
        {
            try
            {
                data.FLAG_DEL = 0;
                db.NEWs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool deleteNews(NEW data)
        {
            try
            {
                NEW itemDelete = db.NEWs.SingleOrDefault(t => t.ID_NEWS == data.ID_NEWS);
                itemDelete.FLAG_DEL = 1;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updateNews(NEW data)
        {
            try
            {
                NEW itemUpdate = db.NEWs.SingleOrDefault(t => t.ID_NEWS == data.ID_NEWS);
                itemUpdate.ID_PROMOTION = data.ID_PROMOTION;
                itemUpdate.USERNAME_STAFF = data.USERNAME_STAFF;
                itemUpdate.TITLE = data.TITLE;
                itemUpdate.CONTENT = data.CONTENT;
                itemUpdate.DATE_VISIBLE = data.DATE_VISIBLE;
                itemUpdate.DATE_HIDDEN = data.DATE_HIDDEN;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<IMAGE_NEW> getImageNews(string ID_NEWS)
        {
            var listAnonymous = from img in db.IMAGE_NEWs
                                where img.ID_NEWS==ID_NEWS
                                select new
                                {
                                    ID_IMAGE = img.ID_IMAGE,
                                    ID_NEWS = img.ID_NEWS,
                                    PATH_IMAGE = img.PATH_IMAGE,

                                };
            List<IMAGE_NEW> list = new List<IMAGE_NEW>();
            foreach (var itemAnonymous in listAnonymous)
            {
                IMAGE_NEW item = new IMAGE_NEW();
                item.ID_IMAGE = itemAnonymous.ID_IMAGE;
                item.ID_NEWS = itemAnonymous.ID_NEWS;
                item.PATH_IMAGE = itemAnonymous.PATH_IMAGE;
                list.Add(item);
            }
            return list;
        }

        public static bool insertImageNews(IMAGE_NEW data)
        {
            try
            {
                db.IMAGE_NEWs.InsertOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool deleteImageNews(IMAGE_NEW data)
        {
            try
            {
                IMAGE_NEW itemDelete = db.IMAGE_NEWs.SingleOrDefault(t => t.ID_IMAGE == data.ID_IMAGE);
                db.IMAGE_NEWs.DeleteOnSubmit(itemDelete);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool updateImageNews(IMAGE_NEW data)
        {
            try
            {
                IMAGE_NEW itemUpdate = db.IMAGE_NEWs.SingleOrDefault(t => t.ID_IMAGE == data.ID_IMAGE);
                itemUpdate.ID_NEWS = data.ID_NEWS;
                itemUpdate.PATH_IMAGE = data.PATH_IMAGE;
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
