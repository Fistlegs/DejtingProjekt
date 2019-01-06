using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DejtingProjekt.Startup))]
namespace DejtingProjekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
