using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyFruitShop.Web.Api.Models
{
    public class FruitDbContext : DbContext
    {
        public FruitDbContext() : base("FruitDbContext")
        {

        }

        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Customer> Customers { get; set; }
    } 
}
