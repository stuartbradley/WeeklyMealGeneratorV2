using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeklyMealGeneratorV2.Models;

namespace WeeklyMealGeneratorV2
{
    public interface IMenu
    {
        BindingList<Meal> Meals{ get; set; }
    }
}
