using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMealGeneratorV2.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection <Ingredient> Ingredients { get; set; }
        public virtual ICollection<ShoppingList> ShoppingLists { get; set; }
    }
}
