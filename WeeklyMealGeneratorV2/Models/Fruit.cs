using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMealGeneratorV2.Models
{
    public class Fruit
    {
        public Fruit()
        {
            NumberOfTimesPicked = 0;
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfTimesPicked { get; private set; }
        public virtual ICollection<ShoppingList> ShoppingLists { get; set; }

        public void BeenPicked()
        {
            NumberOfTimesPicked++;
        }

    }
}
