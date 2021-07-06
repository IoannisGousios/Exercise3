using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise3.Models
{
    public class Supplier
    {      
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        [MinLength(3)]
        [SupplierExists]
        public string Name { get; set; }

        [Required]
        public int SupplierCategoryId { get; set; }

        public SupplierCategory SupplierCategory { get; set; }

        [Required]
        [VatValidator]
        [Display(Name = "VAT Number")]
        public string TaxNumber { get; set; }

        [MaxLength(100)]
        [MinLength(5)]
        public string Address { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string Email { get; set; }

        [Required]
        public int CountryId { get; set; }

        public Country Country { get; set; }

        public bool Active { get; set; }
    }
}
