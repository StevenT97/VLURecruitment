using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VLURecruit.Startup))]
namespace VLURecruit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
