using System;

namespace Aula19Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
          IngressoVip ticket = new IngressoVip();
          ticket.TaxaAdicional = 100f;
          ticket.Valor = 35.00f;
          ticket.ImprimirValor();
          ticket.ValorTotal();

          System.Console.WriteLine($"A diferença de Valores é: {ticket.TaxaAdicional}");
        }
    }
}
