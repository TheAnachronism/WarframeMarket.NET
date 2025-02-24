using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using WarframeMarketNET.Contracts;
using WarframeMarketNET.Implementations;

namespace WarframeMarketNET;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddWarframeMarket(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient<IWarframeMarketApiClient, WarframeMarketApiClient>(client =>
        {
            client.BaseAddress = new Uri("https://api.warframe.market/v1/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        });

        return serviceCollection;
    }
}