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
            string[] nomes = new string[10];
            string busca;
            string tipo;

            Console.WriteLine("Informe os nomes: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"[{i}] > ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Informe o texto que deseja buscar: ");
            busca = Console.ReadLine();

            Console.WriteLine("Informe o tipo de busca: [0] Começa com [1] Termina com [2] Contém");
            tipo = Console.ReadLine();
            
            
            switch(tipo)
            {
                case "0":
                    Console.WriteLine($"Nomes que começam com o texto '{busca}': ");
                    for (int i = 0; i < 10; i++)
                    {
                        if (nomes[i].StartsWith(busca))
                            Console.WriteLine($"[{i}] > {nomes[i]}");
                    }                            
                    break;
                case "1":
                    Console.WriteLine($"Nomes que terminam com o texto '{busca}': ");
                    for (int i = 0; i < 10; i++)
                    {
                        if (nomes[i].EndsWith(busca))
                            Console.WriteLine($"[{i}] > {nomes[i]}");
                    }
                    break;
                case "2":
                    Console.WriteLine($"Nomes que contém o texto '{busca}': ");
                    for (int i = 0; i < 10; i++)
                    {
                        if (nomes[i].Contains(busca))
                            Console.WriteLine($"[{i}] > {nomes[i]}");
                    }
                    break;
                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    return;
            }                
            
        }
    }
}
