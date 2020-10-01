using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM
{
    public class personaNadadora : Operaciones
    {

        public personaNadadora(string ojos, string altura, string peso, string sexo)
            : base(ojos, altura, peso, sexo)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Nada para alcanzar tu peso ideal ");
            this.Peso = "85";
        }
    }
}
