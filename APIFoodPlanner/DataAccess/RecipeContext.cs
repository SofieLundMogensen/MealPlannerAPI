using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIFoodPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace APIFoodPlanner.DataAccess
{
    public class RecipeContext : DbContext
    {
        public DbSet<Recipe> Recipe { get; set; }

        public DbSet<Food> Food { get; set; }
        public DbSet<Measure> Measure { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
      


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysql85.unoeuro.com;user=slund_info;database=slund_info_db;port=3306;password=14Unicorn01");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
            });


            modelBuilder.Entity<Measure>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Short);
                entity.Property(e => e.Type);
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Quantity);
                entity.HasOne(e => e.Food);
                entity.HasOne(e => e.Measure);
               // entity.HasOne(e => e.Recipe).WithMany(e => e.Ingredients);
            });
            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.Description);
                entity.HasMany(e => e.Ingredients);
            });

        }

    }
}