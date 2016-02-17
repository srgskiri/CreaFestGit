using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApplicationGoCD.Startup))]
namespace TestApplicationGoCD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
