using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctoDemo.Startup))]
namespace OctoDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
