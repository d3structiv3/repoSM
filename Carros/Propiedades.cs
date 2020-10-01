using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class Propiedades
    {
        private string _Marca;
        private string _Modelo;

        //Encapsulamiento
        public string Marca
        {
            get => _Marca;
            set => _Marca = value;
        }
        public string Modelo
        {
            get => _Modelo;
            set => _Modelo = value;
        }
        public double vActual;
        public double vMax;


        public void Acelera()
        {
        
            vActual += 5;
        }
        public void Desacelerar()
        {
            vActual -= 5;
        }
    }
}
