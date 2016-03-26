using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int auxiliar;

            for(int i = 0; i < 5; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                for(int j = i; j < 5; j++)
                {
                    if(numeros[i] > numeros[j])
                    {
                        auxiliar = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = auxiliar;
                    }
                }
            }

            Console.WriteLine("---------------");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
