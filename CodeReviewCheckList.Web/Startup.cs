using Owin;
using System.Web.Http;
using Microsoft.Owin;
using Unity.WebApi;

[assembly: OwinStartup(typeof(CodeReviewCheckList.Web.Startup))]

namespace CodeReviewCheckList.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {            
            GlobalConfiguration.Configure(config =>
            {
                config.DependencyResolver = new UnityDependencyResolver(UnityConfiguration.GetContainer());
                CodeReviewCheckList.ApiConfiguration.Install(config, app);
            });
        }
    }
}
