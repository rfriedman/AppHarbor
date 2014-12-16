using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppHarborTest.Startup))]
namespace AppHarborTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
