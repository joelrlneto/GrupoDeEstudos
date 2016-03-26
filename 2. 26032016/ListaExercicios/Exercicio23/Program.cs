using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior, menor;

            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            maior = numeros[0];
            menor = numeros[0];

            for (int i = 1; i < 5; i++)
            {
                if (numeros[i] > maior)
                    maior = numeros[i];

                if (numeros[i] < menor)
                    menor = numeros[i];
            }

            Console.WriteLine("Maior: {0} | Menor: {1}", maior, menor);

            //maior = Convert.ToInt32(Console.ReadLine());
            //menor = maior;
            //int auxiliar;

            //for(int i = 0; i < 4; i++)
            //{
            //    auxiliar = Convert.ToInt32(Console.ReadLine());
            //    if (auxiliar > maior)
            //        maior = auxiliar;
            //    if (auxiliar < menor)
            //        menor = auxiliar;
            //}

            //Console.WriteLine("Maior: {0} | Menor: {1}", maior, menor);
        }
    }
}
