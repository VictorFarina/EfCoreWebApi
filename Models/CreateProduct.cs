using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ef_web_app.Models
{
    public class CreateProduct
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public decimal Price { get; set; }

    }
}
