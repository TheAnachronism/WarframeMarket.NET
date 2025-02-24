using System.Text.Json.Serialization;

namespace WarframeMarketNET.Responses;

public class LichWeapon(string thumbnail, string? iconFormat, string itemName, string icon, string id, string urlName)
{
    [JsonPropertyName("thumb")] public string Thumbnail { get; init; } = thumbnail;
    [JsonPropertyName("icon_format")] public string? IconFormat { get; init; } = iconFormat;
    [JsonPropertyName("item_name")] public string ItemName { get; init; } = itemName;
    public string Icon { get; init; } = icon;
    public string Id { get; init; } = id;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;

    public void Deconstruct(out string thumbnail, out string? iconFormat, out string itenName, out string icon,
        out string id, out string urlName)
    {
        thumbnail = this.Thumbnail;
        iconFormat = this.IconFormat;
        itenName = this.ItemName;
        icon = this.Icon;
        id = this.Id;
        urlName = this.UrlName;
    }
}

public class LichEphemera(
    string urlName,
    string icon,
    string animation,
    string animationFormat,
    string id,
    string iconFormat,
    ElementType element,
    string itemName,
    string thumbnail)
{
    [JsonPropertyName("url_name")]
    public string UrlName { get; init; } = urlName;
    public string Icon { get; init; } = icon;
    public string Animation { get; init; } = animation;
    [JsonPropertyName("animation_format")]
    public string AnimationFormat { get; init; } = animationFormat;
    public string Id { get; init; } = id;
    [JsonPropertyName("icon_format")]
    public string IconFormat { get; init; } = iconFormat;
    public ElementType element { get; init; } = element;
    [JsonPropertyName("item_name")]
    public string ItemName { get; init; } = itemName;
    [JsonPropertyName("thumb")]
    public string Thumbnail { get; init; } = thumbnail;

    public void Deconstruct(out string urlName, out string icon, out string animation, out string animationFormat,
        out string id, out string iconFormat, out ElementType elementType, out string itemName,
        out string thumbnail)
    {
        urlName = this.UrlName;
        icon = this.Icon;
        animation = this.Animation;
        animationFormat = this.AnimationFormat;
        id = this.Id;
        iconFormat = this.IconFormat;
        elementType = this.element;
        itemName = this.ItemName;
        thumbnail = this.Thumbnail;
    }
}

public class LichQuirk(string group, string itemName, string urlName, string description, string id)
{
    public string Group { get; init; } = group;
    [JsonPropertyName("item_name")]
    public string ItemName { get; init; } = itemName;
    [JsonPropertyName("url_name")]
    public string UrlName { get; init; } = urlName;
    public string Description { get; init; } = description;
    public string Id { get; init; } = id;

    public void Deconstruct(out string group, out string itemName, out string urlName, out string description, out string id)
    {
        group = this.Group;
        itemName = this.ItemName;
        urlName = this.UrlName;
        description = this.Description;
        id = this.Id;
    }
}
