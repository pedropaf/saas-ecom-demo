using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySaasProject.Startup))]
namespace MySaasProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
