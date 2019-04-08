using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyMealGeneratorV2.Models;

namespace WeeklyMealGeneratorV2
{
    public class MealGeneratorContext:DbContext
    {
        public MealGeneratorContext() : base("name=MealDbConnectionString") { 
}
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}
