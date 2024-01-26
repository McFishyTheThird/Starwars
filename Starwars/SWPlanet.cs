using System.Text.Json.Serialization;

public class SWPlanet
{
	// "rotation_period": "24",
	// "orbital_period": "4818",
	// "diameter": "10200",
	// "climate": "temperate, tropical",
	// "gravity": "1 standard",
	// "terrain": "jungle, rainforests",
	// "surface_water": "8",
	// "population": "1000",
    [JsonPropertyName("name")]
    public string name {get; set;}
    [JsonPropertyName("rotation_period")]
    public string rotationPeriod {get; set;}
    [JsonPropertyName("orbital_period")]
    public string orbitalPeriod {get; set;}
    [JsonPropertyName("diameter")]
    public string diameter {get; set;}
    [JsonPropertyName("climate")]
    public string climate {get; set;}
    [JsonPropertyName("gravity")]
    public string gravity {get; set;}
    [JsonPropertyName("terrain")]
    public string terrain {get; set;}
    [JsonPropertyName("surface_water")]
    public string surfaceWater {get; set;}
    [JsonPropertyName("population")]
    public string population {get; set;}
}
