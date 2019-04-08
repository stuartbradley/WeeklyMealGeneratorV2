using System;
using System.Collections.Generic;

namespace WeeklyMealGeneratorV2.Models
{
    public class ShoppingList
    {

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<Meal> Meals {get;set;}

        public virtual ICollection<MiscItem> MiscItems { get; set; }

        public virtual ICollection<Fruit> Fruits { get; set; }

    }
}
