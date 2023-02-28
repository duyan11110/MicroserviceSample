namespace Sample.CustomerService;

public class CustomerServiceRemoteServiceConsts
{
    public const string RemoteServiceName = "CustomerService";

    public const string ModuleName = "customer-service";

    public const string RootPath = "api/customer-service/";

    public class Customers
    {
        public const string Default = RootPath + "customer";
        public const string GetBasicList = Default + "/basic-list";
        public const string GetById = Default + "/by-id";
    }
}
