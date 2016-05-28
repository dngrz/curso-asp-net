using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFWeb.Models
{
    public class Category
    {
        public int categoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string description { get; set; }

        [StringLength(100)]
        public string salesContact { get; set; }

        [Required]
        public int salesNumbers { get; set; }
    }
}