using Sample.AdministrationService.EntityFrameworkCore;
using Sample.Shared.Hosting.AspNetCore;
using Medallion.Threading;
using Medallion.Threading.Redis;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using Volo.Abp.AspNetCore.MultiTenancy;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.DistributedLocking;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Sample.SaaSService.EntityFrameworkCore;
using Volo.Abp.EventBus.RabbitMq;

namespace Sample.Shared.Hosting.Microservices
{
    [DependsOn(
    typeof(SampleSharedHostingAspNetCoreModule),
    //typeof(AbpBackgroundJobsRabbitMqModule),
    typeof(AbpAspNetCoreMultiTenancyModule),
    typeof(AbpEventBusRabbitMqModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(SaaSServiceEntityFrameworkCoreModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(AbpDistributedLockingModule)
)]
    public class SampleSharedHostingMicroservicesModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
            var configuration = context.Services.GetConfiguration();

            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = true;
            });

            Configure<AbpDistributedCacheOptions>(options =>
            {
                options.KeyPrefix = "Sample:";
            });

            var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]);
            context.Services
                .AddDataProtection()
                .SetApplicationName("Sample")
                .PersistKeysToStackExchangeRedis(redis, "Sample-Protection-Keys");

            context.Services.AddSingleton<IDistributedLockProvider>(_ =>
            new RedisDistributedSynchronizationProvider(redis.GetDatabase()));
        }
    }
}
