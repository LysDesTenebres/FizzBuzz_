using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FizzBuzz.Web.Startup))]
namespace FizzBuzz.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
