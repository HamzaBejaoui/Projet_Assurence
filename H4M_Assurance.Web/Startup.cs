using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(H4M_Assurance.Web.Startup))]
namespace H4M_Assurance.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
