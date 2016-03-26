using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            Console.WriteLine("Informe o primeiro valor:");

            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");

            b = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            if (soma > 10)
                Console.WriteLine("A soma dos valores {0} e {1} é {2}.", a, b, soma);

            // Equivalente a
            //if ((a + b) > 10)
            //    Console.WriteLine("A soma dos valores {0} e {1} é {2}.", a, b, a+b);
        }
    }
}
