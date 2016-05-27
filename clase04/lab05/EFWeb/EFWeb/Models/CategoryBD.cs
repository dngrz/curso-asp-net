using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFWeb.Models
{
    public class CategoryBD : DbContext
    {
        public DbSet<Category> categories { get; set; }
    }
}