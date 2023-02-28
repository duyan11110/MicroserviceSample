using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Sample.CustomerService.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
