//-----------------------------------------------------------------
// <copyright file="Aula_1.cs" company="IPCA">
// Copyright (c) IPCA-EST 2024. All rights reserved.
// </copyright>
// <date>2024-09-26</date>
// <time>16:01</time>
// <version>0.1</version>
// <author></author>
// <description></description>
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* DATA TYPES 
 * byte    
 * sbyte    
 * short    
 * ushort  
 * int      
 * uint     
 * long     
 * ulong    
 * float    
 * double
 * bool
 * char
 * decimal
 * enum 
 * structs
 */

// variables stored in memory
// constant values have to be assigned a value in the declaration

/* Functions to min and max values
 * int.MinValue
 * int.MaxValue
 * sbyte.MaxValue
 * long.MaxValue
 * decimal.MaxValue
 */

//int i = 10;
//string str = i.ToString(); // str = "10“

//<typeData>.Parse(<stringToConvert>)

//Ternary Operator
//(< condição > ? < expressão_true > : < expressão_false >)

namespace Aula_4
{
    internal class Calculadora
    {
        #region ZonadeTeste
        static void Main(string[] args)
        {
            Console.WriteLine("Teste aula 3");
            //Calculadora
            //Opções: +,-,*,/
            //Pedir apenas dois valores numericos
            //Mostrar resultado arredondadoa 2 casas
            //Segundo Valor é utilizado como denominador
            //tem de ser positivo

            //Variáveis
            double primeiroValor = 0.0, segundoValor = 0.0, valorFinal=0.0;
            string operacao = "";
            bool bIncorreto = true;

            //ler e escrever
            Console.WriteLine("1º valor: ");
            primeiroValor = double.Parse(Console.ReadLine());

            Console.WriteLine("2º valor: ");
            segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação(+,-,*,/): ");
            operacao = Console.ReadLine();

            if (operacao == "+")
            {
                valorFinal = primeiroValor + segundoValor;
            }
            else if (operacao == "-")
            {
                valorFinal = primeiroValor - segundoValor;
            }
            else if (operacao == "*")
            {
                valorFinal = primeiroValor * segundoValor;
            }
            else if (operacao == "/")
            {
                if (segundoValor > 0)
                {
                    valorFinal = primeiroValor / segundoValor;
                }
                else
                {
                    bIncorreto = false;
                }
            }
            else
            {
                Console.WriteLine("Opção incorreta");
                bIncorreto = false;
            }

            Console.WriteLine("Valor Final:" + valorFinal);
        }
        #endregion
    }
}
