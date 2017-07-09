using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(foodweb.Startup))]
namespace foodweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
