using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_C_
{
    internal class Program
    {
        static void Main()
        {
            float tc, pc, codeGrade, oralGrade, media1;

            Console.WriteLine("Calculate your media!");
            Console.WriteLine("Insert your Theorical Component(TC) grade: ");
            tc = float.Parse(Console.ReadLine());
            Console.WriteLine("Insert your code grade: ");
            codeGrade = float.Parse(Console.ReadLine());
            Console.WriteLine("Insert you oral grade: ");
            oralGrade = float.Parse(Console.ReadLine());

            pc = (float)(codeGrade * (0.5)) + (float)(oralGrade * (0.5));

            media1 = (float)(0.4 * tc) + (float)(0.6 * pc);
            //Math.Round(average,2) arredonda com 2 casas decimais

            Console.WriteLine("Your media is: " + media1);

        }
    }
}
