using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrowdfundingPlatform.Startup))]
namespace CrowdfundingPlatform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
