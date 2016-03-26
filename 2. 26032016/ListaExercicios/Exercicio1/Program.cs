using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, valorQuilowatt, valorTotal, valorComDesconto, consumo;

            Console.WriteLine("Informe o valor do salario minimo:");            

            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o consumo mensal em KW:");

            consumo = Convert.ToDouble(Console.ReadLine());

            valorQuilowatt = salario / 7;
            valorTotal = consumo * valorQuilowatt;
            valorComDesconto = valorTotal * 0.9;

            Console.WriteLine("Valor do KW: {0}", valorQuilowatt);

            Console.WriteLine("Valor total: {0}", valorTotal);

            Console.WriteLine("Valor com desconto: {0}", valorComDesconto);
        }
    }
}
