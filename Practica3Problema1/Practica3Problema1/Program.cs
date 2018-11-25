using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3Problema1
{
    class Program
    {
        private int[,] mat;

        public void Cargar()
        {
            int totalSueldoT1, totalSueldoT2, n = 1, m = 1;
            mat = new int[4, 2];
            Console.WriteLine("");
            Console.WriteLine("Ingrese los cuatros sueldos del turno 1 : ");
            Console.WriteLine("");
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 1; c++)
                {
                    Console.WriteLine("Ingrese el sueldo del empleado " + n + " : ");
                    Console.WriteLine("");
                    mat[f, c] = Convert.ToInt32(Console.ReadLine());
                    n += 1;
                }
            }
            totalSueldoT1 = mat[0, 0] + mat[1, 0] + mat[2, 0] + mat[3, 0];
            Console.WriteLine("Ingrese los cuatros sueldos del turno 2 : ");
            Console.WriteLine("");
            for (int f = 0; f < 4; f++)
            {
                for (int c = 1; c < 2; c++)
                {
                    Console.WriteLine("Ingrese el sueldo del empleado " + m + " : ");
                    Console.WriteLine("");
                    mat[f, c] = Convert.ToInt32(Console.ReadLine());
                    m += 1;
                }
            }
            totalSueldoT2 = mat[0, 1] + mat[1, 1] + mat[2, 1] + mat[3, 1];
            Console.WriteLine("");
            Console.WriteLine("El total de gastos de nomina en el turno 1 es = RD$"+totalSueldoT1);
            Console.WriteLine("");
            Console.WriteLine("El total de gastos de nomina en el turno 2 es = RD$" + totalSueldoT2);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program mat = new Program();
            mat.Cargar();
        }
    }
}
