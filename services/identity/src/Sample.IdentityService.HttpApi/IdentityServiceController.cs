using Sample.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sample.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}
