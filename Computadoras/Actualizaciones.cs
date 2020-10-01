using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
    public class Actualizaciones : FichaTecnica
    {
        public void MayorCapacidad()
        {
            double aux = double.Parse(this.DiscoDuro);
            aux += 100;
            this.DiscoDuro = aux.ToString();
        }
        public void MenorCapacidad()
        {
            double aux = double.Parse(this.DiscoDuro);
            aux -= 100;
            this.DiscoDuro = aux.ToString();
        }
    }
}
