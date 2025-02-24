using System.Text.Json.Serialization;

namespace WarframeMarketNET.Responses;

internal class ResponseWrapper<T>
{
    inter
    
    [JsonPropertyName("payload")]
    public T Payload { get; set; }
}