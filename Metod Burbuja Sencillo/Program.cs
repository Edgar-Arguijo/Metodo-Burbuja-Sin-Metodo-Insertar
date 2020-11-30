using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_Burbuja_Sencillo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------Metodo Burbuja------------------------------------");
            Console.WriteLine();

            //Declaracion de objeto
            Burbuja Obj1 = new Burbuja();

            //Arreglo ya con valores
            int[] valores = { 4, 8, 90, 23, 1, 67, 54, 16 };

            Console.Write("---------------------------------- Elementos aun no ordenados: --------------------------");
            Console.WriteLine();
            Obj1.Mostrar(valores);

            Console.Write("----------------------------- Elementos Ordenados de Menor a Mayor: ----------------------");
            Console.WriteLine();
            Obj1.Intercambio(valores);
            Obj1.Mostrar(valores);
            Console.ReadKey();
        }
    }   
}

