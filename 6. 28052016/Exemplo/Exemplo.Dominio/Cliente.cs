using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Dominio
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string email;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return $"{id.ToString("000")} | {nome.PadRight(50)} | {email}";
        }
    }
}
