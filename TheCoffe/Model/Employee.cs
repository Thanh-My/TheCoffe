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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public string UsernameEmp { get; set; }
        public string NameEmp { get; set; }
        public string Gender { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string salary { get; set; }
        public string Address { get; set; }
        public string Hinh { get; set; }
        public string pass { get; set; }
        public bool administrator { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
