using System.Text.Json;
using Microsoft.Extensions.Logging;
using WarframeMarketNET.Contracts;
using WarframeMarketNET.Responses;

namespace WarframeMarketNET.Implementations;

internal class WarframeMarketApiClient : IWarframeMarketApiClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<WarframeMarketApiClient> _logger;

    public WarframeMarketApiClient(HttpClient httpClient, ILogger<WarframeMarketApiClient> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<IEnumerable<GetAllItemsResponse>> GetAlItems(CancellationToken ct = default)
    {
        const string requestUrl = "items";

        var response = await _httpClient.GetAsync(requestUrl, ct);
        response.EnsureSuccessStatusCode();

        var stream = await response.Content.ReadAsStreamAsync(ct);
        var enumerable =
            await JsonSerializer.DeserializeAsync<ResponseWrapper<IEnumerable<GetAllItemsResponse>>>(stream,
                cancellationToken: ct);
        return enumerable!.Payload!;
    }
}