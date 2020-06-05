using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tourrrrr.Startup))]
namespace Tourrrrr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
