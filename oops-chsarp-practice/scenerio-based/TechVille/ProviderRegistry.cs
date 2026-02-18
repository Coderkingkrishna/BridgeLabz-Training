using System.Collections.Generic;

public static class ProviderRegistry
{
    private static readonly List<IExternalServiceProvider> providers = new List<IExternalServiceProvider>();

    public static void Register(IExternalServiceProvider provider)
    {
        if (provider == null)
            return;

        providers.Add(provider);
    }

    public static IEnumerable<Service> LoadServices()
    {
        List<Service> results = new List<Service>();

        foreach (var provider in providers)
        {
            foreach (var service in provider.GetServices())
            {
                if (service != null)
                    results.Add(service);
            }
        }

        return results;
    }
}
