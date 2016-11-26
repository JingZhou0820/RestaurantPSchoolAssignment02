using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantPSchoolAssignment02.Startup))]
namespace RestaurantPSchoolAssignment02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
