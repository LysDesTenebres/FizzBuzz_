using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace FizzBuzz.Web.Controllers
{

    [Authorize(Users = "admin@pxl.be")]
    public class SecretController : Controller //TODO: inherit from the correct base class
    {

        public String Secret1()
        {
            return "Top secret 1";
        }

        public String Secret2()
        {
            return "Top secret 2";
        }

        
        [AllowAnonymous]
        public String Gossip()
        {
            string g = Guid.NewGuid().ToString();
            return g;
        }
    }
}