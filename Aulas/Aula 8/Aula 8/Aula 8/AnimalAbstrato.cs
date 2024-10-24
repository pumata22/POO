using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8
{
    abstract class AnimalAbstrato
    {
        public abstract void Mover();
        //public  void Mover();

        public virtual void Habitat()
        {
            Console.Write("\nOs animais têm um habitat.");
        }

    }
}
