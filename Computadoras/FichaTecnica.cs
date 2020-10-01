using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
     public class FichaTecnica
    {
        private string _Marca;
        private string _Procesador;
        private string _Memoria;
        private string _DiscoDuro;

        public string Marca { get => _Marca; set => _Marca = value; }
        public string Procesador { get => _Procesador; set => _Procesador = value; }
        public string Memoria { get => _Memoria; set => _Memoria = value; }
        public string DiscoDuro { get => _DiscoDuro; set => _DiscoDuro = value; }


        public void Capacidad()
        {
            Console.WriteLine("Actualmente la computadora tiene una capacidad de "+this.DiscoDuro+" GB");
        }
    }
}
