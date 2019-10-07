using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestrauntRaider.MVC.Startup))]
namespace RestrauntRaider.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
