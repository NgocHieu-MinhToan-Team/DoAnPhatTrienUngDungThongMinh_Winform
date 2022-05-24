using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DAL_PPL;
using DTO_PPL;

namespace BLL_PPL
{
    public class BLL_News
    {
            public BLL_News() { }

            public static List<NEW> getNews(string ID_PROMOTION)
            {
                List<NEW> list = DAL_NEW.getNews(ID_PROMOTION);
                return list;
            }

            public static bool insertNews(NEW data)
            {
                try
                {
                    if (DAL_NEW.insertNews(data))
                    {
                        MessageBox.Show("Insert Data Sucessfully !");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Insert Data Failed !");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            public static bool deleteNews(NEW data)
            {
                try
                {
                    if (DAL_NEW.deleteNews(data))
                    {
                        MessageBox.Show("Delete Data Sucessfully !");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Delete Data Failed !");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            public static bool updateNews(NEW data)
            {
                try
                {
                    if (DAL_NEW.updateNews(data))
                    {
                        MessageBox.Show("Update Data Sucessfully !");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Update Data Failed !");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

        public static List<IMAGE_NEW> getImageNews(string ID_NEWS)
        {
            List<IMAGE_NEW> list = DAL_NEW.getImageNews(ID_NEWS);
            return list;
        }

        public static bool insertImageNews(IMAGE_NEW data)
        {
            try
            {
                if (DAL_NEW.insertImageNews(data))
                {
                    MessageBox.Show("Insert Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Insert Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool deleteNews(IMAGE_NEW data)
        {
            try
            {
                if (DAL_NEW.deleteImageNews(data))
                {
                    MessageBox.Show("Delete Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Delete Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool updateImageNews(IMAGE_NEW data)
        {
            try
            {
                if (DAL_NEW.updateImageNews(data))
                {
                    MessageBox.Show("Update Data Sucessfully !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Update Data Failed !");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
    }
