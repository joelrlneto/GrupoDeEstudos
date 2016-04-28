using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class Funcionario
    {
        private string matricula;
        private string nome;
        private double salario;
        private string setor;

        public string Matricula
        {
            get { return matricula; }
            set
            {
                if (value.Length > 10)
                    matricula = value.Substring(0, 10);
                else
                    matricula = value;
            }
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 30)
                    nome = value.Substring(0, 30);
                else
                    nome = value;
            }
        }

        public double Salario
        {
            get { return salario; }
            set
            {
                if (value > 99999.99)
                    salario = 99999.99;
                else
                    salario = value;
            }
        }

        public string Setor
        {
            get { return setor; }
            set
            {
                if (value.Length > 20)
                    setor = value.Substring(0, 20);
                else
                    setor = value;
            }
        }

        public Funcionario()
        {
        }

        public Funcionario(string _matricula, string _nome, double _salario, string _setor)
        {
            // Aqui, apesar de estarmos na própria classe, utilizamos as propriedade (públicas)
            // para aproveitar o recurso de validação que foi implementado nelas (setters).
            Matricula = _matricula;
            Nome = _nome;
            Salario = _salario;
            Setor = _setor;
        }
    }
}
