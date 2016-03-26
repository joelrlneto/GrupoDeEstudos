using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double conta;
            string iniciaisEmPromocao = "ADMS";
            string inicial;

            nome = Console.ReadLine();
            conta = Convert.ToDouble(Console.ReadLine());

            inicial = nome.Substring(0, 1);

            if(iniciaisEmPromocao.Contains(inicial))
                Console.WriteLine("Valor com desconto: {0}", conta * 0.7);
            else
                Console.WriteLine("Que pena.Nesta semana o desconto não é para seu nome; mas continue nos prestigiando que sua vez chegará");

            //Equivalente a
            //if (inicial == "A" || inicial == "D" || inicial == "M" || inicial == "S")
            //    Console.WriteLine("Valor com desconto: {0}", conta * 0.7);
            //else
            //    Console.WriteLine("Que pena.Nesta semana o desconto não é para seu nome; mas continue nos prestigiando que sua vez chegará");
        }
    }
}
