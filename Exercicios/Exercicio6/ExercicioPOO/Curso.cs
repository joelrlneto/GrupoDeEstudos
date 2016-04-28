using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public enum TipoCurso
    {
        Bacharelado, 
        Licenciatura,
        Tecnologo,
        Tecnico
    }

    public class Curso
    {
        private string nome;
        private TipoCurso tipo;
        private List<Disciplina> disciplinas;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public TipoCurso Tipo
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

        public Curso()
        {
            disciplinas = new List<Disciplina>();
        }

        public Curso(string _nome, TipoCurso _tipo)
        {
            nome = _nome;
            tipo = _tipo;
            disciplinas = new List<Disciplina>();
        }
        
        public void ExibirDados()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"CURSO: {nome} ({tipo})");
            foreach(Disciplina d in disciplinas)
            {
                d.ExibirDados();
            }
            Console.WriteLine("------------------------");
        }
    }
}
