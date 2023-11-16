class MascotesAdotados {

    public Mascote NovoMascote { get; set; }

    public List<Mascote> Mascotes { get; set; }

    public void AdotarMascotes(Mascote pokemon)
    {
        Mascotes.Add(pokemon);
    }
    public void MostrarMascotesAdotados()
    {
        Console.Beep();
        Console.Clear();
        Console.WriteLine("Mascotes adotados:");
        foreach (var item in Mascotes)
        {
            Console.WriteLine(item);

        }
    }
}
