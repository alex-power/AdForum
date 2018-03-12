using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdForum.Startup))]
namespace AdForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
