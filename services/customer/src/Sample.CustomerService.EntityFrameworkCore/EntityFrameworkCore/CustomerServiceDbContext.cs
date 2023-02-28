using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Sample.CustomerService.EntityFrameworkCore;

[ConnectionStringName(CustomerServiceDbProperties.ConnectionStringName)]
public class CustomerServiceDbContext : AbpDbContext<CustomerServiceDbContext>, ICustomerServiceDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<Customers.Customer> Customers { get; set; }

    public CustomerServiceDbContext(DbContextOptions<CustomerServiceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCustomerService();
    }
}
