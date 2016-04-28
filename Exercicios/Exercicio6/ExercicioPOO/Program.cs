using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso c1 = new Curso("Bacharelado em Tecnologia da Informação", TipoCurso.Bacharelado);

            Disciplina d1 = new Disciplina("EDB1", "Estruturas de Dados Básicas I");
            Disciplina d2 = new Disciplina("LP1", "Linguagem de Programação I");

            c1.Disciplinas.Add(d1);
            c1.Disciplinas.Add(d2);

            Turma t1 = new Turma(1, "35N12");
            Turma t2 = new Turma(2, "35M34");
            Turma t3 = new Turma(1, "34T56");

            d1.Turmas.Add(t1);
            d1.Turmas.Add(t2);
            d2.Turmas.Add(t3);

            Aluno a1 = new Aluno("001", "Joel Rodrigues", "2016.1");
            Aluno a2 = new Aluno("002", "João Pereira", "2015.2");
            Aluno a3 = new Aluno("003", "Maria da Cunha", "2014.2");

            t1.Alunos.Add(a1);
            t2.Alunos.Add(a2);
            t3.Alunos.Add(a3);
            t3.Alunos.Add(a1);

            c1.ExibirDados();

            Instituicao ufrn = new Instituicao("UFRN");
           
            ufrn.AdicionarCurso(c1);

            Curso c2 = new Curso("Bacharelado em Tecnologia da Informação", TipoCurso.Bacharelado);

            ufrn.AdicionarCurso(c2);
        }
    }
}
