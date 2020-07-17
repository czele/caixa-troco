using System;

namespace caixa_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do produto?");
            int valorproduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o valor do pago?");
            int valorpago = Convert.ToInt32(Console.ReadLine());
            
            //string entrada;
            //while (entrada == "")
            //{
            //    Console.WriteLine("Qual o valor do pago?");
            //    int entrada = Convert.ToInt32(Console.ReadLine());
            //}
            //int valorpago = Convert.ToInt32(entrada);

            int troco = valorpago - valorproduto;

            bool troco1 = true;
            if (valorpago > valorproduto)
                Console.WriteLine($"O seu troco é de {troco}");
            
            else
                Console.WriteLine("Você não tem troco.");

        }
    }
}
