using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dylan.peng.netmysql.Startup))]
namespace dylan.peng.netmysql
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
