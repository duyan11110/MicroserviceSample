using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace MZH.MHIBS.CustomerService.Samples;

[Area(CustomerServiceRemoteServiceConsts.ModuleName)]
[RemoteService(Name = CustomerServiceRemoteServiceConsts.RemoteServiceName)]
[Route("api/CustomerService/sample")]
public class CustomerController : CustomerServiceController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public CustomerController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
