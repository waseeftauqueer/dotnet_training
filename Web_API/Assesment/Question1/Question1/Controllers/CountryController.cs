using Question1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Question1.Controllers
{
    [RoutePrefix("api/country")]
    public class CountryController : ApiController
    {
        static List<Country> countries = new List<Country>()
        {
            new Country { ID = 101, CountryName = "India", Capital = "Delhi" },
            new Country { ID = 102, CountryName = "USA", Capital = "Washington DC" },
            new Country { ID = 103, CountryName = "France", Capital = "Paris"},
            new Country { ID = 104, CountryName = "Portugal", Capital = "Lisbon"}
        };

        // Get All Countries
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // Add Country 
        [Route("")]
        public IHttpActionResult Post(Country country)
        {
            if (countries.Any(c => c.ID == country.ID))
                return BadRequest("Country with same ID already exists");

            if (string.IsNullOrWhiteSpace(country.CountryName))
                return BadRequest("CountryName is required");

            countries.Add(country);
            return Ok(country);
        }


        // Update Country Details
        [Route("{id:int}")]
        public IHttpActionResult Put(int id, Country country)
        {
            var coun = countries.FirstOrDefault(c => c.ID == id);
            if (coun == null)
                return NotFound();

            coun.CountryName = country.CountryName;
            coun.Capital = country.Capital;
            return Ok(coun);
        }

        // Delete any country by ID
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c =>c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            countries.Remove(country);
            return Ok("Country Removed Successfully");
        }
    }
}
