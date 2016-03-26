using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            char sexo;
            int idade;

            Console.WriteLine("Informe o nome:");

            nome = Console.ReadLine();

            Console.WriteLine("Informe o sexo (M ou F):");

            sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Informe a idade:");

            idade = Convert.ToInt32(Console.ReadLine());

            if(sexo == 'F')
            {
                if (idade < 25)
                    Console.WriteLine("{0} ACEITA", nome);
                else
                    Console.WriteLine("{0} NÃO ACEITA", nome);
            }
            else
                Console.WriteLine("{0} NÃO ACEITO(A)", nome);
        }
    }
}
