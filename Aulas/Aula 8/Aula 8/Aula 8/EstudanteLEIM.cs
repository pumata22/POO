using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8
{
    class EstudanteLEIM
    {
       //1ºopcao
        public string idAluno { get; set; }

        private string _idAluno;


        //2ªopcao propriedades
        public string idAluno2 
        {
            get { return _idAluno; }
            set { _idAluno = value; }
        }
        //3ª A LA JAVA get e set
        public string GetIdAluno() 
        {
            return this._idAluno; 
        }

        public void SetIdAluno(string idAlunoParametro)
        { 
        this._idAluno=idAlunoParametro;
        }



    }
}
