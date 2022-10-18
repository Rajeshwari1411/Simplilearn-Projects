namespace ecommerceDB.Models
{
    using System;
    using System.Collections.Generic;

    public partial class OrderProduct
    {
        public int Orders_Id { get; set; }
        public int Products1_prodId { get; set; }

        public virtual Products1 Products1 { get; set; }
    }
}