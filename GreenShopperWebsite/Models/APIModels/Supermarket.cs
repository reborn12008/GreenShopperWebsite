using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenShopperWebsite.Models.APIModels { 
    public class Supermarket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field cannot be blank!")]
        [DisplayName("Supermercado")]
        public String Name { get; set; }

        public String Image { get; set; }
    }
}
