using System;
using System.Collections.Generic;
using System.Text;

namespace EXE_Montadoras.Services
{
    internal class PirelliServices : Interface1
    {
        int Qtd { get; set; }
        public double ValorFrete(double frete, int quantidade)
        {
            Qtd = quantidade;

            if (quantidade > 50)
            {
                return frete = 20.0;
            }
            else
            {
                return frete = 50.0;
            }
        }

        public DateTime Entrega(DateTime dataPedido)
        {
            if (Qtd > 50)
            {
                return dataPedido.AddDays(20);
            }
            else
            {
                return dataPedido.AddDays(15);
            }
        }
    }
}
