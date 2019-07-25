using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCprogram.Startup))]
namespace MVCprogram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
