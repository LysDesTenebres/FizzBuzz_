using System.Web.Mvc;
using FizzBuzz.Web.Controllers.Api;
using FizzBuzz.Web.Models.FizzBuzzViewModels;

namespace FizzBuzz.Web.Controllers
{
    public class HomeController : Controller //TODO: inherit from the correct base class
    {
        public ActionResult Index()
        {
            FizzBuzzViewModel model = new FizzBuzzViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(int fizz, int buzz, int length)
        {
          FizzBuzzController cont = new FizzBuzzController();

            return View();
        }


    }
}