//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class shipping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shipping()
        {
            this.orders = new HashSet<order>();
        }
    
        public decimal shipping_id { get; set; }
        public decimal users_id { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> shipping_created { get; set; }
        public Nullable<double> total_price { get; set; }
    
        public virtual user user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}
