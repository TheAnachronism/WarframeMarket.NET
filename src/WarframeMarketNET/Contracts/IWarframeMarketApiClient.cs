using WarframeMarketNET.Responses;

namespace WarframeMarketNET.Contracts;

public interface IWarframeMarketApiClient
{
    /// <summary>
    /// Get list of all tradable items.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing all tradable items.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetAllItemsResponse> GetAllItemsAsync(CancellationToken ct = default);

    /// <summary>
    /// Get information about an item.
    /// </summary>
    /// <param name="urlName">url_name of the item</param>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing information about the item.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetItemResponse> GetItemAsync(string urlName, CancellationToken ct = default);

    /// <summary>
    /// Get list of orders for a given item.
    /// </summary>
    /// <param name="urlName">The url_name of the item.</param>
    /// <param name="platform">Platform to return content from.</param>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of orders.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetOrdersResponse> GetOrdersAsync(string urlName, Platform platform = Platform.PC,
        CancellationToken ct = default);

    /// <summary>
    /// Get a list of lich weapons.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of lich weapons.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetLichWeaponsResponse> GetLichWeaponsAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of lich ephemeras.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of lich ephemeras.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetLichEphemerasResponse> GetLichEphemerasAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of lich quirks.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of lich quirks.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetLichQuirksResponse> GetLichQuirksAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of sister weapons.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of sister weapons.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetSisterWeaponsResponse> GetSisterWeaponsAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of sister ephemeras.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of sister ephemeras.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetSisterEphemerasResponse> GetSisterEphemerasAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of sister quirks.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of sister quirks.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetSisterQuirksResponse> GetSisterQuirksAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of riven items.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of riven items.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetRivensResponse> GetRivensAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of riven attributes.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of riven attributes.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetRivenAttributesResponse> GetRivenAttributesAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of locations.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of locations.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetLocationsResponse> GetLocationsAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of NPCs.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of NPCs.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetNpcResponse> GetNpcAsync(CancellationToken ct = default);

    /// <summary>
    /// Get a list of missions.
    /// </summary>
    /// <param name="ct">Optional cancellation token.</param>
    /// <returns>Response object containing list of missions.</returns>
    /// <exception cref="HttpRequestException">The HTTP response was unsuccessful</exception>
    Task<GetMissionsResponse> GetMissionsAsync(CancellationToken ct = default);
}