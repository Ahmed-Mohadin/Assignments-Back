using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class OrderLineModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ProductEntity")]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "tinyint")]
        public int Quantity { get; set; }
    }
}
