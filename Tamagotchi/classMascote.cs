using Newtonsoft.Json;
using RestSharp;

class Mascote
{
    public string Name { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public List<Abilities> Abilities { get; set; }

    public void ExibirPokemons()
    {
        //Listando espécies Pokémon
        Console.WriteLine("Pokémons para adoção:");
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
        int escolha = int.Parse(Console.ReadLine()!);
        string pokemonSelecionado = especiesPokemons.Results[escolha].Name;
        var client2 = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemonSelecionado}");
        var request2 = new RestRequest("", Method.Get);
        var response2 = client2.Execute(request2);
        var pokemon = JsonConvert.DeserializeObject<Mascote>(response2.Content);

        //Descrição do Pokémon
        Console.WriteLine($"Nome: {pokemon.Name}");
        Console.WriteLine($"Altura: {pokemon.Height}");
        Console.WriteLine($"Peso: {pokemon.Weight}");

        for (int i = 1; i < pokemon.Abilities.Count; i++)
        {
            Console.WriteLine($"Habilidades: {pokemon.Abilities[i].Ability.Name}");
        }
        //Em desenvolvimento:
        Console.WriteLine("\nO que deseja fazer?");
        Console.WriteLine($"Saber mais do {pokemon.Name}");
        Console.WriteLine("Ver outros pokémons para adoção.");
        Console.ReadKey();

    }
}
