using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace RestaurantRating.Models
{
    //Entity Framwork
    //Entity 

    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

    }
}