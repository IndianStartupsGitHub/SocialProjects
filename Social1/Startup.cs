using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Social1.Startup))]
namespace Social1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
