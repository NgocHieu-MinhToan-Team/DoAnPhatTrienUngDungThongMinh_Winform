using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PPL
{
    public class FPGrowth_Item
    {
        private string _id_receipt, _detail;

        public string id_receipt { get; set; }
        public string detail { get; set; }

        public FPGrowth_Item() { }

        public FPGrowth_Item(string id_receipt, string detail)
        {
            this.id_receipt = id_receipt;
            this.detail = detail;
        }
    }
}
