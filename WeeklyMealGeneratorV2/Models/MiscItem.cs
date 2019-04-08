using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMealGeneratorV2.Models
{
    public class MiscItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ShoppingList> ShoppingLists { get; set; }

        public int MiscItemId { get; set; }

        [ForeignKey(nameof(MiscItemId))]
        public MiscItemType MiscType { get; set; }



    }
}
