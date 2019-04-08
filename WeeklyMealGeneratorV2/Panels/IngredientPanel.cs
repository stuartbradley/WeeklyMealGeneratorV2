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
    public partial class IngredientPanel : UserControl
    {
        public IngredientPanel()
        {
            InitializeComponent();
            gvIngredients.AutoGenerateColumns = false;
            gvMeals.AutoGenerateColumns = false;
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                SetIngredientsForIngredientGrid();
               
            }
        }

        private void SetIngredientsForIngredientGrid()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            using (var db = new MealGeneratorContext())
            {
                ingredients = db.Ingredients.Include(i => i.Meals).ToList();
            }
            gvIngredients.DataSource = ingredients;
        }

        private void gvIngredients_SelectionChanged(object sender, EventArgs e)
        {
            if (gvIngredients.CurrentRow.Index < 0)
                return;
            Ingredient ingredient = (Ingredient)gvIngredients.CurrentRow.DataBoundItem;
            List<Meal> meals = ingredient.Meals.ToList();
            gvMeals.DataSource = meals;
            gvMeals.Refresh();
        }
    }
}
