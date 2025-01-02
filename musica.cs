internal class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    public void EscreveDisponivel(bool value)
    {
        disponivel = value;
    }

    public bool LeituraDisponivel()
    {
        return disponivel;
    }
    public void ExibirFichaTecnica(){
        Console.WriteLine($"Nome da musica {nome}");
        Console.WriteLine($"Artista da musica {artista}");
        Console.WriteLine($"Duração da musica {duracao}");

        if (disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
            else
            {
                Console.WriteLine("Não está disponivel");
            }
           
  }
}