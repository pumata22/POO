using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8
{
     class Animal
    {
        #region PolimorfismoSemOverride
        public void Tipo()
        {
            Console.WriteLine("Animal têm um tipo.");
        }
        #endregion

        #region PolimorfismoComOverride

        public virtual void TipoOverride()
        {
            Console.WriteLine("Animal têm um tipo.");
        }
        #endregion 

    }
}
