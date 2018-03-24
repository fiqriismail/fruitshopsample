using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFruitShop.Web.Api.Models;
using MyFruitShop.Web.Api.Models.Mappers;

namespace MyFruitShop.Web.Api.BL
{
    public class FruitService
    {
        private FruitDbContext context = new FruitDbContext();

        public int SaveFruit(FruitMapper fruit)
        {
            var newFruit = new Fruit();

            if (fruit.Id != null)
            {
                newFruit = context.Fruits.Find(fruit.Id);
            }

            newFruit.Name = fruit.Name;
            newFruit.Quantity = fruit.Quantity;

            if (fruit.Id == null)
            {
                context.Entry(newFruit).State = System.Data.Entity.EntityState.Added;
            }
            else
            {
                context.Entry(newFruit).State = System.Data.Entity.EntityState.Modified;
            }

            if (context.SaveChanges() > 0)
            {
                return newFruit.Id;
            }

            return 0; 
           
        }
    }
}
