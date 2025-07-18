using System.Text.Json.Serialization;

namespace EstudosComAPI.Modelos;

internal class Musica2
{

    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]

    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade
    {
        get
        {
            return tonalidades[Key];
        }
    }
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Nome da musica: {Nome}");
        Console.WriteLine($"Artista da musica: {Artista}");
        Console.WriteLine($"Duração da musica: {Duracao}");
        Console.WriteLine($"Genero da musica: {Genero}");
        Console.WriteLine($"Key da musica: {Tonalidade}");

    }
}
