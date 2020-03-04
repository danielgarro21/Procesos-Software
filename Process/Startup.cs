using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Process.Startup))]
namespace Process
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
