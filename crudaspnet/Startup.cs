using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crudaspnet.Startup))]
namespace crudaspnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
