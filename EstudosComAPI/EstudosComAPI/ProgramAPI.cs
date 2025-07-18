using System.Text.Json;
using EstudosComAPI.Filtro;
using EstudosComAPI.Modelos;
using EstudosComAPI.ModelosAPI;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica2>>(resposta)!;

        LinkFilter.FiltrarMusicasEmCSharp(musicas); 
         
        musicas[0].ExibirDetalhesDaMusica();
        //LinkFilter.FiltrarGeneros(musicas);
        //LinkOrder.ExibirListaDeArtistasOrdenados(musicas);
       // LinkFilter.FiltrarArtistas(musicas, "rock");
        LinkFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");


        var MusicasPreferidasMatheus = new MusicasPreferidas("Minhas Musicas Preferidas");
        MusicasPreferidasMatheus.AdicionarMusicaFavorita(musicas[0]);
        MusicasPreferidasMatheus.AdicionarMusicaFavorita(musicas[2]);
        MusicasPreferidasMatheus.AdicionarMusicaFavorita(musicas[5]);
        MusicasPreferidasMatheus.AdicionarMusicaFavorita(musicas[3]);
        MusicasPreferidasMatheus.AdicionarMusicaFavorita(musicas[25]);


        MusicasPreferidasMatheus.ExibirMusicaFavorita();

        MusicasPreferidasMatheus.GerarArquivoJson();
    }

    catch (Exception ex) {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}" );

    }
}