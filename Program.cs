using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string senha_padrao = "senha";

            Console.WriteLine("Bem vindo ao DescontosApp");

            Console.WriteLine("Por favor, digite a senha:");
            string senha = Console.ReadLine();

            if (senha != senha_padrao)

                Console.WriteLine("A senha esta incorreta!");
            Console.WriteLine("um bjs.");
            Console.ReadKey();
            Environment.Exit(0 );

            // Bem vindo!

            Console.WriteLine("Me diga o valor de um produto");
            decimal produto = decimal.Parse(Console.ReadLine());
           
            Console.WriteLine("qual a porcentagen de desconto?");
            decimal desconto = decimal.Parse(Console.ReadLine());

            // Regras

            if (desconto >= 50 || desconto < 0)
                Console.WriteLine("voce nao possui desconto");

            else if (produto > 200)
                if (desconto > 20)
                    Console.WriteLine("voce possui desconto!");

                else if (produto < 100)
                    if (desconto > 10)
                        Console.WriteLine("voce nao possui desconto");

            // Calculo

           decimal resultado = produto - (produto * (desconto / 100));
                Console.WriteLine("O valor final do produto é " + resultado);
         



          


        }
    }
}
