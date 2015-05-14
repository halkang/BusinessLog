using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusinessLog.Startup))]
namespace BusinessLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
