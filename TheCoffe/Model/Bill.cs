using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffe.Model
{
    class Bill
    {
        public int Table { get; set; }
        public string ProductType { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
        public DateTime TimeOrder { get; set; }

    }
}
