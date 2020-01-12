using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIFoodPlanner.DataAccess;
using APIFoodPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace APIFoodPlanner.Controllers
{
    public class RecipeController : ApiController
    {
     
        // GET api/recipies
        public List<Recipe> Getallrecipies()
        {
            using (var context = new RecipeContext())
            {
                //get recipe
                var xx = context.Recipe.Include("Ingredients.Measure").Include("Ingredients.Food").ToList();
                return xx;
            };
        }

        // GET api/recipies/{"text"}
        public Recipe GetById(int id)
        {
            using (var context = new RecipeContext())
            {

               
            
                //var dd = context.Recipe.Include(x => x.Ingredients).Take(1).FirstOrDefault();
                var customers = context.Recipe.Include("Ingredients.Measure").Include("Ingredients.Food").ToList();
                /*var hierarchy = from p in context.Recipe
                    .Include(p => p.Ingredients.Select(c => c.Ingredient)).ToList()
                                select p;*/
                return customers.Take(1).FirstOrDefault();
            };

          
        }

    }
}

