using EntityFramework.Data;
using EntityFramework.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

Product veggie = new Product
{
    Name = "Veggie Pizaa",
    Price = 9.99m
};
context.Products.Add(veggie);

Product meatLovers = new Product
{
    Name = "Meat Lovers Pizza",
    Price = 11.99m
};
context.Products.Add(meatLovers);
context.SaveChanges();