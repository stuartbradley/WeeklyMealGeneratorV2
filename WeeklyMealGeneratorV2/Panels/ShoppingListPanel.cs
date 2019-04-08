using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using WeeklyMealGeneratorV2.Models;

namespace WeeklyMealGeneratorV2.Panels
{
    public partial class ShoppingListPanel : UserControl
    {
        public ShoppingListPanel()
        {
            InitializeComponent();
            {
                if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
                {
                    gvShoppingLists.AutoGenerateColumns = false;
                    gvMeals.AutoGenerateColumns = false;
                    gvFruit.AutoGenerateColumns = false;
                    SetShoppingLists();
                }
            }
        }

        public void SetShoppingLists()
        {
            using (var db = new MealGeneratorContext())
            {
                gvShoppingLists.DataSource = db.ShoppingLists
                    .Include(s => s.Meals)
                    .Include("Meals.Ingredients")
                    .Include(s => s.Fruits)
                    .Include(s => s.MiscItems)
                    .ToList();
            }
        }

        private void gvShoppingLists_SelectionChanged(object sender, EventArgs e)
        {
            ShoppingList shoppingList = (ShoppingList)gvShoppingLists.CurrentRow.DataBoundItem;


            gvMeals.DataSource = shoppingList.Meals.ToList();
            gvFruit.DataSource = shoppingList.Fruits.ToList();
            gvMeals.Refresh();
            gvFruit.Refresh();

        }
    }
}
