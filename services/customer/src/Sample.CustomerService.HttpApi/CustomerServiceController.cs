using Sample.CustomerService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sample.CustomerService;

public abstract class CustomerServiceController : AbpControllerBase
{
    protected CustomerServiceController()
    {
        LocalizationResource = typeof(CustomerServiceResource);
    }
}
