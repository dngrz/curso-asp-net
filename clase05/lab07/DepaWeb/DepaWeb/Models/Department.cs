using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DepaWeb.Models
{
    public class Department
    {
        public Int16 departmentID { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string groupName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime modifiedDate { get; set; }
    }
}