namespace WarframeMarketNET.Responses;

public record GetAllItemsResponse(IEnumerable<CompactMarketItem> Items);

public record GetItemResponse(ExtendedMarketItem Item);

public record GetOrdersResponse(IEnumerable<Order> Orders);

public record GetLichWeaponsResponse(IEnumerable<LichWeapon> Weapons);

public record GetLichEphemerasResponse(IEnumerable<LichEphemera> Ephemeras);

public record GetLichQuirksResponse(IEnumerable<LichQuirk> Quirks);

public record GetSisterWeaponsResponse(IEnumerable<SisterWeapon> Weapons);

public record GetSisterEphemerasResponse(IEnumerable<SisterEphemera> Ephemeras);

public record GetSisterQuirksResponse(IEnumerable<SisterQuirk> Quirks);

public record GetRivensResponse(IEnumerable<Riven> Items);

public record GetRivenAttributesResponse(IEnumerable<RivenAttribute> Attributes);

public record GetLocationsResponse(IEnumerable<Location> Locations);

public record GetNpcResponse(IEnumerable<Npc> Npc);
public record GetMissionsResponse(IEnumerable<Mission> Missions);