using System;
using System.Collections.Generic;

#nullable disable

namespace GreenShopperWebsite.Models
{
    public partial class Product
    {
        public Product()
        {
            ShoplistProducts = new HashSet<ShoplistProduct>();
        }

        public int ProductId { get; set; }
        public string ApiProductId { get; set; }

        public virtual ICollection<ShoplistProduct> ShoplistProducts { get; set; }
    }
}
