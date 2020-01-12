using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFoodPlanner.Models
{
    public class Measure
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Short { get; set; }

        //public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}