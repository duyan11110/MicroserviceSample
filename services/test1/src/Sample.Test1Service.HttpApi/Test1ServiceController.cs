using Sample.Test1Service.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sample.Test1Service;

public abstract class Test1ServiceController : AbpControllerBase
{
    protected Test1ServiceController()
    {
        LocalizationResource = typeof(Test1ServiceResource);
    }
}
