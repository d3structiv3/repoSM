using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SM
{
    class Program
    {
        static void Main(string[] args)
        {
            personaNadadora p= new personaNadadora("Miel", "1.72", "95.0", "M");

            Console.WriteLine("Descripcion de la persona");
            Console.WriteLine("Ojos: "+ p.Ojos);
            Console.WriteLine("Altura: "+ p.Altura);
            Console.WriteLine("Peso: "+ p.Peso);
            Console.WriteLine("Sexo: "+ p.Sexo);

            p.Hablar("Hola, soy destructive");
            Console.WriteLine("El color de mis ojos es : "+ p.Ojos);
            p.Correr(1000.0);
            Console.WriteLine("Mi peso actual es de: " + p.Peso);
            p.Nadar();
            Console.WriteLine("Tras nadar: " + p.Peso);
        }
    }
}
