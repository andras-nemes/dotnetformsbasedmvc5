using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityMvc5.Startup))]
namespace SecurityMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
