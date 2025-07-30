using bytebank.bytebank.modelos.Conta;

namespace bytebank.bytebank.modelos.bytebank.Util
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens = null;
        public ListaDeContaCorrente(int TamanhoInicial = 5)
        {
            _itens = new ContaCorrente[TamanhoInicial];
        }
    }
}
