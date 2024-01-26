using System.Text.Json.Serialization;

public class SWShip
{
    [JsonPropertyName("name")]
    public string name {get; set;}
    [JsonPropertyName("model")]
	public string model {get; set;}
    [JsonPropertyName("manufacturer")]
	public string manufacturer {get; set;}
    [JsonPropertyName("cost_in_credits")]
    public string cost {get; set;}
    [JsonPropertyName("length")]
    public string length {get; set;}
    [JsonPropertyName("max_atmosphering_speed")]
    public string maxAtmospheringSpeed {get; set;}
    [JsonPropertyName("crew")]
    public string crew {get; set;}
    [JsonPropertyName("passengers")]
    public string passengers {get; set;}
    [JsonPropertyName("cargo_capacity")]
    public string cargo {get; set;}
}
