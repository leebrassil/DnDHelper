using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnDHelper.Startup))]
namespace DnDHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
