using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            int nota = 10;
            String resultado;
            switch (nota)
            {
                case 0:
                case 1:
                case 2:
                    resultado = "Muy deficiente";
                    break;
                case 3:
                case 4:
                    resultado = "Insuficiente";
                    break;
                case 5:
                case 6:
                    resultado = "Aprobado";
                    break;
                case 7:
                case 8:
                    resultado = "Notable";
                    break;
                case 9:
                case 10:
                    resultado = "Sobresaliente";
                    break;
                default:
                    resultado = "Nota no valida";
                    break;

            }
            Console.WriteLine("Nota: "+nota+" "+ resultado);

            int[,] mat = new int [5,5];
            int[,] mat2 = new int[5, 5];
          

            mat[0,0] = 5;
            mat[0, 1] = 6;
            mat[0, 2] = 4;
            mat[0, 3] = 2;
            mat[0, 4] = 8;
            mat[1, 0] = 1;
            mat[1, 1] = 9;
            mat[1, 2] = 7;
            mat[1, 3] = 3;
            mat[1, 4] = 5;
            mat[2, 0] = 2;
            mat[2, 1] = 9;
            mat[2, 2] = 0;
            mat[2, 3] = 5;
            mat[2, 4] = 7;
            mat[3, 0] = 1;
            mat[3, 1] = 6;
            mat[3, 2] = 8;
            mat[3, 3] = 4;
            mat[3, 4] = 9;
            mat[4, 0] = 3;
            mat[4, 1] = 6;
            mat[4, 2] = 7;
            mat[4, 3] = 4;
            mat[4, 4] = 5;

            mat2[0, 0] = 3;
            mat2[0, 1] = 0;
            mat2[0, 2] = 5;
            mat2[0, 3] = 9;
            mat2[0, 4] = 4;
            mat2[1, 0] = 8;
            mat2[1, 1] = 1;
            mat2[1, 2] = 2;
            mat2[1, 3] = 6;
            mat2[1, 4] = 7;
            mat2[2, 0] = 5;
            mat2[2, 1] = 9;
            mat2[2, 2] = 4;
            mat2[2, 3] = 8;
            mat2[2, 4] = 3;
            mat2[3, 0] = 1;
            mat2[3, 1] = 2;
            mat2[3, 2] = 0;
            mat2[3, 3] = 6;
            mat2[3, 4] = 5;
            mat2[4, 0] = 8;
            mat2[4, 1] = 9;
            mat2[4, 2] = 4;
            mat2[4, 3] = 2;
            mat2[4, 4] = 7;

            Console.WriteLine("Matriz 1");
            obj.imprimir(mat);
            Console.WriteLine("Matriz 2");
            obj.imprimir(mat2);
            Console.WriteLine("Resultado");
            obj.imprimir(obj.sumar(mat,mat2));

        }
        public void imprimir(int[,] mat)
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        public int[,] sumar(int[,] mat, int[,] mat2)
        {
            int[,] res = new int[5, 5];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat2.GetLength(1); c++)
                {
                    res[f, c] = mat[f, c] + mat2[f, c];
                }
            }
            return res;
        }
    }
}
