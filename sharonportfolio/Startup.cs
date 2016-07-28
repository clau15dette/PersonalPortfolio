using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sharonportfolio.Startup))]
namespace sharonportfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
