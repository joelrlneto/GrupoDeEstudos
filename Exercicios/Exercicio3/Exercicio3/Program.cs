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
            Funcionario f1 = new Funcionario();
            f1.Matricula = "2016.1.001";
            f1.Nome = "Joao Pereira da Cunha";
            f1.Salario = 1235.44;
            f1.Setor = "Recursos Humanos";

            Console.WriteLine(" *** DADOS DO FUNCIONÁRIO ***");
            Console.WriteLine($"Matricula: {f1.Matricula}");
            Console.WriteLine($"Nome     : {f1.Nome}");
            Console.WriteLine($"Salário  : R$ {f1.Salario}");
            Console.WriteLine($"Setor    : {f1.Setor}");
        }
    }
}
