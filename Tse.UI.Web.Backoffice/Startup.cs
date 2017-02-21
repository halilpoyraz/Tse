using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tse.UI.Web.Backoffice.Startup))]
namespace Tse.UI.Web.Backoffice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
