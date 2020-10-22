using Microsoft.Owin.Security.Provider;
using RestaurantRating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace RestaurantRaterAPI.Controllers
{
    [RoutePrefix("api/restaurant")]
    public class RestaurantController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        // Return all restaurants in the database
        [HttpGet]
        public IHttpActionResult Index()
        {
            List<Restaurant> restaurantsInDB = _context.Restaurants.ToList();

            return Ok(restaurantsInDB);
        }
        // ReadSingle
        [HttpGet]
        [Route("{id")]
        public IHttpActionResult GetByID(int id)
        {
            Restaurant requestedRestaurant = _context.Restaurants.Find(id);
            if (requestedRestaurant == null)
            {
                return NotFound();
            }
            return Ok(requestedRestaurant);
        }
        //Create
        [HttpPost]
        public IHttpActionResult Create(Restaurant restaurantToAdd)
        {
            _context.Restaurants.Add(restaurantToAdd);

            if (_context.SaveChanges() == 1)
            {
                return Ok(restaurantToAdd);
            }

            return BadRequest();
        }
        //Update
        [HttpPut]
        public IHttpActionResult Update(Restaurant updatedRestaurant)
        {
            Restaurant requestedRestaurant = _context.Restaurants.Find(updatedRestaurant.RestaurantID);
            if (requestedRestaurant == null)
            {
                return BadRequest("Invalid ID");
                //return Not Found();
            }

            requestedRestaurant.Name = updatedRestaurant.Name;
            requestedRestaurant.Rating = updatedRestaurant.Rating;

            requestedRestaurant = updatedRestaurant;

            if (_context.SaveChanges() == 1)
            {
                return Ok(updatedRestaurant);
            }

            return BadRequest();
        }

        //Delete
        [HttpDelete]
        [Route("{id")]
        public IHttpActionResult Delete([FromUri] int id)
        {
            Restaurant requestedRestaurant = _context.Restaurants.Find(id);

            if (requestedRestaurant == null)
            {
                return BadRequest("Invalid ID");
            }

            _context.Restaurants.Remove(requestedRestaurant);

            if (_context.SaveChanges() == 1)
            {
                return Ok("Restaurant Deleted");
            }

            return BadRequest();
        }

    }
}
