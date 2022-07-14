using System;
using System.Globalization;
using EXE_Montadoras.Entities;
using EXE_Montadoras.Services;

namespace EXE_Montadoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do Pedido");            
            Console.Write("Quantidade de pneus: ");
            int quantidadePneus = int.Parse(Console.ReadLine());
            Console.Write("Tamanho do Aro: ");
            int tamAro = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário: ");
            double valUnitario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Data do Pedido (dd/MM/yyyy): ");
            DateTime dataPedido = DateTime.Parse(Console.ReadLine());

            PedidoPneu pedido = new PedidoPneu(quantidadePneus, valUnitario ,dataPedido, new TamanhoPneu(tamAro));

            PagamentoServices pagamento = new PagamentoServices(new PirelliServices());

            pagamento.ProcessoPagamento(pedido);
            Console.WriteLine("Dados do pedido:");
            Console.WriteLine(pedido.Pagamento);


        }
    }
}
