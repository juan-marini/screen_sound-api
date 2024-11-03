
using ScreenSoud_04.Models;
using System.Linq;

namespace ScreenSoud_04.Filters;

internal class LinqFilter
{
    public static void FiltrarGeneros(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach(var genero in todosOsGeneros)
        {
            Console.WriteLine($"Gêneros {genero}");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musicas => musicas.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo artistas por genero musical {genero}");

        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"Artista {artista}");
        }

    }

    public static void FiltrarMusicasDeUmArtista(List <Musica> musicas, string nomeArtista)
    {
        var musicaDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista));

        Console.WriteLine(nomeArtista);

        foreach(var musica in musicaDoArtista)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
    }
    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();

        Console.WriteLine("Musicas em C#");
        foreach(var musica in musicasEmCSharp)
        {
            Console.WriteLine($"Musicas: {musica}");
        }
    }
}
