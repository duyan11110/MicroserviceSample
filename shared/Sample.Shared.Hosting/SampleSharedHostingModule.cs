using Volo.Abp.Autofac;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.MultiTenancy;

namespace Sample.Shared.Hosting
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpDataModule)
    )]
    public class SampleSharedHostingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureDatabaseConnections();
        }
        private void ConfigureDatabaseConnections()
        {
            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer();
            });

            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = true;
            });

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.Databases.Configure("SaaSService", database =>
                {
                    database.MappedConnections.Add("AbpTenantManagement");
                    database.IsUsedByTenants = false;
                });

                options.Databases.Configure("AdministrationService", database =>
                {
                    database.MappedConnections.Add("AbpAuditLogging");
                    database.MappedConnections.Add("AbpPermissionManagement");
                    database.MappedConnections.Add("AbpSettingManagement");
                    database.MappedConnections.Add("AbpFeatureManagement");
                    //database.MappedConnections.Add("AbpBlobStoring");
                });

                options.Databases.Configure("IdentityService", database =>
                {
                    database.MappedConnections.Add("AbpIdentity");
                    database.MappedConnections.Add("AbpOpenIddict");
                });
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
            });
        }
    }
}
