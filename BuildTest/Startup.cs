using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildTest.Startup))]
namespace BuildTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
