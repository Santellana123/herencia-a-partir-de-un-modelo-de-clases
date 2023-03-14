using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_a_partir_de_un_modelo_de_clases
{
    internal class gato:animal
    {
        public override string HacerSonido()
        {
           return "El gato maulla !Miau Miau¡.";
        }
    }
}
