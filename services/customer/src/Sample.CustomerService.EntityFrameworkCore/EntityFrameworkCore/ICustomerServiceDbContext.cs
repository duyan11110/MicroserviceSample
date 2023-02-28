﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Sample.CustomerService.EntityFrameworkCore;

[ConnectionStringName(CustomerServiceDbProperties.ConnectionStringName)]
public interface ICustomerServiceDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
