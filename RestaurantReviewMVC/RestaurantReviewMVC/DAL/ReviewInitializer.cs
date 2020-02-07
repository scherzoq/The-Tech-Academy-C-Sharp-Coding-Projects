using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RestaurantReviewMVC.Models;

namespace RestaurantReviewMVC.DAL
{
    public class ReviewInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ReviewContext>
    {
        protected override void Seed(ReviewContext context)
        {
            var restaurants = new List<Restaurant>
            {
            new Restaurant{Name="Capitol Steakhouse",Address="2100 Washington Avenue",Specialty="Steakhouse", Price=Price.High},
            new Restaurant{Name="Le Poisson",Address="152 Seaside Drive",Specialty="Seafood", Price=Price.High},
            new Restaurant{Name="Roma",Address="530 Jefferson Street",Specialty="Italian", Price=Price.High},
            new Restaurant{Name="Kyoto Sushi",Address="1350 Main Street",Specialty="Sushi", Price=Price.Medium},
            new Restaurant{Name="Sandy's Lobster Shack",Address="325 Seaside Drive",Specialty="Seafood", Price=Price.Medium},
            new Restaurant{Name="Bill's Diner",Address="424 Lincoln Road",Specialty="Diner", Price=Price.Low},
            new Restaurant{Name="Mountain View Pizza Parlor",Address="581 Mountain View Drive",Specialty="Pizza", Price=Price.Low},
            };

            restaurants.ForEach(s => context.Restaurants.Add(s));
            context.SaveChanges();

            var reviewers = new List<Reviewer>
            {
            new Reviewer{Name="George Washington", JoinDate=DateTime.Parse("2017-07-04")},
            new Reviewer{Name="Jane Austen", JoinDate=DateTime.Parse("2018-09-02")},
            new Reviewer{Name="Albert Einstein", JoinDate=DateTime.Parse("2019-01-19")},
            new Reviewer{Name="Anna Magdalena Bach", JoinDate=DateTime.Parse("2019-02-27")},
            new Reviewer{Name="Thelonius Monk", JoinDate=DateTime.Parse("2019-05-20")}
            };
            
            reviewers.ForEach(s => context.Reviewers.Add(s));
            context.SaveChanges();

            var reviews = new List<Review>
            {
            new Review{RestaurantID=1,ReviewerID=1,Rating=Rating.Rate_5, ReviewText="The ribeye was perfectly cooked!", ReviewDate=DateTime.Parse("2018-07-04")},
            new Review{RestaurantID=1,ReviewerID=4,Rating=Rating.Rate_4, ReviewText="Side dishes were great!", ReviewDate=DateTime.Parse("2020-01-02")},
            new Review{RestaurantID=2,ReviewerID=2,Rating=Rating.Rate_2, ReviewText="OK, but not worth the high price tag.", ReviewDate=DateTime.Parse("2020-02-05")},
            new Review{RestaurantID=3,ReviewerID=5,Rating=Rating.Rate_5, ReviewText="The tagliatelle with wild mushrooms was excellent!", ReviewDate=DateTime.Parse("2019-11-01")},
            new Review{RestaurantID=4,ReviewerID=2,Rating=Rating.Rate_4, ReviewText="One of the best sushi spots in Epicureanville!", ReviewDate=DateTime.Parse("2019-06-05")},
            new Review{RestaurantID=5,ReviewerID=3,Rating=Rating.Rate_1, ReviewText="Oysters were sandy/gritty!", ReviewDate=DateTime.Parse("2019-07-09")},
            new Review{RestaurantID=5,ReviewerID=4,Rating=Rating.Rate_4, ReviewText="Excellent hot lobster roll!", ReviewDate=DateTime.Parse("2019-10-25")},
            new Review{RestaurantID=6,ReviewerID=3,Rating=Rating.Rate_3, ReviewText="Good breakfast sandwiches.", ReviewDate=DateTime.Parse("2019-12-06")},
            new Review{RestaurantID=7,ReviewerID=1,Rating=Rating.Rate_1, ReviewText="Pizza crust tastes like cardboard.", ReviewDate=DateTime.Parse("2019-02-15")},
            };

            reviews.ForEach(s => context.Reviews.Add(s));
            context.SaveChanges();
        }
    }
}