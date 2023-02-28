using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Sample.Test1Service.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Sample.Test1Service.UTIMaintenanceByCtParties
{
    public interface IUTIMaintenanceByCtPartyAppService : IApplicationService
    {
        Task<LoadResult> GetListAsync(string value, DataSourceLoadOptions loadOptions);
    }
}
