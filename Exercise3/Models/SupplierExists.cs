using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise3.Models
{
    public class SupplierExists : ValidationAttribute
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var supplier = (Supplier)validationContext.ObjectInstance;


            var nameExists = db.Suppliers.Any(x => x.Name == supplier.Name);
           
            
            if(nameExists)
                return new ValidationResult("Name already exists");
            else
                return ValidationResult.Success;


        }
    }
}
