using System.Text.Json;
using System.Text.Json.Serialization;
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
        PropertyNameCaseInsensitive = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public WarframeMarketApiClient(HttpClient httpClient, ILogger<WarframeMarketApiClient> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<GetAllItemsResponse> GetAllItemsAsync(CancellationToken ct = default)
    {
        const string requestUrl = "items";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetAllItemsResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting items");
            throw;
        }
    }

    public async Task<GetItemResponse> GetItemAsync(string urlName, CancellationToken ct = default)
    {
        var requestUrl = $"items/{urlName}";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetItemResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting item");
            throw;
        }
    }

    public async Task<GetOrdersResponse> GetOrdersAsync(string urlName, Platform platform = Platform.PC,
        CancellationToken ct = default)
    {
        var requestUrl = $"items/{urlName}/orders";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            request.Headers.Add("Platform", platform.ToString());

            var result = await SendRequestAsync<GetOrdersResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting orders");
            throw;
        }
    }

    public async Task<GetLichWeaponsResponse> GetLichWeaponsAsync(CancellationToken ct = default)
    {
        const string requestUrl = "lich/weapons";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetLichWeaponsResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting lich weapons");
            throw;
        }
    }

    public async Task<GetLichEphemerasResponse> GetLichEphemerasAsync(CancellationToken ct = default)
    {
        const string requestUrl = "lich/ephemeras";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetLichEphemerasResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting lich ephemeras");
            throw;
        }
    }

    public async Task<GetLichQuirksResponse> GetLichQuirksAsync(CancellationToken ct = default)
    {
        const string requestUrl = "lich/quirks";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetLichQuirksResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting lich quirks");
            throw;
        }
    }

    public async Task<GetSisterWeaponsResponse> GetSisterWeaponsAsync(CancellationToken ct = default)
    {
        const string requestUrl = "sister/weapons";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetSisterWeaponsResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting sister weapons");
            throw;
        }
    }

    public async Task<GetSisterEphemerasResponse> GetSisterEphemerasAsync(CancellationToken ct = default)
    {
        const string requestUrl = "sister/ephemeras";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetSisterEphemerasResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting sister ephemeras");
            throw;
        }
    }

    public async Task<GetSisterQuirksResponse> GetSisterQuirksAsync(CancellationToken ct = default)
    {
        const string requestUrl = "sister/quirks";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetSisterQuirksResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting sister quirks");
            throw;
        }
    }

    public async Task<GetRivensResponse> GetRivensAsync(CancellationToken ct = default)
    {
        const string requestUrl = "riven/items";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetRivensResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting rivens");
            throw;
        }
    }

    public async Task<GetRivenAttributesResponse> GetRivenAttributesAsync(CancellationToken ct = default)
    {
        const string requestUrl = "riven/attributes";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetRivenAttributesResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting riven attributes");
            throw;
        }
    }

    public async Task<GetLocationsResponse> GetLocationsAsync(CancellationToken ct = default)
    {
        const string requestUrl = "locations";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetLocationsResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting locations");
            throw;
        }
    }

    public async Task<GetNpcResponse> GetNpcAsync(CancellationToken ct = default)
    {
        const string requestUrl = "npc";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetNpcResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting NPCs");
            throw;
        }
    }

    public async Task<GetMissionsResponse> GetMissionsAsync(CancellationToken ct = default)
    {
        const string requestUrl = "missions";

        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            var result = await SendRequestAsync<GetMissionsResponse>(request, ct);
            return result.Payload!;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "Error getting missions");
            throw;
        }
    }

    private async Task<ResponseWrapper<T>> SendRequestAsync<T>(HttpRequestMessage request,
        CancellationToken ct = default)
    {
        var response = await _httpClient.SendAsync(request, ct);
        response.EnsureSuccessStatusCode();

        var stream = await response.Content.ReadAsStreamAsync(ct);
        var item = await JsonSerializer.DeserializeAsync<ResponseWrapper<T>>(stream,
            _serializerOptions, cancellationToken: ct);
        return item!;
    }
}