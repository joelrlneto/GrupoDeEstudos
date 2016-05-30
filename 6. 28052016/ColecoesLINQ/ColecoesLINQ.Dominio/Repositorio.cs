using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecoesLINQ.Dominio
{
    public class Repositorio
    {
        public static IEnumerable<Produto> GerarDados()
        {
            List<Produto>  produtos = new List<Produto>();
            produtos.Add(new Produto() { Descricao = "Arroz", Preco = 2.5, Estoque = 2});
            produtos.Add(new Produto() { Descricao = "Feijão", Preco = 5.3, Estoque = 3});
            produtos.Add(new Produto() { Descricao = "Sabão", Preco = 2.4, Estoque = 5 });
            produtos.Add(new Produto() { Descricao = "Farinha", Preco = 3.95, Estoque = 8 });
            produtos.Add(new Produto() { Descricao = "Biscoito", Preco = 1.99 , Estoque = 15});
            return produtos;            
        }
    }
}
