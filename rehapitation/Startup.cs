using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rehapitation.Startup))]
namespace rehapitation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
