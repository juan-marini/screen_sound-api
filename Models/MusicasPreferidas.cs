namespace ScreenSoud_04.Models;
using System.Text.Json;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas sao as musicas favoritas: {Nome}");

        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"Musica: {musica.Nome} de Artista: {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeArquivo, json);

        Console.WriteLine($"JSon criado com sucesso {Path.GetFullPath(nomeArquivo)}");
    }
}
