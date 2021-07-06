using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise3.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(2)]
        [Display(Name = "Country Code")]
        public string Code { get; set; }

        [Required]
        [MaxLength(64)]
        public string Name { get; set; }
    }
}