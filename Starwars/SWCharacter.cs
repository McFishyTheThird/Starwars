

using System.Text.Json.Serialization;

public class SWCharacter
{
    [JsonPropertyName("name")]
    public string name {get; set;}
    [JsonPropertyName("height")]
	public string height {get; set;}
    [JsonPropertyName("mass")]
	public string mass {get; set;}
    [JsonPropertyName("hair_color")]
    public string hairColor {get; set;}
    [JsonPropertyName("skin_color")]
    public string skinColor {get; set;}
}
