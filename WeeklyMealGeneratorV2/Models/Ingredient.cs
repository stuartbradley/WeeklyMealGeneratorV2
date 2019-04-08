using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMealGeneratorV2.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FoodType { get; set; }
        public decimal AveragePrice { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}
