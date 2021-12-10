using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    [Table("Products")]
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Img { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Short { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public int Price { get; set; }

        public virtual ICollection<OrderLineEntity> OrderLines { get; set; }
    }
}
