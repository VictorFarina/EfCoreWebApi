using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef_web_app.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Desc { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; } 

    }
}