using System.Text.Json.Serialization;

namespace WarframeMarketNET.Responses;

public enum OrderType
{
    Sell,
    Buy
}

public class OrderUser(
    int reputation,
    string locale,
    string avatar,
    DateTimeOffset lastSeen,
    string inGameName,
    bool crossPlay,
    Platform platform,
    string id,
    string region,
    string status)
{
    public int Reputation { get; init; } = reputation;
    public string Locale { get; init; } = locale;
    public string Avatar { get; init; } = avatar;
    [JsonPropertyName("last_seen")] public DateTimeOffset LastSeen { get; init; } = lastSeen;
    [JsonPropertyName("ingame_name")] public string InGameName { get; init; } = inGameName;
    public bool CrossPlay { get; init; } = crossPlay;
    public Platform platform { get; init; } = platform;
    public string Id { get; init; } = id;
    public string Region { get; init; } = region;
    public string status { get; init; } = status;

    public void Deconstruct(out int reputation, out string locale, out string avatar, out DateTimeOffset lastSeen,
        out string inGameName, out bool crossPlay, out Platform platform, out string id, out string region,
        out string status)
    {
        reputation = this.Reputation;
        locale = this.Locale;
        avatar = this.Avatar;
        lastSeen = this.LastSeen;
        inGameName = this.InGameName;
        crossPlay = this.CrossPlay;
        platform = this.platform;
        id = this.Id;
        region = this.Region;
        status = this.status;
    }
}

public class Order(
    OrderType orderType,
    int quantity,
    int platinum,
    OrderUser user,
    DateTimeOffset creationDate,
    DateTimeOffset lastUpdate,
    bool visible,
    string id,
    string region)
{
    [JsonPropertyName("order_type")]
    public OrderType OrderType { get; init; } = orderType;
    public int Quantity { get; init; } = quantity;
    public int Platinum { get; init; } = platinum;
    public OrderUser User { get; init; } = user;
    [JsonPropertyName("creation_date")]
    public DateTimeOffset CreationDate { get; init; } = creationDate;
    [JsonPropertyName("last_update")]
    public DateTimeOffset LastUpdate { get; init; } = lastUpdate;
    public bool Visible { get; init; } = visible;
    public string Id { get; init; } = id;
    public string Region { get; init; } = region;

    public void Deconstruct(out OrderType orderType, out int quantity, out int platinum, out OrderUser user,
        out DateTimeOffset creationDate, out DateTimeOffset lastUpdate, out bool visible, out string id,
        out string region)
    {
        orderType = this.OrderType;
        quantity = this.Quantity;
        platinum = this.Platinum;
        user = this.User;
        creationDate = this.CreationDate;
        lastUpdate = this.LastUpdate;
        visible = this.Visible;
        id = this.Id;
        region = this.Region;
    }
}