//Tamagotchi API Rest Pokemon

//https://pokeapi.co/api/v2/pokemon/{id or name}/
//https://pokeapi.co/api/v2/pokemon-species/

using RestSharp;
using Newtonsoft.Json;
class Program
{
    static void Main(string[] args)
    {
        //Menu de seleção
        Console.WriteLine("BEM VINDO (A) AO TAMAGOTCHI!");
        Console.WriteLine("Neste jogo você irá escolher um Pokémon para ser seu mascote!");
        Console.WriteLine("\nSeleção de espécies:");

        //Listando espécies Pokémon
        var client = new RestClient($"https://pokeapi.co/api/v2/pokemon-species/");
        var request = new RestRequest("", Method.Get);
        var response = client.Execute(request);
        var especiesPokemons = JsonConvert.DeserializeObject<Species>(response.Content);

        for (int i = 1; i < especiesPokemons.Results.Count; i++)
        {
            Console.WriteLine($"{i}-{especiesPokemons.Results[i].Name}");
        }

        //Com o índice da lista, acessar a API de cada Pokémon
        Console.WriteLine("\nEscolha um Pokémon do menu para ver seus detalhes:");
        int escolha = int.Parse(Console.ReadLine()!.ToLower());
        string pokemonSelecionado = especiesPokemons.Results[escolha].Name;
        var client2 = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemonSelecionado}");
        var request2 = new RestRequest("", Method.Get);
        var response2 = client2.Execute(request2);
        var pokemon = JsonConvert.DeserializeObject<Mascote>(response2.Content);

        //Descrição do Pokémon
        Console.WriteLine($"Name: {pokemon.Name}");
        Console.WriteLine($"Height: {pokemon.Height}");
        Console.WriteLine($"Weight: {pokemon.Weight}");

        for (int i = 1; i < pokemon.Ability.Count; i++)
        {
            Console.WriteLine(pokemon.Ability[i].Name);
        }

        Console.ReadKey();

    }

}


