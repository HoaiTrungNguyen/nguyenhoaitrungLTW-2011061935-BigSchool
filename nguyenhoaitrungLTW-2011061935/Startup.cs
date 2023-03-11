using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyenhoaitrungLTW_2011061935.Startup))]
namespace nguyenhoaitrungLTW_2011061935
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
