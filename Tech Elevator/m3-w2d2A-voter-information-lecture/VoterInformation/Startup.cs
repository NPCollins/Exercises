using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoterInformation.Startup))]
namespace VoterInformation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
