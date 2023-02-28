using Sample.SaaSService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sample.SaaSService;

public abstract class SaaSServiceController : AbpControllerBase
{
    protected SaaSServiceController()
    {
        LocalizationResource = typeof(SaaSServiceResource);
    }
}
