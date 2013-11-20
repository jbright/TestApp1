using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApp1.Startup))]
namespace TestApp1
{
    public partial class Startup
    {
        /// <summary>
        /// Testing.
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
