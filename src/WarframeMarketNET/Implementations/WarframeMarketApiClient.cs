using System.Text.Json;
using Microsoft.Extensions.Logging;
using WarframeMarketNET.Contracts;
using WarframeMarketNET.Responses;

namespace WarframeMarketNET.Implementations;

internal class WarframeMarketApiClient : IWarframeMarketApiClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<WarframeMarketApiClient> _logger;

    private readonly JsonSerializerOptions _serializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public WarframeMarketApiClient(HttpClient httpClient, ILogger<WarframeMarketApiClient> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<GetAllItemsResponse> GetAlItemsAsync(CancellationToken ct = default)
    {
        const string requestUrl = "items";

        var response = await _httpClient.GetAsync(requestUrl, ct);
        response.EnsureSuccessStatusCode();

        var stream = await response.Content.ReadAsStreamAsync(ct);
        var enumerable =
            await JsonSerializer.DeserializeAsync<ResponseWrapper<GetAllItemsResponse>>(stream, _serializerOptions,
                cancellationToken: ct);
        return enumerable!.Payload!;
    }

    public async Task<GetItemResponse> GetItemAsync(string urlName, CancellationToken cancellationToken = default)
    {
        var requestUrl = $"items/{urlName}";

        var response = await _httpClient.GetAsync(requestUrl, cancellationToken);
        response.EnsureSuccessStatusCode();

        var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
        var item = await JsonSerializer.DeserializeAsync<ResponseWrapper<GetItemResponse>>(stream,
            _serializerOptions, cancellationToken: cancellationToken);
        return item!.Payload!;
    }
}