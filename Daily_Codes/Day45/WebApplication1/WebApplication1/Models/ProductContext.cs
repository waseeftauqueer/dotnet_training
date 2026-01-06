using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=connectstr") { }

        public DbSet<Products> Product { get; set; }
        public DbSet<Sales> Sales { get; set; }

    }
}