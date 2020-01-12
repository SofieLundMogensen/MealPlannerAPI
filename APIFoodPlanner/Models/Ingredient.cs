using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace APIFoodPlanner.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
  
        public virtual Measure Measure { get; set; }

        public double Quantity { get; set; }
        public virtual Food Food { get; set; }

        
        /*   [ForeignKey("RecipeId")]
           public virtual ICollection<IngredientRecipe> Recipes { get; set; }*/
    }
}