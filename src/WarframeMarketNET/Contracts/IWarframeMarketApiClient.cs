using WarframeMarketNET.Responses;

namespace WarframeMarketNET.Contracts;

public interface IWarframeMarketApiClient
{
    Task<IEnumerable<GetAllItemsResponse>> GetAlItems(CancellationToken ct = default);
}