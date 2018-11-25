using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3Ejercicio2
{
    class Program
    {
        private int[] sueldos;

        public void Cargar()
        {
            sueldos = new int[6];
            for (int f=1; f<=5; f++)
            {
                Console.WriteLine("Ingrese Sueldo del operario " +f+ ":");
                sueldos[f] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Los 5 sueldos de los operarios: ");
            for (int f=1; f<=5; f++)
            {
                Console.WriteLine("["+sueldos[f]+"]");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program pa = new Program();
            pa.Cargar();
            pa.Imprimir();

        }
    }
}
