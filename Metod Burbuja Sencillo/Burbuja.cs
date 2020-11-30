using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod_Burbuja_Sencillo
{
    class Burbuja
    {
        // Metodo para Intercambiar posiciones
        public void Intercambio(int[] valores)
        {
            //Variable auxiliar
            int aux;

            //Metodo burbuja
            for (int i = 1; i < valores.Length; i++)
                for (int j = valores.Length - 1; j >= i; j--)
                {
                    if (valores[j] < valores[j - 1])
                    {
                        aux = valores[j - 1];
                        valores[j - 1] = valores[j];
                        valores[j] = aux;
                    }
                }
        }
        //Metodo para Mostrar
        public void Mostrar(int[] valores)
        {
            //arreglo para mostrar valores
            for (int i = 0; i <= 7; i++)
            {
                //Muestra los valores del arreglo
                Console.WriteLine("Elemento[ " + i + " ]" + " = " + valores[i]);
            }
        }

    }
}
