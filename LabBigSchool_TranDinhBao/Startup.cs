using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabBigSchool_TranDinhBao.Startup))]
namespace LabBigSchool_TranDinhBao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
