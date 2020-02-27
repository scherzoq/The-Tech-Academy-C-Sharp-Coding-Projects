using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Join Date")]
        public DateTime JoinDate { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}