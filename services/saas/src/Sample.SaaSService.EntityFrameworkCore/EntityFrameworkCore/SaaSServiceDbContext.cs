using Microsoft.EntityFrameworkCore;
using Sample.SaaSService.EntityFrameworkCore;
using Sample.SaaSService;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Sample.SaaSService.EntityFrameworkCore;

[ConnectionStringName(SaaSServiceDbProperties.ConnectionStringName)]
public class SaaSServiceDbContext : AbpDbContext<SaaSServiceDbContext>, ITenantManagementDbContext, ISaaSServiceDbContext
{
    public SaaSServiceDbContext(DbContextOptions<SaaSServiceDbContext> options)
        : base(options)
    {
    }

    public DbSet<Tenant> Tenants { get; set; }

    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureSaaSService();
        builder.ConfigureTenantManagement();
    }
}