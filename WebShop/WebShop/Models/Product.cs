using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Between {1} and {2} in character length!")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Image Link")]
        [StringLength(250, MinimumLength = 15, ErrorMessage = "Between {1} and {2} in character length!")]
        public string Img { get; set; }

        [Required]
        [DisplayName("Product Short Description")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Between {1} and {2} in character length!")]
        public string Short { get; set; }

        [Required]
        [DisplayName("Product Description")]
        [StringLength(8192, MinimumLength = 40, ErrorMessage = "Between {2} and more character in length!")]
        public string Description { get; set; }

        [Required]
        [Range(1, 200000, ErrorMessage = "Between {1} and {2} in character length!")]
        public int Price { get; set; }
    }
}
