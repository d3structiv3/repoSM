using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM
{
    public class Operaciones
    {        
        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;
        public Operaciones(string ojos, string altura, string peso, string sexo)
        {
            this.Ojos = ojos;
            this.Altura = altura;
            this.Peso = peso;
            this.Sexo = sexo;

        }




        public void Hablar(String texto)
        {
            Console.WriteLine("Voy a decir " + texto);
        }
        public virtual void Comer(double Calorias)
        {
            Console.WriteLine("Ganando: " + Calorias + " calorias");
            double aux = double.Parse(this.Peso);
            aux += Calorias / 1000;
            this.Peso = "Tu peso actuale es de: " + aux;
        }
        public void Correr(double Calorias)
        {
            Console.WriteLine("Perdiendo: " + Calorias + " Calorias");
            double aux = double.Parse(this.Peso);
            aux -= Calorias / 1000;
            this.Peso = "Tu peso actuale es de: " + aux;
        }

    }

}
