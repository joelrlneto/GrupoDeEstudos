using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine("Informe o valor:");

            valor = Convert.ToInt32(Console.ReadLine());

            if (valor > 20)
                Console.WriteLine("Valor maior que 20");
            else if (valor < 20)
                Console.WriteLine("Valor menor que 20");
            else
                Console.WriteLine("Valor igual a 20");
        }
    }
}
