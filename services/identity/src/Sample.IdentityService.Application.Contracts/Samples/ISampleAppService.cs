using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Sample.IdentityService.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
