using Sample.AdministrationService.EntityFrameworkCore;
using Sample.AdministrationService;
using Sample.IdentityService.EntityFrameworkCore;
using Sample.IdentityService;
using Sample.SaaSService.EntityFrameworkCore;
using Sample.SaaSService;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Sample.Test1Service;
using Sample.Test1Service.EntityFrameworkCore;
using Sample.CustomerService.EntityFrameworkCore;
using Sample.CustomerService;

namespace Sample.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(AdministrationServiceApplicationContractsModule),
    typeof(IdentityServiceEntityFrameworkCoreModule),
    typeof(IdentityServiceApplicationContractsModule),
    typeof(SaaSServiceEntityFrameworkCoreModule),
    typeof(SaaSServiceApplicationContractsModule),
    typeof(Test1ServiceEntityFrameworkCoreModule),
    typeof(Test1ServiceApplicationContractsModule),
    typeof(CustomerServiceEntityFrameworkCoreModule),
    typeof(CustomerServiceApplicationContractsModule)
    )]
public class SampleDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //base.ConfigureServices(context);
    }
}
