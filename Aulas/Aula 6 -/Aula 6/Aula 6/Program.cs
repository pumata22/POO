using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ZonaDeTeste
            #endregion

            #region teste da classe Funcionario

            Funcionario funcionario = new Funcionario();
            
            funcionario.nome="Tiago";
            funcionario.idade = 40;

            Console.WriteLine("1ºExemplo, Nome:{0}, Idade:{1}",funcionario.nome,funcionario.idade);

            Funcionario funcionario1 = new Funcionario("Paulo",45, 900.6);

            Console.WriteLine("1ºExemplo, Nome:{0}, Idade:{1} e Salário: {2}", funcionario1.nome, funcionario1.idade, funcionario1.salario);

            Console.WriteLine("");

            #endregion

            Console.ReadKey();
        }


    }
}
