using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S_Dproject.Startup))]
namespace S_Dproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
