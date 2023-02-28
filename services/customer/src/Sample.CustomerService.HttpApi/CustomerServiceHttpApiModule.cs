using Localization.Resources.AbpUi;
using Sample.CustomerService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.CustomerService;

[DependsOn(
    typeof(CustomerServiceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class CustomerServiceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(CustomerServiceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<CustomerServiceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
