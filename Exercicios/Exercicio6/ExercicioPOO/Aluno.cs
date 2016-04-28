using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    public class Aluno
    {
        private string matricula;
        private string nome;
        private string periodo;

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

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
        
        public Aluno()
        {
            //Construtor padrão vazio    
        }
        
        public Aluno(string _matricula, string _nome, string _periodo)
        {
            matricula = _matricula;
            nome = _nome;
            periodo = _periodo;            
        }
    }
}
