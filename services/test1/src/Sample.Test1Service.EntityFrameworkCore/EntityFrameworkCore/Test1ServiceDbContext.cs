using Microsoft.EntityFrameworkCore;
using Sample.Test1Service.UTIMaintenanceByCtParties;
using System.Reflection.Metadata;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Sample.Test1Service.EntityFrameworkCore;

[ConnectionStringName(Test1ServiceDbProperties.ConnectionStringName)]
public class Test1ServiceDbContext : AbpDbContext<Test1ServiceDbContext>, IJTest1ServiceDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    #region Entities
    public virtual DbSet<UTIMaintenanceByCtParty> UTIMaintenanceByCtParties { get; set; }
    #endregion

    #region Views
    public virtual DbSet<UTIMaintenanceByCtPartyGetListView> UTIMaintenanceByCtPartyGetListViews { get; set; }
    #endregion

    public Test1ServiceDbContext(DbContextOptions<Test1ServiceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureTest1Service();
    }
}
