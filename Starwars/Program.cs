using System.Text.Json;
using RestSharp;
using System.IO;
string yn = "y";
while(yn == "yes" || yn == "y")
{
    Console.WriteLine("What do you want to see?(people, planets or starships)");
    string type = Console.ReadLine().ToLower();
    Console.WriteLine("Write the number for the thing you want to see(people: 1-88, planets: 3-60, starships: 9-17)");
    string sWName = Console.ReadLine();
    RestClient client = new("https://swapi.py4e.com/api/");


    RestRequest request = new($"{type}/{sWName}/");

    RestResponse response = client.GetAsync(request).Result;


    if(response.StatusCode == System.Net.HttpStatusCode.OK)
    {
        if(type == "people")
        {
            SWCharacter c = JsonSerializer.Deserialize<SWCharacter>(response.Content);

            Console.WriteLine($"Name: {c.name}");
            Console.WriteLine($"Height: {c.height}");
            Console.WriteLine($"Mass: {c.mass}");
            Console.WriteLine($"Hair Color: {c.hairColor}");
            Console.WriteLine($"Skin Color: {c.skinColor}");
        }
        else if(type == "planets")
        {
            SWPlanet p = JsonSerializer.Deserialize<SWPlanet>(response.Content);
            Console.WriteLine($"Name: {p.name}");
            Console.WriteLine($"Rotation Period: {p.rotationPeriod}");
            Console.WriteLine($"Orbital Period: {p.orbitalPeriod}");
            Console.WriteLine($"Diameter: {p.diameter}");
            Console.WriteLine($"Climate: {p.climate}");
            Console.WriteLine($"Gravity: {p.gravity}");
            Console.WriteLine($"Terrain: {p.terrain}");
            Console.WriteLine($"Surface Water: {p.surfaceWater}");
            Console.WriteLine($"Population: {p.population}");
        }
        else if(type == "starships")
        {
            SWShip s = JsonSerializer.Deserialize<SWShip>(response.Content);
            Console.WriteLine($"Name: {s.name}");
            Console.WriteLine($"Model: {s.model}");
            Console.WriteLine($"Manufacturer: {s.manufacturer}");
            Console.WriteLine($"Cost: {s.cost}");
            Console.WriteLine($"Length: {s.length}");
            Console.WriteLine($"Max Atmosphering Speed: {s.maxAtmospheringSpeed}");
            Console.WriteLine($"Crew Size: {s.crew}");
            Console.WriteLine($"Passengers: {s.passengers}");
            Console.WriteLine($"Cargo Space: {s.cargo}");
        }
    }
    else
    {
        Console.WriteLine("What?");
    }

    // Console.WriteLine(response.Content);
     File.WriteAllText("SWCharacter.json", response.Content);

    Console.WriteLine();

    Console.WriteLine("Do you want to see another star wars thing? yes/no");
    yn = Console.ReadLine().ToLower();
    Console.Clear();
}