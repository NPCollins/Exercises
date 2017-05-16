using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeatherWebsite.Startup))]
namespace WeatherWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
