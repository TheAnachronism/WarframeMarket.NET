using System.Text.Json.Serialization;

namespace WarframeMarketNET.Responses;

public class Location(
    int maxLevel,
    string urlName,
    string id,
    int minLevel,
    string icon,
    string systemName,
    string nodeName,
    string thumbnail)
{
    [JsonPropertyName("max_level")] public int MaxLevel { get; init; } = maxLevel;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    public string Id { get; init; } = id;
    [JsonPropertyName("min_level")] public int MinLevel { get; init; } = minLevel;
    public string Icon { get; init; } = icon;
    [JsonPropertyName("system_name")] public string SystemName { get; init; } = systemName;
    [JsonPropertyName("node_name")] public string NodeName { get; init; } = nodeName;
    [JsonPropertyName("thumb")] public string Thumbnail { get; init; } = thumbnail;

    public void Deconstruct(out int maxLevel, out string urlName, out string id, out int minLevel, out string icon,
        out string systemName, out string nodeName, out string thumbnail)
    {
        maxLevel = this.MaxLevel;
        urlName = this.UrlName;
        id = this.Id;
        minLevel = this.MinLevel;
        icon = this.Icon;
        systemName = this.SystemName;
        nodeName = this.NodeName;
        thumbnail = this.Thumbnail;
    }
}

public class Npc(string name, string thumbnail, string icon, string urlName, string id)
{
    public string Name { get; init; } = name;
    [JsonPropertyName("thumb")] public string Thumbnail { get; init; } = thumbnail;
    public string Icon { get; init; } = icon;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    public string Id { get; init; } = id;

    public void Deconstruct(out string name, out string thumbnail, out string icon, out string urlName, out string id)
    {
        name = this.Name;
        thumbnail = this.Thumbnail;
        icon = this.Icon;
        urlName = this.UrlName;
        id = this.Id;
    }
}

public class Mission(string thumbnail, string name, string urlName, string id, string icon)
{
    [JsonPropertyName("thumb")] public string Thumbnail { get; init; } = thumbnail;
    public string Name { get; init; } = name;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    public string Id { get; init; } = id;
    public string Icon { get; init; } = icon;

    public void Deconstruct(out string thumbnail, out string name, out string urlName, out string id, out string icon)
    {
        thumbnail = this.Thumbnail;
        name = this.Name;
        urlName = this.UrlName;
        id = this.Id;
        icon = this.Icon;
    }
}