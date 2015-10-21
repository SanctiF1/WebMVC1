using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMVC1.Startup))]
namespace WebMVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
