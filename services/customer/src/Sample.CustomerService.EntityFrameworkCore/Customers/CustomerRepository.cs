using Sample.CustomerService.Customers;
using Sample.CustomerService.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Sample.CustomerService.Repositories
{
    public class CustomerRepository : EfCoreRepository<CustomerServiceDbContext, Customers.Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbContextProvider<CustomerServiceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
