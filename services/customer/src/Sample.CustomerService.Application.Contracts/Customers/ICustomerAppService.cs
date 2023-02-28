using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Sample.CustomerService.Customers
{
    public interface ICustomerAppService : IApplicationService
    {
        //Task<LoadResult> GetBasicListAsync(int skip, int take);
        Task<LoadResult> GetBasicListAsync(DataSourceLoadOptions loadOptions);
        Task<BasicCustomerDto> GetByIdAsync(int customerID);
    }
}
