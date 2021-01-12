using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seguridad.Startup))]
namespace Seguridad
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
