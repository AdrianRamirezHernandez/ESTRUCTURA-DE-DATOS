using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int[] Arreglo = {1,9,6,8,5,4,7 };
            Console.WriteLine("Tu arreglo esta asi:");
                Mostrar(ref Arreglo);
            OrdenarMergeSort(ref  Arreglo,0, Arreglo.Length-1 );

            Console.WriteLine("ORDENADO ES");
            Mostrar(ref Arreglo);
            Console.ReadKey();
        }
        static void OrdenarMergeSort( ref  int []Arreglo, int inicio, int fin) {



            if (inicio >= fin)
                return;

            int medio = (inicio + fin) / 2;

            OrdenarMergeSort(ref Arreglo, inicio, medio);
            OrdenarMergeSort(ref Arreglo, medio + 1, fin);

            Merge(ref Arreglo, inicio, medio, fin);

        }
        static void Merge(ref int[] Arreglo2, int inicio, int medio, int fin)
        {
            int i = inicio;
            int j = medio + 1;
            int k = 0;

            int[] temp = new int[fin - inicio + 1];

            while (i <= medio && j <= fin)
            {
                if (Arreglo2[i] <= Arreglo2[j])
                {
                    temp[k] = Arreglo2[i];
                    i++;
                }
                else
                {
                    temp[k] = Arreglo2[j];
                    j++;
                }
                k++;
            }

            while (i <= medio)
            {
                temp[k] = Arreglo2[i];
                i++;
                k++;
            }

            while (j <= fin)
            {
                temp[k] = Arreglo2[j];
                j++;
                k++;
            }



            for (int t = 0; t < temp.Length; t++)
            {
                Arreglo2[inicio + t] = temp[t];
            }
        }


        public static void Mostrar(ref int [] Arreglo)
        {
            for(int i = 0; i < Arreglo.Length; i++)
            {
                Console.WriteLine( Arreglo[i] );
            }
        }
    }
}
