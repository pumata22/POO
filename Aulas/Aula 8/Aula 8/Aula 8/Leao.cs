using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8
{
    class Leao: Animal, IAnimal2 
    {
        public temperaturas temperatura { get; set; }= new temperaturas();
        
        public void getTipo() 
        { 
        
        }
        
        void getEspecie()
        {
        
        }

        public temperaturas temperatura { get; set; } = temperaturas.Media;//enum
        
        #region Polimorfismo sem override

        public void Tipo()
        {
            Console.WriteLine("O L~eao é do tipo carnivor.");
        }
        #endregion

        public override string ToString()
        {
            
            StringBuilder stringBuilder = new StringBuilder();
            
            temperaturas temperatura = temperaturas.Media;
            
            this.temperatura = temperatura;
            
            stringBuilder.Append("O leão tem ");
            
            if ((int)temperaturas.Media)
                stringBuilder.Append("temperatura"+this.temperatura);

            return stringBuilder.ToString();
        }
    }
}
