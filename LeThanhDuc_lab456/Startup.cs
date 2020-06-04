using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeThanhDuc_lab456.Startup))]
namespace LeThanhDuc_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
