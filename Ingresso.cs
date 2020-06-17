namespace Aula19Dojo2
{
    public class Ingresso
    {
        public float Valor { get; set; }

        public void ImprimirValor(){
            System.Console.WriteLine($"O Valor do ingresso é de R${Valor}");
        }
    }
}