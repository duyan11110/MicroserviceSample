using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Sample.Test1Service;

[DependsOn(
    typeof(Test1ServiceApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class Test1ServiceHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddStaticHttpClientProxies(
            typeof(Test1ServiceApplicationContractsModule).Assembly,
            Test1ServiceRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<Test1ServiceHttpApiClientModule>();
        });

    }
}
