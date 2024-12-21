using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalManagementSystemNew.Startup))]
namespace HospitalManagementSystemNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
