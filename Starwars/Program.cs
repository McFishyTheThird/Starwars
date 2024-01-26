using System.Text.Json;
using RestSharp;
using System.IO;
string yn = "y";
while(yn == "yes" || yn == "y")
{
    Console.WriteLine("Write the number for the character you want to see");
    string sWName = Console.ReadLine();
    RestClient client = new("https://swapi.py4e.com/api/");


    RestRequest request = new($"people/{sWName}/");

    RestResponse response = client.GetAsync(request).Result;


    if(response.StatusCode == System.Net.HttpStatusCode.OK)
    {
        SWCharacter s = JsonSerializer.Deserialize<SWCharacter>(response.Content);

        Console.WriteLine(s.name);
        Console.WriteLine(s.height);
        Console.WriteLine(s.mass);
        Console.WriteLine(s.hairColor);
        Console.WriteLine(s.skinColor);
    }
    else
    {
        Console.WriteLine("What?");
    }

    // Console.WriteLine(response.Content);
     File.WriteAllText("SWCharacter.json", response.Content);

    Console.WriteLine();

    Console.WriteLine("Do you want to see another character? yes/no");
    yn = Console.ReadLine().ToLower();
    Console.Clear();
}