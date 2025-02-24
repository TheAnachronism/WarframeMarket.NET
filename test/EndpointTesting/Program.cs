
using Microsoft.Extensions.DependencyInjection;
using WarframeMarketNET;
using WarframeMarketNET.Contracts;

var collection = new ServiceCollection()
    .AddWarframeMarket()
    .AddLogging();

var services = collection.BuildServiceProvider();

var client = services.GetRequiredService<IWarframeMarketApiClient>();

var item = await client.GetRivenAttributesAsync();