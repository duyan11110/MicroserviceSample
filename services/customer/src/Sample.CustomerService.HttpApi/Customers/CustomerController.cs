using System.Threading.Tasks;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace MZH.MHIBS.CustomerService.Customers;

[Area(CustomerServiceRemoteServiceConsts.ModuleName)]
[RemoteService(Name = CustomerServiceRemoteServiceConsts.RemoteServiceName)]
//[Route(CustomerServiceRemoteServiceConsts.Customers.Default)]
public class CustomerController : CustomerServiceController, ICustomerAppService
{
    private readonly ICustomerAppService _customerAppService;

    public CustomerController(ICustomerAppService customerAppService)
    {
        _customerAppService = customerAppService;
    }

    [HttpGet]
    [Route(CustomerServiceRemoteServiceConsts.Customers.GetBasicList)]
    public async Task<LoadResult> GetBasicListAsync(DataSourceLoadOptions loadOptions)
    {
        return await _customerAppService.GetBasicListAsync(loadOptions);
    }

    [HttpGet]
    [Route(CustomerServiceRemoteServiceConsts.Customers.GetById)]
    public async Task<BasicCustomerDto> GetByIdAsync(int customerID)
    {
        return await _customerAppService.GetByIdAsync(customerID);
    }
}
