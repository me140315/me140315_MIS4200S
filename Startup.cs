using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(me140315_MIS4200S.Startup))]
namespace me140315_MIS4200S
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
