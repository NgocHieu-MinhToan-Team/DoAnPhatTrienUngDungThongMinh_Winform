using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FP_Growth;
using DTO_PPL;
namespace BLL_PPL
{
    public class BLL_FPGrowth
    {
        public static List<FPGrowth_Item> getResult(double minsup,double conf)
        {
            return TrainModel.Load(minsup, conf);
        }


    }
}
