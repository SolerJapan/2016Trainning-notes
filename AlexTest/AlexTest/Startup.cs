using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlexTest.Startup))]
namespace AlexTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
