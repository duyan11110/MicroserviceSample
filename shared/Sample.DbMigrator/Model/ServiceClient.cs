using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.DbMigrator
{
    public class ServiceClient
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RootUrl { get; set; }
        public string[] Scopes { get; set; }
        public string[] GrantTypes { get; set; }
        public string RedirectUri { get; set; }
        public string PostLogoutRedirectUri { get; set; }
        public string[] AllowedCorsOrigins { get; set; }
    }
}
