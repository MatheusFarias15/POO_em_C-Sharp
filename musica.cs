internal class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista} \n"; 

    // " => " representa apenas o modo leitura "get"

    public void ExibirFichaTecnica(){
        Console.WriteLine($"Nome da musica {Nome}");
        Console.WriteLine($"Artista da musica {Artista}");
        Console.WriteLine($"Duração da musica {Duracao}");
        Console.WriteLine(DescricaoResumida);

        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
            else
            {
                Console.WriteLine("Não está disponivel");
            }
           
  }
}