using Microsoft.Owin;
using OrderLibrary.Rebates;
using Owin;

[assembly: OwinStartupAttribute(typeof(OfficeFurnitureProviderApp.Startup))]
namespace OfficeFurnitureProviderApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            CreationRebatesManager.CreateRebates();
            ConfigureAuth(app);
        }
    }
}
