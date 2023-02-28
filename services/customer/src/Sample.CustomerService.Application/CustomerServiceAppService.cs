using Sample.CustomerService.Localization;
using Volo.Abp.Application.Services;

namespace Sample.CustomerService;

public abstract class CustomerServiceAppService : ApplicationService
{
    protected CustomerServiceAppService()
    {
        LocalizationResource = typeof(CustomerServiceResource);
        ObjectMapperContext = typeof(CustomerServiceApplicationModule);
    }
}
