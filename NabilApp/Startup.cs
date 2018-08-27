using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NabilApp.Startup))]
namespace NabilApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
