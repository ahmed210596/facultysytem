using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp3.Startup))]
namespace WebApp3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
