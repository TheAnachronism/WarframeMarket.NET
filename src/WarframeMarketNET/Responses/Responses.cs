namespace WarframeMarketNET.Responses;

public record GetAllItemsResponse(IEnumerable<CompactMarketItem> Items);
public record GetItemResponse(ExtendedMarketItem Item);