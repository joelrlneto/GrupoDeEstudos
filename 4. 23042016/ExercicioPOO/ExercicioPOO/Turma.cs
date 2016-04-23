using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Turma
    {
        private int numero;
        private string horario;
        private List<Aluno> alunos;

        public Turma()
        {
            alunos = new List<Aluno>();
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public List<Aluno> Alunos
        {
            get { return alunos; }
            set { alunos = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"\t\tTURMA: {numero} - {horario}");
            foreach(Aluno a in alunos)
            {
                Console.WriteLine($"\t\t\tALUNO: {a.Matricula} - {a.Nome} - {a.Periodo}");
            }
        }
    }
}