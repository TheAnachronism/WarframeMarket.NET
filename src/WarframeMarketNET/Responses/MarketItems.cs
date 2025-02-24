using System.Text.Json.Serialization;

namespace WarframeMarketNET.Responses;

public class CompactMarketItem(string itemName, string thumbnail, string urlName, string id)
{
    [JsonPropertyName("item_name")] public string ItemName { get; init; } = itemName;
    public string Thumbnail { get; init; } = thumbnail;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    public string Id { get; init; } = id;

    public void Deconstruct(out string itemName, out string thumbnail, out string urlName, out string id)
    {
        itemName = this.ItemName;
        thumbnail = this.Thumbnail;
        urlName = this.UrlName;
        id = this.Id;
    }
}

public class ExtendedMarketItem(string id, IEnumerable<ItemInSet> itemsInSet)
{
    public string Id { get; init; } = id;
    [JsonPropertyName("items_in_set")] public IEnumerable<ItemInSet> ItemsInSet { get; init; } = itemsInSet;

    public void Deconstruct(out string id, out IEnumerable<ItemInSet> itemsInSet)
    {
        id = this.Id;
        itemsInSet = this.ItemsInSet;
    }
}

public class ItemLanguageSet(string itemName, string description, string wikiLink, string thumbnail, string icon)
{
    [JsonPropertyName("item_name")] public string ItemName { get; init; } = itemName;
    public string Description { get; init; } = description;
    [JsonPropertyName("wiki_link")] public string WikiLink { get; init; } = wikiLink;
    [JsonPropertyName("thumb")] public string Thumbnail { get; init; } = thumbnail;
    public string Icon { get; init; } = icon;

    public void Deconstruct(out string itemName, out string description, out string wikiLink, out string thumbnail,
        out string icon)
    {
        itemName = this.ItemName;
        description = this.Description;
        wikiLink = this.WikiLink;
        thumbnail = this.Thumbnail;
        icon = this.Icon;
    }
}

public class ItemInSet(
    int masteryLevel,
    string id,
    int ducats,
    int tradingTax,
    int quantityForSet,
    string urlName,
    string subIcon,
    bool setRoot,
    string thumbnail,
    string iconFormat,
    string icon,
    string[] tags)
{
    [JsonPropertyName("mastery_level")] public int MasteryLevel { get; init; } = masteryLevel;
    public string Id { get; init; } = id;
    public int Ducats { get; init; } = ducats;
    [JsonPropertyName("trading_tax")] public int TradingTax { get; init; } = tradingTax;
    [JsonPropertyName("quantity_for_set")] public int QuantityForSet { get; init; } = quantityForSet;
    [JsonPropertyName("url_name")] public string UrlName { get; init; } = urlName;
    [JsonPropertyName("sub_icon")] public string? SubIcon { get; init; } = subIcon;
    [JsonPropertyName("set_root")] public bool SetRoot { get; init; } = setRoot;
    [JsonPropertyName("thumb")] public string Thumbnail { get; init; } = thumbnail;
    [JsonPropertyName("icon_format")] public string IconFormat { get; init; } = iconFormat;
    public string Icon { get; init; } = icon;
    public string[] Tags { get; init; } = tags;

    public void Deconstruct(out int masteryLevel, out string id, out int ducats, out int tradingTax,
        out int quantityForSet, out string urlName, out string? subIcon, out bool setRoot, out string thumbnail,
        out string iconFormat, out string icon, out string[] tags)
    {
        masteryLevel = this.MasteryLevel;
        id = this.Id;
        ducats = this.Ducats;
        tradingTax = this.TradingTax;
        quantityForSet = this.QuantityForSet;
        urlName = this.UrlName;
        subIcon = this.SubIcon;
        setRoot = this.SetRoot;
        thumbnail = this.Thumbnail;
        iconFormat = this.IconFormat;
        icon = this.Icon;
        tags = this.Tags;
    }
}