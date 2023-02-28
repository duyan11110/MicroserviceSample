using Sample.Test1Service.Localization;
using Volo.Abp.Application.Services;

namespace Sample.Test1Service;

public abstract class Test1ServiceAppService : ApplicationService
{
    protected Test1ServiceAppService()
    {
        LocalizationResource = typeof(Test1ServiceResource);
        ObjectMapperContext = typeof(Test1ServiceApplicationModule);
    }
}
