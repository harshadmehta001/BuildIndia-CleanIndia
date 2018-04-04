using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildIndia.WebApp.Startup))]
namespace BuildIndia.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
