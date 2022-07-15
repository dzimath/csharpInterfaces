using System;

namespace EXE_Montadoras.Services
{
    interface IServicos
    {
        double ValorFrete(int quantidade);
        DateTime Entrega(int qtde, DateTime dataPedido);
    }
}
