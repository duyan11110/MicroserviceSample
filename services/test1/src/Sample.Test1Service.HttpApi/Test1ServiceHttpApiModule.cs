using Localization.Resources.AbpUi;
using Sample.Test1Service.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Test1Service;

[DependsOn(
    typeof(Test1ServiceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class Test1ServiceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(Test1ServiceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<Test1ServiceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
