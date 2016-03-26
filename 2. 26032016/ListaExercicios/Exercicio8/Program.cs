using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
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

            if (soma > 20)
                Console.WriteLine("Novo valor: {0}", soma + 8);
            else
                Console.WriteLine("Novo valor: {0}", soma - 5);
        }
    }
}
