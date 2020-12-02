using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EfaasSampleMvcWebApplication.Startup))]
namespace EfaasSampleMvcWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
