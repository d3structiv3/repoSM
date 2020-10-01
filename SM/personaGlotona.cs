using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM
{
    public class personaGlotona : Operaciones
    {
        public personaGlotona(string ojos, string altura, string peso, string sexo )
            : base(ojos, altura,peso,sexo) { }
        public double cantidad = 2;
        public override void Comer(double Calorias)
        {
            Console.WriteLine("Ganando: " + (2+cantidad) + " calorias");
            double aux = double.Parse(this.Peso);
            aux += 2*Calorias / 1000;
            this.Peso = "Tu peso actuale es de: " + aux;
        }
    }
}
