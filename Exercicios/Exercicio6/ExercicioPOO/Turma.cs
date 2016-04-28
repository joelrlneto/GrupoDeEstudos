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
        
        public Turma()
        {
            alunos = new List<Aluno>();
        }
        
        public Turma(int _numero, string _horario)
        {
            numero = _numero;
            horario = _horario;
            alunos = new List<Aluno>();
        }
        
        public void ExibirDados()
        {
            Console.WriteLine("\t\t--------------------------------------------------------");
            Console.WriteLine($"\t\tTURMA {numero}: {horario}");
            Console.WriteLine("\t\t--------------------------------------------------------");
            foreach (Aluno a in alunos)
            {
                Console.WriteLine($"\t\t| {a.Matricula.PadRight(8, ' ')} | {a.Nome.PadRight(30, ' ')} | {a.Periodo.PadRight(7, ' ')} |");
            }
            Console.WriteLine("\t\t--------------------------------------------------------");
        }
    }
}