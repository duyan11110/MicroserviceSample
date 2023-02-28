// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Sample.Test1Service.UTIMaintenanceByCtParties;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;

// ReSharper disable once CheckNamespace
namespace Sample.Test1Service.UTIMaintenanceByCtParties;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IUTIMaintenanceByCtPartyAppService), typeof(UTIMaintenanceByCtPartyClientProxy))]
public partial class UTIMaintenanceByCtPartyClientProxy : ClientProxyBase<IUTIMaintenanceByCtPartyAppService>, IUTIMaintenanceByCtPartyAppService
{
    public virtual async Task<LoadResult> GetListAsync(string value, DataSourceLoadOptions loadOptions)
    {
        return await RequestAsync<LoadResult>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), value },
            { typeof(DataSourceLoadOptions), loadOptions }
        });
    }
}
