using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;

            Console.WriteLine("Informe o valor do produto: ");

            preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor com desconto: R$ {0}", preco * 0.81);
        }
    }
}
