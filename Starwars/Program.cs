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

            Console.WriteLine(c.name);
            Console.WriteLine(c.height);
            Console.WriteLine(c.mass);
            Console.WriteLine(c.hairColor);
            Console.WriteLine(c.skinColor);
        }
        else if(type == "planets")
        {
            SWPlanet p = JsonSerializer.Deserialize<SWPlanet>(response.Content);
            Console.WriteLine(p.name);
            Console.WriteLine(p.rotationPeriod);
            Console.WriteLine(p.orbitalPeriod);
            Console.WriteLine(p.diameter);
            Console.WriteLine(p.climate);
            Console.WriteLine(p.gravity);
            Console.WriteLine(p.terrain);
            Console.WriteLine(p.surfaceWater);
            Console.WriteLine(p.population);
        }
        else if(type == "starships")
        {
            SWShip s = JsonSerializer.Deserialize<SWShip>(response.Content);
            Console.WriteLine(s.name);
            Console.WriteLine(s.model);
            Console.WriteLine(s.manufacturer);
            Console.WriteLine(s.cost);
            Console.WriteLine(s.length);
            Console.WriteLine(s.maxAtmospheringSpeed);
            Console.WriteLine(s.crew);
            Console.WriteLine(s.passengers);
            Console.WriteLine(s.cargo);
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