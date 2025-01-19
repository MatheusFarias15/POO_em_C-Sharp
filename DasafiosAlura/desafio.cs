// Modular uma class conta que tenha os atributos Numero da conta Saldo e limite  
// e um método que devolva as informações da conta de forma detalhada.

internal class Conta
{
    public int NumeroDaConta { get; set; }
    public float SaldoDaConta { get; set; }
    public float LimiteDaConta { get; set; }

    public void ExibirInformacoesDaConta()
    {
        Console.WriteLine($"Número da conta: {NumeroDaConta} \n");
        Console.WriteLine($"Saldo da conta: R$ {SaldoDaConta} \n ");
        Console.WriteLine($"Limite da conta: R$ {LimiteDaConta} \n ");
    }

}