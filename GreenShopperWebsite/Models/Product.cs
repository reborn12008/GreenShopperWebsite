using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace GreenShopperWebsite.Models
{
    public partial class Product
    {
        public Product()
        {
            ShoplistProducts = new HashSet<ShoplistProduct>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProductId { get; set; }
        public string ApiProductId { get; set; }

        public virtual ICollection<ShoplistProduct> ShoplistProducts { get; set; }
    }
}
