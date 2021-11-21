using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ef_web_app.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Email { get; set; }

    }
}
