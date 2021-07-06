using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise3.Models
{
    public class VatValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var supplier = (Supplier)validationContext.ObjectInstance;

            int _numVAT = 0;
            if (supplier.TaxNumber == null || supplier.TaxNumber.Length != 9 || !int.TryParse(supplier.TaxNumber, out _numVAT))
                return new ValidationResult("Please provide a valid VAT");

            else
            {
                double sum = 0;
                int iter = supplier.TaxNumber.Length - 1;
                supplier.TaxNumber.ToCharArray().Take(iter).ToList().ForEach(c =>
                {
                    sum += double.Parse(c.ToString()) * Math.Pow(2, iter);
                    iter--;
                });
                if (sum % 11 == double.Parse(supplier.TaxNumber.Substring(8)) || double.Parse(supplier.TaxNumber.Substring(8)) == 0)
                    return ValidationResult.Success; 
                else
                    return new ValidationResult("Please provide a valid VAT");
            }
        }
    }
}