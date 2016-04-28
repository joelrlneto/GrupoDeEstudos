using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Instituicao
    {
        private string nome;
        private List<Curso> cursos;

        public Instituicao()
        {
            cursos = new List<Curso>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Curso> Cursos
        {
            get { return cursos; }
            //set { cursos = value; }
        }

        public void AdicionarCurso(Curso novoCurso)
        {
            foreach(Curso c in cursos)
            {
                if (c.Nome == novoCurso.Nome)
                {
                    Console.WriteLine("ERRO: Curso já cadastrado.");
                    return;
                }   
            }
            cursos.Add(novoCurso);
        }
    }
}
