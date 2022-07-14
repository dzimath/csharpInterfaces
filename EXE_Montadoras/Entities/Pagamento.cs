using System;
using System.Globalization;

namespace EXE_Montadoras.Entities
{
    internal class Pagamento
    {
        public double ValorTotalPneus { get; set; }
        public double ValorFrete { get; set; }
        public DateTime Entrega { get; set; }

        public Pagamento(double valorTotalPneus, double valorFrete, DateTime entrega)
        {
            ValorTotalPneus = valorTotalPneus;
            ValorFrete = valorFrete;
            Entrega = entrega;
        }

        public double PagamentoTotal
        {
            get { return ValorTotalPneus + ValorFrete; }
        }

        public override string ToString()
        {
            return "Valor Total dos Pneus: "
                + ValorTotalPneus.ToString("F2", CultureInfo.InvariantCulture)
                + "\nFrete: "
                + ValorFrete.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal do Pedido: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture)
                + "\nData de Entrega: "
                + Entrega.ToString("d");
        }

    }
}
