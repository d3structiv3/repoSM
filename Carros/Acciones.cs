using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class Acciones : Propiedades
    {

        public void Frenar()
        {
            this.vActual = 0;
        }
        public void Estado()
        {
            Console.WriteLine("Velocidad actual del " + this.Marca + " " + this.Modelo + " es " + vActual + "km/h");
        }
    }
}
