using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForecastWeatherAPI.Factory;
using ForecastWeatherAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ForecastWeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var rng = new Random();
            var number = Math.Round((decimal)rng.Next(0, 100), 0);
            //Randomly return an Error
            if (number % 2 == 0)
            {
                var repository = InstanceFactory.Create<IForecastWeatherRepository>();
                return Ok(
                    repository.GetForecastWeatherList()
                );
            }
            else
                //Return error 500
                return StatusCode(500);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
