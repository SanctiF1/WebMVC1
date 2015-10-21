using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebMVC1.Models;
using System.Data.Entity.Infrastructure;


namespace WebMVC1.DataAccessLayer
{
    public class SalesERPDAL:DbContext 
    {
        public DbSet<Employee> Employees { get; set; }

        //change the ConnectionString
        //public SalesERPDAL() : base("SalesERPDAL_BK")
        //{
        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Entity<Employee>().ToTable("Employees");
            base.OnModelCreating(modelBuilder);
        }

  
    }
}