using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA6_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de notas:");
            Console.Write("->"); int cantidad=int.Parse(Console.ReadLine());

            int i = 0;
            float sumanotas = 0f;
            float sumapesos = 0f;

            while (i < cantidad)
            {

                Console.WriteLine("------NOTA"+(i+1)+"------");
                Console.Write("Ingrese la nota:");
                float nota = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el peso:");
                float peso=float.Parse(Console.ReadLine());

                sumanotas = sumanotas + (nota * peso);
                sumapesos = sumapesos + peso;

                sumapesos = sumapesos + peso;
                i++;
            }
            Console.WriteLine("------PROMEDIO------");
            Console.WriteLine("EL PROMEDIO ES:"+(sumanotas/sumapesos));
            Console.ReadKey();
        }
    }
}
