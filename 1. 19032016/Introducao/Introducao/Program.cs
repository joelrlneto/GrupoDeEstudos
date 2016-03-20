using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentário de uma linha

            /*
            Comentário 
            de várias
            linhas
            */

            //Declaração de variáveis (com e sem inicialização)
            int idade = 17;
            string nome;
            double saldo;
            char categoria = 'A';
            bool ativo = true;
            int[] numeros = new int[5];                       //Declaração de vetor sem inicialização
            string[] linguagens = { "C#", "Java", "PHP" };    //Declaração de vetor com inicialização
            var data = DateTime.Now;                          //Type Inference

            //Estrutura condicional IF
            /*
            if (idade < 16)
                Console.WriteLine("Não pode votar, nem responder criminalmente.");
            else if(idade < 18)
                Console.WriteLine("Pode votar, mas não responder criminalmente.");
            else
                Console.WriteLine("Pode votar e responder criminalmente.");
            */

            //Estrutura condicional CASE
            /*
            switch(categoria)
            {
                case 'A':
                    Console.WriteLine("Habilitação para moto.");
                    break;
                case 'C':
                    Console.WriteLine("Habilitação para carro.");
                    break;
                default:
                    Console.WriteLine("Outro tipo de habilitação.");
                    break;
            }
            */

            //Estrutura de repetição FOR
            /*
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            */

            //Estrutura de repetição WHILE
            /*
            int contador = 0;
            while(contador < 5)
            {
                Console.WriteLine(contador);
                contador++;
            }
            */

            //Estrutura de repetição FOR EACH
            /*
            foreach(string linguagem in linguagens)
            {
                Console.WriteLine(linguagem);
            }
            */

            //Funções da classe String
            /*
            string sigla = "UnP";
            string universidade = "Universidade Potiguar";

            string nomeCompleto1 = sigla + " - " + universidade; //Concatenação padrão
            string nomeCompleto2 = $"{sigla} - {universidade}";  //String Interpolation (C# 6.0)
            string nomeCompleto3 = String.Format("{0} - {1}", sigla, universidade);
            string primeiraParte = universidade.Substring(13, 4); //Substring começando na posição 13 com 4 caracteres

            Console.WriteLine(nomeCompleto1);
            Console.WriteLine(nomeCompleto2);
            Console.WriteLine(nomeCompleto3);
            Console.WriteLine(primeiraParte);

            if (sigla.StartsWith("U"))
                Console.WriteLine("Começa com U");
            if (sigla.EndsWith("P"))
                Console.WriteLine("Termina com P");
            if (sigla.Contains("n"))
                Console.WriteLine("Contém N");
            */
        }
    } 
}
