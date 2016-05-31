using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAutenticacion.Startup))]
namespace MVCAutenticacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
