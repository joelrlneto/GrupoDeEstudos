using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorAula, qtdAulas, descontoINSS;

            Console.WriteLine("Informe o valor da hora/aula:");

            valorAula = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o número de horas ministradas no mês:");

            qtdAulas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do desconto do INSS (em %):");

            descontoINSS = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Salario liquido: {0}", valorAula * qtdAulas * (1 - descontoINSS / 100));
        }
    }
}