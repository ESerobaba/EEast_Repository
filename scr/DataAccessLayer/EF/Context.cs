using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
namespace DataAccessLayer.EF
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Indicator> Indicators { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public Context(DbContextOptions<Context> options)
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestData;Trusted_Connection=True;");
        }
        
    }
}
