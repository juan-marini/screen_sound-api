using ScreenSoud_04.Models;
using System.Text.Json;
using ScreenSoud_04.Filters;
using System.Runtime.ExceptionServices;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);

        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //musicas[6].ExibirDetalhes();
        //LinqFilter.FiltrarGeneros(musicas);

        //LinqOrder.ExibirListaArtistasOrdenados(musicas);

        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");

        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        //var musicasPreferidas = new MusicasPreferidas("Juan");
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[5]);

        //musicasPreferidas.ExibirMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJson();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Erro encontrado {e.Message}");
    }
}