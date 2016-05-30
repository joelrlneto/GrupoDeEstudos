using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecoesLINQ.Dominio
{
    public class Produto : IComparable
    {
        private string descricao;
        private double preco;
        private int estoque;

        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }        

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int CompareTo(object obj)
        {
            var outro = (obj as Produto);

            //if (preco > outro.Preco)
            //    return 1;
            //else if (preco < outro.preco)
            //    return -1;
            //else
            //    return 0;

            return Convert.ToInt32(preco - outro.Preco);

            //Compara o comprimento da descrição
            //return descricao.Length - outro.Descricao.Length;
        }

        public override string ToString()
        {
            return $"{descricao} | {preco.ToString("c")}";
        }
    }
}
