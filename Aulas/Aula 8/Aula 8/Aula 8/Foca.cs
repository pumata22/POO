using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8
{
    class Foca : AnimalAbstrato, IAnimal, IAnimal2 
    {
        //public override void Mover()
        //{
        //  Console.WriteLine("Foca move-se nadando.");
        //}

        
        public void getTipo()
        {

        }

        public void getEspecie()
        {

        }

        public override void Tipo()
        {
            Console.WriteLine("Foca move-se nadando.");
        }

        public virtual void Habitat() 
        {
            Console.Write("\nOs animais têm um habitat.");
        }

        public void GetTipoAnimal()
        {
            Console.WriteLine("Mamífero.");
        }

        public void GetTipoHabitat()
        {
            Console.WriteLine("Marinho.");
        }

        public void Mover()
        {
            Console.WriteLine("Foca move-se nadando.");
        }
    }
}
