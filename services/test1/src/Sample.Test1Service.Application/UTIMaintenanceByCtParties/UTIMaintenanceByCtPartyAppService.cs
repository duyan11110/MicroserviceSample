using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;
using Sample.Test1Service.Common;
using Sample.Test1Service.Permissions;

namespace Sample.Test1Service.UTIMaintenanceByCtParties
{
    [Authorize(Test1ServicePermissions.UTIMaintenanceByCtParties.Default)]
    public class UTIMaintenanceByCtPartyAppService : Test1ServiceAppService, IUTIMaintenanceByCtPartyAppService
    {
        IUTIMaintenanceByCtPartyGetListViewRepository _utiMaintenanceGetListViewRepository;
        IUTIMaintenanceByCtPartyRepository _utiMaintenanceByCtPartyRepository;

        public UTIMaintenanceByCtPartyAppService(
            IUTIMaintenanceByCtPartyGetListViewRepository utiMaintenanceByCtPartyGetListViewRepository
            , IUTIMaintenanceByCtPartyRepository utiMaintenanceByCtPartyRepository

            )
        {
            _utiMaintenanceGetListViewRepository = utiMaintenanceByCtPartyGetListViewRepository;
            _utiMaintenanceByCtPartyRepository = utiMaintenanceByCtPartyRepository;
        }

        public async Task<LoadResult> GetListAsync(string value, DataSourceLoadOptions loadOptions)
        {
            try
            {
                var filter = new UTIMaintenanceByCtPartyFilterDto();
                if (!string.IsNullOrEmpty(value))
                {
                    filter = JsonConvert.DeserializeObject<UTIMaintenanceByCtPartyFilterDto>(value);
                }
                loadOptions.RequireTotalCount = true;

                var utiMaintenances = await _utiMaintenanceGetListViewRepository.GetQueryableAsync();
                var query = utiMaintenances
                            .WhereIf(filter.CustomerID.HasValue, c => c.CustomerID == filter.CustomerID)
                            .WhereIf(!string.IsNullOrEmpty(filter.TransType), c => c.TransType == filter.TransType)
                            .WhereIf(!string.IsNullOrEmpty(filter.Type), c => c.Type == filter.Type)
                            ;
                return await DataSourceLoader.LoadAsync(query, loadOptions);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
