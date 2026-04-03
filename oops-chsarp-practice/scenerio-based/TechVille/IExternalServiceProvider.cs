using System.Collections.Generic;

public interface IExternalServiceProvider
{
    string ProviderName { get; }
    IEnumerable<Service> GetServices();
}
