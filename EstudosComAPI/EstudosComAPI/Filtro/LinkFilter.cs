using EstudosComAPI.Modelos;
namespace EstudosComAPI.Filtro;

internal class LinkFilter
{
    public static void FiltrarGeneros(List<Musica2> musicas)
    {
        var FiltrarGenereos = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in FiltrarGenereos)
        {
            Console.WriteLine($"Genero: {genero}");
        }
    }
    public static void FiltrarArtistas(List<Musica2> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine($"Artistas do genero {genero}:");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine(artista);
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica2> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    internal static void FiltrarMusicasEmCSharp(List<Musica2> musicas)
    {
        {
            var musicasEmCSharp = musicas
        .Where(musica => musica.Tonalidade.Equals("C#"))
        .Select(musica => musica.Nome)
        .ToList();
            Console.WriteLine("Músicas em C#:");
            foreach (var musica in musicasEmCSharp)
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}
