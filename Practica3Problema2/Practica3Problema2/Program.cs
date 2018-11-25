using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3Problema2
{
    class Program
    {
        private int[,] mat = new int [3,4];
        int comp = 0;
        public void cargar()
        {
            Console.WriteLine("Hemos creado una matriz de 3x4");
            Console.WriteLine("");
            Console.WriteLine("Ingrese los 12 Componentes");
            Console.WriteLine("");

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.WriteLine("Ingrese el Componente numero " +comp);

                    mat[f, c] = Convert.ToInt32(Console.ReadLine());
                    comp += 1;

                }
            }
        }
         public void ImprimirPrimeraFila()
        {
            Console.WriteLine("");
            Console.WriteLine("La primera fila es : ");
            Console.WriteLine("");
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.WriteLine(mat[0,c] + " ");
            }
        }
        public void ImprimirUltimaFila()
        {
            Console.WriteLine("");
            Console.WriteLine("La ultima fila es : ");
            Console.WriteLine("");
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.WriteLine(mat[mat.GetLength(0)-1, c] + " ");
            }
        }
         public void ImprimirPrimeraCol()
        {
            Console.WriteLine("");
            Console.WriteLine("La primera columna es : ");
            Console.WriteLine("");
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                Console.WriteLine(mat[f, 0] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Program Matriz = new Program();
            Matriz.cargar();
            Matriz.ImprimirPrimeraFila();
            Matriz.ImprimirUltimaFila();
            Matriz.ImprimirPrimeraCol();

            Console.ReadKey();
        }
    }
}
