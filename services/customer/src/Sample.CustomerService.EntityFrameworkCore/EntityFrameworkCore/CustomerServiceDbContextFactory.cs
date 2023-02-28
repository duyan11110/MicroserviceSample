using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Sample.CustomerService.EntityFrameworkCore;
using Sample.CustomerService;

namespace Sample.CustomerService.EntityFrameworkCore;

public class CustomerServiceDbContextFactory : IDesignTimeDbContextFactory<CustomerServiceDbContext>
{
    public CustomerServiceDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<CustomerServiceDbContext>()
            .UseSqlServer(GetConnectionStringFromConfiguration());

        return new CustomerServiceDbContext(builder.Options);
    }

    private static string GetConnectionStringFromConfiguration()
    {
        return BuildConfiguration()
            .GetConnectionString(CustomerServiceDbProperties.ConnectionStringName);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(
                Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory())?.Parent!.FullName!,
                    $"host{Path.DirectorySeparatorChar}Sample.CustomerService.HttpApi.Host"
                )
            )
            .AddJsonFile("appsettings.json", false);

        return builder.Build();
    }
}