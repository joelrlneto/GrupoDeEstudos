using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoPOO
{
    //A classe deve ser pública para que possa ser acessada externamente
    public class Produto
    {
        //Atributos: privados
        private string codigo;
        private string descricao;
        private double precoVenda;
        private double precoCusto;

        //Propriedades: públicas. Encapsulam os atributos, controlando o acesso externo a eles.
        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                // Validando a entrada de dados: a descrição não pode ser vazia
                // Para quem utiliza essa classe, essa validação é transparente, ou seja, pode-se atribuir qualquer valor e a classe se encarrega de validar
                if (value == "")
                    descricao = "[Produto sem descrição]";
                else
                    descricao = value;
            }
        }

        public double PrecoVenda
        {
            get
            {
                return precoVenda;
            }
            set
            {
                // Validando a entrada de dados: o preço não pode ser negativo
                // Para quem utiliza essa classe, essa validação é transparente, ou seja, pode-se atribuir qualquer valor e a classe se encarrega de validar
                if (value < 0)
                    precoVenda = 0;
                else
                    precoVenda = value;
            }
        }

        //Construtor padrão, usado para iniciar os valores dos atributos
        public Produto()
        {
            codigo = "000";
            descricao = "[Produto sem descrição]";
            precoVenda = 0;
        }

        //Construtor com argumentos, usado para iniciar os valores dos atributos a partir de parâmetros
        public Produto(string _codigo, string _descricao, double _precoVenda)
        {
            codigo = _codigo;
            descricao = _descricao;
            precoVenda = _precoVenda;
        }

        //Método com retorno, mas sem argumentos
        public string GetDetalhes()
        {
            return $"Codigo: {codigo} | Descrição: {descricao} | Preço: R$ {precoVenda}";
        }

        //Método sem retorno, mas com argumento
        public void AplicarDesconto(double percentual)
        {
            precoVenda = precoVenda * (1 - (percentual/100));
        }
    }
}