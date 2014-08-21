using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ode2Mvc4.Models
{
    public class RestaurantReview
    {
        [Required]
        public int ID { get; set; }

        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }

        public RestaurantReview(int id, string name, string city, string country, int rating)
        {
            this.ID = id;
            this.Name = name;
            this.City = city;
            this.Country = country;
            this.Rating = rating;
        }
        public RestaurantReview() {}

        public static List<RestaurantReview> GetReviews()
        {
            List<RestaurantReview> lre = new List<RestaurantReview>();
            lre.Add(new RestaurantReview
            (
                1,
                "Baja Fresh",
                "Anaheim",
                "Orange",
                7
            ));
            lre.Add(new RestaurantReview
            (
                2,
                "El Supremo",
                "Narrato",
                "Texas",
                5
            ));
            lre.Add(new RestaurantReview
            (
                3,
                "EJB",
                "Redondo Beach",
                "Hermosa",
                9
            ));
            return lre;
        }
    }

    
}