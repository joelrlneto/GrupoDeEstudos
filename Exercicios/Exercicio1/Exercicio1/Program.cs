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
            string[] nomes = new string[10];
            string busca;

            Console.WriteLine("Informe os nomes: ");

            for(int i = 0; i < 10; i++)
            {
                Console.Write($"[{i}] > ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Informe o texto que deseja buscar: ");
            busca = Console.ReadLine();

            Console.WriteLine($"Nomes que contém o texto '{busca}': ");
            for (int i = 0; i < 10; i++)
            {
                if(nomes[i].Contains(busca))
                    Console.WriteLine($"[{i}] > {nomes[i]}");
            }
        }
    }
}
