using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeklyMealGeneratorV2.Models;

namespace WeeklyMealGeneratorV2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();


        }

        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            pnlFruit.Visible = false;
            pnlIngredient.Visible = false;
            pnlShoppingList.Visible = false;
            runGeneratorPanel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlIngredient.Visible = true;
            pnlFruit.Visible = false;
            pnlMenu.Visible = false;
            pnlShoppingList.Visible = false;
            runGeneratorPanel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlIngredient.Visible = false;
            pnlMenu.Visible = false;
            pnlFruit.Visible = true;
            pnlShoppingList.Visible = false;
            runGeneratorPanel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlIngredient.Visible = false;
            pnlMenu.Visible = false;
            pnlFruit.Visible = false;
            runGeneratorPanel1.Visible = true;
            pnlShoppingList.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlIngredient.Visible = false;
            pnlMenu.Visible = false;
            pnlFruit.Visible = false;
            runGeneratorPanel1.Visible = false;
            pnlShoppingList.Visible = true;
        }
    }
}
