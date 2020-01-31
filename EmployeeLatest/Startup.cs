using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeLatest.Startup))]
namespace EmployeeLatest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
