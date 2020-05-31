using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My__Shop.WebUI.Startup))]
namespace My__Shop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
