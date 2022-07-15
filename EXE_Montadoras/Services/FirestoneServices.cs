using System;
using System.Collections.Generic;
using System.Text;

namespace EXE_Montadoras.Services
{
    class FirestoneServices : IServicos
    {
        public DateTime Entrega(int qtde, DateTime dataPedido)
        {
            if (qtde > 40)
            {
                return dataPedido.AddDays(15);    
            }
            else
            {
                return dataPedido.AddDays(3);
            }
        }

        public double ValorFrete(int quantidade)
        {
            if ( quantidade > 40 )
            {
                return quantidade * 1.00; // cobra um real por pneu
            }
            else
            {
                return quantidade * 1.50; // cobra 1.50 por pneu para uma entrega com menos de 40 pneus
            }
        }
    }
}
