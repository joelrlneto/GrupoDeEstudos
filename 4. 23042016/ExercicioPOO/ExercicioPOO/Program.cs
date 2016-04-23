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
            Curso c1 = new Curso();
            c1.Nome = "Bacharelado em Tecnologia da Informação";
            c1.Tipo = "Bacharelado";

            Disciplina d1 = new Disciplina();
            d1.Codigo = "EDB1";
            d1.Nome = "Estruturas de Dados Básicas I";

            Disciplina d2 = new Disciplina();
            d2.Codigo = "LP1";
            d2.Nome = "Linguagem de Programação I";

            c1.Disciplinas.Add(d1);
            c1.Disciplinas.Add(d2);

            Turma t1 = new Turma();
            t1.Numero = 1;
            t1.Horario = "35N12";

            Turma t2 = new Turma();
            t2.Numero = 2;
            t2.Horario = "35M34";

            Turma t3 = new Turma();
            t3.Numero = 1;
            t3.Horario = "24T56";

            d1.Turmas.Add(t1);
            d1.Turmas.Add(t2);

            d2.Turmas.Add(t3);

            Aluno a1 = new Aluno();
            a1.Matricula = "001";
            a1.Nome = "Joel";
            a1.Periodo = "2016.1";

            Aluno a2 = new Aluno();
            a2.Matricula = "002";
            a2.Nome = "Maria";
            a2.Periodo = "2015.2";

            Aluno a3 = new Aluno();
            a3.Matricula = "003";
            a3.Nome = "José";
            a3.Periodo = "2014.1";

            t1.Alunos.Add(a1);
            t2.Alunos.Add(a2);
            t3.Alunos.Add(a3);
            t3.Alunos.Add(a1);

            c1.ExibirDados();

            Instituicao ufrn = new Instituicao();
            ufrn.Nome = "UFRN";
            ufrn.AdicionarCurso(c1);

            Curso c2 = new Curso();
            c2.Nome = "Bacharelado em Tecnologia da Informação";
            c2.Tipo = "Bacharelado";

            ufrn.AdicionarCurso(c2);
        }
    }
}
