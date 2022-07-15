using System;
using System.Collections.Generic;
using System.Text;

namespace EXE_Montadoras.Services
{
    class PirelliServices : IServicos
    {
        int Qtd { get; set; }
        public double ValorFrete(int quantidade)
        {
            Qtd = quantidade;

            if (quantidade > 50)
            {
                return 20.0;
            }
            else
            {
                return 50.0;
            }
        }

        public DateTime Entrega(int qtde, DateTime dataPedido)
        {
            if (qtde > 50)
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
