using System;
using System.Globalization;
using EXE_Montadoras.Entities;
using EXE_Montadoras.Services;

namespace EXE_Montadoras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados de entrada da aplicacao
            Console.WriteLine("Dados do Pedido");
            Console.WriteLine(" Escolha a marca dos Pneus:");
            Console.WriteLine(" Digite F para Firestone ");
            Console.WriteLine(" Digite P para Pirelli ");
            string marca = Console.ReadLine();
            Console.Write("Quantidade de pneus: ");
            int quantidadePneus = int.Parse(Console.ReadLine());
            Console.Write("Tamanho do Aro: ");
            int tamAro = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário: ");
            double valUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Data do Pedido (dd/MM/yyyy): ");
            DateTime dataPedido = DateTime.Parse(Console.ReadLine());


            //aqui e criado um pedido passando as informacoes obtidas anteriormente
            PedidoPneu pedido = new PedidoPneu(quantidadePneus, valUnitario, dataPedido, new TamanhoPneu(tamAro));

            /*instânciado aqui fora como null e apenas setado o objetivo á variavel pagamento dentro dos if's, dependendo 
            da marca selecinada*/
            PagamentoServices pagamento = null;
            if (marca == "P")
            { 
                /*Com esse if, foi possível determinar qual objeto é passado para o construtor da pagamentosServices, nesse caso aqui,
                 * instanciou um PirelliService e passou na criação do objeto de PagamentoServices
                */
                pagamento = new PagamentoServices(new PirelliServices());

            }
            else
            {
                /*Com esse if-else, foi possível determinar qual objeto é passado para o construtor da pagamentosServices, nesse caso aqui,
                 * instanciou um FirestoneService e passou na criação do objeto de PagamentoServices
                */
                pagamento = new PagamentoServices(new FirestoneServices());
            }
           


            /*
             * Aqui irá processar o pagamento do pedido. Dependendo da escolha da marca pelo usuário, 
             * o método ProcessoPagamento, executado pelo objeto pagamento, que chamar lá
             * na classe PagamentoServices, os métodos entrega e valor frete da IServicos, chamará na 
             * verdade PirelliServices.Entrega ou PirelliServices.ValorFrete ou então chamará
             * a FirestoneServices.Entrega ou FirestoneServices.Valor frete, já que essas duas classes
             * implementam a interface IServicos, então na verdade um PirelliService é um Iservicos e 
             * FirestoneService também é um IServicos.
             * 
             * 
             */
            pagamento.ProcessoPagamento(pedido);
            Console.WriteLine("Dados do pedido:");
            Console.WriteLine(pedido.Pagamento);


        }
    }
}
