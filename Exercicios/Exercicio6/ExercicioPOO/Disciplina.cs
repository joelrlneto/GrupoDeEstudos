using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Disciplina
    {
        private string codigo;
        private string nome;
        private List<Turma> turmas;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Turma> Turmas
        {
            get { return turmas; }
            set { turmas = value; }
        }

        public Disciplina()
        {
            turmas = new List<Turma>();
        }
        
        public Disciplina(string _codigo, string _nome)
        {
            codigo = _codigo;
            nome = _nome;    
            turmas = new List<Turma>();
        }
        
        public void ExibirDados()
        {
            Console.WriteLine($"\tDISCPLINA: {codigo} - {nome}");
            foreach(Turma t in turmas)
            {
                t.ExibirDados();
            }
        }
    }
}
