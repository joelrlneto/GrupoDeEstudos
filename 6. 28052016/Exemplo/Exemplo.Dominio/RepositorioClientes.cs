using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Dominio
{
    public class RepositorioClientes
    {
        private static int ultimoID = 0;

        private static List<Cliente> clientes;

        public static List<Cliente> Clientes
        {
            get
            {
                if (clientes == null)
                    IniciarDados();
                return clientes;
            }
        }

        private static void IniciarDados()
        {
            clientes = new List<Cliente>();
            AdicionarCliente(new Cliente { Nome = "Serafim dos Santos", Email = "serafim@email.com" });
            AdicionarCliente(new Cliente { Nome = "João da Cunha", Email = "joaocunha@email.com" });
            AdicionarCliente(new Cliente { Nome = "Antonio Pinto", Email = "toin@email.com" });
        }

        private static void AdicionarCliente(Cliente c)
        {
            c.ID = ++ultimoID;
            clientes.Add(c);
        }
    }
}
