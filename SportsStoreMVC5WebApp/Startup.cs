using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsStoreMVC5WebApp.Startup))]
namespace SportsStoreMVC5WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
