﻿using System.Collections.Generic;
using Sample.Web.Bundling.Reporting.DocumentViewer;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace Sample.Web.Bundling.Reporting.DocumentDesigner;

[DependsOn(
    typeof(DevExpressDocumentViewerStyleContributor)
)]
public class DevExpressDocumentDesignerStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/libs/devexpress-analytics-core/css/dx-querybuilder.css");
        context.Files.AddIfNotContains("/libs/devexpress-reporting/css/dx-reportdesigner.css");
    }
}