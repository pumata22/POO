using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8
{
    class Cao: Animal
    {
        public void Tipo()
        {
            Console.WriteLine("O cão é do tipo omnivoro.");
        }

        #region PolimorfismoComOverride
        public override void TipoOverride()
        {
            Console.WriteLine("O cão é do tipo omnivoro.");
        }
        #endregion
    }
}
