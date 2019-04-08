using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeklyMealGeneratorV2.Models;
using System.Data.Entity;


namespace WeeklyMealGeneratorV2.Panels
{
    public partial class RunGeneratorPanel : UserControl
    {
        private MealGeneratorContext db;
        public RunGeneratorPanel()
        {
            InitializeComponent();
            gvMeals.AutoGenerateColumns = false;
            gvFruit.AutoGenerateColumns = false;
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                using (var db = new MealGeneratorContext())
                {
                    gvFruit.DataSource = db.Fruits.ToList();
                    gvMeals.DataSource = db.Meals.ToList();
                }
                cbNumberOfDays.Items.AddRange(Enumerable.Range(1, 7).Select(i => (object)i).ToArray());
                cbNumberOfFruit.Items.AddRange(Enumerable.Range(1, 5).Select(i => (object)i).ToArray());

            }
        }

        private void btnRunGenerator_Click(object sender, EventArgs e)
        {
            //getActiveMeals;
            db = new MealGeneratorContext();
            ShoppingList shoppingList = new ShoppingList
            {
                Meals = GetMeals(),
                Fruits = GetFruit(),
                Date = dtDateFrom.Value
            };
                db.ShoppingLists.Add(shoppingList);
                db.SaveChanges();
        }

        private List<Fruit> GetFruit()
        {
            List<Fruit> allFruits;
            List<Fruit> pickedFruits = new List<Fruit>();
            Random random = new Random();
            allFruits = db.Fruits.ToList();

                for (int i = 0; i < (int)cbNumberOfFruit.SelectedItem; i++)
                {
                    Fruit pickedFruit = allFruits[random.Next(1, allFruits.Count())];
                    pickedFruit.BeenPicked();

                    db.SaveChanges();
                    pickedFruits.Add(pickedFruit);
                }
            return pickedFruits;
        }

        private List<Meal> GetMeals()
        {
            List<Meal> activeMeals = new List<Meal>();
            List<Meal> pickedMeals = new List<Meal>();
            Random random = new Random();
            activeMeals = db.Meals.Include(m => m.Ingredients).Where(m => m.IsActive).ToList();

            if (activeMeals.Count() < (int)cbNumberOfDays.SelectedItem)
            {
                int leftOver = (int)cbNumberOfDays.SelectedItem - activeMeals.Count();
                List<Meal> leftOverMeals = new List<Meal>();
                leftOverMeals.AddRange(activeMeals);
                ResetMeals(leftOverMeals);
                activeMeals = db.Meals.Include(m => m.Ingredients).Where(m => m.IsActive).ToList();

                for (int i = 0; i < leftOver; i++)
                {
                    Meal pickedMeal = activeMeals[random.Next(1, activeMeals.Count)];
                    pickedMeals.Add(pickedMeal);
                    activeMeals.Remove(pickedMeal);
                }
                    foreach (Meal meal in pickedMeals)
                    {
                        db.Meals.Where(m => m.Id == meal.Id).Single().IsActive = false;

                    }
                    foreach(Meal meal in leftOverMeals)
                    {
                        db.Meals.Where(m => m.Id == meal.Id).Single().IsActive = true;
                    }
                    db.SaveChanges();
                    pickedMeals.AddRange(leftOverMeals);
                    return pickedMeals;
            }
            else
            {
                for (int i = 0; i < (int)cbNumberOfDays.SelectedItem; i++)
                {
                    Meal pickedMeal = activeMeals[random.Next(1, activeMeals.Count)];
                    pickedMeals.Add(pickedMeal);
                    activeMeals.Remove(pickedMeal);
                }
                    foreach (Meal meal in pickedMeals)
                    {
                        db.Meals.Where(m => m.Id == meal.Id).Single().IsActive = false;
                    }
                    db.SaveChanges();
                return pickedMeals;
            }
        }

        private void ResetMeals(List<Meal> notToBeReset)
        {
                foreach(Meal meal in db.Meals)
                {
                    if (notToBeReset.Contains(meal))
                        continue;
                    meal.IsActive = true;
                }
                db.SaveChanges();
        }
    }
}
