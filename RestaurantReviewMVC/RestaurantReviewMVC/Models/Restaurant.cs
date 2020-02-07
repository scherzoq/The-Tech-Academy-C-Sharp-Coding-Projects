using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantReviewMVC.Models
{
    public enum Price
    {
        [Display(Name = "$")] Low, [Display(Name = "$$")] Medium, [Display(Name = "$$$")] High
    }
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Specialty { get; set; }
        public Price? Price { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}