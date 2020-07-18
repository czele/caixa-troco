using System;

namespace caixa_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do produto?");
            int valorproduto = Convert.ToInt32(Console.ReadLine());

            string entrada = "";
            while (entrada == "")
            {
                Console.WriteLine("Qual o valor pago?");
                entrada = Console.ReadLine();
            }
            int valorpago = Convert.ToInt32(entrada);

            int troco = valorpago - valorproduto;

            if (valorpago > valorproduto)
                Console.WriteLine($"O seu troco é de {troco}");
            
            else
                Console.WriteLine("Você não tem troco.");

        }
    }
}
