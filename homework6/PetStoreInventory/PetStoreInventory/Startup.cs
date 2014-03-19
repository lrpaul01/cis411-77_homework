using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetStoreInventory.Startup))]
namespace PetStoreInventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
