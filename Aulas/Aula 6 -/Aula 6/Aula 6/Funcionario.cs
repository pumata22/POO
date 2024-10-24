using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
    internal class Funcionario
    {
        #region Atributos
        //const constante quando criamos um atributo que queremos que nao mude de valor
        public string nome;
        public int idade;
        public double salario;
        #endregion

        #region Construtores
        public Funcionario()
        {

        }
        public Funcionario(string nomeParamatro, int idadeParametro)
        {
            this.nome = nomeParamatro;
            this.idade = idadeParametro;
        }
        public Funcionario(string nomeParamatro, int idadeParametro, double salarioParametro)
        {
            this.nome = nomeParamatro;
            this.idade = idadeParametro;
            this.salario = salarioParametro;

        }
        #endregion

    }
}
