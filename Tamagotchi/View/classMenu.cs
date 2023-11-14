class Menu
{
    public string NomeUsuario { get; set; }

    public List<string> opcoes = new();

    void ExibirTituloComEstilo(string titulo)
    {
        string estilo = string.Empty.PadLeft(38, '-');
        Console.WriteLine($"{estilo}{titulo}{estilo}");
    }
    void ExibirTituloSemEstilo(string titulo)
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
    public void Mensagem()
    {
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
        MostrarMenu();
    }

}