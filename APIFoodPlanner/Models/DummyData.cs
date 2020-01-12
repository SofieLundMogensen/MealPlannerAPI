using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFoodPlanner.Models
{
    public class DummyData
    {
        public List<Recipe> Recipes()
        {
            List<Recipe> recipes = new List<Recipe>();

            Recipe r1 = new Recipe
            {
                Description = "En god ret",
                Id = 1,
                
            };
            return null;

        }
    }
}