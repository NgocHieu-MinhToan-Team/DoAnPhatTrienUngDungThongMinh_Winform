using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PPL
{
    public static class GeneralMethods
    {
        public static List<T> GetClone<T>(this List<T> source)
        {
            return source.GetRange(0, source.Count);
        }
        public  static string createID(string prefix)
        {
            string id = prefix+ DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond;
            return id;
        }

        public static bool isLetter(string s, bool hasSpace)
        {
            string str = s.Trim();
            if (str.Length > 0)
            {
                if (hasSpace)
                {
                    if (str.All(t => char.IsLetter(t) || t == ' '))
                    {
                        return true;
                    }
                }
                else
                {
                    if (str.All(t => char.IsLetter(t)))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool isDigit(string s, bool hasSpace)
        {
            string str = s.Trim();
            if (str.Length > 0 && str!="")
            {
                if (hasSpace)
                {
                    if (str.All(t => char.IsDigit(t) || t == ' '))
                    {
                        return true;
                    }
                }
                else
                {
                    if (str.All(t => char.IsDigit(t)))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool isLetterOrDigit(string s, bool hasSpace)
        {
            string str = s.Trim();
            if (str.Length > 0)
            {
                if (hasSpace)
                {
                    if (str.All(t => char.IsLetter(t) || char.IsDigit(t) || t == ' '))
                    {
                        return true;
                    }
                }
                else
                {
                    if (str.All(t => char.IsLetter(t) || char.IsDigit(t)))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool isNumberTypeDouble(string s)
        {
            string str = s.Trim();
            if (str.Length > 0)
            {
                foreach (char c in str)
                {
                    if (char.IsDigit(c) || c == ',')
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;

        }
    }
}
