using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise3.Models
{
    public class SupplierCategory
    {
        public int Id { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }
    }
}