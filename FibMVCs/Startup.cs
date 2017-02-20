using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FibMVCs.Startup))]
namespace FibMVCs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
