using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlmacenBasico.Startup))]
namespace AlmacenBasico
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
