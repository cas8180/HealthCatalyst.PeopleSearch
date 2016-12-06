using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthCatalyst.PeopleSearch.Web.Startup))]
namespace HealthCatalyst.PeopleSearch.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
