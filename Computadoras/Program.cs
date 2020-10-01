using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Actualizaciones obj = new Actualizaciones();
            Console.WriteLine("Marca de tu PC");
            obj.Marca = Console.ReadLine();
            Console.WriteLine("¿Que procesador tienes?");
            obj.Procesador = Console.ReadLine();
            Console.WriteLine("¿Que cantidad de memoria tienes?");
            obj.Memoria = Console.ReadLine();
            Console.WriteLine("¿Que cantidad de almacenamiento tienes?");
            obj.DiscoDuro = Console.ReadLine();

            Boolean bandera = true;
            while (bandera)
            {
                Console.WriteLine("1. Aumentar Capacidad");
                Console.WriteLine("2. Disminuye Capacidad");

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
                            obj.MayorCapacidad();
                            break;
                        case "2":
                            obj.MenorCapacidad();
                            break;
                        default:
                            Console.WriteLine("NO es una opcion");
                            break;
                    }
                }
                obj.Capacidad();
            }

        }
    }
}
