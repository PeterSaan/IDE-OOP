using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingtipsToys.Startup))]
namespace WingtipsToys
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
