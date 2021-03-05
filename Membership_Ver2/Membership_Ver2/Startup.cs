using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Membership_Ver2.Startup))]
namespace Membership_Ver2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
