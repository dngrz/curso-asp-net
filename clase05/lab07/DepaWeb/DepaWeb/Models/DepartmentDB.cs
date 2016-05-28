using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DepaWeb.Models
{
    public class DepartmentDB : DbContext
    {
        public DbSet<Department> departments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department", schemaName: "HumanResources");
            base.OnModelCreating(modelBuilder);
            //Check
            // https://marcominerva.wordpress.com/2013/01/07/how-to-specify-table-schema-name-with-entity-framework-code-first/

        }

    }
}