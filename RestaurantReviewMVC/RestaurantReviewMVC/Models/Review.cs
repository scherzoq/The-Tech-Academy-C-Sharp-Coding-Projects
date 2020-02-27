using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantReviewMVC.Models
{
    public enum Rating
    {
        [Display(Name = "1")] Rate_1=1, [Display(Name = "2")] Rate_2=2, [Display(Name = "3")] Rate_3=3, [Display(Name = "4")] Rate_4 = 4, [Display(Name = "5")] Rate_5 = 5,
    }
    public class Review
    {
        public int ReviewID { get; set; }
        public int RestaurantID { get; set; }
        public int ReviewerID { get; set; }
        public Rating Rating { get; set; }
        [DisplayName("Review Text")]
        public string ReviewText { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Review Date")]
        public DateTime ReviewDate { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual Reviewer Reviewer { get; set; }
    }
}