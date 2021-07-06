using Exercise3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise3.ViewModels
{
    public class SupplierCountryViewModel
    {
        public IEnumerable<Country> Countries { get; set; }
        public Supplier Supplier { get; set; }
    }
}