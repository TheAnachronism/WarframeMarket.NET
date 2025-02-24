using System.Text.Json.Serialization;

namespace WarframeMarketNET.Responses;

public enum RivenGroup
{
    Secondary,
    Melee,
    Primary,
    Zaw,
    Archgun,
    Kitgun,
}

public enum RivenType
{
    Pistol,
    Melee,
    Rifle,
    Shotgun,
    Zaw,
    Kitgun
}

public class Riven(
    string thumbnail,
    RivenGroup group,
    string urlName,
    string itemName,
    int masteryLevel,
    string iconFormat,
    string id,
    string icon,
    RivenType rivenType)
{
    [JsonPropertyName("thumb")] public string Thumbnail { get; init; } = thumbnail;
    public RivenGroup Group { get; init; } = group;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    [JsonPropertyName("item_name")] public string ItemName { get; init; } = itemName;
    [JsonPropertyName("mastery_level")] public int MasteryLevel { get; init; } = masteryLevel;
    [JsonPropertyName("icon_format")] public string IconFormat { get; init; } = iconFormat;
    public string Id { get; init; } = id;
    public string Icon { get; init; } = icon;
    [JsonPropertyName("riven_type")] public RivenType RivenType { get; init; } = rivenType;

    public void Deconstruct(out string thumbnail, out RivenGroup group, out string urlName, out string itemName,
        out int masteryLevel, out string iconFormat, out string id, out string icon, out RivenType rivenType)
    {
        thumbnail = this.Thumbnail;
        group = this.Group;
        urlName = this.UrlName;
        itemName = this.ItemName;
        masteryLevel = this.MasteryLevel;
        iconFormat = this.IconFormat;
        id = this.Id;
        icon = this.Icon;
        rivenType = this.RivenType;
    }
}

public enum RivenAttributeUnit
{
    Multiply,
    Percent,
    Seconds,
}

public class RivenAttribute(
    string prefix,
    string group,
    string effect,
    RivenAttributeUnit? units,
    bool isPositive,
    bool isPositiveOnly,
    string suffix,
    string urlName,
    string id,
    bool searchOnly,
    bool negativeOnly,
    RivenType[] exclusiveTo)
{
    public string Prefix { get; init; } = prefix;
    public string Group { get; init; } = group;
    public string Effect { get; init; } = effect;
    public RivenAttributeUnit? Units { get; init; } = units;

    [JsonPropertyName("positive_is_negative")]
    public bool IsPositive { get; init; } = isPositive;

    [JsonPropertyName("positive_only")] public bool IsPositiveOnly { get; init; } = isPositiveOnly;
    public string Suffix { get; init; } = suffix;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    public string Id { get; init; } = id;
    [JsonPropertyName("search_only")] public bool SearchOnly { get; init; } = searchOnly;
    [JsonPropertyName("negative_only")] public bool NegativeOnly { get; init; } = negativeOnly;
    [JsonPropertyName("exclusive_to")] public RivenType[] ExclusiveTo { get; init; } = exclusiveTo;

    public void Deconstruct(out string prefix, out string group, out string effect, out RivenAttributeUnit? units,
        out bool isPositive, out bool isPositiveOnly, out string suffix, out string urlName, out string id,
        out bool searchOnly, out bool negativeOnly, out RivenType[] exclusiveTo)
    {
        prefix = this.Prefix;
        group = this.Group;
        effect = this.Effect;
        units = this.Units;
        isPositive = this.IsPositive;
        isPositiveOnly = this.IsPositiveOnly;
        suffix = this.Suffix;
        urlName = this.UrlName;
        id = this.Id;
        searchOnly = this.SearchOnly;
        negativeOnly = this.NegativeOnly;
        exclusiveTo = this.ExclusiveTo;
    }
}