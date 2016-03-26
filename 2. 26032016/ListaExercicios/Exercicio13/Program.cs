using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string estado;

            Console.WriteLine("Informe o estado:");

            estado = Console.ReadLine();

            switch(estado)
            {
                case "RJ": Console.WriteLine("Carioca");
                    break;
                case "SP": Console.WriteLine("Paulista");
                    break;
                case "MG": Console.WriteLine("Mineiro");
                    break;
                default: Console.WriteLine("Outros estados");
                    break;
            }
        }
    }
}
