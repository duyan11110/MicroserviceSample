using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Test1Service.UTIMaintenanceByCtParties;
using System.Threading.Tasks;

namespace Sample.Test1Service.Web.Pages.Test1.UTIMaintenanceByCtParties
{
    public class IndexModel : Test1ServicePageModel
    {
        private IWebHostEnvironment _environment;
        private IUTIMaintenanceByCtPartyAppService _utiMaintenanceAppService;

        public IndexModel(IWebHostEnvironment environment, IUTIMaintenanceByCtPartyAppService utiMaintenanceAppService)
        {
            _environment = environment;
            _utiMaintenanceAppService = utiMaintenanceAppService;
        }

        public void OnGet()
        {

        }

        public async Task OnPost([FromForm] IFormFile fileImport)
        {

        }
    }
}
