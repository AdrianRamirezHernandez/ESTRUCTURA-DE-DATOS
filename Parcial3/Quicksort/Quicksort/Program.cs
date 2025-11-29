using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = { 3, 5, 2, 67, 1, 4, 8 };
            Console.WriteLine("TU arreglo en desorden es");
            Mostrar( ref Arreglo);
            Console.WriteLine("Ordenado es"+"\n");
            OrdenarQsort( ref  Arreglo, 0,Arreglo.Length);

            Console.WriteLine("ORDENADO");
            Mostrar(ref Arreglo);

            Console.Beep();
            Console.ReadKey();
        }

        static void OrdenarQsort(ref int[]Arreglo,int inicio, int fin)
        {
            int pivote = Arreglo[(inicio+fin)/2];
            int i = inicio;
            int d=fin;
            while (i <= d)
            {
                while (pivote > Arreglo[1])
                {
                    i++;
                }
                while (pivote < Arreglo[d])
                {
                    d--;
                }

                if (i <= d)
                {
                    int temp = Arreglo[i];
                    Arreglo[i] = Arreglo[d];
                    Arreglo[d] = temp;

                    i++;
                    d--;
                }
            }
            if (inicio < d) {
                OrdenarQsort(ref Arreglo,inicio,d );
            }
            if (i < fin)
            {
                OrdenarQsort(ref Arreglo, d + 1, fin);
            }

        }



        static void Mostrar( ref int[]Arreglo)
        {
            for (int J=0;J<Arreglo.Length-1;J++)
            {
                Console.WriteLine(Arreglo[J]);
            }
        }
    }
}
