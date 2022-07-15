using System;
using EXE_Montadoras.Entities;
namespace EXE_Montadoras.Services
{
    class PagamentoServices
    {
        private IServicos IServicos;

        public PagamentoServices(IServicos iservicos)
        {
            IServicos = iservicos;
        }

        public void ProcessoPagamento(PedidoPneu pedidoPneu)
        {
            double valorPneus = pedidoPneu.QtdPneus * pedidoPneu.ValorUnitário;

            //IServicos é um atributo dessa classe ou seja, trata-se ele como uma variável, nesse caso aqui, chama-se o 
            //método Entrega sobre a "variável" Iservicos, mas na verdade estará sendo chamado sobre um objeto
            // de uma classe que implementa a IServicos. No caso aqui da aplicação, pode ser um PirelliService ou um FirestoneService.
            //ou seja, vamos supor que o usuario comprar pneu Pirelli, aqui nesse momento estaria sendo executado um PirelliService.Entrega(o C# entende isso pois
            //a atributo IServicos dessa classe estaria contendo um objeto de PirelliServices, já que o usuário escolheu essa marca)
            DateTime entrega = IServicos.Entrega(pedidoPneu.QtdPneus, pedidoPneu.DataPedido);
            double frete = IServicos.ValorFrete(pedidoPneu.QtdPneus);

            pedidoPneu.Pagamento = new Pagamento(valorPneus, frete, entrega);

        }
    }
}
