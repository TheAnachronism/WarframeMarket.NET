using System.Text.Json.Serialization;

namespace WarframeMarketNET.Responses;

public class SisterWeapon(string iconFormat, string thumbnail, string icon, string urlName, string id, string itemName)
{
    [JsonPropertyName("icon_format")] public string IconFormat { get; init; } = iconFormat;
    [JsonPropertyName("thumb")] public string Thumbnail { get; init; } = thumbnail;
    public string Icon { get; init; } = icon;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    public string Id { get; init; } = id;
    [JsonPropertyName("item_name")] public string ItemName { get; init; } = itemName;

    public void Deconstruct(out string iconFormat, out string thumbnail, out string icon, out string urlName,
        out string id, out string itemName)
    {
        iconFormat = this.IconFormat;
        thumbnail = this.Thumbnail;
        icon = this.Icon;
        urlName = this.UrlName;
        id = this.Id;
        itemName = this.ItemName;
    }
}

public class SisterEphemera(
    string id,
    string urlName,
    string icon,
    string iconFormat,
    string thumbnail,
    string animation,
    string animationFormat,
    ElementType element,
    string itemName)
{
    public string Id { get; init; } = id;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    public string Icon { get; init; } = icon;
    [JsonPropertyName("icon_format")] public string IconFormat { get; init; } = iconFormat;
    [JsonPropertyName("thumb")] public string Thumbnail { get; init; } = thumbnail;
    public string Animation { get; init; } = animation;
    [JsonPropertyName("animation_format")] public string AnimationFormat { get; init; } = animationFormat;
    public ElementType Element { get; init; } = element;
    [JsonPropertyName("item_name")] public string ItemName { get; init; } = itemName;

    public void Deconstruct(out string id, out string urlName, out string icon, out string iconFormat,
        out string thumbnail, out string animation, out string animationFormat, out ElementType element,
        out string itemName)
    {
        id = this.Id;
        urlName = this.UrlName;
        icon = this.Icon;
        iconFormat = this.IconFormat;
        thumbnail = this.Thumbnail;
        animation = this.Animation;
        animationFormat = this.AnimationFormat;
        element = this.Element;
        itemName = this.ItemName;
    }
}

public class SisterQuirk(string group, string itemName, string urlName, string description, string id)
{
    public string Group { get; init; } = group;
    [JsonPropertyName("item_name")] public string ItemName { get; init; } = itemName;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    public string Description { get; init; } = description;
    public string Id { get; init; } = id;

    public void Deconstruct(out string group, out string itemName, out string urlName, out string description,
        out string id)
    {
        group = this.Group;
        itemName = this.ItemName;
        urlName = this.UrlName;
        description = this.Description;
        id = this.Id;
    }
}