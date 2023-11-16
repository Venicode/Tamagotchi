using Newtonsoft.Json;
using RestSharp;

class APIPokemon
{

    public static List<Results> BuscarEspeciesPokemons()
    {
        Console.Beep();
        Console.Clear();
        //Listando espécies Pokémon
        Console.WriteLine("     Pokémons para adoção:");
        var client = new RestClient($"https://pokeapi.co/api/v2/pokemon-species/");
        var request = new RestRequest("", Method.Get);
        var response = client.Execute(request);
        var especiesPokemons = JsonConvert.DeserializeObject<Species>(response.Content);

        return especiesPokemons.Results;
    }

    public static Mascote BuscarDetalhesPokemons(string especie)
    {

        var client2 = new RestClient($"https://pokeapi.co/api/v2/pokemon/{especie}");
        var request2 = new RestRequest("", Method.Get);
        var response2 = client2.Execute(request2);
        var pokemon = JsonConvert.DeserializeObject<Mascote>(response2.Content);

        return pokemon;
    }
}