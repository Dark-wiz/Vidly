using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        protected ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
       public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {
            var customeer = _context.Customers.Single(c => c.Id
            == newRentalDto.CustomerId);
            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id));
            foreach(var movie in movies)
            {
                var rental = new Rental
                {
                    Customer = customeer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();
            return Ok();    
        }
    }
}
