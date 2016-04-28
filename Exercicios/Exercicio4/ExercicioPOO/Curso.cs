using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Curso
    {
        private string nome;
        private string tipo;
        private List<Disciplina> disciplinas;

        public Curso()
        {
            disciplinas = new List<Disciplina>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public List<Disciplina> Disciplinas
        {
            get
            {
                //if (disciplinas == null)
                //    disciplinas = new List<Disciplina>();
                return disciplinas;
            }
            set { disciplinas = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"CURSO: {tipo} - {nome}");
            foreach(Disciplina d in disciplinas)
            {
                d.ExibirDados();
            }
            Console.WriteLine("------------------------");
        }
    }
}
