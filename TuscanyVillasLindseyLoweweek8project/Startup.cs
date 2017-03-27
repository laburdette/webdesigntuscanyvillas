using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TuscanyVillasLindseyLoweweek8project.Startup))]
namespace TuscanyVillasLindseyLoweweek8project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
