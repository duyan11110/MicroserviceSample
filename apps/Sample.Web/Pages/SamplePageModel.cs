﻿using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Sample.Web.Pages;

public abstract class SamplePageModel : AbpPageModel
{
    protected SamplePageModel()
    {
        //LocalizationResourceType = typeof(SampleResource);
    }
}
