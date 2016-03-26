using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine("Insira um valor:");

            valor = Convert.ToInt32(Console.ReadLine());

            if (valor > 20)
                Console.WriteLine("O valor {0} é maior que 20.", valor);
        }
    }
}
