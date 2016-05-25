using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab01.Models
{
    public class CustomerDB :DbContext
    {
        public DbSet<Customer> Customers { get; set; }

    }
}