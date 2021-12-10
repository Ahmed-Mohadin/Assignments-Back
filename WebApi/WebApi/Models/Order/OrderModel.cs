using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("UserEntity")]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Status { get; set; }

        public virtual ICollection<OrderLineModel> OrderLines { get; set; }
    }
}
