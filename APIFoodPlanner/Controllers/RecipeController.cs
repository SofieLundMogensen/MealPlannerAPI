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
                var customers = context.Recipe.Include("Ingredients.Measure").Include("Ingredients.Food").ToList();
                return customers.Where(i => i.Id == id).FirstOrDefault();
            };
        }
        // POST api/recipies
        public void post(Recipe recipe)
        {
            using (var context = new RecipeContext())
            {
                context.Recipe.Add(recipe);
                context.SaveChanges();
            };
          
        }

        // PUT api/recipies/5
        public void Put(Recipe recipe)
        {
            using (var context = new RecipeContext())
            {
                context.Recipe.Update(recipe);
                context.SaveChanges();
            };
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
           //To do: Handle delete
        }

    }
}

