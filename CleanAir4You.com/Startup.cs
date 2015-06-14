using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CleanAir4You.com.Startup))]
namespace CleanAir4You.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
