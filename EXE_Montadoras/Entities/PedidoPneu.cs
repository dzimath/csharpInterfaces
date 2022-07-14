using System;

namespace EXE_Montadoras.Entities
{
    internal class PedidoPneu
    {
        public int QtdPneus { get; set; }
        public double ValorUnitário { get; set; }
        public DateTime DataPedido { get; set; }
        public TamanhoPneu TamanhoPneu { get; set; }
        public Pagamento Pagamento { get; set; }

        public PedidoPneu(int qtdPneus, double valorUnitario ,DateTime dataPedido, TamanhoPneu tamanhoPneu)
        {
            QtdPneus = qtdPneus;
            ValorUnitário = valorUnitario; 
            DataPedido = dataPedido;
            TamanhoPneu = tamanhoPneu;
        }
    }
}
