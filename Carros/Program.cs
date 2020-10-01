using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class Program
    {
        static void Main(string[] args)
        {
            Acciones obj = new Acciones();
            Console.WriteLine("Marca de tu vehiculo");
            obj.Marca = Console.ReadLine();
            Console.WriteLine("Modelo de tu vehiculo");
            obj.Modelo = Console.ReadLine();
          
            Console.WriteLine("¿ Cual es la velocidad maxima de tu vehiculo "+obj.Marca + " "+obj.Modelo+" ?");
            obj.vMax = Double.Parse(Console.ReadLine());
            Console.WriteLine("¿ Cual es la velocidad actual ?");
            obj.vActual = Double.Parse(Console.ReadLine());
            Boolean bandera = true;
            while (bandera)
            {
                Console.WriteLine("1. Acelera");
                Console.WriteLine("2. Desacelera");
                Console.WriteLine("3. Frena");
                
                Console.WriteLine("Que quieres hacer");
                Console.WriteLine("Digita cero para salir del menu");
                string opt = Console.ReadLine();
                if (opt.Equals("0"))
                {
                    bandera = false;
                }
                else
                {
                    switch (opt)
                    {
                        case "1":
                            obj.Acelera();
                         break;
                        case "2":
                            obj.Desacelerar();
                         break;
                        case "3":
                            obj.Frenar();
                         break;

                        default: 
                            Console.WriteLine("NO es una opcion");
                         break;
                    }
                }
                obj.Estado();
            }
        }
    }
}
