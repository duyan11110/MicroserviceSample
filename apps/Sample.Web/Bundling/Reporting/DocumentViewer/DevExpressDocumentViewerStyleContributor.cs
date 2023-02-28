using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace Sample.Web.Bundling.Reporting.DocumentViewer;

[DependsOn(
    typeof(DevExtremeStyleContributor)
)]
public class DevExpressDocumentViewerStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/libs/devexpress-reporting/css/dx-reporting-skeleton-screen.css");
        context.Files.AddIfNotContains("/libs/devexpress-analytics-core/css/dx-analytics.common.css");
        context.Files.AddIfNotContains("/libs/devexpress-analytics-core/css/dx-analytics.carmine.css");
        context.Files.AddIfNotContains("/libs/devexpress-reporting/css/dx-webdocumentviewer.css");
    }
}