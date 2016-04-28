using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    public class Setor
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                AbreviarNome();
                if (nome.Length > 20)
                    nome = nome.Substring(0, 20);
            }
        }

        public Setor(string _nome)
        {
            Nome = _nome;
        }

        private void AbreviarNome()
        {
            Dictionary<string, string> abreviacoes = new Dictionary<string, string>();
            abreviacoes.Add("Departamento", "Depto.");
            abreviacoes.Add("Secretaria", "Sec.");
            abreviacoes.Add("Coordenação", "Coord.");
            abreviacoes.Add("Gerência", "Ger.");
            abreviacoes.Add("Administração", "Adm.");
            abreviacoes.Add("Pesquisa", "Pesq.");
            abreviacoes.Add("Extensão", "Ext.");

            foreach(string termo in abreviacoes.Keys)
            {
                if (nome.Contains(termo))
                    nome = nome.Replace(termo, abreviacoes[termo]);
            }
        }
    }
}
