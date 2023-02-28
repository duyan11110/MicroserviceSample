using Sample.Test1Service.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Sample.Test1Service.Web.Pages;

/* Inherit your PageModel classes from this class. */
public abstract class Test1ServicePageModel : AbpPageModel
{
    protected Test1ServicePageModel()
    {
        LocalizationResourceType = typeof(Test1ServiceResource);
        ObjectMapperContext = typeof(Test1ServiceWebModule);
    }
}
