using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyMealGeneratorV2.Models;
using System.Data.Entity;
using System.ComponentModel;

namespace WeeklyMealGeneratorV2.Presenters
{
    public class PreMenu
    {
        private IMenu view;
        public PreMenu(IMenu view)
        {
            this.view = view;
            view.Meals = GetAllMeals();
        }

        private BindingList<Meal> GetAllMeals()
        {
            List<Meal> meals = new List<Meal>();
            using (var db = new MealGeneratorContext())
            {
                meals = db.
                     Meals
                    .Include(a => a.Ingredients)
                    .ToList();
            }
            BindingList<Meal> mealBinded = new BindingList<Meal>(meals);
            return mealBinded;
        }

        internal List<Ingredient> GetAllIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            using (var db = new MealGeneratorContext())
            {
                ingredients = db.Ingredients.ToList();
            }
            return ingredients;
        }

        internal async void DeleteMeal(Meal meal)
        {
            using (var db = new MealGeneratorContext())
            {
                db.Meals.Attach(meal);
                db.Meals.Remove(meal);
                await db.SaveChangesAsync();
            }
        }
    }
}
