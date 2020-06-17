using System;

namespace Aula19Dojo2
{
    public class IngressoVip : Ingresso
    {
        public float TaxaAdicional {get; set;}

        public void ValorTotal(){
            float newValor = Valor - TaxaAdicional;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("O valor VIP é {0:c}", newValor);
            Console.ResetColor();
        }
    }

}