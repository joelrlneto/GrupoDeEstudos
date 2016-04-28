using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario("2015.1.001", "Joao Pereira da Silva Cunha Santos", 2204.79, "Pró-reitoria de Pesquisa"));
            funcionarios.Add(new Funcionario("2015.1.134", "Maria das Graças Silva e Sousa", 10349.78, "Pró-Reitoria de Extensão"));
            funcionarios.Add(new Funcionario("2016.2.876", "Juliana Andrade Garcia", 928.86, "Departamento Especializado em Assuntos Estudantis"));


            Console.WriteLine("                               LISTA DE FUNCIONÁRIOS                                ");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("| Matrícula  | Nome                           | Salário     | Setor                |");
            Console.WriteLine("------------------------------------------------------------------------------------");
            foreach (Funcionario f in funcionarios)
            {
                Console.WriteLine($"| {f.Matricula.PadRight(10, ' ')} | {f.Nome.PadRight(30, ' ')} | R$ {f.Salario.ToString().PadLeft(8, ' ')} | {f.Setor.PadRight(20, ' ')} |");
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }
}
