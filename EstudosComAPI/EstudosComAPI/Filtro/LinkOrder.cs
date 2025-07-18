using EstudosComAPI.Modelos;

namespace EstudosComAPI.Filtro; 

internal class LinkOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica2> musicas)
    {
        var artistaOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados:");
        foreach (var artista in artistaOrdenados)
        {
            Console.WriteLine(artista);
        }
    }
}
