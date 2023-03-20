using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Entities.Context
{
    public class MyContext : DbContext
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
        public MyContext() : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employees> Employees { get; set; }
    }
}
