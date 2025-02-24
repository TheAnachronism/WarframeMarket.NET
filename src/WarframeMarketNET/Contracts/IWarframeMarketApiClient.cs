using WarframeMarketNET.Responses;

namespace WarframeMarketNET.Contracts;

public interface IWarframeMarketApiClient
{
    Task<GetAllItemsResponse> GetAlItemsAsync(CancellationToken ct = default);
    Task<GetItemResponse> GetItemAsync(string urlName, CancellationToken cancellationToken = default);
}