using System;
using Microsoft.Extensions.DependencyInjection;
using Sample.SaaSService;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Sample.SaaSService.EntityFrameworkCore;

[DependsOn(
    typeof(SaaSServiceDomainModule),
    typeof(AbpTenantManagementEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule)
)]
public class SaaSServiceEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbContextOptions>(options =>
        {
            options.UseSqlServer();
        });

        //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        context.Services.AddAbpDbContext<SaaSServiceDbContext>(options =>
        {
            options.ReplaceDbContext<ITenantManagementDbContext>();
            options.AddDefaultRepositories(true);
        });
    }
}