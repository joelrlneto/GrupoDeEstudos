using Exemplo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientes = RepositorioClientes.Clientes;

            foreach(var c in clientes)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
