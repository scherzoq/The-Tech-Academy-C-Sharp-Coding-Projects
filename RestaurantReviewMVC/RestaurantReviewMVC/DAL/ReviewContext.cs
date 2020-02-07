using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestaurantReviewMVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RestaurantReviewMVC.DAL
{
    public class ReviewContext : DbContext
    {
        public ReviewContext() : base("ReviewContext")
        {
        }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Reviewer> Reviewers { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}