using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
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
            set { matricula = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }
    }
}
