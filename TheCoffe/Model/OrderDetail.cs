//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheCoffe.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int IdOrderDetail { get; set; }
        public Nullable<int> IDOrder { get; set; }
        public string IDProduct { get; set; }
        public int Quantity { get; set; }
        public int price { get; set; }
        public Nullable<System.DateTime> TimeOrder { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
