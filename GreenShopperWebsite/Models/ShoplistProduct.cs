using System;
using System.Collections.Generic;

#nullable disable

namespace GreenShopperWebsite.Models
{
    public partial class ShoplistProduct
    {
        public int ShoplistProductId { get; set; }
        public int? ShoplistId { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Shoplist Shoplist { get; set; }
    }
}
