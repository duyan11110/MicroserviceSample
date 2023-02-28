using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Sample.Test1Service.EntityFrameworkCore;

[ConnectionStringName(Test1ServiceDbProperties.ConnectionStringName)]
public interface IJTest1ServiceDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
