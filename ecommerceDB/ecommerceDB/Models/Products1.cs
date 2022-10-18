namespace ecommerceDB.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Products1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products1()
        {
            this.OrderProducts = new HashSet<OrderProduct>();
        }

        public int prodId { get; set; }
        public string prodName { get; set; }
        public string desc { get; set; }
        public double price { get; set; }
        public string img { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}