using ScreenSoud_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoud_04.Filters
{
    internal class LinqOrder
    {
        public static void ExibirListaArtistasOrdenados(List<Musica> musicas)
        {
            var ArtistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();

            Console.WriteLine("Lista de artistas ordenados");

            foreach(var artista in ArtistasOrdenados)
            {
                Console.WriteLine($"Artistas {artista}");
            }
        }
    }
}
