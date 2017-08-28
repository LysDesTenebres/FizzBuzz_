using System.Web.Http;
using FizzBuzz.Web.Models;

namespace FizzBuzz.Web.Controllers.Api
{
    public class FizzBuzzController : ApiController //TODO: inherit from the correct base class
    {

        private readonly IFizzBuzzService service;

       // [Route("api/fizz/{fizzFactor:int}/buzz/{buzzFactor:int}{lastNumber:int?}")]
        public IHttpActionResult GetFizzBuzzText(int fizzFactor, int buzzFactor, int lastNumber=100)
        {
            var fizzbuzz = service.GenerateFizzBuzzText(fizzFactor, buzzFactor, lastNumber);
            if (fizzbuzz != "")
            {
                return Ok(fizzbuzz);
            }
            else
            {
                return NotFound();
            }

        }

    }
}
