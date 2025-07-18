using EstudosComAPI.Modelos;
using System.Text.Json;

namespace EstudosComAPI.ModelosAPI;

internal class MusicasPreferidas
{

    public string Nome { get; set; }
    public List<Musica2> ListaDeMusicasPreferidas;
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasPreferidas = new List<Musica2>();
    }

    public void AdicionarMusicaFavorita(Musica2 musica)
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    public void ExibirMusicaFavorita()
    {
        Console.WriteLine($"Musicas favoritas: {Nome} ");
        foreach (var musica in ListaDeMusicasPreferidas)
        {
            Console.WriteLine($"--{musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {

        string Json = JsonSerializer.Serialize(new { 
        
            nome = Nome,
            musicas = ListaDeMusicasPreferidas
        });

        string NomeDoArquivo = $"MusicasFavoritas-{Nome}.json";
        File.WriteAllText(NomeDoArquivo, Json);
        Console.WriteLine($"Arquivo Json gerado - {Path.GetFullPath(NomeDoArquivo)}");
    }
}
