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

namespace WeeklyMealGeneratorV2.Panels
{
    public partial class FruitPanel : UserControl
    {
        public FruitPanel()
        {
            InitializeComponent();
            gvFruit.AutoGenerateColumns = false;
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                PopulateFruitGrid();
            }
        }

        private void PopulateFruitGrid()
        {
            using(var db = new MealGeneratorContext())
            {
                gvFruit.DataSource = db.Fruits.ToList();
            }
        }

        private async void btnAddFruit_Click(object sender, EventArgs e)
        {
            if (tbFruitName.Text == "")
                return;

            using (var db = new MealGeneratorContext())
            {
                Fruit fruit = new Fruit()
                {
                    Name = tbFruitName.Text
                };
                db.Fruits.Add(fruit);
                await db.SaveChangesAsync();
            }
            PopulateFruitGrid();

        }
    }
}
