namespace Sample.CustomerService;

public static class CustomerServiceDbProperties
{
    public static string DbTablePrefix { get; set; } = "tCIM_";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "CustomerService";
}
