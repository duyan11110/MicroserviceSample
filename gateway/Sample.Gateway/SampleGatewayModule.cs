using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Rewrite;
using Sample.Shared.Hosting.AspNetCore;
using Sample.Shared.Hosting.Gateways;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace Sample.Gateway;

[DependsOn(
    typeof(SampleSharedHostingGatewaysModule)
)]
public class SampleGatewayModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();
        var hostingEnvironment = context.Services.GetHostingEnvironment();

        SwaggerConfigurationHelper.ConfigureWithAuth(
            context: context,
            authority: configuration["AuthServer:Authority"],
            scopes: new
                Dictionary<string, string> /* Requested scopes for authorization code request and descriptions for swagger UI only */
                {
                    {"IdentityService", "Identity Service API"},
                    {"AdministrationService", "Administration Service API"},
                    {"SaaSService", "SaaS Service API"},
                    {"Test1Service", "Test1 Service API"},
                    {"CustomerService", "Customer Service API"}
                },
            apiTitle: "Sample Gateway"
        );

        context.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder
                    .WithOrigins(
                        configuration["App:CorsOrigins"]
                            .Split(",", StringSplitOptions.RemoveEmptyEntries)
                            .Select(o => o.Trim().RemovePostFix("/"))
                            .ToArray()
                    )
                    .WithAbpExposedHeaders()
                    .SetIsOriginAllowedToAllowWildcardSubdomains()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
            });
        });
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        app.UseCorrelationId();
        app.UseAbpSerilogEnrichers();
        app.UseCors();
        app.UseSwaggerUIWithYarp(context);

        app.UseRewriter(new RewriteOptions()
            // Regex for "", "/" and "" (whitespace)
            .AddRedirect("^(|\\|\\s+)$", "/swagger"));

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapReverseProxy();
        });
    }
}