using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AvailableDomainBackLinkSpider.Startup))]
namespace AvailableDomainBackLinkSpider
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
