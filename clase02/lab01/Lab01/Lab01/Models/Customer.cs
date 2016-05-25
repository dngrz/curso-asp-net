using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab01.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string ContactName { get; set; }

        [Required]
        [VerifyEmployees]
        public int NumberEmployees { get; set; }
    }

    public class VerifyEmployees : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int number = (int)value;
            return number < 20;
        }

        public VerifyEmployees()
        {
            ErrorMessage = "Información no Válida";
        }
    }

   

}