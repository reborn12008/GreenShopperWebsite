using System;
using System.Collections.Generic;

#nullable disable

namespace GreenShopperWebsite.Models
{
    public partial class Shoplist
    {
        public Shoplist()
        {
            ShoplistProducts = new HashSet<ShoplistProduct>();
        }

        public int ShoplistId { get; set; }
        public string ImactDescricao { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<ShoplistProduct> ShoplistProducts { get; set; }
    }
}
