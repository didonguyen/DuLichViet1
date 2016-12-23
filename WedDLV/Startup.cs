using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WedDLV.Startup))]
namespace WedDLV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
