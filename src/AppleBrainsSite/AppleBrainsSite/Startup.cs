using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppleBrainsSite.Startup))]
namespace AppleBrainsSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
