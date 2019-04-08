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
using WeeklyMealGeneratorV2.Presenters;


namespace WeeklyMealGeneratorV2.Panels
{
    [System.ComponentModel.Localizable(false)]
    public partial class MenuPanel : UserControl, IMenu
    {

        private PreMenu presenter;
        public BindingList<Meal> Meals { get; set; }

        public MenuPanel()
        {

            InitializeComponent();
            Meals = new BindingList<Meal>();
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                presenter = new PreMenu(this);
                gvMeals.AutoGenerateColumns = false;
                gvSelectIngredientsForMeal.AutoGenerateColumns = false;

                gvMeals.DataSource = Meals;
                gvMeals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvIngredients.AutoGenerateColumns = false;
                gvMeals.RowHeadersVisible = false;

            }

        }

        private void gvMeals_SelectionChanged(object sender, EventArgs e)
        {
            if (gvMeals.CurrentRow.Index < 0)
                return;
            Meal meal = (Meal)gvMeals.CurrentRow.DataBoundItem;
            List<Ingredient> ingredients = meal.Ingredients.ToList();
            gvIngredients.DataSource = ingredients;
            gvIngredients.Refresh();
        }

        private async void btnAddMeal_ClickAsync(object sender, EventArgs e)
        {
            if (tbMealName.Text == "")
                return;
            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (DataGridViewRow row in gvSelectIngredientsForMeal.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ingredients.Add(row.DataBoundItem as Ingredient);
                }
            }
            //move db to presenter
            Meal meal = new Meal()
            {
                Name = tbMealName.Text,
                IsActive = true,
                Ingredients = ingredients,
            };
            Meals.Add(meal);

            using (var db = new MealGeneratorContext())
            {
                db.Meals.Add(meal);
                await db.SaveChangesAsync();
            }
        }

        private void btnOpenAddMeal_Click(object sender, EventArgs e)
        {
            gvSelectIngredientsForMeal.DataSource = presenter.GetAllIngredients();
            pnAddMeal.Visible = true;
        }

        private void btnDeleteSelectedMeal_Click(object sender, EventArgs e)
        {
            //GetSelected Meal from grid and confirm deletion. 
            presenter.DeleteMeal(gvMeals.CurrentRow.DataBoundItem as Meal);
            Meals.Remove(gvMeals.CurrentRow.DataBoundItem as Meal);
            gvMeals.DataSource = Meals;

        }

        private void btnHideAddMealPanel_Click(object sender, EventArgs e)
        {
            pnAddMeal.Visible = false;
        }



        private void btnOpenAddMeal_Click_1(object sender, EventArgs e)
        {
            pnAddMeal.Visible = true;
            using (var db = new MealGeneratorContext())
            {
                List<Ingredient> allIngredients = db.Ingredients.ToList();
                gvSelectIngredientsForMeal.DataSource = allIngredients;
            }
            
        }

    }
}
