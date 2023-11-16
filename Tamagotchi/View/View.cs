class Menu
{
    public string NomeUsuario { get; set; }

    public List<string> opcoes = new();

    private static void ExibirTituloComEstilo(string titulo)
    {
        string estilo = string.Empty.PadLeft(38, '-');
        Console.WriteLine($"{estilo}{titulo}{estilo}");
    }
    private static void ExibirTituloSemEstilo(string titulo)
    {
        string estilo = string.Empty.PadLeft(30, ' ');
        Console.WriteLine($"{estilo}{titulo}{estilo}");
    }
    public void MostrarMenu()
    {
        ExibirTituloComEstilo(" MENU ");
        opcoes.Add(" 1-Adotar um mascote ");
        opcoes.Add(" 2-Ver mascotes adotados ");
        opcoes.Add(" 3-Sair do jogo ");

        foreach (var opco in opcoes)
        {
            ExibirTituloSemEstilo(opco.ToUpper());
        }

    }

    public static void MostrarPokemonsDisponiveis(List<Results> especies)
    {
        foreach (var item in especies)
        {
            Console.WriteLine($"    {item.Name}");
        }
      
    }

    public static string EscolherPokemon(List<Results> especies)
    {
        //Com o índice da lista, acessar a API de cada Pokémon
        Console.WriteLine("\n   Escolha um Pokémon do menu para ver seus detalhes:");
        int escolha = int.Parse(Console.ReadLine()!);
        string pokemonSelecionado = especies[escolha].Name;
        return pokemonSelecionado;
    }

    public static void MostrarDetalhesPokemons(Mascote mascote)
    {
        //Descrição do Pokémon
        Console.Beep();
        Console.Clear();
        Console.WriteLine($"    Nome: {mascote.Name}");
        Console.WriteLine($"    Altura: {mascote.Height}");
        Console.WriteLine($"    Peso: {mascote.Weight}");

        for (int i = 1; i < mascote.Abilities.Count; i++)
        {
            Console.WriteLine($"    Habilidades: {mascote.Abilities[i].Ability.Name}");
        }
    }

    public void Mensagem()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Beep();
        Console.Clear();

        Console.WriteLine(@"
    ████████╗ █████╗ ███╗   ███╗ █████╗  ██████╗  ██████╗ ████████╗ ██████╗██╗  ██╗██╗
    ╚══██╔══╝██╔══██╗████╗ ████║██╔══██╗██╔════╝ ██╔═══██╗╚══██╔══╝██╔════╝██║  ██║██║
       ██║   ███████║██╔████╔██║███████║██║  ███╗██║   ██║   ██║   ██║     ███████║██║
       ██║   ██╔══██║██║╚██╔╝██║██╔══██║██║   ██║██║   ██║   ██║   ██║     ██╔══██║██║
       ██║   ██║  ██║██║ ╚═╝ ██║██║  ██║╚██████╔╝╚██████╔╝   ██║   ╚██████╗██║  ██║██║
       ╚═╝   ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝    ╚═╝    ╚═════╝╚═╝  ╚═╝╚═╝");

        Console.WriteLine("\n    Olá, seja bem vindo(a) ao Tamagotchi!");
        Console.WriteLine("    Aqui você irá poder adotar " +
            "mascotes e cuidar dos seus bichinhos!");
        Console.WriteLine("    Prazer em conhecer você, como posso te chamar?\n");
        NomeUsuario = Console.ReadLine()!.ToUpper();
        Console.WriteLine($"   \nCerto {NomeUsuario}! O que deseja fazer hoje?\n");

    }

}