using FP_Growth;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PPL;
namespace FP_Growth
{
    public class TrainModel
    {
        //default
        const double MINSUPPORT = 0.035;
        const double MINCONFIDENT = 0.9;
        public static List<FPGrowth_Item> Load(double minsup_input,double conf_input)
        {
            double minSupport , minConfidence;
            if (minsup_input>0 && minsup_input<1 && conf_input > 0 && conf_input <1)
            {
                minSupport = minsup_input;
                minConfidence = conf_input;
            }
            else
            {
                minSupport = MINSUPPORT;
                minConfidence = MINCONFIDENT;
            }
            DateTime start = DateTime.Now;
            string filepath = System.IO.Directory.GetCurrentDirectory() + @"\input.txt";

            List<Transaction> dataset = PrepareData(filepath);

            FPGrowth method = new FPGrowth(dataset, minSupport * dataset.Count);
            FPTree tree = method.GenerateTree(false);
            var patterns = method.MineFrequentPatterns();
            var rules = method.GenerateRules(patterns, minSupport, minConfidence);
            DateTime end = DateTime.Now;
            //Console.WriteLine("Program finished in {0} seconds", (end - start).TotalSeconds);
            //patterns.ForEach(p => Console.WriteLine(p));
            //Console.WriteLine("==========================================================================");
            rules.Sort((r1, r2) => r2.Confidence.CompareTo(r1.Confidence));
            //rules.ForEach(p => Console.WriteLine(p));
            //Console.ReadKey();
            List<FPGrowth_Item> lst = new List<FPGrowth_Item>();
            foreach(AssociationRule rule in rules)
            {
                FPGrowth_Item item = new FPGrowth_Item();
                string value = "";
                foreach(var dish in rule.Rule_From)
                {
                    value += dish.ToString()+",";
                }
                value += rule.Rule_To;
                item.detail = value;
                item.id_receipt = rule.Confidence.ToString();
                lst.Add(item);

            }
            return lst;
        }
        private static List<Transaction> PrepareData(string filepath)
        {
            var result = new List<Transaction>();
            System.IO.StreamReader file =
                           new System.IO.StreamReader(filepath);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                result.Add(new Transaction(line.Split(',')));
            }
            return result;
        }
    }
}
