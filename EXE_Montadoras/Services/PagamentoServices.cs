using System;
using EXE_Montadoras.Entities;
namespace EXE_Montadoras.Services
{
    internal class PagamentoServices
    {
        private Interface1 _interface1;

        public PagamentoServices(Interface1 interface1)
        {
            _interface1 = interface1;
        }

        public void ProcessoPagamento(PedidoPneu pedidoPneu)
        {
            double valorPneus = pedidoPneu.QtdPneus * pedidoPneu.ValorUnitário;
            DateTime entrega = _interface1.Entrega(pedidoPneu.DataPedido);
            double valFrete = 0.0;
            double frete = _interface1.ValorFrete(valFrete, pedidoPneu.QtdPneus);

            pedidoPneu.Pagamento = new Pagamento(valorPneus, frete, entrega);

        }
    }
}
