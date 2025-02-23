namespace ScreenSound.Menu; 

internal class MenuAvaliarBanda : Menu
{

    public void Executar(Dictionary<string, List<int>> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar uma banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
            Console.Write("Digite a nota que deseja dar para a banda: ");
            int nota = int.Parse(Console.ReadLine()!);
            notasDaBanda.Add(nota);
            Console.WriteLine("Voto computado com sucesso!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
