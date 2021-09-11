using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffe.Model
{
    class BillRP
    {
        public String Table { get; set; }
        public String ProductType { get; set; }
        public String Product { get; set; }
        public String size { get; set; }
        public String Price { get; set; }
        public String Quantity { get; set; }
        public String TotalPrice { get; set; }
        public DateTime TimeOrder { get; set; }

    }
}
