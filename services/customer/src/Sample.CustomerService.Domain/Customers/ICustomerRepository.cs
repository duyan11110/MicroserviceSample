using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Sample.CustomerService.Customers
{
    public interface ICustomerRepository : IRepository<Customer>
    {
    }
}
