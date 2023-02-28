using Sample.AdministrationService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sample.AdministrationService;

public abstract class AdministrationServiceController : AbpControllerBase
{
    protected AdministrationServiceController()
    {
        LocalizationResource = typeof(AdministrationServiceResource);
    }
}
