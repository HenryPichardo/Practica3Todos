using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3Ejercicio1
{
    class Program
    {
        private int[,] mat;
        public void Cargar()
        {
            Console.WriteLine("Cuanta fila tiene la matriz: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuanta columnas tiene la matriz: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            mat = new int[filas, columnas];

            for (int f=0; f< mat.GetLength(0); f++)
            {
                for (int c=0; c<mat.GetLength(1); c++)
                {
                    Console.WriteLine("Ingrese Componente");
                    mat[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
         public void Imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.WriteLine(mat[f,c]+" ");                                       
                }
                Console.WriteLine();
            }
        }
         public void ImprimirUltimaFila()
        {
            Console.WriteLine("Ultima Fila");
            for (int c=0; c < mat.GetLength(1); c++)
            {
                Console.WriteLine(mat[mat.GetLength(0)-1,c]+" ");
            }
        }
        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.Cargar();
            ma.Imprimir();
            ma.ImprimirUltimaFila();
            Console.ReadKey();
        }
    }
}
