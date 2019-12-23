using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ServerSignalR.Startup))]

namespace ServerSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
