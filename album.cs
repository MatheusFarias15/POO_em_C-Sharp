class Album { 
    private List<Musica> musicas = new List<Musica> ();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome {  get; }
    public int DuracaoTotal => musicas.Sum( m => m.Duracao); 
    public void AdicionarMusica (Musica musica)
    {
        musicas.Add (musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Listas de musica do album: {Nome} ");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musicas do album: {musica.Nome}"); 
        }
        Console.WriteLine($"Duração: {DuracaoTotal}"); 
    }
}
