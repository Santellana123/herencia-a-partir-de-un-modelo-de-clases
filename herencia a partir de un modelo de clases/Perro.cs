using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_a_partir_de_un_modelo_de_clases
{
    internal class Perro:animal
    {
        public override string HacerSonido()
        {
           return "EL perro ladra !Guau Guau¡.";
        }
    }
}
