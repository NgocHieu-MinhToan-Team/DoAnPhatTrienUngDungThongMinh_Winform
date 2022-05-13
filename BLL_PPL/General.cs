using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PPL
{
    public class General
    {
        public string createID(string prefix)
        {
            
            string id = prefix+DateTime.Now.Year + DateTime.Now.Month+ DateTime.Now.Day+ DateTime.Now.Hour+ DateTime.Now.Minute+ DateTime.Now.Second+ DateTime.Now.Millisecond;
            return id;
        }
    }
}
