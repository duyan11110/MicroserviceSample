using Sample.Shared.Hosting.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;

namespace Sample.Shared.Hosting.Gateways
{
    [DependsOn(
        typeof(SampleSharedHostingAspNetCoreModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
    )]
    public class SampleSharedHostingGatewaysModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            context.Services.AddReverseProxy()
                .LoadFromConfig(configuration.GetSection("ReverseProxy"));
        }
    }
}