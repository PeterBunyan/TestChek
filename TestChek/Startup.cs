using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestChek.Startup))]
namespace TestChek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
