using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sample.Web.Pages.Reporting
{
    public class ViewerModel : PageModel
    {
        [BindProperty(Name = "reportName", SupportsGet = true)]
        public string ReportName { get; set; }
        public void OnGet()
        {
        }
    }
}
