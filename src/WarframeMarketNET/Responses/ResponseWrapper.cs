using System.Text.Json.Serialization;

namespace WarframeMarketNET.Responses;

internal class ResponseWrapper<T>
{
    
    [JsonPropertyName("payload")]
    public T? Payload { get; set; }
}