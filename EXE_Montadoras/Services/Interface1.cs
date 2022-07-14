using System;

namespace EXE_Montadoras.Services
{
    internal interface Interface1
    {
        double ValorFrete(double frete, int quantidade);
        DateTime Entrega(DateTime dataPedido);
    }
}
