using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantReviewMVC.Models
{
    public class Reviewer
    {
        public int ReviewerID { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}