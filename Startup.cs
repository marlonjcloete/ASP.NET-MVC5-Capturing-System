using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FA_1.Startup))]
namespace FA_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
