using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(memberShip.Startup))]
namespace memberShip
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
