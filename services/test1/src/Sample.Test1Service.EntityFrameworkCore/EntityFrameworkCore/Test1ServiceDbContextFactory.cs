using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Sample.Test1Service.EntityFrameworkCore;
using Sample.Test1Service;

namespace Sample.Test1Service.EntityFrameworkCore;

public class Test1ServiceDbContextFactory : IDesignTimeDbContextFactory<Test1ServiceDbContext>
{
    public Test1ServiceDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<Test1ServiceDbContext>()
            .UseSqlServer(GetConnectionStringFromConfiguration());

        return new Test1ServiceDbContext(builder.Options);
    }

    private static string GetConnectionStringFromConfiguration()
    {
        return BuildConfiguration()
            .GetConnectionString(Test1ServiceDbProperties.ConnectionStringName);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(
                Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory())?.Parent!.FullName!,
                    $"host{Path.DirectorySeparatorChar}Sample.Test1Service.HttpApi.Host"
                )
            )
            .AddJsonFile("appsettings.json", false);

        return builder.Build();
    }
}